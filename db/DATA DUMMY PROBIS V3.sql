-- ========================== DATA TESTING ===============================

-- KAMAR
INSERT INTO KAMAR 
    (ROW_ID_KAMAR, NOMOR_KAMAR, JENIS_KAMAR, HARGA_KAMAR, STATUS_TERSEDIA)
VALUES('', '101', 0, 250000, 0);

INSERT INTO KAMAR 
    (ROW_ID_KAMAR, NOMOR_KAMAR, JENIS_KAMAR, HARGA_KAMAR, STATUS_TERSEDIA)
VALUES('', '201', 0, 250000, 0);

INSERT INTO KAMAR 
    (ROW_ID_KAMAR, NOMOR_KAMAR, JENIS_KAMAR, HARGA_KAMAR, STATUS_TERSEDIA)
VALUES('', '202', 0, 250000, 1);

INSERT INTO KAMAR 
    (ROW_ID_KAMAR, NOMOR_KAMAR, JENIS_KAMAR, HARGA_KAMAR, STATUS_TERSEDIA)
VALUES('', '301', 1, 750000, 1);

INSERT INTO KAMAR 
    (ROW_ID_KAMAR, NOMOR_KAMAR, JENIS_KAMAR, HARGA_KAMAR, STATUS_TERSEDIA)
VALUES('', '302', 1, 750000, 0);

INSERT INTO KAMAR 
    (ROW_ID_KAMAR, NOMOR_KAMAR, JENIS_KAMAR, HARGA_KAMAR, STATUS_TERSEDIA)
VALUES('', '401', 0, 250000, 0);

INSERT INTO KAMAR 
    (ROW_ID_KAMAR, NOMOR_KAMAR, JENIS_KAMAR, HARGA_KAMAR, STATUS_TERSEDIA)
VALUES('', '402', 1, 750000, 1);

INSERT INTO KAMAR 
    (ROW_ID_KAMAR, NOMOR_KAMAR, JENIS_KAMAR, HARGA_KAMAR, STATUS_TERSEDIA)
VALUES('', '501', 0, 250000, 1);

INSERT INTO KAMAR 
    (ROW_ID_KAMAR, NOMOR_KAMAR, JENIS_KAMAR, HARGA_KAMAR, STATUS_TERSEDIA)
VALUES('', '502', 1, 750000, 0);

INSERT INTO KAMAR 
    (ROW_ID_KAMAR, NOMOR_KAMAR, JENIS_KAMAR, HARGA_KAMAR, STATUS_TERSEDIA)
VALUES('', '601', 0, 250000, 1);


INSERT INTO KAMAR 
    (ROW_ID_KAMAR, NOMOR_KAMAR, JENIS_KAMAR, HARGA_KAMAR, STATUS_TERSEDIA)
VALUES('', '602', 1, 750000, 1);

-- FASILITAS
INSERT INTO FASILITAS
    (ROW_ID_FASILITAS, NAMA_FASILITAS, JUMLAH_TERSEDIA, BIAYA_PEMINJAMAN)
VALUES('', 'Handuk', 12, 15000);

INSERT INTO FASILITAS
    (ROW_ID_FASILITAS, NAMA_FASILITAS, JUMLAH_TERSEDIA, BIAYA_PEMINJAMAN)
VALUES('', 'Sabun', 23, 5000);

INSERT INTO FASILITAS
    (ROW_ID_FASILITAS, NAMA_FASILITAS, JUMLAH_TERSEDIA, BIAYA_PEMINJAMAN)
VALUES('', 'Bantal', 35, 10000);

INSERT INTO FASILITAS
    (ROW_ID_FASILITAS, NAMA_FASILITAS, JUMLAH_TERSEDIA, BIAYA_PEMINJAMAN)
VALUES('', 'Guling', 35, 10000);

INSERT INTO FASILITAS
    (ROW_ID_FASILITAS, NAMA_FASILITAS, JUMLAH_TERSEDIA, BIAYA_PEMINJAMAN)
