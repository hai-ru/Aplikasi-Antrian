# Software Antrian
Software Antrian.
Software sistem antrian andal untuk mengelola antrian pelanggan, mengurangi waktu tunggu, 
meningkatkan kualitas layanan dan memaksimalkan kepuasan pelanggan.

## Kebutuhan minimal
* Windows 7 Service Pack 1 
* Microsoft .NET Framework 4.0
Dengan konfigurasi default, tidak perlu menggunakan Microsoft SQL Server, 
karena Aplikasi Antrian menggunakan database SQLite.

#### Struktur folder output
```
_OUTPUT
   \---Database
   \---AntrianAdmin
   \---AntrianCaller
   \---AntrianDisplay
       \---img
       \---movie
       \---wav
   \---AntrianService
   \---AntrianTicket
       \---img
   \---LICENSE
   \---AntrianConfig.exe
   \---README.md
```

## Instalasi
Aplikasi yang telah jadi copy ke folder lain: 
misalkan C:\Aplikasi Antrian

#### Menampilkan file video
Bila ingin menampilkan video pada AntrianDisplay:
Copykan file video (**format wmv**), atau format lainnya(bila codec sudah terinstall pada windows)
pada folder AntrianDisplay\movie\ 

#### Menjalankan AntrianService.exe sebagai  Windows service (opsional)
* Jalankan commmand prompt sebagai Administrator
* Masuk ke dalam folder AntrianService
* Jalankan command berikut:
```
c:\Windows\Microsoft.NET\Framework\v4.0.30319\installutil AntrianService.exe
```