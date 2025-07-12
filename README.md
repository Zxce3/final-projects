# Zakatin - Aplikasi Manajemen Zakat, Fidyah, dan Infaq

## Deskripsi
**Zakatin** adalah aplikasi desktop berbasis Windows Forms yang dibangun dengan .NET 8.0 untuk mengelola pembayaran amal Islam, meliputi:
- **Zakat** (amal wajib)
- **Fidyah** (pengganti puasa yang terlewat)
- **Infaq** (amal sukarela)

## Fitur Utama

### 🔐 Sistem Autentikasi
- Form login dengan kredensial default (admin/admin123)
- Loading screen dengan animasi saat aplikasi dimulai

### 💰 Manajemen Zakat
- Input data muzakki (pembayar zakat)
- Pencatatan jenis zakat (Fitrah/Mal)
- Kalkulasi jumlah beras dan uang
- Perhitungan total zakat otomatis

### 🍚 Manajemen Fidyah
- Pencatatan pembayar fidyah
- Input jumlah beras dan uang
- Kalkulasi total pembayaran fidyah

### 🤲 Manajemen Infaq
- Pencatatan pembayar infaq
- Input total jumlah infaq
- Sistem manajemen data yang sederhana

### 📊 Fitur Data
- **CRUD Operations**: Tambah, Edit, Hapus data untuk semua modul
- **Data Grid View**: Tampilan tabel untuk semua record
- **Validasi Form**: Validasi input untuk field yang wajib diisi
- **Clear Form**: Reset semua field input
- **Print Preview**: Pratinjau laporan sebelum dicetak
- **Printing**: Cetak laporan ringkasan dan individual

## Struktur Aplikasi

### 📁 File Utama
```
Zakatin/
├── Program.cs              # Entry point aplikasi
├── MainForm.cs            # Dashboard utama dengan navigasi
├── LoginForm.cs           # Form autentikasi
├── LoadingForm.cs         # Form loading awal
├── ZakatForm.cs           # Modul manajemen zakat
├── FidyahForm.cs          # Modul manajemen fidyah
├── InfaqForm.cs           # Modul manajemen infaq
└── Zakatin.csproj         # File konfigurasi proyek
```

### 🗄️ Database
- **Database**: SQL Server LocalDB
- **File Database**: `Zakatindb.mdf`
- **Tabel Utama**:
  - `ZakatTbl` - Data pembayaran zakat
  - `FidyahTbl` - Data pembayaran fidyah
  - `InfaqTbl` - Data pembayaran infaq

### 🎨 Assets
Folder `zakatin-assets/` berisi:
- Icon dan gambar untuk UI
- Asset grafis untuk form
- Elemen branding aplikasi

## Alur Kerja Aplikasi

### 1. **Startup Application**
```
LoadingForm → LoginForm → MainForm
```

### 2. **Navigasi Utama**
- MainForm menyediakan akses ke tiga modul utama
- Setiap modul dapat kembali ke MainForm
- Fungsi exit tersedia dari berbagai form

### 3. **Operasi Data**
1. **Tambah Data**: Input data baru melalui form
2. **Lihat Data**: Tampilkan semua record dalam grid
3. **Edit Data**: Modifikasi record yang sudah ada
4. **Hapus Data**: Menghapus record dari database
5. **Cetak Laporan**: Generate dan print laporan

## Field Data

### 📋 Form Zakat
- **Nama Muzakki**: Nama pembayar zakat
- **Tanggal Pembayaran**: Tanggal transaksi
- **Jenis Zakat**: Zakat Fitrah atau Zakat Mal
- **Jumlah Beras**: Jumlah beras (kg)
- **Jumlah Uang**: Jumlah uang (Rupiah)
- **Total Zakat**: Total keseluruhan

### 📋 Form Fidyah
- **Nama Pembayar**: Nama pembayar fidyah
- **Tanggal Pembayaran**: Tanggal transaksi
- **Jumlah Beras**: Jumlah beras (kg)
- **Jumlah Uang**: Jumlah uang (Rupiah)
- **Total Pembayaran**: Total keseluruhan

### 📋 Form Infaq
- **Nama Pembayar**: Nama pembayar infaq
- **Tanggal Pembayaran**: Tanggal transaksi
- **Total**: Total jumlah infaq

## Teknologi yang Digunakan

- **Framework**: .NET 8.0 Windows Forms
- **Database**: SQL Server LocalDB dengan SQLite packages
- **Architecture**: Desktop application berbasis form
- **Printing**: Windows printing capabilities bawaan
- **UI**: Windows Forms dengan custom assets

## Cara Menjalankan Aplikasi

### Prasyarat
- Windows OS
- .NET 8.0 Runtime
- SQL Server LocalDB

### Langkah Instalasi
1. Clone repository ini
2. Buka `Zakatin.sln` di Visual Studio
3. Build solution (Ctrl+Shift+B)
4. Jalankan aplikasi (F5)

### Login Default
- **Username**: admin
- **Password**: admin123

## Penggunaan

1. **Login**: Masukkan kredensial untuk mengakses aplikasi
2. **Pilih Modul**: Dari MainForm, pilih Zakat, Fidyah, atau Infaq
3. **Input Data**: Isi form sesuai dengan jenis pembayaran
4. **Simpan**: Klik tombol simpan untuk menyimpan data
5. **Kelola Data**: Gunakan fungsi edit/hapus untuk mengelola record
6. **Cetak Laporan**: Gunakan fitur print untuk mencetak laporan

## Kontribusi

Aplikasi ini dikembangkan sebagai bagian dari final project teknik pemrogramman. Kontribusi dan saran perbaikan sangat diterima.

## Lisensi

Lihat file `LICENSE` untuk informasi lisensi.