VALUES('', 'Sandal', 20, 30000);


-- TAMU
INSERT INTO TAMU
    (ROW_ID_TAMU, NAMA_TAMU, NOMOR_TELEPON, EMAIL)
VALUES('', 'Winda Angelina Utama', '082233529285', 'WAU959@GMAIL.COM');

INSERT INTO TAMU
    (ROW_ID_TAMU, NAMA_TAMU, NOMOR_TELEPON, EMAIL)
VALUES('', 'Bambang Budiman', '082212345678', 'BAMBANG123@GMAIL.COM');

INSERT INTO TAMU
    (ROW_ID_TAMU, NAMA_TAMU, NOMOR_TELEPON, EMAIL)
VALUES('', 'Hasan Kasusra', '07059834070', 'hasanksei@gmail.com');

INSERT INTO TAMU
    (ROW_ID_TAMU, NAMA_TAMU, NOMOR_TELEPON, EMAIL)
VALUES('', 'Vanya Malika', '09496591326', 'vanyni@gmail.com');

INSERT INTO TAMU
    (ROW_ID_TAMU, NAMA_TAMU, NOMOR_TELEPON, EMAIL)
VALUES('', 'Karen Nasyiah', '04391040047', 'kareah@gmail.com');

INSERT INTO TAMU
    (ROW_ID_TAMU, NAMA_TAMU, NOMOR_TELEPON, EMAIL)
VALUES('', 'Arnold Chandar', '08135678721', 'arnoldh@gmail.com');

INSERT INTO TAMU
    (ROW_ID_TAMU, NAMA_TAMU, NOMOR_TELEPON, EMAIL)
VALUES('', 'Evan Chandar', '08132378715', 'evan@gmail.com');

INSERT INTO TAMU
    (ROW_ID_TAMU, NAMA_TAMU, NOMOR_TELEPON, EMAIL)
VALUES('', 'George Hamdani', '08132621715', 'george@gmail.com');

INSERT INTO TAMU
    (ROW_ID_TAMU, NAMA_TAMU, NOMOR_TELEPON, EMAIL)
VALUES('', 'Nadya Hamdani', '08112324715', 'nadya@gmail.com');




-- H_BOOKING : ada data checkout



INSERT INTO H_BOOKING
    (ROW_ID_BOOKING, ROW_ID_TAMU, JUMLAH_KAMAR_SINGLE, JUMLAH_KAMAR_FAMILY,
    TANGGAL_CHECK_IN, TANGGAL_CHECK_OUT, STATUS_BOOKING, SUBTOTAL,
    BIAYA_TAMBAHAN, KETERANGAN, TOTAL_HARGA, KODE_BOOKING)
VALUES 
    ('', 1, 2, 0, 
    to_date('21/03/2017 13:04:08','dd/MM/yyyy hh24:mi:ss'), 
    to_date('23/03/2017 11:05:08','dd/MM/yyyy hh24:mi:ss'), 1, 500000,
    150000, 'merusak shower', 650000,'');


INSERT INTO H_BOOKING
    (ROW_ID_BOOKING, ROW_ID_TAMU, JUMLAH_KAMAR_SINGLE, JUMLAH_KAMAR_FAMILY,
    TANGGAL_CHECK_IN, TANGGAL_CHECK_OUT, STATUS_BOOKING, SUBTOTAL,
    BIAYA_TAMBAHAN, KETERANGAN, TOTAL_HARGA)
VALUES 
    ('', 2, 2, 1, 
    to_date('21/03/2017 13:04:08','dd/MM/yyyy hh24:mi:ss'), 
    to_date('23/03/2017 11:05:08','dd/MM/yyyy hh24:mi:ss'), 2, 1200000,
    0, '', 1200000);

