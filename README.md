# FormUtamaMovieApp
Bukti menjalankan aplikasi

- Aplikasi berhasil terkoneksi dengan database, ditandai dengan muncul data pada katalog
![Screenshot Aplikasi](FormUtamaMovieApp/Gambar/TestKoneksi.png)
- Form Insert
![Screenshot Aplikasi](FormUtamaMovieApp/Gambar/FromInsert.png)
- Form Tampil Data
![Screenshot Aplikasi](FormUtamaMovieApp/Gambar/FormTampil.png)
- Bukti insert, update, delete, dan search
[Screenshot Aplikasi](FormUtamaMovieApp/Gambar/TestInsert.png)
[Screenshot Aplikasi](FormUtamaMovieApp/Gambar/TestUpdate.png)
[Screenshot Aplikasi](FormUtamaMovieApp/Gambar/TestDelete.png)

##### SKENARIO SQL INJECTION #####
Dalam kasus ini kelompok kami mencoba untuk menjalankan sebuah skenario hakcing dengan menggunakan SQL Injection pada sistem aplikasi kami sendiri dengan memanfaatkan celah pada bagian form login.
Login yang seharusnya dilakukan dengan menggunakan menginputkan nilai username dan password yang tepat dapat dibobol dengan menggunakan sebuah query yang dapat digunakan untuk login ke dalam aplikasi tanpa memerlukan username dan password yang benar.

Skenario ini dilakukan dengan tujuan untuk:
1. Mengetahui apakah fitur login rentan terhadap SQL Injection
2. Membuktikan bahwa autentikasi dapat dibypass
3. Memahami dampak keamanan dari SQL Injection
4. Memberikan solusi pencegahan terhadap kerentanan serangan SQL Injection.

Skenario dijalankan untuk dapat masuk ke dalam aplikasi dengan akses login admin tanpa memerlukan username dan password yang valid. Berikut adalah langkah-langkah yang dilakukan dalam menjalankan SQL Injection pada aplikasi Movie Database System:
1. Masuk ke dalam aplikasi
2. Buka form login
3. Masukkan input pada bagin username dengan nilai bebas
4. Masukkan query ' OR 1=1; -- pada entry password
5. Klik tombol login
6. Serangan berhasil membobol masuk ke dalam aplikasi dengan akses login admin.

setelah berhasil masuk ke dalam aplikasi, penyerang dapat melakukan semua akses yang ada dalam aplikasi.