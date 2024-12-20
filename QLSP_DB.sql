-- DE 2
create database QLSanPham_KT
go
use QLSanPham_KT
go

create table LoaiSanPham 
(
	MaLoai char(2) not null primary key,
	TenLoai nvarchar(30)
)

create table SanPham
(
	MaSanPham char(6) not null primary key,
	TenSanPham nvarchar(30),
	NgayNhap datetime,
	MaLoai char(2) not null
)

alter table SanPham
	add constraint fk_1 foreign key(MaLoai) references LoaiSanPham(MaLoai)

insert into LoaiSanPham
values
	('L1', N'TÊN LOẠI 1'),
	('L2', N'TÊN LOẠI 2')
	
insert into SanPham
values
	('SP1', N'SẢN PHẨM 1', '2024-12-15', 'L1'),
	('SP2', N'SẢN PHẨM 2', '2024-12-17', 'L1'),
	('SP3', N'SẢN PHẨM 3', '2024-12-19', 'L2')

SELECT * FROM LoaiSanPham
SELECT * FROM SanPham