create database QLNV1
use QLNV1
drop database QLNV1
create table PHONGBAN(
	MaPhong varchar(10) primary key not null,
	TenPhong nvarchar(20) not null
)

create table CHUCVU(
	MaChucVu varchar(10) primary key not null,
	TenChucVu nvarchar(20) not null,
	PhuCap int not null
)

create table DSNV(
	MaNV varchar(10) primary key not null,
	HoDem nvarchar(40) not null,
	Ten nvarchar(20) not null,
	NgaySinh datetime not null,
	GioiTinh bit not null,
	MaPhong varchar(10) not null,
	MaChucVu varchar(10) not null,
	HeSoLuong float not null,
	SoDienThoai varchar(10) not null,
	DiaChi nvarchar(100) not null
)

drop table DSNV

alter table DSNV add constraint fk_MaPhong foreign key (MaPhong) references PHONGBAN(MaPhong)
alter table DSNV add constraint fk_MaChucVu foreign key (MaChucVu) references CHUCVU(MaChucVu)

alter table DSNV drop constraint fk_MaPhong
alter table DSNV drop constraint fk_MaChucVu

insert into PHONGBAN(MaPhong, TenPhong) values 
('BV', N'Bảo vệ'),
('HC', N'Hành chính'),
('KD', N'Kinh doanh'),
('NS', N'Nhân sự'),
('DV', N'Dịch vụ'),
('KT', N'Kế toán'),
('SX', N'Sản xuất')

insert into CHUCVU(MaChucVu, TenChucVu, PhuCap) values
('TP', N'Trưởng phòng', 3000000),
('PP', N'Phó phòng', 2500000),
('QL', N'Quản lý', 2000000),
('NV', N'Nhân viên', 1500000)

insert into DSNV(MaNV, HoDem, Ten, NgaySinh, GioiTinh, MaPhong, MaChucVu, HeSoLuong, SoDienThoai, DiaChi) values
('010', N'Nguyễn Anh', N'Vũ', '2003-06-22', 1, 'DV', 'NV', 3.5, '0902128743', N'Trần Quang Diệu'),
('101', N'Trần Thu', N'An', '2003-10-16', 0, 'DV', 'PP', 4.5, '0902457243', N'Trần Quang Diệu'),
('100', N'Lê Ngọc', N'Quý', '1996-02-12', 1, 'HC', 'TP', 5.5, '0908436243', N'Tây Sơn'),
('011', N'Phạm Quốc', N'Cường', '1997-07-19', 1, 'HC', 'PP', 3.9, '0902197462', N'An Nhơn'),
('111', N'Trần Quốc', N'Đạt', '2003-11-02', 1, 'BV', 'NV', 2.5, '0902836251', N'Quy Hòa'),
('192', N'Nguyễn Thị Thu', N'Uyên', '1997-10-30', 0, 'KD', 'PP', 4.5, '0902492745', N'Quy Nhơn'),
('115', N'Võ Tuấn', N'Danh', '2003-12-05', 1, 'SX', 'NV', 3.1, '0902109263', N'Quy Nhơn'),
('294', N'Đỗ Ngọc', N'Đạt', '2003-11-19', 1, 'KT', 'NV', 3.8, '0902129852', N'Quy Nhơn'),
('492', N'Đinh Thị Lưu', N'Xuyến', '2002-02-16', 0, 'KT', 'PP', 4.5, '0902423245', N'Quy Nhơn'),
('000', N'Nguyễn Ngọc', N'Hiếu', '1999-08-27', 1, 'BV', 'NV', 3.1, '0902124852', N'Quy Nhơn')