INSERT INTO H_BOOKING
    (ROW_ID_BOOKING, ROW_ID_TAMU, JUMLAH_KAMAR_SINGLE, JUMLAH_KAMAR_FAMILY,
    TANGGAL_CHECK_IN, TANGGAL_CHECK_OUT, STATUS_BOOKING, SUBTOTAL,
    BIAYA_TAMBAHAN, KETERANGAN, TOTAL_HARGA)
VALUES 
    ('', 2, 0, 2, 
    to_date('21/03/2017 13:04:08','dd/MM/yyyy hh24:mi:ss'), 
    to_date('23/03/2017 11:05:08','dd/MM/yyyy hh24:mi:ss'), 2, 1400000,
    0, '', 1400000);



-- H_BOOKING : tanpa data checkout
INSERT INTO H_BOOKING
    (ROW_ID_BOOKING, ROW_ID_TAMU, JUMLAH_KAMAR_SINGLE, JUMLAH_KAMAR_FAMILY,
    TANGGAL_CHECK_IN, STATUS_BOOKING)
VALUES 
    ('', 3, 2, 0, 
    to_date('21/03/2017 13:04:08','dd/MM/yyyy hh24:mi:ss'), 0);

INSERT INTO H_BOOKING
    (ROW_ID_BOOKING, ROW_ID_TAMU, JUMLAH_KAMAR_SINGLE, JUMLAH_KAMAR_FAMILY,
    TANGGAL_CHECK_IN, STATUS_BOOKING)
VALUES 
    ('', 4, 2, 0, 
    to_date('21/03/2017 13:04:08','dd/MM/yyyy hh24:mi:ss'), 0);
-------------------------------


-- H_BOOKING : ada data checkout
INSERT INTO H_BOOKING
    (ROW_ID_BOOKING, ROW_ID_TAMU, JUMLAH_KAMAR_SINGLE, JUMLAH_KAMAR_FAMILY,
    TANGGAL_CHECK_IN, TANGGAL_CHECK_OUT, STATUS_BOOKING, SUBTOTAL,
    BIAYA_TAMBAHAN, KETERANGAN, TOTAL_HARGA)
VALUES
    ('', 5, 0, 0, 
    to_date('22/03/2017 13:04:08','dd/MM/yyyy hh24:mi:ss'), 
    to_date('24/03/2017 11:05:08','dd/MM/yyyy hh24:mi:ss'), 1, 500000,
    150000, 'merusak shower', 650000);

INSERT INTO H_BOOKING
    (ROW_ID_BOOKING, ROW_ID_TAMU, JUMLAH_KAMAR_SINGLE, JUMLAH_KAMAR_FAMILY,
    TANGGAL_CHECK_IN, TANGGAL_CHECK_OUT, STATUS_BOOKING, SUBTOTAL,
    BIAYA_TAMBAHAN, KETERANGAN, TOTAL_HARGA)
VALUES 
    ('', 6, 2, 0, 
    to_date('22/03/2017 13:04:08','dd/MM/yyyy hh24:mi:ss'), 
    to_date('24/03/2017 11:05:08','dd/MM/yyyy hh24:mi:ss'), 2, 2000000,
    0, '', 2000000);

-- H_BOOKING : tanpa data checkout
INSERT INTO H_BOOKING
    (ROW_ID_BOOKING, ROW_ID_TAMU, JUMLAH_KAMAR_SINGLE, JUMLAH_KAMAR_FAMILY,
    TANGGAL_CHECK_IN, STATUS_BOOKING)
VALUES 
    ('', 7, 2, 0, 
    to_date('22/03/2017 13:04:08','dd/MM/yyyy hh24:mi:ss'), 0);
---------------------------------
INSERT INTO H_BOOKING
    (ROW_ID_BOOKING, ROW_ID_TAMU, JUMLAH_KAMAR_SINGLE, JUMLAH_KAMAR_FAMILY,
    TANGGAL_CHECK_IN, STATUS_BOOKING)
VALUES 
    ('', 8, 2, 0, 
    to_date('22/03/2017 13:04:08','dd/MM/yyyy hh24:mi:ss'), 0);


