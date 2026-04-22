Project ini adalah REST API sederhana untuk mengelola data peternakan ayam yang meliputi data ayam, kandang, dan pakan menggunakan .NET Core dan PostgreSQL. Tugas ini dibuat untuk memenuhi kriteria implementasi CRUD dengan database relasional.

---

## Teknologi yang Digunakan

* Bahasa Pemrograman: C#
* Framework: ASP.NET Core Web API
* Database: PostgreSQL
* Library: Dapper, Npgsql

---

## Langkah Instalasi & Menjalankan Project

1. Clone repository ini ke local machine.
2. Pastikan PostgreSQL sudah terinstal dan berjalan.
3. Jalankan file `database.sql` pada pgAdmin atau PostgreSQL untuk membuat tabel dan data awal.
4. Buka file `appsettings.json`, sesuaikan bagian ConnectionStrings dengan username, password, dan nama database (`farm_chicken`).
5. Buka project di Visual Studio 2022.
6. Tekan tombol **Run / F5** untuk menjalankan aplikasi.
7. API akan berjalan di browser (Swagger atau localhost).

---

## Cara Import Database

1. Buka pgAdmin.
2. Buat database baru dengan nama:

   ```
   farm_chicken
   ```
3. Klik kanan database → pilih **Query Tool**.
4. Copy isi file `database.sql` dari project ini.
5. Paste ke Query Tool.
6. Klik tombol Execute.

---

## Daftar Endpoint Utama

| Method | URL              | Keterangan                                     |
| ------ | ---------------- | ---------------------------------------------- |
| GET    | /api/ayam        | Mengambil semua data ayam                      |
| GET    | /api/ayam/{id}   | Mengambil detail ayam berdasarkan ID           |
| POST   | /api/ayam        | Menambah data ayam                             |
| PUT    | /api/ayam/{id}   | Memperbarui data ayam                          |
| DELETE | /api/ayam/{id}   | Menghapus data ayam                            |
| GET    | /api/ayam/detail | Menampilkan data relasi (JOIN kandang & pakan) |

---

## Video Presentasi

Link Video: (isi dengan link video kamu)

---

## Kesimpulan

API ini telah berhasil dibuat dengan fitur CRUD lengkap, menggunakan relasi database (foreign key), serta mampu mengembalikan response dalam format JSON. Selain itu, penggunaan Dapper membantu dalam pengolahan query database yang lebih efisien dan aman.
