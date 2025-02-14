# Quản Lý Bán Điện Thoại

## Giới thiệu
Dự án **Quản Lý Bán Điện Thoại** là một phần mềm quản lý cửa hàng điện thoại, giúp quản lý sản phẩm, khách hàng, đơn hàng, nhân viên và nhà cung cấp.

## Tính năng chính
- Quản lý sản phẩm (Thêm, sửa, xóa, tìm kiếm)
- Quản lý khách hàng và nhà cung cấp
- Quản lý hóa đơn nhập/xuất
- Chức năng đăng nhập với vai trò **Admin**
- Báo cáo doanh thu, tồn kho

## Công nghệ sử dụng
- **Ngôn ngữ:** C# (Windows Forms)
- **Cơ sở dữ liệu:** SQL Server
- **Môi trường phát triển:** Visual Studio

## Cách cài đặt
### 1. Khôi phục cơ sở dữ liệu
- Mở **SQL Server Management Studio (SSMS)**
- Chạy lệnh sau để khôi phục từ file `.bak`:
  ```sql
  RESTORE DATABASE QuanLyBanDienThoai
  FROM DISK = 'C:\path\to\QuanLyBanDT.bak'
  WITH REPLACE, MOVE 'QuanLyBanDienThoai' TO 'C:\Program Files\Microsoft SQL Server\MSSQL\Data\QuanLyBanDienThoai.mdf',
  MOVE 'QuanLyBanDienThoai_log' TO 'C:\Program Files\Microsoft SQL Server\MSSQL\Data\QuanLyBanDienThoai.ldf'
  ```
  
### 2. Cấu hình kết nối CSDL trong `App.config`
- Mở file `App.config` và kiểm tra phần `<connectionStrings>`:
  ```xml
  <connectionStrings>
      <add name="QuanLyBanDienThoaiConnectionString"
          connectionString="Data Source=YOUR_SERVER;Initial Catalog=QuanLyBanDienThoai;Integrated Security=True"
          providerName="System.Data.SqlClient" />
  </connectionStrings>
  ```
- Thay `YOUR_SERVER` bằng tên SQL Server trên máy bạn.

### 3. Chạy chương trình
- Mở **Visual Studio** và mở file `QuanLyBanDienThoai.sln`
- Build và chạy chương trình (`Ctrl + F5`)

## Tài khoản đăng nhập
- **Admin:**  
  - Tài khoản: `admin`  
  - Mật khẩu: `admin123`

