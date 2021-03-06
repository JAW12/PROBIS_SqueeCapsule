-- ============================ OPSIONAL ========================================

-- LOGIN USER
disc
conn proyekbisnis1/proyekbisnis1;

-- RESET TABLE
SELECT 'DROP TABLE ' || TNAME || ' CASCADE CONSTRAINT PURGE;' FROM TAB;

DROP TABLE D_BOOKING_FASILITAS CASCADE CONSTRAINT PURGE;
DROP TABLE D_BOOKING_KAMAR CASCADE CONSTRAINT PURGE;
DROP TABLE FASILITAS CASCADE CONSTRAINT PURGE;
DROP TABLE H_BOOKING CASCADE CONSTRAINT PURGE;
DROP TABLE KAMAR CASCADE CONSTRAINT PURGE;
DROP TABLE TAMU CASCADE CONSTRAINT PURGE;


-- ============================ !! WAJIB !! ========================================

-- ALTER SESSION BIAR TIPE DATA DATE BISA MUNCULIN TIME JUGA
alter session set nls_date_format = 'dd/MM/yyyy hh24:mi:ss';

-- DML TABLE

/* == KAMAR ==

JENIS_KAMAR
- 0 = single
- 1 = family

STATUS_TERSEDIA
- 0 = tidak tersedia
- 1 = tersedia
*/
CREATE TABLE KAMAR(
    ROW_ID_KAMAR INT PRIMARY KEY,
    NOMOR_KAMAR VARCHAR2(10) UNIQUE NOT NULL,
    JENIS_KAMAR INT CONSTRAINT CH_JENIS_KAMAR CHECK(JENIS_KAMAR = 0 OR JENIS_KAMAR = 1),
    HARGA_KAMAR INT NOT NULL,
    STATUS_TERSEDIA INT CONSTRAINT CH_KAMAR_STATUS_TERSEDIA CHECK(STATUS_TERSEDIA = 0 OR STATUS_TERSEDIA = 1)
);

CREATE TABLE FASILITAS(
    ROW_ID_FASILITAS INT PRIMARY KEY,
    NAMA_FASILITAS VARCHAR2(50) NOT NULL,
    JUMLAH_TERSEDIA INT NOT NULL,
    BIAYA_PEMINJAMAN INT NOT NULL
);

CREATE TABLE TAMU(
    ROW_ID_TAMU INT PRIMARY KEY,
    NAMA_TAMU VARCHAR2(50) NOT NULL,
    NOMOR_TELEPON VARCHAR2(12) NOT NULL,
    EMAIL VARCHAR2(320) NOT NULL
);


/* == H_BOOKING ==
INSERT_AT = akan terisi secara otomatis dengan CURRENT_TIMESTAMP
*/
CREATE TABLE H_BOOKING(
    ROW_ID_BOOKING INT PRIMARY KEY,
    ROW_ID_TAMU INT CONSTRAINT FK_H_BOOKING_TAMU REFERENCES TAMU(ROW_ID_TAMU),
    JUMLAH_KAMAR_SINGLE INT,
    JUMLAH_KAMAR_FAMILY INT,
    INSERT_AT TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    TANGGAL_CHECK_IN DATE,
    TANGGAL_CHECK_OUT DATE,
    STATUS_BOOKING INT NOT NULL,
    SUBTOTAL INT,
    BIAYA_TAMBAHAN INT,
    KETERANGAN VARCHAR2(300),
    TOTAL_HARGA INT
);

CREATE TABLE D_BOOKING_FASILITAS(
    ROW_ID_BOOKING INT REFERENCES H_BOOKING(ROW_ID_BOOKING),
    ROW_ID_FASILITAS INT REFERENCES FASILITAS(ROW_ID_FASILITAS),
    ROW_ID_KAMAR INT REFERENCES KAMAR(ROW_ID_KAMAR),
    JUMLAH_PEMINJAMAN INT,
    BIAYA_PEMINJAMAN INT,
    SUBTOTAL INT,
    CONSTRAINT PK_D_BOOKING_FASILITAS PRIMARY KEY(ROW_ID_BOOKING, ROW_ID_FASILITAS, ROW_ID_KAMAR)
);

