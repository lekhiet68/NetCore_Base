# NetCore_Base - Ứng dụng Quản lý Sản phẩm

##  Giới thiệu
NetCore_Base là một ứng dụng ASP.NET Core MVC sử dụng **Entity Framework Core** và **AutoMapper** để quản lý danh sách sản phẩm. Ứng dụng hỗ trợ các chức năng **CRUD (Create, Read, Update, Delete)**.

---
## Công nghệ sử dụng
- **.NET Core 8**
- **Entity Framework Core** (EF Core) - Quản lý dữ liệu
- **SQL Server** - Cơ sở dữ liệu chính
- **AutoMapper** - Chuyển đổi giữa Entity & ViewModel
- **Bootstrap 5** - Giao diện người dùng
- **Razor View Engine** - Tạo giao diện động
---
## Hướng dẫn Entity Framework Core và cách kết nối SQL Server 
- **Bước 1: Cài đặt Entity Framework Core => Vào cửa sổ Package Manager Console(Tools/Nuget Package Manager/Package Manager Console) chạy các lệnh sau**
~~~sh
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design
~~~
- **Bước 2: Tạo class Product**
- **Bước 3: Tạo Dbcontext => Tạo file MyDbContext.cs**
~~~sh
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options) { }

        public DbSet<Product> Products { get; set; }
    }  
~~~
- **Bước 4: Cấu hình chuỗi kết nối:**
- **- Mở file appsettings.json thêm dòng:**
~~~sh
    "ConnectionStrings": {
    "DefaultConnection": "Server=...\\SQLEXPRESS;Database=Dev_EF;User Id=sa;Password=Password123;TrustServerCertificate=True;"
}
~~~
- **- Mở file Program.cs thêm dòng:**
~~~sh
 var connectString = builder.Configuration.GetConnectionString("DefaultConnection");
 builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer(connectString));
 builder.Services.AddAutoMapper(typeof(Program));
}
~~~
- **Bước 5: Tạo Migration và Cập nhật CSDL**
~~~sh
dotnet ef migrations add InitialCreate
dotnet ef database update
~~~
- **Bước 6: Tạo class ProductViewModel**
- **Bước 7: Sử dụng thư viện AutoMapper để mapping Entity và View Model**
~~~sh
- Cài đặt:
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
- Tạo file MappingProfile.cs trong thư mục Mappings

  public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductViewModel>().ReverseMap();
    }
}
- Cấu hình AutoMapper trong Program.cs
builder.Services.AddAutoMapper(typeof(Program));
~~~
- **Bước 8: Tạo Controller và view sử dụng EF => Để tạo nhanh CRUD**
