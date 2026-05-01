# 🏢 Aplikasi Manajemen Karyawan (WinForms C#)

Sebuah aplikasi desktop interaktif berbasis **C# Windows Forms (.NET)** untuk mengelola pendataan karyawan perusahaan. Proyek ini dibangun untuk mempraktikkan konsep Pemrograman Berorientasi Objek (OOP), manipulasi UI/UX dengan *Dialog Box*, serta penerapan validasi input tingkat lanjut untuk mencegah *error* dan anomali data.

## ✨ Fitur Utama

- **Sistem *Create & Update* Dinamis:** Menggunakan satu form dialog (`FormEntriKaryawan`) yang cerdas untuk menangani penambahan data baru sekaligus mengedit data yang sudah ada (memanfaatkan *Constructor Overloading*).
- **Auto-Refresh DataGrid (Smart Binding):** Menerapkan `BindingList<Karyawan>` pada `DataGridView` sehingga tabel secara *real-time* dan otomatis bereaksi terhadap penambahan atau perubahan data tanpa perlu *refresh* manual.
- **Validasi Input Ketat (Standar Industri):**
  - **Regex Email:** Memastikan format email yang dimasukkan valid (mutlak harus mengandung huruf, simbol `@`, dan ekstensi domain seperti `.com` atau `.id`).
  - **Anti-Crash Angka:** Menggunakan `decimal.TryParse` untuk input Gaji Pokok sehingga aplikasi tidak *crash* meskipun pengguna memasukkan huruf atau membiarkannya kosong.
  - **Validasi Usia Minimum:** Membatasi `DateTimePicker` secara UI (`MaxDate`) dan secara logika *back-end* untuk memastikan karyawan yang didaftarkan minimal berusia 18 tahun.
  - **Validasi Wajib Isi:** Perlindungan dari *form* kosong atau teks bawaan (*placeholder*).
- **Strict ComboBox:** Menggunakan mode `DropDownList` pada pilihan Departemen dan Jabatan untuk memastikan integritas data dan menghindari salah ketik (*typo*).

## 🗂️ Struktur Data Model (`Karyawan.cs`)

Aplikasi ini mengelola 9 entitas data utama:
1. ID Karyawan (String)
2. Nama Lengkap (String)
3. Email (String)
4. Departemen (String - IT, HR, Finance)
5. Jabatan (String - Staff, Manager, Director)
6. Gaji Pokok (Decimal)
7. Tanggal Lahir (DateTime)
8. Tanggal Bergabung (DateTime)
9. Status Karyawan Tetap (Boolean)

## 💻 Cara Menjalankan Proyek

1. Pastikan Anda telah menginstal **Visual Studio** dengan *workload* **.NET desktop development**.
2. Lakukan *clone* repositori ini:
   ```bash
   git clone https://github.com/mreiswy/AplikasiKaryawan.git
