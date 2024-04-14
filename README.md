# MVC Dotnet EcommerceFashion

## Documentation
 - Official ASP.NET Core MVC: https://learn.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-8.0
 - Entity Framework Core: https://learn.microsoft.com/en-us/ef/core/
 - Scaffold Identity into an MVC project with authorization: https://learn.microsoft.com/vi-vn/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-6.0&tabs=netcore-cli#scaffold-identity-into-an-mvc-project-with-authorization-1

## Cài đặt phát triển với DotNetSDK
1. Đảm bảo rằng bạn đang có bộ cài DotNetSDK trong máy, nếu như không, sử dụng đường link dưới đây để tải về: https://dotnet.microsoft.com/en-us/download, hoặc đơn giản máy có VisualStudio
2. Mở Terminal bất kì để kiểm tra phiên bản Dotnet trong máy:
```bash
dotnet --version
```
3. Đảm bảo dotnet có hai thư viện này ở cấp độ global bằng cách sử dụng các câu lệnh sau(lần lượt)
```bash
dotnet tool uninstall --global dotnet-aspnet-codegenerator
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef
```
4. Chạy migration để cài đặt phần authentication
```bash
dotnet ef database update --context EntityDbContext 
```
5. Chạy migration để cài đặt phần định nghĩa DB
```bash
dotnet ef database update --context ApplicationDbContext
```

- Khởi chạy dự án
```bash
dotnet run
```

- Tạo migration khi thay đổi Entity:
```bash
dotnet ef migrations add <ten-migration> --context <ten-context>
```

- Tạo Controller mẫu từ Entity đã tạo:
```bash
dotnet aspnet-codegenerator controller -name <ten-entity>Controller -m <ten-entity> -dc MvcEcommerceFashion.Data.EntityDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
```

## Thiết đặt với VisualStudio
1. Mở file `MvcEcommerceFashion.csproj` bằng VisualStudio và để IDE làm phần thiết đặt cơ bản
1. Tìm kiếm file `appsettings.json` và thay đổi nội dung của nó ứng với hai key `ApplicationDbContextConnection` và `EntityDbContext` thành:
    ```plaintext
    Server=localhost;Database=<tên-db-sử-dụng>;User Id=<tên-người-dùng-thiết-đặt-db>;Password=<mật-khẩu-thiết-đặt-cho-db>;Trusted_Connection=False;TrustServerCertificate=True;MultipleActiveResultSets=true
    ```
    để Server có thể kết nối được với databse, database nên được tạo mới hoàn toàn, xóa và tạo lại database trên giao diện quản lý thường dùng
1. Sau khi dự án được thiết đặt xong, từ menu `Tools`, chọn **NuGet Package Manager** > **Package Manager Console**
1. Từ giao diện console mở ra, lần lượt chạy hai câu lệnh sau:
```powershell
Update-Database -Context EntityDbContext
Update-Database -Context ApplicationDbContext
```