create database QLKhoThuoc;
--khach hang
create table KhachHang(
SDT char(20) not null primary key,
HoTenK varchar(50) not null,
TongTien money not null
)

--Hoa Don
create table HoaDon (
SoDonThuoc char(20) not null primary key,
NgayMua date not null,
SDT char(20) not null foreign key references KhachHang(SDT)
)

--Danh Muc 
create table DanhMuc (
MaDM char(20) not null primary key,
TenDM varchar (50) not null
)

--Loai Thuoc
create table LoaiThuoc(
MaLoai char(20) not null primary key,
TenLoai varchar(50) not null,
MaDM char(20) not null foreign key references DanhMuc(MaDM)
)

--Nha San Xuat 
 create table NhaSX (
 MaNSX char(20) not null primary key,
 TenNSX varchar(50) not null,
 SDTNSX char(20) not null
 )

 --Thuoc
create table Thuoc (
MaThuoc char(20) not null primary key,
TenThuoc varchar (50) not null,
GiaNhap money not null,
GiaBan money not null,
DonViTinh char(20) not null,
NXS date not null,
NSD date not null,
SlgCon int not null,
MaNSX char(20) not null foreign key references NhaSX(MaNSX),
GhiChu varchar not null,
MaLoai char(20) not null foreign key references LoaiThuoc(MaLoai)
)

--Chi tiet Hoa Don
create table ChiTietHD(
SoDonThuoc char(20) not null foreign key references HoaDon(SoDonThuoc),
MaThuoc char(20) not null foreign key references Thuoc(MaThuoc),
SoLuong Char(20) not null,
primary key(SoDonThuoc,MaThuoc)
)


INSERT INTO KhachHang (SDT, HoTenK, TongTien) VALUES
  ('0123456789', N'Nguyễn Văn A', 1000000),
  ('9876543210', N'Trần Thị B', 500000);

select * from KhachHang;

INSERT INTO HoaDon (SoDonThuoc, NgayMua, SDT) VALUES
  ('HD0001', '2024-03-10', '0123456789'),
  ('HD0002', '2024-03-08', '9876543210');

select * from HoaDon;

INSERT INTO DanhMuc (MaDM, TenDM) VALUES
  ('DM001', N'Thực Phẩm Chức Năng'),
  ('DM002', N'Thuốc Chữa Bệnh');

select *from DanhMuc;

INSERT INTO LoaiThuoc (MaLoai, TenLoai, MaDM) VALUES
  ('LT001', N'Vitamin', 'DM001'),
  ('LT002', N'Giảm Đau', 'DM002');

select * from LoaiThuoc;

INSERT INTO NhaSX (MaNSX, TenNSX, SDTNSX) VALUES
  ('NSX001', N'Dược phẩm ABC', '0234567890'),
  ('NSX002', N'Công ty X', '123456789');

select * from NhaSX;
ALTER TABLE Thuoc ALTER COLUMN GhiChu VARCHAR(255);


INSERT INTO Thuoc (MaThuoc, TenThuoc, GiaNhap, GiaBan, DonViTinh, NXS, NSD, SlgCon, MaNSX, GhiChu, MaLoai) VALUES
  ('TH001', N'Vitamin C', 10000, 15000, N'Hộp', '2024-02-20', '2025-01-19', 150, 'NSX001', N'Tăng cường sức đề kháng', 'LT001'),
  ('TH002', N'Thuốc giảm đau', 20000, 30000, N'Viên', '2024-03-01', '2025-02-28', 100, 'NSX001', N'Có tác dụng giảm đau hiệu quả', 'LT002'),
  ('TH003', N'Siro ho', 15000, 25000, N'Chai', '2024-02-15', '2025-01-14', 50, 'NSX002', N'Dùng cho trẻ em và người lớn bị ho', 'LT002');\

  select * from Thuoc;

  INSERT INTO ChiTietHD (SoDonThuoc, MaThuoc, SoLuong) VALUES
  ('HD0001', 'TH001', 2),
  ('HD0001', 'TH002', 1),
  ('HD0002', 'TH003', 1);

  select * from ChiTietHD;