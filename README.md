<!-- ABOUT THE PROJECT -->
### Công nghệ

* ![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)
* ![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
* ![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)

<!-- FEATURE -->
## Tính năng

- [x] Quản lý chuyến bay (Thêm, xóa)
- [x] Quản lý hàng khách (Thêm, xóa)
- [x] Quản lý vé (Thêm, xóa)
- [x] Công cụ tìm kiếm và bộ lọc
- [x] Hệ thống làm việc đa cửa sổ
- [x] Thống kê
- [x] Hỗ trợ kết nối nhiều thiết bị thông qua SQL server

<!-- GETTING STARTED -->
## Yêu cầu

1. [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Developer Edition hoặc Express Edition)
2. [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
3. Scale Windows tối ưu từ 150% đến 175%

### Hướng dẫn cài đặt

1. Cài đặt [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Khuyến kích sử dụng bản developer).
2. Chạy [file sql](https://github.com/tqb2512/Airline-Reservation-System/blob/master/SQL/script.sql) để tạo database bằng [SQL Server Management Studio](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16) hoặc dùng chạy scirpt bên dưới bằng cmd.
	```
	sqlcmd -S .\ -i "Đường dẫn file sql" -f 65001
	```
3. Cài đặt phần mềm bằng file [setup](https://github.com/tqb2512/QuanLyPhongKham/releases/download/release/QuanLyPhongKham_Setup.msi).
4. Nêu sử dụng MSQL phiên bản dev thì có thể bắt đầu sử dụng ngay. Đối với MSQL Express thì truy cập đường dẫn của phần mềm đã cài, mở file `QuanLyPhongKham.dll.config` và thay đổi trường `connectionString` bằng
	```
	Data Source=./;Initial Catalog=Airline_Reservation_System;Integrated Security=True
	```

<!-- USAGE EXAMPLES -->
## Một số lỗi có thể gặp

* Lỗi button bị mất, layout bị khuất khỏi cửa sổ, và các vấn đề liên quan đến layout của các mục. Lỗi này thường xảy ra đối với các màn hình quá nhỏ hoặc quá lớn để khắc phục tạm thời có thể mở ứng dụng thay đổi `scale` trong `display setting` thấp hơn hoặc lớn hơn, xác nhận và thay đổi `scale` về lại như cũ.

* Lỗi không thể đăng nhập, lỗi này do việc thiết lập `connectionString` chưa đúng. Hãy truy cập thư mục đã cài đặt và thay đổi `connectionString` của file `Airline-Reservation-System.dll.config` cho hợp lệ.

<!-- CONTRIBUTING -->
## Người đóng góp

* [Trịnh Quốc Bảo](https://github.com/tqb2512)
* [Trần Văn Huy](https://github.com/grvhuy)
* [Võ Thiên Phúc](https://github.com/tkj3nfuq)