CREATE TABLE D_BOOKING_KAMAR(
    ROW_ID_BOOKING INT REFERENCES H_BOOKING(ROW_ID_BOOKING),
    ROW_ID_KAMAR INT REFERENCES KAMAR(ROW_ID_KAMAR),
    CONSTRAINT PK_D_BOOKING_KAMAR PRIMARY KEY(ROW_ID_BOOKING, ROW_ID_KAMAR)
);



-- AUTO INCREMENT ROW ID : harus manual. oracle ga secanggih mysql. so sed :(

-- reset
DROP SEQUENCE KAMAR_SEQ;
DROP SEQUENCE FASILITAS_SEQ;
DROP SEQUENCE TAMU_SEQ;
DROP SEQUENCE H_BOOKING_SEQ;

-- create
CREATE SEQUENCE KAMAR_SEQ START WITH 1;
CREATE SEQUENCE FASILITAS_SEQ START WITH 1;
CREATE SEQUENCE TAMU_SEQ START WITH 1;
CREATE SEQUENCE H_BOOKING_SEQ START WITH 1;

-- trigger auto increment
CREATE OR REPLACE TRIGGER KAMAR_AUTOINCREMENT
BEFORE INSERT ON KAMAR
FOR EACH ROW
BEGIN
    SELECT KAMAR_SEQ.NEXTVAL
    INTO   :NEW.ROW_ID_KAMAR
    FROM   DUAL;
END;
/

CREATE OR REPLACE TRIGGER FASILITAS_AUTOINCREMENT
BEFORE INSERT ON FASILITAS
FOR EACH ROW
BEGIN
    SELECT FASILITAS_SEQ.NEXTVAL
    INTO   :NEW.ROW_ID_FASILITAS
    FROM   DUAL;
END;
/

CREATE OR REPLACE TRIGGER TAMU_AUTOINCREMENT
BEFORE INSERT ON TAMU
FOR EACH ROW
BEGIN
    SELECT TAMU_SEQ.NEXTVAL
    INTO   :NEW.ROW_ID_TAMU
    FROM   DUAL;
END;
/

CREATE OR REPLACE TRIGGER H_BOOKING_AUTOINCREMENT
BEFORE INSERT ON H_BOOKING
FOR EACH ROW
BEGIN
    SELECT H_BOOKING_SEQ.NEXTVAL
    INTO   :NEW.ROW_ID_BOOKING
    FROM   DUAL;
END;
/

-- views
CREATE OR REPLACE VIEW V_DETAIL_BOOKING_KAMAR AS
    SELECT 
        DBK.ROW_ID_BOOKING,
        K.ROW_ID_KAMAR,
        K.NOMOR_KAMAR AS NOMOR_KAMAR,
        CASE K.JENIS_KAMAR
            WHEN 0 THEN 'Single'
            WHEN 1 THEN 'Family'
        END AS JENIS_KAMAR,
        K.HARGA_KAMAR,
        CASE 
            WHEN SUM(DBF.SUBTOTAL) IS NULL THEN 0
            ELSE SUM(DBF.SUBTOTAL)
        END AS SUBTOTAL
    FROM
        D_BOOKING_KAMAR DBK
    LEFT JOIN KAMAR K 
    ON 
        K.ROW_ID_KAMAR = DBK.ROW_ID_KAMAR
    LEFT JOIN 
        D_BOOKING_FASILITAS DBF
    ON        
        DBF.ROW_ID_BOOKING = DBK.ROW_ID_BOOKING
    GROUP BY
        DBK.ROW_ID_BOOKING,
        K.ROW_ID_KAMAR,
        K.NOMOR_KAMAR,
        K.JENIS_KAMAR,
        K.HARGA_KAMAR
    ORDER BY ROW_ID_BOOKING ASC, K.NOMOR_KAMAR ASC;


CREATE OR REPLACE VIEW V_DETAIL_FASILITAS_KAMAR AS
    SELECT 
        DBF.ROW_ID_BOOKING,
        HB.STATUS_BOOKING,
        T.NAMA_TAMU,
        K.NOMOR_KAMAR,
        F.NAMA_FASILITAS,
        F.ROW_ID_FASILITAS,
        DBF.JUMLAH_PEMINJAMAN,
        DBF.BIAYA_PEMINJAMAN,
        DBF.SUBTOTAL
    FROM 
        FASILITAS F, KAMAR K, D_BOOKING_FASILITAS DBF, TAMU T, H_BOOKING HB
    WHERE 
        F.ROW_ID_FASILITAS = DBF.ROW_ID_FASILITAS AND 
        DBF.ROW_ID_KAMAR = K.ROW_ID_KAMAR AND
        HB.ROW_ID_BOOKING = DBF.ROW_ID_BOOKING AND
        HB.ROW_ID_TAMU = T.ROW_ID_TAMU
    ORDER BY F.NAMA_FASILITAS ASC;


CREATE OR REPLACE VIEW V_DATA_PENGINAPAN AS
    SELECT V.*, T.NAMA_TAMU, T.ROW_ID_TAMU, HB.STATUS_BOOKING
    FROM V_DETAIL_BOOKING_KAMAR V, TAMU T, H_BOOKING HB
    WHERE HB.ROW_ID_BOOKING = V.ROW_ID_BOOKING AND HB.ROW_ID_TAMU = T.ROW_ID_TAMU;

-- buat input peminjaman. masih on progress
CREATE OR REPLACE VIEW V_DATA_PEMINJAMAN_FASILITAS AS
    SELECT 
        V.STATUS_BOOKING,
        V.NOMOR_KAMAR,
        F.ROW_ID_FASILITAS,
        F.NAMA_FASILITAS,
        F.BIAYA_PEMINJAMAN,
        F.JUMLAH_TERSEDIA,
        NVL(SUM(V.JUMLAH_PEMINJAMAN), 0) AS JUMLAH_DIPINJAM
    FROM FASILITAS F
    LEFT JOIN 
        V_DETAIL_FASILITAS_KAMAR V
    ON 
        V.ROW_ID_FASILITAS = F.ROW_ID_FASILITAS
    GROUP BY
        V.STATUS_BOOKING,
        V.NOMOR_KAMAR,
        F.NAMA_FASILITAS,
        F.BIAYA_PEMINJAMAN,
        F.JUMLAH_TERSEDIA,
        F.ROW_ID_FASILITAS
    ORDER BY F.NAMA_FASILITAS ASC;

SELECT * FROM V_DATA_PEMINJAMAN_FASILITAS;

SELECT * FROM V_DETAIL_FASILITAS_KAMAR;


-- TESTING

-- SELECT * FROM V_DATA_PENGINAPAN;

-- SELECT * FROM V_DETAIL_FASILITAS_KAMAR;

-- SELECT NOMOR_KAMAR AS "Nomor Kamar", NAMA_TAMU AS "Nama Tamu" FROM V_DATA_PENGINAPAN WHERE STATUS_BOOKING = 1;

-- SELECT NOMOR_KAMAR AS "Nomor Kamar", NAMA_TAMU AS "Nama Tamu" FROM V_DATA_PENGINAPAN WHERE STATUS_BOOKING = 1 AND UPPER(NAMA_TAMU) LIKE '%W%' OR STATUS_BOOKING = 1 AND NOMOR_KAMAR LIKE '%W%';

-- SELECT * FROM V_DETAIL_FASILITAS_KAMAR WHERE ROW_ID_BOOKING = 1 AND NOMOR_KAMAR = 101;

-- SELECT NVL(SUM(SUBTOTAL), 0) AS TOTAL FROM V_DETAIL_FASILITAS_KAMAR WHERE ROW_ID_BOOKING = 1 AND NOMOR_KAMAR = 101;

-- SELECT CASE WHEN SUM(SUBTOTAL) IS NULL THEN 0 ELSE SUM(SUBTOTAL) FROM V_DETAIL_FASILITAS_KAMAR WHERE ROW_ID_BOOKING = 1 AND NOMOR_KAMAR = 101;

-- SELECT NAMA_FASILITAS AS "Nama Fasilitas", JUMLAH_PEMINJAMAN AS "Jumlah", BIAYA_PEMINJAMAN AS "Biaya Peminjaman", SUBTOTAL AS "Subtotal" FROM V_DETAIL_FASILITAS_KAMAR WHERE ROW_ID_BOOKING = 1 AND NOMOR_KAMAR = 101;

-- select * from V_DETAIL_BOOKING_KAMAR;

