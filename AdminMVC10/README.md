# AdminMVC10 - ASP.NET Core MVC .NET 10

Dự án mẫu giao diện quản trị theo bài thực hành, sử dụng AdminLTE 4.10.1 (phiên bản trong file ZIP người học cung cấp) và ASP.NET Core MVC .NET 10.

## Mở và chạy
1. Cài .NET 10 SDK và Visual Studio có workload ASP.NET and web development.
2. Giải nén `AdminMVC10.zip`.
3. Mở `AdminMVC10.csproj` bằng Visual Studio.
4. Chọn HTTPS hoặc HTTP trong cấu hình chạy, sau đó nhấn F5. Có thể chạy terminal tại thư mục dự án bằng `dotnet run`.
5. Trang Dashboard là trang mặc định. Chọn **Danh mục** hoặc **Sản phẩm** ở menu trái để xem các trang mẫu.

## Cấu trúc
- `Controllers/`: Home, Category, Product.
- `Models/`: dữ liệu mẫu Category và Product.
- `Views/Shared/_Layout.cshtml`: layout dùng chung, header, sidebar, footer.
- `Views/Home/Index.cshtml`: dashboard.
- `Views/Category/Index.cshtml`: danh sách danh mục.
- `Views/Product/Index.cshtml`: danh sách sản phẩm và bộ lọc giao diện.
- `wwwroot/adminlte/`: tài nguyên `dist` từ AdminLTE ZIP đã gửi.

## Lưu ý
- Dữ liệu danh mục và sản phẩm hiện là dữ liệu mẫu trong bộ nhớ; chưa kết nối SQL Server và các nút thêm/sửa/xóa chỉ là minh họa.
- Bootstrap và Font Awesome được tham chiếu qua CDN, vì vậy cần Internet khi chạy để tải các thư viện đó. CSS/JS AdminLTE được đóng gói trong `wwwroot/adminlte`.
- Đề bài trong ảnh tham chiếu AdminLTE 3, nhưng file được gửi là AdminLTE 4.10.1. Project này dùng đúng file bạn gửi; giao diện được tổ chức theo mẫu dashboard và menu tiếng Việt của đề.
