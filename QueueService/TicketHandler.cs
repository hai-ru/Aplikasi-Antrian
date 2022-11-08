using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using HuaweiAPI;
using System.Text.RegularExpressions;

namespace Tobasa
{
    class TicketHandler
    {
        public TicketHandler()
        {
        }

        public void sendSMS(string message, string tujuan)
        {
            try
            {

                string ip = "192.168.99.1";
                string username = "admin";
                string password = "qazwsxedc123";

                DataTable rest = QueueRepository.getConfigModem();

                foreach (DataRow row in rest.Rows)
                {
                    ip = row["endpoints"].ToString();
                    username = row["username"].ToString();
                    password = row["password"].ToString();
                }

                //check login state
                Console.WriteLine("Checking login state..");
                if (HuaweiAPI.HuaweiAPI.MethodExample.loginState(ip) == true)
                {
                    //Console.WriteLine("Already logged in.");
                }
                else
                {
                    Console.WriteLine("Not logged in, logging in..");
                    var login = HuaweiAPI.HuaweiAPI.MethodExample.UserLogin(ip, username, password);
                    if (login == false)
                    {
                        //Console.WriteLine("Failed to log in.");
                        //Console.ReadLine();
                        return;
                    }
                }

                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string xml_message = @"<request>
	                <Index>-1</Index>
	                <Phones>
		                <Phone>"+tujuan+ "</Phone>"+
	                "</Phones>"+
	                "<Sca></Sca>"+
	                "<Content>" +message+ "</Content>"+
	                "<Length>24</Length>"+
                    "<Reserved>1</Reserved>"+
                    "<Date>" + timestamp + "</Date></request>";

                HuaweiAPI.HuaweiAPI.Tools.POST(ip, xml_message, "api/sms/send-sms");

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void OnMessage(DataReceivedEventArgs arg, Client client)
        {
            Exception exp = null;

            try
            {
                Message qmessage = new Message(arg);

                Logger.Log("[TicketHandler] Processing " + qmessage.MessageType.Text + " from " + client.RemoteInfo);

                // Handle TicketCreate
                if (qmessage.MessageType == Msg.TicketCreate && qmessage.Direction == MessageDirection.REQUEST)
                {
                    MessageHandler< Dictionary<string,string> > handler = new MessageHandler< Dictionary<string, string> >(qmessage)
                    {
                        ReceiveHandler = new Func< Dictionary<string, string>, Dictionary<string, string> >(QueueRepository.CreateNewNumber),
                        ResponseHandler = (session, result) =>
                        {
                            // Send response to client
                            if (result != null)
                            {
                                // Send response to client(caller)
                                string message = Msg.TicketCreate.Text +
                                                 Msg.Separator + "RES" +
                                                 Msg.Separator + "Identifier" +
                                                 Msg.Separator + result["postprefix"] +
                                                 Msg.CompDelimiter + result["number"] +
                                                 Msg.CompDelimiter + result["post"] +
                                                 Msg.CompDelimiter + result["timestamp"];

                                session.Send(message);

                                string res = QueueRepository.GetTotalWaitingJobs(result["post"]);
                                message += Msg.CompDelimiter + res;
                                QueueServer.SendMessageToQueueCaller(message, result["post"]);

                                //DataTable rest = QueueRepository.GetLoginsPost(result["post"]);

                                //int limit_hours = 1;

                                //foreach (DataRow row in rest.Rows)
                                //{
                                //    string lastTime = row["last_login"].ToString();
                                //    string username = row["username"].ToString();
                                //    DateTime lastLog = DateTime.Parse(lastTime);
                                //    DateTime n = DateTime.Now;
                                //    TimeSpan diff = n - lastLog;
                                //    var isNumeric = Regex.IsMatch(username, @"^\d+$");
                                //    //Console.WriteLine(username);
                                //    //Console.WriteLine(isNumeric);
                                //    if (diff.TotalHours > limit_hours && isNumeric)
                                //    {
                                //        string sms_message = "Nomor Antrian " + result["postprefix"]+result["number"] + " sedang menunggu. #Aplikasi antrian puskesmas";
                                //        sendSMS(sms_message, username);
                                //    }
                                //}
                            }
                        }

                };

                    handler.Process();
                }
            }
            catch(AppException ex)
            {
                exp = ex;
            }
            catch (Exception ex)
            {
                exp = ex;
            }

            if(exp != null)
            {
                Logger.Log("TicketHandler", exp);

                // SYS|NOTIFY|[Type!Message]
                string message =
                    Msg.SysNotify.Text +
                    Msg.Separator + "ERROR" +
                    Msg.CompDelimiter + exp.Message;

                client.Session.Send(message);
            }
        }
    }
}
