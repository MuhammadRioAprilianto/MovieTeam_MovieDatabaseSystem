CREATE DATABASE MovieDB;
GO

USE MovieDB;
GO

-- =========================================
-- PEMBUATAN TABEL MASTER
-- =========================================

-- Tabel Roles (Tingkatan Hak Akses)
CREATE TABLE Roles (
    role_id INT PRIMARY KEY, 
    role_name VARCHAR(50) NOT NULL
);

-- Tabel Genres (Kategori Film)
CREATE TABLE Genres (
    genre_id INT PRIMARY KEY IDENTITY(1,1), 
    nama_genre VARCHAR(50) NOT NULL
);

-- =========================================
-- PEMBUATAN TABEL TRANSAKSIONAL UTAMA
-- =========================================

-- Tabel Accounts (Data Pengguna & Admin)
CREATE TABLE Accounts (
    id INT PRIMARY KEY IDENTITY(1,1),
    role_id INT NOT NULL,
    username VARCHAR(50) UNIQUE NOT NULL, 
    password VARCHAR(50) NOT NULL,
    nama VARCHAR(100) NOT NULL,
    FOREIGN KEY (role_id) REFERENCES Roles(role_id)
);

-- Tabel Movies (Katalog Film)
-- [UPDATED]: Penambahan is_deleted untuk Soft Delete
CREATE TABLE Movies (
    movie_id INT PRIMARY KEY IDENTITY(1,1),
    genre_id INT NOT NULL,
    judul VARCHAR(200) NOT NULL,
    deskripsi TEXT,
    durasi INT NOT NULL, 
    is_deleted BIT DEFAULT 0, -- 0 = Aktif (Bisa dilihat), 1 = Terhapus (Disembunyikan)
    FOREIGN KEY (genre_id) REFERENCES Genres(genre_id)
);

-- =========================================
-- PEMBUATAN TABEL ASOSIATIF (RELASI)
-- =========================================

-- Tabel Watchlists (Daftar Simpanan Film User)
CREATE TABLE Watchlists (
    watchlist_id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT NOT NULL,
    movie_id INT NOT NULL,
    tanggal_ditambahkan DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (user_id) REFERENCES Accounts(id),
    FOREIGN KEY (movie_id) REFERENCES Movies(movie_id)
);

-- Tabel Reviews (Histori Ulasan & Rating)
CREATE TABLE Reviews (
    review_id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT NOT NULL,
    movie_id INT NOT NULL,
    skor_rating INT CHECK (skor_rating >= 1 AND skor_rating <= 5), 
    komentar TEXT,
    tanggal_diposting DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (user_id) REFERENCES Accounts(id),
    FOREIGN KEY (movie_id) REFERENCES Movies(movie_id)
);

-- Tabel History (Riwayat Tontonan User)
CREATE TABLE History (
    history_id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT NOT NULL,
    movie_id INT NOT NULL,
    tanggal_nonton DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (user_id) REFERENCES Accounts(id),
    FOREIGN KEY (movie_id) REFERENCES Movies(movie_id)
);

-- =========================================
-- INSERT DATA AWAL (SEEDING)
-- =========================================

-- Memasukkan role dasar agar sistem bisa login
INSERT INTO Roles (role_id, role_name) VALUES (1, 'Admin'), (2, 'User');

-- Membuat 1 akun Admin bawaan
INSERT INTO Accounts (role_id, username, password, nama) 
VALUES (1, 'admin', 'admin123', 'Budi');

-- Memasukkan beberapa genre awal untuk testing
INSERT INTO Genres (nama_genre) VALUES ('Action'), ('Horror'), ('Comedy'), ('Drama'), ('Sci-Fi');

