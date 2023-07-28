--Create PROCEDURE [dbo].[NguoiDung_GetByUser](
--@userName nvarchar(50),
--@passWord nvarchar(50)
--)
--AS 
--BEGIN
--	select * From tblNguoiDung
--	Where TenDangNhap = @userName and MatKhau=@passWord
--	END

--insert khach hang
Create PROCEDURE [dbo].[KhachHang_Insert](
@tenKhach nvarchar(50),
@diaChi nvarchar(50),
@dienThoai nvarchar(50)
)
AS 
BEGIN
	Insert into tblKhachHang
			(
			TenKhach,
			DiaChi,
			DienThoai)
			Values (
			@tenKhach,
			@diaChi,
			@dienThoai)
	END

	--update khach hang
Create PROCEDURE [dbo].[KhachHang_Update](
@maKhach int,
@tenKhach nvarchar(50),
@diaChi nvarchar(50),
@dienThoai nvarchar(50)
)
AS 
BEGIN
Update tblKhachHang
Set 
TenKhach =@tenKhach,
DiaChi = @diaChi,
DienThoai = @dienThoai
	where MaKhach =@maKhach
	END