-- D_BOOKING_KAMAR
INSERT INTO D_BOOKING_KAMAR
    (ROW_ID_BOOKING, ROW_ID_KAMAR)
VALUES(1, 1);

INSERT INTO D_BOOKING_KAMAR
    (ROW_ID_BOOKING, ROW_ID_KAMAR)
VALUES(1, 2);

INSERT INTO D_BOOKING_KAMAR
    (ROW_ID_BOOKING, ROW_ID_KAMAR)
VALUES(2, 7);

INSERT INTO D_BOOKING_KAMAR
    (ROW_ID_BOOKING, ROW_ID_KAMAR)
VALUES(2, 8);

INSERT INTO D_BOOKING_KAMAR
    (ROW_ID_BOOKING, ROW_ID_KAMAR)
VALUES(2, 10);

INSERT INTO D_BOOKING_KAMAR
    (ROW_ID_BOOKING, ROW_ID_KAMAR)
VALUES(3, 9);

INSERT INTO D_BOOKING_KAMAR
    (ROW_ID_BOOKING, ROW_ID_KAMAR)
VALUES(3, 11);


INSERT INTO D_BOOKING_KAMAR
    (ROW_ID_BOOKING, ROW_ID_KAMAR)
VALUES(4, 6);

INSERT INTO D_BOOKING_KAMAR
    (ROW_ID_BOOKING, ROW_ID_KAMAR)
VALUES(5, 7);


-- D_BOOKING_FASILITAS
INSERT INTO D_BOOKING_FASILITAS
    (ROW_ID_BOOKING, ROW_ID_FASILITAS, ROW_ID_KAMAR,
    JUMLAH_PEMINJAMAN, BIAYA_PEMINJAMAN, SUBTOTAL)
VALUES(1, 1, 1, 2, 15000, 15000);

INSERT INTO D_BOOKING_FASILITAS
    (ROW_ID_BOOKING, ROW_ID_FASILITAS, ROW_ID_KAMAR,
    JUMLAH_PEMINJAMAN, BIAYA_PEMINJAMAN, SUBTOTAL)
VALUES(1, 3, 1, 2, 10000, 20000);

INSERT INTO D_BOOKING_FASILITAS
    (ROW_ID_BOOKING, ROW_ID_FASILITAS, ROW_ID_KAMAR,
    JUMLAH_PEMINJAMAN, BIAYA_PEMINJAMAN, SUBTOTAL)
VALUES(1, 4, 1, 2, 10000, 20000);

INSERT INTO D_BOOKING_FASILITAS
    (ROW_ID_BOOKING, ROW_ID_FASILITAS, ROW_ID_KAMAR,
    JUMLAH_PEMINJAMAN, BIAYA_PEMINJAMAN, SUBTOTAL)
VALUES(1, 5, 1, 1, 30000, 30000);

INSERT INTO D_BOOKING_FASILITAS
    (ROW_ID_BOOKING, ROW_ID_FASILITAS, ROW_ID_KAMAR,
    JUMLAH_PEMINJAMAN, BIAYA_PEMINJAMAN, SUBTOTAL)
VALUES(1, 2, 1, 1, 5000, 5000);


INSERT INTO D_BOOKING_FASILITAS
    (ROW_ID_BOOKING, ROW_ID_FASILITAS, ROW_ID_KAMAR,
    JUMLAH_PEMINJAMAN, BIAYA_PEMINJAMAN, SUBTOTAL)
VALUES(4, 2, 6, 2, 5000, 10000);

INSERT INTO D_BOOKING_FASILITAS
    (ROW_ID_BOOKING, ROW_ID_FASILITAS, ROW_ID_KAMAR,
    JUMLAH_PEMINJAMAN, BIAYA_PEMINJAMAN, SUBTOTAL)
VALUES(2, 2, 7, 7, 5000, 10000);




commit;
