# Smart Library

[![Build Status](https://dev.azure.com/Literasi/Smart%20Library/_apis/build/status/MufidJamaluddin.SmartLibrary?branchName=master)](https://dev.azure.com/Literasi/Smart%20Library/_build/latest?definitionId=1&branchName=master) 
[![Coverage](https://img.shields.io/azure-devops/coverage/Literasi/Smart%20Library/1?style=plastic)](https://dev.azure.com/Literasi/Smart%20Library/_build/latest?definitionId=1&branchName=master)

Aplikasi SmartLibrary merupakan aplikasi yang membantu pengunjung perpustakaan dalam pencarian koleksi buku dan peminjaman buku dengan biaya yang ditentukan oleh formula yang telah ditentukan serta membantu pustakawan dalam mengelola koleksi buku.

Aplikasi SmartLibrary dibangun menggunakan teknologi ASP.NET Core, Entity Framework Core, dan ReactJS. ASP.NET Core dipilih karena aplikasi dapat berjalan multiplatform. Entity Framework Core dipilih dengan pendekatan Code-First Database sehingga bersifat agnostik terhadap database engine yang digunakan. ReactJS dipilih untuk meningkatkan user experience dengan SPA dan learning rate untuk developer yang tinggi. Anda dapat menjalankan aplikasi ini pada OS Windows, OS Linux, maupun MacOS serta anda dapat bebas menggunakan SQL database engine yang mendukung entity framework (MySQL, PostgreSQL, SQLServer, Oracle, dll).

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

Anda dapat kontribusi terhadap aplikasi ini dengan melakukan Fork repositori ini dan melakukan pengembangan aplikasi.

Anda dapat membantu mengerjakan fitur yang belum selesai, improve UI/UX, maupun menambahkan fitur baru yang dapat digunakan secara umum (tidak terikat dengan proses bisnis eksklusif salahsatu perpustakaan).

Jangan lupa untuk menambahkan skenario testing (Unit Testing, Integration Testing, dsb) sebelum melakukan pull request ke repositori utama ini.