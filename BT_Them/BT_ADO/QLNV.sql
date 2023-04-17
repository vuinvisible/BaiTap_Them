create database QLNV
use QLNV

create table CHUCVU(
	MaChucVu varchar(10) primary key not null,
	TenChucVu nvarchar(30) not null,
	PhuCapCV int not null,
)

create table DSNV(
	MaNV varchar(10) primary key not null,
	HoTen nvarchar(50) not null,
	NgaySinh datetime not null,
	GioiTinh bit not null,
	MaPhong varchar(10) not null,
	HeSoLuong float not null,
	MaChucVu varchar(10) not null
)

create table DMPHONG(
	MaPhong varchar(10) primary key not null,
	TenPhong nvarchar(40) not null
)

drop table DSNV

alter table DSNV add constraint fk_maphong foreign key (MaPhong) references DMPHONG(MaPhong);
alter table DSNV add constraint fk_machucvu foreign key (MaChucVu) references CHUCVU(MaChucVu);

insert into DMPHONG(MaPhong, TenPhong) values
('HC', N'Hành chính'),
('KD', N'Kinh doanh'),
('BV', N'Bảo vệ'),
('DV', N'Dịch vụ'),
('NS', N'Nhân sự');

insert into CHUCVU(MaChucVu, TenChucVu, PhuCapCV) values
('TP', N'Trưởng phòng', 5000000),
('PP', N'Phó phòng', 4500000),
('NV', N'Nhân viên', 2000000);

insert into DSNV(MaNV, HoTen, NgaySinh, GioiTinh, MaPhong, HeSoLuong, MaChucVu) values
('010', N'Nguyễn Anh Vũ', '2003-06-22', 1, 'DV', 3.5, 'NV'),
('001', N'Nguyễn Khánh Duy', '2003-03-12', 1, 'HC', 4.5, 'PP'),
('093', N'Trần Thu An', '2003-10-16', 0, 'DV', 4.0, 'NV'),
('101', N'Lê Ngọc Quý', '1997-07-10', 1, 'DV', 5.5, 'TP'),
('234', N'Phạm Quốc Cường', '1999-12-03', 1, 'NS', 3.5, 'PP'),
('842', N'Bùi Nguyễn Diễm Quỳnh', '2003-06-03', 0, 'KD', 3.5, 'NV'),
('532', N'Trần Quốc Đạt', '2003-01-20', 1, 'BV', 2.5, 'NV'),
('537', N'Lê Thị Vi', '2000-02-16', 0, 'HC', 4.8, 'TP'),
('425', N'Võ Tuấn Danh', '2003-10-24', 1, 'BV', 3.0, 'PP'),
('586', N'Huỳnh Quốc Trung', '2002-09-28', 1, 'BV', 3.5, 'TP'),
('356', N'Nguyễn Thị Thu Uyên', '1999-11-29', 0, 'KD', 5.5, 'TP');


select * from DSNV;
