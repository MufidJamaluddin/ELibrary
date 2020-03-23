# Smart Library

[![Build Status](https://dev.azure.com/Literasi/Smart%20Library/_apis/build/status/MufidJamaluddin.SmartLibrary?branchName=master)](https://dev.azure.com/Literasi/Smart%20Library/_build/latest?definitionId=1&branchName=master) 
[![Coverage](https://img.shields.io/azure-devops/coverage/Literasi/Smart%20Library/1?style=plastic)](https://dev.azure.com/Literasi/Smart%20Library/_build/latest?definitionId=1&branchName=master)

Aplikasi SmartLibrary merupakan aplikasi yang membantu pengunjung perpustakaan dalam pencarian koleksi buku dan peminjaman buku dengan biaya yang ditentukan oleh formula yang telah ditentukan serta membantu pustakawan dalam mengelola koleksi buku.

Aplikasi SmartLibrary dibangun menggunakan teknologi ASP.NET Core, Entity Framework Core, dan ReactJS. ASP.NET Core dipilih karena aplikasi dapat berjalan multiplatform. Entity Framework Core dipilih dengan pendekatan Code-First Database sehingga bersifat agnostik terhadap database engine yang digunakan. ReactJS dipilih untuk meningkatkan user experience dengan SPA dan learning rate untuk developer yang tinggi.

## Dependency dan Cara Instalasi

### Dependency Aplikasi (Saat ini)

1. ASP.NET Core versi 3.0
2. Entity Framework Core versi 3.1.2
3. Pomelo.EntityFrameworkCore.Mysql versi 3.1.1
4. Microsoft.EntityFrameworkCore.SqlServer versi 3.1.2 
5. NodeJS versi 12.16.1 (DEV)
6. NPM versi 6.13.4 (DEV)

### Requirement

1. IDE Visual Studio 2019 dengan ASP.NET Core 3.0
2. Database Engine telah terinstal:
   1. MySQL
       - MySQL versi 8.0
       - MySQL versi 5.7
       - MariaDB versi 10.4
       - MariaDB versi 10.3
   2. SQLServer
       - Microsoft SQL Server diatas versi 2012 hingga 2019 (yang mendukung Entity Framework Core 3.1.2)

### Setting Konfigurasi

1. Buka src/SmartLibrary.Web/appsettings.json
2. Ubah field DatabaseDriver dengan "MySQL" atau "SQLServer"
3. Ubah field ConnectionStrings -> DefaultConnection berdasarkan konfigurasi database engine anda.
   Anda boleh ubah selain konfigurasi TreatTinyAsBoolean.
   "Server=<Server DB Engine anda>;Database=<Database yang akan anda gunakan untuk aplikasi ini>;User=<User DB Engine anda>;Password=<Password DB Engine anda>;TreatTinyAsBoolean=true;"

### Instalasi di Windows

1. Buka SmartLibrary.sln nya di Visual Studio
2. Jalankan DB Engine anda dan pastikan konfigurasi appsettings.json telah sesuai.
3. Jalankan aplikasi anda melalui Visual Studio

### Instalasi di MacOS (belum diuji)

1. Buka SmartLibrary.sln nya di Visual Studio
2. Jalankan DB Engine anda dan pastikan konfigurasi appsettings.json telah sesuai.
3. Jalankan aplikasi anda melalui Visual Studio

### Deployment

Proses development belum dapat dilakukan di Linux, namun kita dapat porting aplikasi supaya jalan di Linux dengan menggunakan command ```dotnet build --runtime ubuntu.16.04-x64```

Aplikasi dapat berjalan di Windows, Mac, dan Linux sesuai dengan ![versi OS yang didukung oleh ASP.NET Core 3.0](https://github.com/dotnet/core/blob/master/release-notes/3.0/3.0-supported-os.md)


## Fitur Aplikasi (sedang dibangun)

### Pencarian Buku

Pengunjung perpustakaan dapat mencari informasi posisi buku / rak buku di perpustakaan melalui aplikasi dengan kata kunci ISBN, judul buku, pengarang, penerbit, dan tahun terbit.

### Peminjaman Buku

Dalam peminjaman buku, pengunjung perpustakaan yang diizinkan untuk meminjam buku adalah pengunjung yang telah terdaftar sebagai anggota perpustakaan (Patron). 

![Domain Model Peminjaman Buku](/docs/domain/DomainModel_BookLending.jpg)

Patron membuat order peminjaman buku (Lend Order) dengan biaya yang dihitung (oleh LendCalculator) berdasarkan formula yang telah ditetapkan (Lend Formula) dan diizinkan oleh pustakawan (Librarian).

### Pengelolaan Peminjaman Buku

- Jumlah pinjaman
- Laporan Keuntungan
- Laporan Kerugian

### Pengelolaan Buku

- Buku yang dipinjam
- Buku yang hilang
- Buku yang rusak
- Laporan bulanan

### Pengadaan Buku

Pengadaan buku dari pihak ketiga untuk memenuhi koleksi buku perpustakaan

- Purchase Request
- Purchase Order
- Books Receipt
- Invoice 

# Kontribusi

## Kontribusi Pengembangan Aplikasi

Anda dapat kontribusi terhadap aplikasi ini dengan melakukan Fork repositori ini dan melakukan pengembangan aplikasi.

Anda dapat membantu mengerjakan fitur yang belum selesai, improve UI/UX, maupun menambahkan fitur baru yang dapat digunakan secara umum (tidak terikat dengan proses bisnis eksklusif salahsatu perpustakaan).

Anda tidak boleh membuat query yang depends ke database engine tertentu. Semua akses database engine harus melalui LINQ Entity Framework dengan cara Code-First.

Jangan lupa untuk menambahkan skenario testing (Unit Testing, Integration Testing, dsb) sebelum melakukan pull request ke repositori utama ini.

## Menambah Support Database Engine

Anda dapat menambahkan database engine yang belum ada didukung oleh aplikasi ini dengan cara:

1. Install library ekstensi Entity Framework Core yang akan berperan sebagai penghubung antara DB Engine anda dengan Entity Framework Core versi 3.1.2
2. Buka project SmartLibrary.TechnicalServices
3. Buka folder database
4. Buat kelas yang inherit ke BaseDatabaseService dan tambahkan ke kelas DatabaseServiceFactory
5. Untuk menjalankannya, ubah SmartLibrary.Web file appsettings.json
6. Jalankan program. Cek DB Engine anda, pastikan kelas-kelas EF Core berubah menjadi tabel-tabel di DB Engine anda :)
6. Ubah Readme.md dan tambahkan DB Engine, pull request ke git ini
