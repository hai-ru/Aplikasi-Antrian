#region License
/*
    Sotware Antrian Tobasa
    Copyright (C) 2021  Jefri Sibarani

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/
#endregion

namespace Tobasa
{
    partial class Display
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /*
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        */
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display));
            this.mainDiv = new System.Windows.Forms.TableLayoutPanel();
            this.bottomDiv = new System.Windows.Forms.TableLayoutPanel();
            this.runningTextBottom = new Tobasa.RuntextLabel();
            this.topDiv = new System.Windows.Forms.TableLayoutPanel();
            this.leftDiv = new System.Windows.Forms.TableLayoutPanel();
            this.leftDivPost = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPost0 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPost0Caption = new System.Windows.Forms.Label();
            this.lblPost0No = new System.Windows.Forms.Label();
            this.pnlPost1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPost1Caption = new System.Windows.Forms.Label();
            this.pnlPost2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPost2Caption = new System.Windows.Forms.Label();
            this.lblPost2No = new System.Windows.Forms.Label();
            this.pnlPost3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPost3Caption = new System.Windows.Forms.Label();
            this.lblPost3No = new System.Windows.Forms.Label();
            this.leftDivNmrCtr = new System.Windows.Forms.TableLayoutPanel();
            this.lblCounterLeft = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.centerDiv = new System.Windows.Forms.TableLayoutPanel();
            this.centerInfoStrip1Div = new System.Windows.Forms.TableLayoutPanel();
            this.lblTopText1 = new System.Windows.Forms.Label();
            this.centerInfoStrip0Div = new System.Windows.Forms.TableLayoutPanel();
            this.lblTopText0 = new System.Windows.Forms.Label();
            this.centerBrandDiv = new System.Windows.Forms.TableLayoutPanel();
            this.centerBrandLogoDiv = new System.Windows.Forms.TableLayoutPanel();
            this.centerBrandLogoLabelDiv = new System.Windows.Forms.TableLayoutPanel();
            this.lblBranding = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.centerDateTimeDiv = new System.Windows.Forms.TableLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.centerMiddleDiv = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAntrianFinished = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblQueueNumberFinished = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFin4 = new System.Windows.Forms.Label();
            this.lblFin9 = new System.Windows.Forms.Label();
            this.lblFin8 = new System.Windows.Forms.Label();
            this.lblFin7 = new System.Windows.Forms.Label();
            this.lblFin3 = new System.Windows.Forms.Label();
            this.lblFin6 = new System.Windows.Forms.Label();
            this.lblFin2 = new System.Windows.Forms.Label();
            this.lblFin0 = new System.Windows.Forms.Label();
            this.lblFin5 = new System.Windows.Forms.Label();
            this.lblFin1 = new System.Windows.Forms.Label();
            this.pnlOwnPostStat = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPostNameCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPostNumber = new System.Windows.Forms.Label();
            this.centerPanelVideo = new System.Windows.Forms.Panel();
            this.rightDiv = new System.Windows.Forms.TableLayoutPanel();
            this.rightDivPost = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPost5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPost5Caption = new System.Windows.Forms.Label();
            this.lblPost5No = new System.Windows.Forms.Label();
            this.pnlPost6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPost6Caption = new System.Windows.Forms.Label();
            this.lblPost6No = new System.Windows.Forms.Label();
            this.pnlPost7 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPost7Caption = new System.Windows.Forms.Label();
            this.lblPost7No = new System.Windows.Forms.Label();
            this.pnlPost8 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPost8Caption = new System.Windows.Forms.Label();
            this.lblPost8No = new System.Windows.Forms.Label();
            this.pnlPost9 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPost9Caption = new System.Windows.Forms.Label();
            this.lblPost9No = new System.Windows.Forms.Label();
            this.rightDivNmrCtr = new System.Windows.Forms.TableLayoutPanel();
            this.lblCounterRight = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timerPost0 = new System.Windows.Forms.Timer(this.components);
            this.timerPost1 = new System.Windows.Forms.Timer(this.components);
            this.timerPost2 = new System.Windows.Forms.Timer(this.components);
            this.timerPost3 = new System.Windows.Forms.Timer(this.components);
            this.timerPost4 = new System.Windows.Forms.Timer(this.components);
            this.timerPost5 = new System.Windows.Forms.Timer(this.components);
            this.timerPost6 = new System.Windows.Forms.Timer(this.components);
            this.timerPost7 = new System.Windows.Forms.Timer(this.components);
            this.timerPost8 = new System.Windows.Forms.Timer(this.components);
            this.timerPost9 = new System.Windows.Forms.Timer(this.components);
            this.lblPost1No = new System.Windows.Forms.Label();
            this.lblPost4No = new System.Windows.Forms.Label();
            this.lblPost4Caption = new System.Windows.Forms.Label();
            this.pnlPost4 = new System.Windows.Forms.TableLayoutPanel();
            this.mainDiv.SuspendLayout();
            this.bottomDiv.SuspendLayout();
            this.topDiv.SuspendLayout();
            this.leftDiv.SuspendLayout();
            this.leftDivPost.SuspendLayout();
            this.pnlPost0.SuspendLayout();
            this.pnlPost1.SuspendLayout();
            this.pnlPost2.SuspendLayout();
            this.pnlPost3.SuspendLayout();
            this.leftDivNmrCtr.SuspendLayout();
            this.centerDiv.SuspendLayout();
            this.centerInfoStrip1Div.SuspendLayout();
            this.centerInfoStrip0Div.SuspendLayout();
            this.centerBrandDiv.SuspendLayout();
            this.centerBrandLogoDiv.SuspendLayout();
            this.centerBrandLogoLabelDiv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.centerDateTimeDiv.SuspendLayout();
            this.centerMiddleDiv.SuspendLayout();
            this.pnlAntrianFinished.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlOwnPostStat.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.rightDiv.SuspendLayout();
            this.rightDivPost.SuspendLayout();
            this.pnlPost5.SuspendLayout();
            this.pnlPost6.SuspendLayout();
            this.pnlPost7.SuspendLayout();
            this.pnlPost8.SuspendLayout();
            this.pnlPost9.SuspendLayout();
            this.rightDivNmrCtr.SuspendLayout();
            this.pnlPost4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDiv
            // 
            this.mainDiv.AutoSize = true;
            this.mainDiv.BackColor = System.Drawing.Color.Transparent;
            this.mainDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainDiv.ColumnCount = 1;
            this.mainDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainDiv.Controls.Add(this.bottomDiv, 0, 1);
            this.mainDiv.Controls.Add(this.topDiv, 0, 0);
            this.mainDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDiv.Location = new System.Drawing.Point(0, 0);
            this.mainDiv.Margin = new System.Windows.Forms.Padding(0);
            this.mainDiv.Name = "mainDiv";
            this.mainDiv.RowCount = 2;
            this.mainDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.90741F));
            this.mainDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.092592F));
            this.mainDiv.Size = new System.Drawing.Size(1008, 742);
            this.mainDiv.TabIndex = 0;
            // 
            // bottomDiv
            // 
            this.bottomDiv.BackColor = System.Drawing.Color.Black;
            this.bottomDiv.BackgroundImage = global::Tobasa.Properties.Resources.bgblue330x40;
            this.bottomDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bottomDiv.ColumnCount = 1;
            this.bottomDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.bottomDiv.Controls.Add(this.runningTextBottom, 0, 0);
            this.bottomDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomDiv.Location = new System.Drawing.Point(3, 704);
            this.bottomDiv.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.bottomDiv.Name = "bottomDiv";
            this.bottomDiv.RowCount = 1;
            this.bottomDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.bottomDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.bottomDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.bottomDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.bottomDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.bottomDiv.Size = new System.Drawing.Size(1005, 38);
            this.bottomDiv.TabIndex = 0;
            // 
            // runningTextBottom
            // 
            this.runningTextBottom.AutoSize = true;
            this.runningTextBottom.BackColor = System.Drawing.Color.Transparent;
            this.runningTextBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.runningTextBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runningTextBottom.ForeColor = System.Drawing.Color.Gold;
            this.runningTextBottom.Location = new System.Drawing.Point(3, 0);
            this.runningTextBottom.Name = "runningTextBottom";
            this.runningTextBottom.Size = new System.Drawing.Size(999, 38);
            this.runningTextBottom.TabIndex = 0;
            this.runningTextBottom.Text = "Aplikasi antrian Tobasa";
            this.runningTextBottom.UseCompatibleTextRendering = true;
            // 
            // topDiv
            // 
            this.topDiv.AutoSize = true;
            this.topDiv.ColumnCount = 3;
            this.topDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topDiv.Controls.Add(this.leftDiv, 0, 0);
            this.topDiv.Controls.Add(this.centerDiv, 1, 0);
            this.topDiv.Controls.Add(this.rightDiv, 2, 0);
            this.topDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topDiv.Location = new System.Drawing.Point(0, 0);
            this.topDiv.Margin = new System.Windows.Forms.Padding(0);
            this.topDiv.Name = "topDiv";
            this.topDiv.RowCount = 1;
            this.topDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topDiv.Size = new System.Drawing.Size(1008, 704);
            this.topDiv.TabIndex = 1;
            // 
            // leftDiv
            // 
            this.leftDiv.AutoSize = true;
            this.leftDiv.BackColor = System.Drawing.Color.Transparent;
            this.leftDiv.ColumnCount = 1;
            this.leftDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftDiv.Controls.Add(this.leftDivPost, 0, 1);
            this.leftDiv.Controls.Add(this.leftDivNmrCtr, 0, 0);
            this.leftDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftDiv.Location = new System.Drawing.Point(0, 0);
            this.leftDiv.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.leftDiv.Name = "leftDiv";
            this.leftDiv.RowCount = 2;
            this.leftDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.leftDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.leftDiv.Size = new System.Drawing.Size(252, 701);
            this.leftDiv.TabIndex = 2;
            // 
            // leftDivPost
            // 
            this.leftDivPost.AutoSize = true;
            this.leftDivPost.BackColor = System.Drawing.Color.RoyalBlue;
            this.leftDivPost.ColumnCount = 1;
            this.leftDivPost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftDivPost.Controls.Add(this.pnlPost4, 0, 4);
            this.leftDivPost.Controls.Add(this.pnlPost0, 0, 0);
            this.leftDivPost.Controls.Add(this.pnlPost1, 0, 1);
            this.leftDivPost.Controls.Add(this.pnlPost2, 0, 2);
            this.leftDivPost.Controls.Add(this.pnlPost3, 0, 3);
            this.leftDivPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftDivPost.Location = new System.Drawing.Point(3, 35);
            this.leftDivPost.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.leftDivPost.Name = "leftDivPost";
            this.leftDivPost.RowCount = 5;
            this.leftDivPost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.leftDivPost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.leftDivPost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.leftDivPost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.leftDivPost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.leftDivPost.Size = new System.Drawing.Size(246, 663);
            this.leftDivPost.TabIndex = 0;
            // 
            // pnlPost0
            // 
            this.pnlPost0.BackColor = System.Drawing.Color.Transparent;
            this.pnlPost0.BackgroundImage = global::Tobasa.Properties.Resources.bgblue_rounded330x40;
            this.pnlPost0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPost0.ColumnCount = 1;
            this.pnlPost0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.82927F));
            this.pnlPost0.Controls.Add(this.lblPost0Caption, 0, 0);
            this.pnlPost0.Controls.Add(this.lblPost0No, 0, 1);
            this.pnlPost0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPost0.Location = new System.Drawing.Point(0, 3);
            this.pnlPost0.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pnlPost0.Name = "pnlPost0";
            this.pnlPost0.RowCount = 2;
            this.pnlPost0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlPost0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlPost0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlPost0.Size = new System.Drawing.Size(246, 126);
            this.pnlPost0.TabIndex = 15;
            // 
            // lblPost0Caption
            // 
            this.lblPost0Caption.AutoSize = true;
            this.lblPost0Caption.BackColor = System.Drawing.Color.Transparent;
            this.lblPost0Caption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPost0Caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost0Caption.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPost0Caption.Image = global::Tobasa.Properties.Resources.btn326x35;
            this.lblPost0Caption.Location = new System.Drawing.Point(0, 0);
            this.lblPost0Caption.Margin = new System.Windows.Forms.Padding(0);
            this.lblPost0Caption.Name = "lblPost0Caption";
            this.lblPost0Caption.Size = new System.Drawing.Size(246, 31);
            this.lblPost0Caption.TabIndex = 0;
            this.lblPost0Caption.Text = "POST#0";
            this.lblPost0Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPost0Caption.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // lblPost0No
            // 
            this.lblPost0No.AutoSize = true;
            this.lblPost0No.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPost0No.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost0No.ForeColor = System.Drawing.Color.Gold;
            this.lblPost0No.Location = new System.Drawing.Point(0, 31);
            this.lblPost0No.Margin = new System.Windows.Forms.Padding(0);
            this.lblPost0No.Name = "lblPost0No";
            this.lblPost0No.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblPost0No.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPost0No.Size = new System.Drawing.Size(246, 95);
            this.lblPost0No.TabIndex = 2;
            this.lblPost0No.Text = "A000";
            this.lblPost0No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPost0No.UseCompatibleTextRendering = true;
            this.lblPost0No.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // pnlPost1
            // 
            this.pnlPost1.BackColor = System.Drawing.Color.Transparent;
            this.pnlPost1.BackgroundImage = global::Tobasa.Properties.Resources.bgblue_rounded330x40;
            this.pnlPost1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPost1.ColumnCount = 1;
            this.pnlPost1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.pnlPost1.Controls.Add(this.lblPost1Caption, 0, 0);
            this.pnlPost1.Controls.Add(this.lblPost1No, 0, 1);
            this.pnlPost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPost1.Location = new System.Drawing.Point(0, 135);
            this.pnlPost1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pnlPost1.Name = "pnlPost1";
            this.pnlPost1.RowCount = 2;
            this.pnlPost1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlPost1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlPost1.Size = new System.Drawing.Size(246, 126);
            this.pnlPost1.TabIndex = 14;
            // 
            // lblPost1Caption
            // 
            this.lblPost1Caption.AutoSize = true;
            this.lblPost1Caption.BackColor = System.Drawing.Color.Transparent;
            this.lblPost1Caption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPost1Caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost1Caption.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPost1Caption.Image = global::Tobasa.Properties.Resources.btn326x35;
            this.lblPost1Caption.Location = new System.Drawing.Point(0, 0);
            this.lblPost1Caption.Margin = new System.Windows.Forms.Padding(0);
            this.lblPost1Caption.Name = "lblPost1Caption";
            this.lblPost1Caption.Size = new System.Drawing.Size(246, 31);
            this.lblPost1Caption.TabIndex = 0;
            this.lblPost1Caption.Text = "POST#1";
            this.lblPost1Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPost1Caption.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // pnlPost2
            // 
            this.pnlPost2.BackColor = System.Drawing.Color.Transparent;
            this.pnlPost2.BackgroundImage = global::Tobasa.Properties.Resources.bgblue_rounded330x40;
            this.pnlPost2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPost2.ColumnCount = 1;
            this.pnlPost2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.pnlPost2.Controls.Add(this.lblPost2Caption, 0, 0);
            this.pnlPost2.Controls.Add(this.lblPost2No, 0, 1);
            this.pnlPost2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPost2.Location = new System.Drawing.Point(0, 267);
            this.pnlPost2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pnlPost2.Name = "pnlPost2";
            this.pnlPost2.RowCount = 2;
            this.pnlPost2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlPost2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlPost2.Size = new System.Drawing.Size(246, 126);
            this.pnlPost2.TabIndex = 13;
            // 
            // lblPost2Caption
            // 
            this.lblPost2Caption.AutoSize = true;
            this.lblPost2Caption.BackColor = System.Drawing.Color.Transparent;
            this.lblPost2Caption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPost2Caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost2Caption.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPost2Caption.Image = global::Tobasa.Properties.Resources.btn326x35;
            this.lblPost2Caption.Location = new System.Drawing.Point(0, 0);
            this.lblPost2Caption.Margin = new System.Windows.Forms.Padding(0);
            this.lblPost2Caption.Name = "lblPost2Caption";
            this.lblPost2Caption.Size = new System.Drawing.Size(246, 31);
            this.lblPost2Caption.TabIndex = 0;
            this.lblPost2Caption.Text = "POST#2";
            this.lblPost2Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPost2Caption.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // lblPost2No
            // 
            this.lblPost2No.AutoSize = true;
            this.lblPost2No.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPost2No.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost2No.ForeColor = System.Drawing.Color.Gold;
            this.lblPost2No.Location = new System.Drawing.Point(0, 31);
            this.lblPost2No.Margin = new System.Windows.Forms.Padding(0);
            this.lblPost2No.Name = "lblPost2No";
            this.lblPost2No.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblPost2No.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPost2No.Size = new System.Drawing.Size(246, 95);
            this.lblPost2No.TabIndex = 2;
            this.lblPost2No.Text = "A000";
            this.lblPost2No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPost2No.UseCompatibleTextRendering = true;
            this.lblPost2No.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // pnlPost3
            // 
            this.pnlPost3.BackColor = System.Drawing.Color.Transparent;
            this.pnlPost3.BackgroundImage = global::Tobasa.Properties.Resources.bgblue_rounded330x40;
            this.pnlPost3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPost3.ColumnCount = 1;
            this.pnlPost3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.pnlPost3.Controls.Add(this.lblPost3Caption, 0, 0);
            this.pnlPost3.Controls.Add(this.lblPost3No, 0, 1);
            this.pnlPost3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPost3.Location = new System.Drawing.Point(0, 399);
            this.pnlPost3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.pnlPost3.Name = "pnlPost3";
            this.pnlPost3.RowCount = 2;
            this.pnlPost3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlPost3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlPost3.Size = new System.Drawing.Size(246, 129);
            this.pnlPost3.TabIndex = 12;
            // 
            // lblPost3Caption
            // 
            this.lblPost3Caption.AutoSize = true;
            this.lblPost3Caption.BackColor = System.Drawing.Color.Transparent;
            this.lblPost3Caption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPost3Caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost3Caption.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPost3Caption.Image = global::Tobasa.Properties.Resources.btn326x35;
            this.lblPost3Caption.Location = new System.Drawing.Point(0, 0);
            this.lblPost3Caption.Margin = new System.Windows.Forms.Padding(0);
            this.lblPost3Caption.Name = "lblPost3Caption";
            this.lblPost3Caption.Size = new System.Drawing.Size(246, 32);
            this.lblPost3Caption.TabIndex = 0;
            this.lblPost3Caption.Text = "POST#3";
            this.lblPost3Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPost3Caption.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // lblPost3No
            // 
            this.lblPost3No.AutoSize = true;
            this.lblPost3No.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPost3No.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost3No.ForeColor = System.Drawing.Color.Gold;
            this.lblPost3No.Location = new System.Drawing.Point(0, 32);
            this.lblPost3No.Margin = new System.Windows.Forms.Padding(0);
            this.lblPost3No.Name = "lblPost3No";
            this.lblPost3No.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblPost3No.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPost3No.Size = new System.Drawing.Size(246, 97);
            this.lblPost3No.TabIndex = 2;
            this.lblPost3No.Text = "A000";
            this.lblPost3No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPost3No.UseCompatibleTextRendering = true;
            this.lblPost3No.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // leftDivNmrCtr
            // 
            this.leftDivNmrCtr.BackColor = System.Drawing.Color.Black;
            this.leftDivNmrCtr.BackgroundImage = global::Tobasa.Properties.Resources.bgblue330x40;
            this.leftDivNmrCtr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftDivNmrCtr.ColumnCount = 2;
            this.leftDivNmrCtr.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.leftDivNmrCtr.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.leftDivNmrCtr.Controls.Add(this.lblCounterLeft, 0, 0);
            this.leftDivNmrCtr.Controls.Add(this.label1, 0, 0);
            this.leftDivNmrCtr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftDivNmrCtr.Location = new System.Drawing.Point(3, 0);
            this.leftDivNmrCtr.Margin = new System.Windows.Forms.Padding(3, 0, 3, 1);
            this.leftDivNmrCtr.Name = "leftDivNmrCtr";
            this.leftDivNmrCtr.RowCount = 1;
            this.leftDivNmrCtr.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftDivNmrCtr.Size = new System.Drawing.Size(246, 34);
            this.leftDivNmrCtr.TabIndex = 2;
            // 
            // lblCounterLeft
            // 
            this.lblCounterLeft.AutoSize = true;
            this.lblCounterLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblCounterLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCounterLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounterLeft.ForeColor = System.Drawing.Color.Gold;
            this.lblCounterLeft.Location = new System.Drawing.Point(159, 0);
            this.lblCounterLeft.Margin = new System.Windows.Forms.Padding(0);
            this.lblCounterLeft.Name = "lblCounterLeft";
            this.lblCounterLeft.Size = new System.Drawing.Size(87, 34);
            this.lblCounterLeft.TabIndex = 7;
            this.lblCounterLeft.Text = "Loket";
            this.lblCounterLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nomor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // centerDiv
            // 
            this.centerDiv.BackColor = System.Drawing.Color.Transparent;
            this.centerDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.centerDiv.ColumnCount = 1;
            this.centerDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.centerDiv.Controls.Add(this.centerInfoStrip1Div, 0, 3);
            this.centerDiv.Controls.Add(this.centerInfoStrip0Div, 0, 2);
            this.centerDiv.Controls.Add(this.centerBrandDiv, 0, 0);
            this.centerDiv.Controls.Add(this.centerDateTimeDiv, 0, 1);
            this.centerDiv.Controls.Add(this.centerMiddleDiv, 0, 4);
            this.centerDiv.Controls.Add(this.centerPanelVideo, 0, 5);
            this.centerDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerDiv.Location = new System.Drawing.Point(252, 0);
            this.centerDiv.Margin = new System.Windows.Forms.Padding(0);
            this.centerDiv.Name = "centerDiv";
            this.centerDiv.RowCount = 6;
            this.centerDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.centerDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.centerDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.centerDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.centerDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.centerDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.centerDiv.Size = new System.Drawing.Size(504, 704);
            this.centerDiv.TabIndex = 3;
            // 
            // centerInfoStrip1Div
            // 
            this.centerInfoStrip1Div.AutoSize = true;
            this.centerInfoStrip1Div.BackColor = System.Drawing.Color.Black;
            this.centerInfoStrip1Div.BackgroundImage = global::Tobasa.Properties.Resources.bgblue_rounded133_1x40b;
            this.centerInfoStrip1Div.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.centerInfoStrip1Div.ColumnCount = 2;
            this.centerInfoStrip1Div.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.centerInfoStrip1Div.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.centerInfoStrip1Div.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.centerInfoStrip1Div.Controls.Add(this.lblTopText1, 0, 0);
            this.centerInfoStrip1Div.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerInfoStrip1Div.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.centerInfoStrip1Div.Location = new System.Drawing.Point(0, 147);
            this.centerInfoStrip1Div.Margin = new System.Windows.Forms.Padding(0);
            this.centerInfoStrip1Div.Name = "centerInfoStrip1Div";
            this.centerInfoStrip1Div.Padding = new System.Windows.Forms.Padding(1);
            this.centerInfoStrip1Div.RowCount = 1;
            this.centerInfoStrip1Div.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.centerInfoStrip1Div.Size = new System.Drawing.Size(504, 28);
            this.centerInfoStrip1Div.TabIndex = 8;
            // 
            // lblTopText1
            // 
            this.lblTopText1.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblTopText1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTopText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopText1.ForeColor = System.Drawing.Color.Gold;
            this.lblTopText1.Location = new System.Drawing.Point(1, 1);
            this.lblTopText1.Margin = new System.Windows.Forms.Padding(0);
            this.lblTopText1.Name = "lblTopText1";
            this.lblTopText1.Size = new System.Drawing.Size(502, 26);
            this.lblTopText1.TabIndex = 4;
            this.lblTopText1.Text = "...";
            this.lblTopText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // centerInfoStrip0Div
            // 
            this.centerInfoStrip0Div.AutoSize = true;
            this.centerInfoStrip0Div.BackColor = System.Drawing.Color.Black;
            this.centerInfoStrip0Div.BackgroundImage = global::Tobasa.Properties.Resources.bgblue_rounded133_1x40b;
            this.centerInfoStrip0Div.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.centerInfoStrip0Div.ColumnCount = 2;
            this.centerInfoStrip0Div.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.centerInfoStrip0Div.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.centerInfoStrip0Div.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.centerInfoStrip0Div.Controls.Add(this.lblTopText0, 0, 0);
            this.centerInfoStrip0Div.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerInfoStrip0Div.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.centerInfoStrip0Div.Location = new System.Drawing.Point(0, 119);
            this.centerInfoStrip0Div.Margin = new System.Windows.Forms.Padding(0);
            this.centerInfoStrip0Div.Name = "centerInfoStrip0Div";
            this.centerInfoStrip0Div.Padding = new System.Windows.Forms.Padding(1);
            this.centerInfoStrip0Div.RowCount = 1;
            this.centerInfoStrip0Div.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.centerInfoStrip0Div.Size = new System.Drawing.Size(504, 28);
            this.centerInfoStrip0Div.TabIndex = 7;
            // 
            // lblTopText0
            // 
            this.lblTopText0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTopText0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTopText0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopText0.ForeColor = System.Drawing.Color.Gold;
            this.lblTopText0.Location = new System.Drawing.Point(1, 1);
            this.lblTopText0.Margin = new System.Windows.Forms.Padding(0);
            this.lblTopText0.Name = "lblTopText0";
            this.lblTopText0.Size = new System.Drawing.Size(502, 26);
            this.lblTopText0.TabIndex = 3;
            this.lblTopText0.Text = "...";
            this.lblTopText0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // centerBrandDiv
            // 
            this.centerBrandDiv.AutoSize = true;
            this.centerBrandDiv.BackColor = System.Drawing.Color.Transparent;
            this.centerBrandDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.centerBrandDiv.ColumnCount = 1;
            this.centerBrandDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.centerBrandDiv.Controls.Add(this.centerBrandLogoDiv, 0, 0);
            this.centerBrandDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerBrandDiv.Location = new System.Drawing.Point(0, 0);
            this.centerBrandDiv.Margin = new System.Windows.Forms.Padding(0);
            this.centerBrandDiv.Name = "centerBrandDiv";
            this.centerBrandDiv.RowCount = 1;
            this.centerBrandDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.centerBrandDiv.Size = new System.Drawing.Size(504, 91);
            this.centerBrandDiv.TabIndex = 6;
            // 
            // centerBrandLogoDiv
            // 
            this.centerBrandLogoDiv.AutoSize = true;
            this.centerBrandLogoDiv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.centerBrandLogoDiv.BackgroundImage = global::Tobasa.Properties.Resources.bgblue_rounded133_1x40b;
            this.centerBrandLogoDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.centerBrandLogoDiv.ColumnCount = 2;
            this.centerBrandLogoDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.centerBrandLogoDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.centerBrandLogoDiv.Controls.Add(this.centerBrandLogoLabelDiv, 1, 0);
            this.centerBrandLogoDiv.Controls.Add(this.pictureBoxLogo, 0, 0);
            this.centerBrandLogoDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerBrandLogoDiv.Location = new System.Drawing.Point(0, 0);
            this.centerBrandLogoDiv.Margin = new System.Windows.Forms.Padding(0);
            this.centerBrandLogoDiv.Name = "centerBrandLogoDiv";
            this.centerBrandLogoDiv.Padding = new System.Windows.Forms.Padding(3);
            this.centerBrandLogoDiv.RowCount = 1;
            this.centerBrandLogoDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.centerBrandLogoDiv.Size = new System.Drawing.Size(504, 91);
            this.centerBrandLogoDiv.TabIndex = 0;
            // 
            // centerBrandLogoLabelDiv
            // 
            this.centerBrandLogoLabelDiv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.centerBrandLogoLabelDiv.ColumnCount = 1;
            this.centerBrandLogoLabelDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.centerBrandLogoLabelDiv.Controls.Add(this.lblBranding, 0, 0);
            this.centerBrandLogoLabelDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerBrandLogoLabelDiv.Location = new System.Drawing.Point(105, 6);
            this.centerBrandLogoLabelDiv.Name = "centerBrandLogoLabelDiv";
            this.centerBrandLogoLabelDiv.RowCount = 1;
            this.centerBrandLogoLabelDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.centerBrandLogoLabelDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.centerBrandLogoLabelDiv.Size = new System.Drawing.Size(393, 79);
            this.centerBrandLogoLabelDiv.TabIndex = 1;
            // 
            // lblBranding
            // 
            this.lblBranding.AutoSize = true;
            this.lblBranding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBranding.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranding.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBranding.Location = new System.Drawing.Point(0, 0);
            this.lblBranding.Margin = new System.Windows.Forms.Padding(0);
            this.lblBranding.Name = "lblBranding";
            this.lblBranding.Size = new System.Drawing.Size(393, 79);
            this.lblBranding.TabIndex = 0;
            this.lblBranding.Text = "PUSKESMAS\r\nSELAKAU TIMUR";
            this.lblBranding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBranding.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = global::Tobasa.Properties.Resources.Logo_Puskesmas;
            this.pictureBoxLogo.Location = new System.Drawing.Point(4, 7);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(1, 4, 1, 1);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(97, 80);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // centerDateTimeDiv
            // 
            this.centerDateTimeDiv.AutoSize = true;
            this.centerDateTimeDiv.BackColor = System.Drawing.Color.Black;
            this.centerDateTimeDiv.BackgroundImage = global::Tobasa.Properties.Resources.bgblue_rounded133_1x40b;
            this.centerDateTimeDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.centerDateTimeDiv.ColumnCount = 1;
            this.centerDateTimeDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.centerDateTimeDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.centerDateTimeDiv.Controls.Add(this.lblDate, 0, 0);
            this.centerDateTimeDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerDateTimeDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.centerDateTimeDiv.Location = new System.Drawing.Point(0, 91);
            this.centerDateTimeDiv.Margin = new System.Windows.Forms.Padding(0);
            this.centerDateTimeDiv.Name = "centerDateTimeDiv";
            this.centerDateTimeDiv.Padding = new System.Windows.Forms.Padding(1);
            this.centerDateTimeDiv.RowCount = 1;
            this.centerDateTimeDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.centerDateTimeDiv.Size = new System.Drawing.Size(504, 28);
            this.centerDateTimeDiv.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblDate.Location = new System.Drawing.Point(254, 1);
            this.lblDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(249, 26);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Rabu 01-01-2022 14.23.20";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDate.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // centerMiddleDiv
            // 
            this.centerMiddleDiv.BackColor = System.Drawing.Color.MidnightBlue;
            this.centerMiddleDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.centerMiddleDiv.ColumnCount = 2;
            this.centerMiddleDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.centerMiddleDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.centerMiddleDiv.Controls.Add(this.pnlAntrianFinished, 0, 0);
            this.centerMiddleDiv.Controls.Add(this.pnlOwnPostStat, 1, 0);
            this.centerMiddleDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerMiddleDiv.Location = new System.Drawing.Point(0, 175);
            this.centerMiddleDiv.Margin = new System.Windows.Forms.Padding(0);
            this.centerMiddleDiv.Name = "centerMiddleDiv";
            this.centerMiddleDiv.RowCount = 1;
            this.centerMiddleDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.centerMiddleDiv.Size = new System.Drawing.Size(504, 176);
            this.centerMiddleDiv.TabIndex = 4;
            // 
            // pnlAntrianFinished
            // 
            this.pnlAntrianFinished.Controls.Add(this.tableLayoutPanel1);
            this.pnlAntrianFinished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAntrianFinished.Location = new System.Drawing.Point(3, 3);
            this.pnlAntrianFinished.Name = "pnlAntrianFinished";
            this.pnlAntrianFinished.Size = new System.Drawing.Size(246, 170);
            this.pnlAntrianFinished.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblQueueNumberFinished, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(246, 170);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblQueueNumberFinished
            // 
            this.lblQueueNumberFinished.AutoSize = true;
            this.lblQueueNumberFinished.BackColor = System.Drawing.Color.Transparent;
            this.lblQueueNumberFinished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQueueNumberFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueueNumberFinished.ForeColor = System.Drawing.Color.Gold;
            this.lblQueueNumberFinished.Location = new System.Drawing.Point(0, 0);
            this.lblQueueNumberFinished.Margin = new System.Windows.Forms.Padding(0);
            this.lblQueueNumberFinished.Name = "lblQueueNumberFinished";
            this.lblQueueNumberFinished.Size = new System.Drawing.Size(246, 25);
            this.lblQueueNumberFinished.TabIndex = 1;
            this.lblQueueNumberFinished.Text = "Antrian Telah Selesai";
            this.lblQueueNumberFinished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQueueNumberFinished.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.BackgroundImage = global::Tobasa.Properties.Resources.bgblue_rounded133_1x401;
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblFin4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblFin9, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblFin8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblFin7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblFin3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblFin6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblFin2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblFin0, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblFin5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblFin1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(12);
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(240, 142);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblFin4
            // 
            this.lblFin4.AutoSize = true;
            this.lblFin4.BackColor = System.Drawing.Color.Transparent;
            this.lblFin4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFin4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin4.ForeColor = System.Drawing.Color.Lavender;
            this.lblFin4.Image = global::Tobasa.Properties.Resources.bgblue4;
            this.lblFin4.Location = new System.Drawing.Point(15, 104);
            this.lblFin4.Name = "lblFin4";
            this.lblFin4.Size = new System.Drawing.Size(102, 26);
            this.lblFin4.TabIndex = 10;
            this.lblFin4.Text = "A5";
            this.lblFin4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFin4.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // lblFin9
            // 
            this.lblFin9.AutoSize = true;
            this.lblFin9.BackColor = System.Drawing.Color.Transparent;
            this.lblFin9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFin9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin9.ForeColor = System.Drawing.Color.Lavender;
            this.lblFin9.Image = global::Tobasa.Properties.Resources.bgblue3;
            this.lblFin9.Location = new System.Drawing.Point(120, 104);
            this.lblFin9.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblFin9.Name = "lblFin9";
            this.lblFin9.Size = new System.Drawing.Size(105, 26);
            this.lblFin9.TabIndex = 9;
            this.lblFin9.Text = "A10";
            this.lblFin9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFin9.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // lblFin8
            // 
            this.lblFin8.AutoSize = true;
            this.lblFin8.BackColor = System.Drawing.Color.Transparent;
            this.lblFin8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFin8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin8.ForeColor = System.Drawing.Color.Gold;
            this.lblFin8.Location = new System.Drawing.Point(120, 81);
            this.lblFin8.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblFin8.Name = "lblFin8";
            this.lblFin8.Size = new System.Drawing.Size(105, 23);
            this.lblFin8.TabIndex = 8;
            this.lblFin8.Text = "A9";
            this.lblFin8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFin8.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // lblFin7
            // 
            this.lblFin7.AutoSize = true;
            this.lblFin7.BackColor = System.Drawing.Color.Transparent;
            this.lblFin7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFin7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin7.ForeColor = System.Drawing.Color.Lavender;
            this.lblFin7.Image = global::Tobasa.Properties.Resources.bgblue3;
            this.lblFin7.Location = new System.Drawing.Point(120, 58);
            this.lblFin7.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblFin7.Name = "lblFin7";
            this.lblFin7.Size = new System.Drawing.Size(105, 23);
            this.lblFin7.TabIndex = 7;
            this.lblFin7.Text = "A8";
            this.lblFin7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFin7.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // lblFin3
            // 
            this.lblFin3.AutoSize = true;
            this.lblFin3.BackColor = System.Drawing.Color.Transparent;
            this.lblFin3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFin3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin3.ForeColor = System.Drawing.Color.Gold;
            this.lblFin3.Location = new System.Drawing.Point(15, 81);
            this.lblFin3.Name = "lblFin3";
            this.lblFin3.Size = new System.Drawing.Size(102, 23);
            this.lblFin3.TabIndex = 6;
            this.lblFin3.Text = "A4";
            this.lblFin3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFin3.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // lblFin6
            // 
            this.lblFin6.AutoSize = true;
            this.lblFin6.BackColor = System.Drawing.Color.Transparent;
            this.lblFin6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFin6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin6.ForeColor = System.Drawing.Color.Gold;
            this.lblFin6.Location = new System.Drawing.Point(120, 35);
            this.lblFin6.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblFin6.Name = "lblFin6";
            this.lblFin6.Size = new System.Drawing.Size(105, 23);
            this.lblFin6.TabIndex = 5;
            this.lblFin6.Text = "A7";
            this.lblFin6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFin6.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // lblFin2
            // 
            this.lblFin2.AutoSize = true;
            this.lblFin2.BackColor = System.Drawing.Color.Transparent;
            this.lblFin2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin2.ForeColor = System.Drawing.Color.Lavender;
            this.lblFin2.Image = global::Tobasa.Properties.Resources.bgblue4;
            this.lblFin2.Location = new System.Drawing.Point(15, 58);
            this.lblFin2.Name = "lblFin2";
            this.lblFin2.Size = new System.Drawing.Size(102, 23);
            this.lblFin2.TabIndex = 4;
            this.lblFin2.Text = "A3";
            this.lblFin2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFin2.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // lblFin0
            // 
            this.lblFin0.AutoSize = true;
            this.lblFin0.BackColor = System.Drawing.Color.Transparent;
            this.lblFin0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFin0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin0.ForeColor = System.Drawing.Color.Lavender;
            this.lblFin0.Image = global::Tobasa.Properties.Resources.bgblue4;
            this.lblFin0.Location = new System.Drawing.Point(15, 12);
            this.lblFin0.Name = "lblFin0";
            this.lblFin0.Size = new System.Drawing.Size(102, 23);
            this.lblFin0.TabIndex = 3;
            this.lblFin0.Text = "A1";
            this.lblFin0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFin0.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // lblFin5
            // 
            this.lblFin5.AutoSize = true;
            this.lblFin5.BackColor = System.Drawing.Color.Transparent;
            this.lblFin5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFin5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin5.ForeColor = System.Drawing.Color.Lavender;
            this.lblFin5.Image = global::Tobasa.Properties.Resources.bgblue3;
            this.lblFin5.Location = new System.Drawing.Point(120, 12);
            this.lblFin5.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblFin5.Name = "lblFin5";
            this.lblFin5.Size = new System.Drawing.Size(105, 23);
            this.lblFin5.TabIndex = 2;
            this.lblFin5.Text = "A6";
            this.lblFin5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFin5.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // lblFin1
            // 
            this.lblFin1.AutoSize = true;
            this.lblFin1.BackColor = System.Drawing.Color.Transparent;
            this.lblFin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin1.ForeColor = System.Drawing.Color.Gold;
            this.lblFin1.Location = new System.Drawing.Point(15, 35);
            this.lblFin1.Name = "lblFin1";
            this.lblFin1.Size = new System.Drawing.Size(102, 23);
            this.lblFin1.TabIndex = 1;
            this.lblFin1.Text = "A2";
            this.lblFin1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFin1.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // pnlOwnPostStat
            // 
            this.pnlOwnPostStat.Controls.Add(this.tableLayoutPanel6);
            this.pnlOwnPostStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOwnPostStat.Location = new System.Drawing.Point(255, 3);
            this.pnlOwnPostStat.Name = "pnlOwnPostStat";
            this.pnlOwnPostStat.Size = new System.Drawing.Size(246, 170);
            this.pnlOwnPostStat.TabIndex = 5;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.lblPostNameCaption, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(246, 170);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // lblPostNameCaption
            // 
            this.lblPostNameCaption.AutoSize = true;
            this.lblPostNameCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblPostNameCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPostNameCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblPostNameCaption.ForeColor = System.Drawing.Color.Gold;
            this.lblPostNameCaption.Location = new System.Drawing.Point(0, 0);
            this.lblPostNameCaption.Margin = new System.Windows.Forms.Padding(0);
            this.lblPostNameCaption.Name = "lblPostNameCaption";
            this.lblPostNameCaption.Size = new System.Drawing.Size(246, 25);
            this.lblPostNameCaption.TabIndex = 3;
            this.lblPostNameCaption.Text = "POST NAME";
            this.lblPostNameCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPostNameCaption.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.BackgroundImage = global::Tobasa.Properties.Resources.bgblue_rounded133_1x401;
            this.tableLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lblPostNumber, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 28);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(6, 3, 6, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(234, 142);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // lblPostNumber
            // 
            this.lblPostNumber.AutoSize = true;
            this.lblPostNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPostNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPostNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostNumber.ForeColor = System.Drawing.Color.Gold;
            this.lblPostNumber.Location = new System.Drawing.Point(0, 0);
            this.lblPostNumber.Margin = new System.Windows.Forms.Padding(0);
            this.lblPostNumber.MinimumSize = new System.Drawing.Size(211, 82);
            this.lblPostNumber.Name = "lblPostNumber";
            this.lblPostNumber.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblPostNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPostNumber.Size = new System.Drawing.Size(234, 142);
            this.lblPostNumber.TabIndex = 3;
            this.lblPostNumber.Text = "A000";
            this.lblPostNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPostNumber.UseCompatibleTextRendering = true;
            this.lblPostNumber.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // centerPanelVideo
            // 
            this.centerPanelVideo.BackColor = System.Drawing.Color.Gainsboro;
            this.centerPanelVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanelVideo.Location = new System.Drawing.Point(1, 354);
            this.centerPanelVideo.Margin = new System.Windows.Forms.Padding(1, 3, 1, 5);
            this.centerPanelVideo.Name = "centerPanelVideo";
            this.centerPanelVideo.Size = new System.Drawing.Size(502, 345);
            this.centerPanelVideo.TabIndex = 0;
            // 
            // rightDiv
            // 
            this.rightDiv.AutoSize = true;
            this.rightDiv.ColumnCount = 1;
            this.rightDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightDiv.Controls.Add(this.rightDivPost, 0, 1);
            this.rightDiv.Controls.Add(this.rightDivNmrCtr, 0, 0);
            this.rightDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightDiv.Location = new System.Drawing.Point(756, 0);
            this.rightDiv.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.rightDiv.Name = "rightDiv";
            this.rightDiv.RowCount = 2;
            this.rightDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.rightDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.rightDiv.Size = new System.Drawing.Size(252, 701);
            this.rightDiv.TabIndex = 4;
            // 
            // rightDivPost
            // 
            this.rightDivPost.AutoSize = true;
            this.rightDivPost.BackColor = System.Drawing.Color.RoyalBlue;
            this.rightDivPost.ColumnCount = 1;
            this.rightDivPost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightDivPost.Controls.Add(this.pnlPost5, 0, 0);
            this.rightDivPost.Controls.Add(this.pnlPost6, 0, 1);
            this.rightDivPost.Controls.Add(this.pnlPost7, 0, 2);
            this.rightDivPost.Controls.Add(this.pnlPost8, 0, 3);
            this.rightDivPost.Controls.Add(this.pnlPost9, 0, 4);
            this.rightDivPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightDivPost.Location = new System.Drawing.Point(3, 35);
            this.rightDivPost.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.rightDivPost.Name = "rightDivPost";
            this.rightDivPost.RowCount = 5;
            this.rightDivPost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.rightDivPost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.rightDivPost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.rightDivPost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.rightDivPost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.rightDivPost.Size = new System.Drawing.Size(246, 663);
            this.rightDivPost.TabIndex = 4;
            // 
            // pnlPost5
            // 
            this.pnlPost5.BackColor = System.Drawing.Color.Transparent;
            this.pnlPost5.BackgroundImage = global::Tobasa.Properties.Resources.bgblue_rounded330x40;
            this.pnlPost5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPost5.ColumnCount = 1;
            this.pnlPost5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.pnlPost5.Controls.Add(this.lblPost5Caption, 0, 0);
            this.pnlPost5.Controls.Add(this.lblPost5No, 0, 1);
            this.pnlPost5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPost5.Location = new System.Drawing.Point(0, 3);
            this.pnlPost5.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.pnlPost5.Name = "pnlPost5";
            this.pnlPost5.RowCount = 2;
            this.pnlPost5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlPost5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlPost5.Size = new System.Drawing.Size(246, 129);
            this.pnlPost5.TabIndex = 16;
            // 
            // lblPost5Caption
            // 
            this.lblPost5Caption.AutoSize = true;
            this.lblPost5Caption.BackColor = System.Drawing.Color.Transparent;
            this.lblPost5Caption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPost5Caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost5Caption.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPost5Caption.Image = global::Tobasa.Properties.Resources.btn326x35;
            this.lblPost5Caption.Location = new System.Drawing.Point(0, 0);
            this.lblPost5Caption.Margin = new System.Windows.Forms.Padding(0);
            this.lblPost5Caption.Name = "lblPost5Caption";
            this.lblPost5Caption.Size = new System.Drawing.Size(246, 32);
            this.lblPost5Caption.TabIndex = 0;
            this.lblPost5Caption.Text = "POST#5";
            this.lblPost5Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPost5Caption.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // lblPost5No
            // 
            this.lblPost5No.AutoSize = true;
            this.lblPost5No.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPost5No.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost5No.ForeColor = System.Drawing.Color.Gold;
            this.lblPost5No.Location = new System.Drawing.Point(0, 32);
            this.lblPost5No.Margin = new System.Windows.Forms.Padding(0);
            this.lblPost5No.Name = "lblPost5No";
            this.lblPost5No.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblPost5No.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPost5No.Size = new System.Drawing.Size(246, 97);
            this.lblPost5No.TabIndex = 2;
            this.lblPost5No.Text = "A000";
            this.lblPost5No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPost5No.UseCompatibleTextRendering = true;
            this.lblPost5No.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // pnlPost6
            // 
            this.pnlPost6.BackColor = System.Drawing.Color.Transparent;
            this.pnlPost6.BackgroundImage = global::Tobasa.Properties.Resources.bgblue_rounded330x40;
            this.pnlPost6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPost6.ColumnCount = 1;
            this.pnlPost6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.pnlPost6.Controls.Add(this.lblPost6Caption, 0, 0);
            this.pnlPost6.Controls.Add(this.lblPost6No, 0, 1);
            this.pnlPost6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPost6.Location = new System.Drawing.Point(0, 134);
            this.pnlPost6.Margin = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.pnlPost6.Name = "pnlPost6";
            this.pnlPost6.RowCount = 2;
            this.pnlPost6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlPost6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlPost6.Size = new System.Drawing.Size(246, 127);
            this.pnlPost6.TabIndex = 15;
            // 
            // lblPost6Caption
            // 
            this.lblPost6Caption.AutoSize = true;
            this.lblPost6Caption.BackColor = System.Drawing.Color.Transparent;
            this.lblPost6Caption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPost6Caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost6Caption.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPost6Caption.Image = global::Tobasa.Properties.Resources.btn326x35;
            this.lblPost6Caption.Location = new System.Drawing.Point(0, 0);
            this.lblPost6Caption.Margin = new System.Windows.Forms.Padding(0);
            this.lblPost6Caption.Name = "lblPost6Caption";
            this.lblPost6Caption.Size = new System.Drawing.Size(246, 31);
            this.lblPost6Caption.TabIndex = 0;
            this.lblPost6Caption.Text = "POST#6";
            this.lblPost6Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPost6Caption.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // lblPost6No
            // 
            this.lblPost6No.AutoSize = true;
            this.lblPost6No.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPost6No.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost6No.ForeColor = System.Drawing.Color.Gold;
            this.lblPost6No.Location = new System.Drawing.Point(0, 31);
            this.lblPost6No.Margin = new System.Windows.Forms.Padding(0);
            this.lblPost6No.Name = "lblPost6No";
            this.lblPost6No.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblPost6No.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPost6No.Size = new System.Drawing.Size(246, 96);
            this.lblPost6No.TabIndex = 2;
            this.lblPost6No.Text = "A000";
            this.lblPost6No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPost6No.UseCompatibleTextRendering = true;
            this.lblPost6No.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // pnlPost7
            // 
            this.pnlPost7.BackColor = System.Drawing.Color.Transparent;
            this.pnlPost7.BackgroundImage = global::Tobasa.Properties.Resources.bgblue_rounded330x40;
            this.pnlPost7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPost7.ColumnCount = 1;
            this.pnlPost7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.pnlPost7.Controls.Add(this.lblPost7Caption, 0, 0);
            this.pnlPost7.Controls.Add(this.lblPost7No, 0, 1);
            this.pnlPost7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPost7.Location = new System.Drawing.Point(0, 267);
            this.pnlPost7.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pnlPost7.Name = "pnlPost7";
            this.pnlPost7.RowCount = 2;
            this.pnlPost7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlPost7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlPost7.Size = new System.Drawing.Size(246, 126);
            this.pnlPost7.TabIndex = 14;
            // 
            // lblPost7Caption
            // 
            this.lblPost7Caption.AutoSize = true;
            this.lblPost7Caption.BackColor = System.Drawing.Color.Transparent;
            this.lblPost7Caption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPost7Caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost7Caption.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPost7Caption.Image = global::Tobasa.Properties.Resources.btn326x35;
            this.lblPost7Caption.Location = new System.Drawing.Point(0, 0);
            this.lblPost7Caption.Margin = new System.Windows.Forms.Padding(0);
            this.lblPost7Caption.Name = "lblPost7Caption";
            this.lblPost7Caption.Size = new System.Drawing.Size(246, 31);
            this.lblPost7Caption.TabIndex = 0;
            this.lblPost7Caption.Text = "POST#7";
            this.lblPost7Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPost7Caption.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // lblPost7No
            // 
            this.lblPost7No.AutoSize = true;
            this.lblPost7No.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPost7No.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost7No.ForeColor = System.Drawing.Color.Gold;
            this.lblPost7No.Location = new System.Drawing.Point(0, 31);
            this.lblPost7No.Margin = new System.Windows.Forms.Padding(0);
            this.lblPost7No.Name = "lblPost7No";
            this.lblPost7No.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblPost7No.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPost7No.Size = new System.Drawing.Size(246, 95);
            this.lblPost7No.TabIndex = 2;
            this.lblPost7No.Text = "A000";
            this.lblPost7No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPost7No.UseCompatibleTextRendering = true;
            this.lblPost7No.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // pnlPost8
            // 
            this.pnlPost8.BackColor = System.Drawing.Color.Transparent;
            this.pnlPost8.BackgroundImage = global::Tobasa.Properties.Resources.bgblue_rounded330x40;
            this.pnlPost8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPost8.ColumnCount = 1;
            this.pnlPost8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.pnlPost8.Controls.Add(this.lblPost8Caption, 0, 0);
            this.pnlPost8.Controls.Add(this.lblPost8No, 0, 1);
            this.pnlPost8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPost8.Location = new System.Drawing.Point(0, 399);
            this.pnlPost8.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pnlPost8.Name = "pnlPost8";
            this.pnlPost8.RowCount = 2;
            this.pnlPost8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlPost8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlPost8.Size = new System.Drawing.Size(246, 126);
            this.pnlPost8.TabIndex = 13;
            // 
            // lblPost8Caption
            // 
            this.lblPost8Caption.AutoSize = true;
            this.lblPost8Caption.BackColor = System.Drawing.Color.Transparent;
            this.lblPost8Caption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPost8Caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost8Caption.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPost8Caption.Image = global::Tobasa.Properties.Resources.btn326x35;
            this.lblPost8Caption.Location = new System.Drawing.Point(0, 0);
            this.lblPost8Caption.Margin = new System.Windows.Forms.Padding(0);
            this.lblPost8Caption.Name = "lblPost8Caption";
            this.lblPost8Caption.Size = new System.Drawing.Size(246, 31);
            this.lblPost8Caption.TabIndex = 0;
            this.lblPost8Caption.Text = "POST#8";
            this.lblPost8Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPost8Caption.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // lblPost8No
            // 
            this.lblPost8No.AutoSize = true;
            this.lblPost8No.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPost8No.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost8No.ForeColor = System.Drawing.Color.Gold;
            this.lblPost8No.Location = new System.Drawing.Point(0, 31);
            this.lblPost8No.Margin = new System.Windows.Forms.Padding(0);
            this.lblPost8No.Name = "lblPost8No";
            this.lblPost8No.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblPost8No.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPost8No.Size = new System.Drawing.Size(246, 95);
            this.lblPost8No.TabIndex = 2;
            this.lblPost8No.Text = "A000";
            this.lblPost8No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPost8No.UseCompatibleTextRendering = true;
            this.lblPost8No.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // pnlPost9
            // 
            this.pnlPost9.BackColor = System.Drawing.Color.Transparent;
            this.pnlPost9.BackgroundImage = global::Tobasa.Properties.Resources.bgblue_rounded330x40;
            this.pnlPost9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPost9.ColumnCount = 1;
            this.pnlPost9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.pnlPost9.Controls.Add(this.lblPost9Caption, 0, 0);
            this.pnlPost9.Controls.Add(this.lblPost9No, 0, 1);
            this.pnlPost9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPost9.Location = new System.Drawing.Point(0, 531);
            this.pnlPost9.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.pnlPost9.Name = "pnlPost9";
            this.pnlPost9.RowCount = 2;
            this.pnlPost9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlPost9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlPost9.Size = new System.Drawing.Size(246, 132);
            this.pnlPost9.TabIndex = 12;
            // 
            // lblPost9Caption
            // 
            this.lblPost9Caption.AutoSize = true;
            this.lblPost9Caption.BackColor = System.Drawing.Color.Transparent;
            this.lblPost9Caption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPost9Caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost9Caption.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPost9Caption.Image = global::Tobasa.Properties.Resources.btn326x35;
            this.lblPost9Caption.Location = new System.Drawing.Point(0, 0);
            this.lblPost9Caption.Margin = new System.Windows.Forms.Padding(0);
            this.lblPost9Caption.Name = "lblPost9Caption";
            this.lblPost9Caption.Size = new System.Drawing.Size(246, 33);
            this.lblPost9Caption.TabIndex = 0;
            this.lblPost9Caption.Text = "POST#9";
            this.lblPost9Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPost9Caption.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // lblPost9No
            // 
            this.lblPost9No.AutoSize = true;
            this.lblPost9No.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPost9No.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost9No.ForeColor = System.Drawing.Color.Gold;
            this.lblPost9No.Location = new System.Drawing.Point(0, 33);
            this.lblPost9No.Margin = new System.Windows.Forms.Padding(0);
            this.lblPost9No.Name = "lblPost9No";
            this.lblPost9No.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblPost9No.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPost9No.Size = new System.Drawing.Size(246, 99);
            this.lblPost9No.TabIndex = 2;
            this.lblPost9No.Text = "A000";
            this.lblPost9No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPost9No.UseCompatibleTextRendering = true;
            this.lblPost9No.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // rightDivNmrCtr
            // 
            this.rightDivNmrCtr.BackColor = System.Drawing.Color.Black;
            this.rightDivNmrCtr.BackgroundImage = global::Tobasa.Properties.Resources.bgblue330x40;
            this.rightDivNmrCtr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightDivNmrCtr.ColumnCount = 2;
            this.rightDivNmrCtr.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.rightDivNmrCtr.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.rightDivNmrCtr.Controls.Add(this.lblCounterRight, 0, 0);
            this.rightDivNmrCtr.Controls.Add(this.label5, 0, 0);
            this.rightDivNmrCtr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightDivNmrCtr.Location = new System.Drawing.Point(3, 0);
            this.rightDivNmrCtr.Margin = new System.Windows.Forms.Padding(3, 0, 3, 1);
            this.rightDivNmrCtr.Name = "rightDivNmrCtr";
            this.rightDivNmrCtr.RowCount = 1;
            this.rightDivNmrCtr.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightDivNmrCtr.Size = new System.Drawing.Size(246, 34);
            this.rightDivNmrCtr.TabIndex = 3;
            // 
            // lblCounterRight
            // 
            this.lblCounterRight.AutoSize = true;
            this.lblCounterRight.BackColor = System.Drawing.Color.Transparent;
            this.lblCounterRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCounterRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounterRight.ForeColor = System.Drawing.Color.Gold;
            this.lblCounterRight.Location = new System.Drawing.Point(159, 0);
            this.lblCounterRight.Margin = new System.Windows.Forms.Padding(0);
            this.lblCounterRight.Name = "lblCounterRight";
            this.lblCounterRight.Size = new System.Drawing.Size(87, 34);
            this.lblCounterRight.TabIndex = 7;
            this.lblCounterRight.Text = "Loket";
            this.lblCounterRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCounterRight.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 34);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nomor";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // timerPost0
            // 
            this.timerPost0.Tick += new System.EventHandler(this.OnTimer);
            // 
            // timerPost1
            // 
            this.timerPost1.Tick += new System.EventHandler(this.OnTimer);
            // 
            // timerPost2
            // 
            this.timerPost2.Tick += new System.EventHandler(this.OnTimer);
            // 
            // timerPost3
            // 
            this.timerPost3.Tick += new System.EventHandler(this.OnTimer);
            // 
            // timerPost4
            // 
            this.timerPost4.Tick += new System.EventHandler(this.OnTimer);
            // 
            // timerPost5
            // 
            this.timerPost5.Tick += new System.EventHandler(this.OnTimer);
            // 
            // timerPost6
            // 
            this.timerPost6.Tick += new System.EventHandler(this.OnTimer);
            // 
            // timerPost7
            // 
            this.timerPost7.Tick += new System.EventHandler(this.OnTimer);
            // 
            // timerPost8
            // 
            this.timerPost8.Tick += new System.EventHandler(this.OnTimer);
            // 
            // timerPost9
            // 
            this.timerPost9.Tick += new System.EventHandler(this.OnTimer);
            // 
            // lblPost1No
            // 
            this.lblPost1No.AutoSize = true;
            this.lblPost1No.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPost1No.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost1No.ForeColor = System.Drawing.Color.Gold;
            this.lblPost1No.Location = new System.Drawing.Point(0, 31);
            this.lblPost1No.Margin = new System.Windows.Forms.Padding(0);
            this.lblPost1No.Name = "lblPost1No";
            this.lblPost1No.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblPost1No.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPost1No.Size = new System.Drawing.Size(246, 95);
            this.lblPost1No.TabIndex = 2;
            this.lblPost1No.Text = "A000";
            this.lblPost1No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPost1No.UseCompatibleTextRendering = true;
            this.lblPost1No.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // lblPost4No
            // 
            this.lblPost4No.AutoSize = true;
            this.lblPost4No.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPost4No.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost4No.ForeColor = System.Drawing.Color.Gold;
            this.lblPost4No.Location = new System.Drawing.Point(0, 32);
            this.lblPost4No.Margin = new System.Windows.Forms.Padding(0);
            this.lblPost4No.Name = "lblPost4No";
            this.lblPost4No.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblPost4No.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPost4No.Size = new System.Drawing.Size(246, 97);
            this.lblPost4No.TabIndex = 2;
            this.lblPost4No.Text = "A000";
            this.lblPost4No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPost4No.UseCompatibleTextRendering = true;
            this.lblPost4No.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // lblPost4Caption
            // 
            this.lblPost4Caption.AutoSize = true;
            this.lblPost4Caption.BackColor = System.Drawing.Color.Transparent;
            this.lblPost4Caption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPost4Caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost4Caption.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPost4Caption.Image = global::Tobasa.Properties.Resources.btn326x35;
            this.lblPost4Caption.Location = new System.Drawing.Point(0, 0);
            this.lblPost4Caption.Margin = new System.Windows.Forms.Padding(0);
            this.lblPost4Caption.Name = "lblPost4Caption";
            this.lblPost4Caption.Size = new System.Drawing.Size(246, 32);
            this.lblPost4Caption.TabIndex = 0;
            this.lblPost4Caption.Text = "POST#4";
            this.lblPost4Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPost4Caption.Resize += new System.EventHandler(this.OnLabelResize);
            // 
            // pnlPost4
            // 
            this.pnlPost4.BackColor = System.Drawing.Color.Transparent;
            this.pnlPost4.BackgroundImage = global::Tobasa.Properties.Resources.bgblue_rounded330x40;
            this.pnlPost4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPost4.ColumnCount = 1;
            this.pnlPost4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.pnlPost4.Controls.Add(this.lblPost4Caption, 0, 0);
            this.pnlPost4.Controls.Add(this.lblPost4No, 0, 1);
            this.pnlPost4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPost4.Location = new System.Drawing.Point(0, 531);
            this.pnlPost4.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pnlPost4.Name = "pnlPost4";
            this.pnlPost4.RowCount = 2;
            this.pnlPost4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlPost4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlPost4.Size = new System.Drawing.Size(246, 129);
            this.pnlPost4.TabIndex = 16;
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1008, 742);
            this.Controls.Add(this.mainDiv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Display";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Display_FormClosing);
            this.Load += new System.EventHandler(this.Display_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.On_KeyDown);
            this.Resize += new System.EventHandler(this.Display_Resize);
            this.mainDiv.ResumeLayout(false);
            this.mainDiv.PerformLayout();
            this.bottomDiv.ResumeLayout(false);
            this.bottomDiv.PerformLayout();
            this.topDiv.ResumeLayout(false);
            this.topDiv.PerformLayout();
            this.leftDiv.ResumeLayout(false);
            this.leftDiv.PerformLayout();
            this.leftDivPost.ResumeLayout(false);
            this.pnlPost0.ResumeLayout(false);
            this.pnlPost0.PerformLayout();
            this.pnlPost1.ResumeLayout(false);
            this.pnlPost1.PerformLayout();
            this.pnlPost2.ResumeLayout(false);
            this.pnlPost2.PerformLayout();
            this.pnlPost3.ResumeLayout(false);
            this.pnlPost3.PerformLayout();
            this.leftDivNmrCtr.ResumeLayout(false);
            this.leftDivNmrCtr.PerformLayout();
            this.centerDiv.ResumeLayout(false);
            this.centerDiv.PerformLayout();
            this.centerInfoStrip1Div.ResumeLayout(false);
            this.centerInfoStrip0Div.ResumeLayout(false);
            this.centerBrandDiv.ResumeLayout(false);
            this.centerBrandDiv.PerformLayout();
            this.centerBrandLogoDiv.ResumeLayout(false);
            this.centerBrandLogoLabelDiv.ResumeLayout(false);
            this.centerBrandLogoLabelDiv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.centerDateTimeDiv.ResumeLayout(false);
            this.centerDateTimeDiv.PerformLayout();
            this.centerMiddleDiv.ResumeLayout(false);
            this.pnlAntrianFinished.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnlOwnPostStat.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.rightDiv.ResumeLayout(false);
            this.rightDiv.PerformLayout();
            this.rightDivPost.ResumeLayout(false);
            this.pnlPost5.ResumeLayout(false);
            this.pnlPost5.PerformLayout();
            this.pnlPost6.ResumeLayout(false);
            this.pnlPost6.PerformLayout();
            this.pnlPost7.ResumeLayout(false);
            this.pnlPost7.PerformLayout();
            this.pnlPost8.ResumeLayout(false);
            this.pnlPost8.PerformLayout();
            this.pnlPost9.ResumeLayout(false);
            this.pnlPost9.PerformLayout();
            this.rightDivNmrCtr.ResumeLayout(false);
            this.rightDivNmrCtr.PerformLayout();
            this.pnlPost4.ResumeLayout(false);
            this.pnlPost4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainDiv;
        private System.Windows.Forms.TableLayoutPanel bottomDiv;
        private System.Windows.Forms.TableLayoutPanel topDiv;
        private System.Windows.Forms.TableLayoutPanel leftDiv;
        private System.Windows.Forms.TableLayoutPanel leftDivPost;
        private System.Windows.Forms.TableLayoutPanel centerDiv;
        public System.Windows.Forms.Panel centerPanelVideo;
        private System.Windows.Forms.TableLayoutPanel pnlPost0;
        private System.Windows.Forms.Label lblPost0Caption;
        private System.Windows.Forms.Label lblPost0No;
        private System.Windows.Forms.TableLayoutPanel pnlPost1;
        private System.Windows.Forms.Label lblPost1Caption;
        private System.Windows.Forms.TableLayoutPanel pnlPost2;
        private System.Windows.Forms.Label lblPost2Caption;
        private System.Windows.Forms.Label lblPost2No;
        private System.Windows.Forms.TableLayoutPanel pnlPost3;
        private System.Windows.Forms.Label lblPost3Caption;
        private System.Windows.Forms.Label lblPost3No;
        private System.Windows.Forms.Timer timerPost0;
        private System.Windows.Forms.Timer timerPost1;
        private System.Windows.Forms.Timer timerPost2;
        private System.Windows.Forms.Timer timerPost3;
        private System.Windows.Forms.TableLayoutPanel centerMiddleDiv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblPostNameCaption;
        private System.Windows.Forms.Label lblPostNumber;
        private System.Windows.Forms.TableLayoutPanel leftDivNmrCtr;
        private System.Windows.Forms.Label lblCounterLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel centerDateTimeDiv;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlAntrianFinished;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlOwnPostStat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblQueueNumberFinished;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblFin4;
        private System.Windows.Forms.Label lblFin9;
        private System.Windows.Forms.Label lblFin8;
        private System.Windows.Forms.Label lblFin7;
        private System.Windows.Forms.Label lblFin3;
        private System.Windows.Forms.Label lblFin6;
        private System.Windows.Forms.Label lblFin2;
        private System.Windows.Forms.Label lblFin0;
        private System.Windows.Forms.Label lblFin5;
        private System.Windows.Forms.Label lblFin1;
        private System.Windows.Forms.Timer timerPost4;
		private System.Windows.Forms.TableLayoutPanel rightDiv;
		private System.Windows.Forms.TableLayoutPanel rightDivPost;
		private System.Windows.Forms.TableLayoutPanel pnlPost5;
		private System.Windows.Forms.Label lblPost5Caption;
		private System.Windows.Forms.Label lblPost5No;
		private System.Windows.Forms.TableLayoutPanel pnlPost6;
		private System.Windows.Forms.Label lblPost6Caption;
		private System.Windows.Forms.Label lblPost6No;
		private System.Windows.Forms.TableLayoutPanel pnlPost7;
		private System.Windows.Forms.Label lblPost7Caption;
		private System.Windows.Forms.Label lblPost7No;
		private System.Windows.Forms.TableLayoutPanel pnlPost8;
		private System.Windows.Forms.Label lblPost8Caption;
		private System.Windows.Forms.Label lblPost8No;
		private System.Windows.Forms.TableLayoutPanel pnlPost9;
		private System.Windows.Forms.Label lblPost9Caption;
		private System.Windows.Forms.Label lblPost9No;
		private System.Windows.Forms.TableLayoutPanel rightDivNmrCtr;
		private System.Windows.Forms.Label lblCounterRight;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TableLayoutPanel centerBrandDiv;
		private System.Windows.Forms.TableLayoutPanel centerBrandLogoDiv;
		private System.Windows.Forms.TableLayoutPanel centerBrandLogoLabelDiv;
		private System.Windows.Forms.Label lblBranding;
		private System.Windows.Forms.PictureBox pictureBoxLogo;
		private System.Windows.Forms.Timer timerPost5;
		private System.Windows.Forms.Timer timerPost6;
		private System.Windows.Forms.Timer timerPost7;
		private System.Windows.Forms.Timer timerPost8;
		private System.Windows.Forms.Timer timerPost9;
		private RuntextLabel runningTextBottom;
		private System.Windows.Forms.TableLayoutPanel centerInfoStrip1Div;
		private System.Windows.Forms.Label lblTopText1;
		private System.Windows.Forms.TableLayoutPanel centerInfoStrip0Div;
		private System.Windows.Forms.Label lblTopText0;
        private System.Windows.Forms.Label lblPost1No;
        private System.Windows.Forms.TableLayoutPanel pnlPost4;
        private System.Windows.Forms.Label lblPost4Caption;
        private System.Windows.Forms.Label lblPost4No;
    }
}