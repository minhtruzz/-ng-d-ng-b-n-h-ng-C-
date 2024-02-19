create database quanlycuahang
go
use quanlycuahang
alter table SanPham
(	
	Anh nvarchar(200),
	MaSanPham nvarchar(10) primary key,
	TenSanPham nvarchar(30),
	MauSanPham nvarchar(15),
	GiaBan int,
	SoLuong int
)
alter table SanPham
alter column Anh nvarchar(200)

create table TaiKhoan
(	
	Ten nvarchar(50),
	TenTK int primary key,
	MatKhau nvarchar(10),
	Quyen int,
)
insert into TaiKhoan
values 
(N'Hồ Ngọc Tùng','0923616634','Tung6634',1),
(N'Nguyễn Minh Trường','0963651899','Truong1899',0),
(N'Tô Khải Hiên','0963651900','Hien9999',1)
delete from TaiKhoan
update SanPham
set TenSanPham='IPhone 13 Pro Max' where MaSanPham='IP13PM'
insert into SanPham
values
('D:\CSharp\DoAnVer2\Image\ip11.jpg','IP11','IPhone 11','White',10590000,20),
('D:\CSharp\DoAnVer2\Image\ip11pm.jpg','IP11PM','IPhone 11 Pro Max','Grey',15590000,20),
('D:\CSharp\DoAnVer2\Image\ip12.jpg','IP12','IPhone 12','Red',12590000,20),
('D:\CSharp\DoAnVer2\Image\ip12pm.jpg','IP12PM','IPhone 12 Pro Max','Gold',27590000,20),
('D:\CSharp\DoAnVer2\Image\ip13.jpg','IP13','IPhone 13','White',13590000,20),
('D:\CSharp\DoAnVer2\Image\ip13p.jpg','IP13P','IPhone 13 Pro','Gold',16590000,20),
('D:\CSharp\DoAnVer2\Image\ip13pm.jpg','IP13PM','IPhone 11 Pro Max','Light Blue',22590000,20),
('D:\CSharp\DoAnVer2\Image\ip14.jpg','IP14','IPhone 14','Black',25590000,20),
('D:\CSharp\DoAnVer2\Image\ip14pm.jpg','IP14PM','IPhone 14 Pro Max','White',32590000,20)


create table HoaDon
( 
	MaHD int ,
	HoTen nvarchar(50),
	SDT int primary key,
	TenSanPham nvarchar(30),
	MauSanPham nvarchar(15),
	Gia float,
	SoLuong int,
	GiamGia float,
	TongTien float,
	Ngay Date
)
delete from HoaDon
--insert into HoaDon
--values
--('1','Tô Khải Hiên',0111222333,'IPhone 14 Pro Max','Black',25590000,1,0,25590000,'3/5/2023'),
--('2','Hồ Ngọc Tùng',0987665412,'IPhone 13 Pro Max','Light Blue',22590000,1,590000,22000000,'4/5/2023'),
--('3','Lê Đức Minh',0984567851,'IPhone 11','White',10590000,1,90000,10500000,'5/5/2023')

create table ChiTietHoaDon
(
	MaHD nvarchar(10) ,
	MaSanPham nvarchar(10) ,
	NhanVienBan nvarchar(30),
	TenKh nvarchar(50),
	DiaChi nvarchar(50),
	TenSanPham nvarchar(50),
	Mau nvarchar(20),
	SoLuong int,
	NgayMua Date,
	TongTien int,
	primary key(MaHD,MaSanPham)
)
insert into ChiTietHoaDon
values
('HD1','IP14',N'Hồ Ngọc Tùng',N'Tô Khải Hiên',N'Gò Vấp','IPhone 14','Black',1,'2023-05-05',25590000),
('HD2','IP14',N'Hồ Ngọc Tùng',N'Đoàn Văn Quốc',N'Thủ Đức','IPhone 13','Black',1,'2023-06-02',20590000),
('HD3','IP14',N'Hồ Ngọc Tùng',N'Phạm Nhật Trường',N'Thủ Đức','IPhone 12','White',1,'2023-06-02',18590000),
('HD4','IP14',N'Hồ Ngọc Tùng',N'Phạm Hữu Tài',N'Quận 7','IPhone 11','White',1,'2023-06-02',10590000)
delete from ChiTietHoaDon
create table NhaCungCap
(
	MaNCC nvarchar(10),
	TenNCC nvarchar(50),
	SDT int,
	MaSanPham nvarchar(10),
	TenSanPham nvarchar(50),
	SoLuong int,
	GiaSi int,
	NgayCap Date
)
delete From NhaCungCap
insert into NhaCungCap
values 
('app','Apple Store',0999999999,'IP11','IPhone 11',20,8900000,'4/5/2023'),
('app','Apple Store',0999999999,'IP11p','IPhone 11 Pro',20,9900000,'4/5/2023'),
('app','Apple Store',0999999999,'IP11PM','IPhone 11 Pro Max',20,10900000,'4/5/2023'),
('app','Apple Store',0999999999,'IP12','IPhone 12',20,8900000,'4/5/2023'),
('app','Apple Store',0999999999,'IP12PM','IPhone 12 Pro Max',20,12900000,'4/5/2023'),
('app','Apple Store',0999999999,'IP13','IPhone 13',20,11900000,'4/5/2023'),
('app','Apple Store',0999999999,'IP14','IPhone 14',20,8900000,'4/5/2023')