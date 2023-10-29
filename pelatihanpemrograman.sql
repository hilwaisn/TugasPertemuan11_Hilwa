CREATE DATABASE pelatihan_pemrograman;
USE pelatihan_pemrograman;

CREATE TABLE Pelatihan(
	id INT AUTO_INCREMENT PRIMARY KEY,
	nama_pelatihan VARCHAR(255) NOT NULL,
	deskripsi TEXT,
	tanggal_mulai DATE,
	tanggal_selesai DATE,
	instruktur VARCHAR(100),
	lokasi VARCHAR(255),
	harga DECIMAL(10, 2)
);

CREATE TABLE Peserta(
	id INT AUTO_INCREMENT PRIMARY KEY,
	nama_peserta VARCHAR(255) NOT NULL,
	email VARCHAR(255),
	no_telepon VARCHAR(15)
);

create table Sertifikat(
	id int auto_increment primary key,
	nama_sertifikat varchar(255) not null,
	deskripsi text,
	pelatihan_id Int,
	foreign key (pelatihan_id) references Pelatihan(id)
);

create table Registrasi(
	id int auto_increment primary key,
	peserta_id int,
	pelatihan_id int,
	foreign key(peserta_id) references Peserta(id),
	foreign key (pelatihan_id) references Pelatihan(id)
);