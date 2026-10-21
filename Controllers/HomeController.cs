
using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Controllers
{
    public class HomeController : Controller
    {
        // 1. Trang chủ
        public IActionResult Index()
        {
            return View(GetSampleProducts());
        }

        // 2. Danh sách danh mục
        public IActionResult Category()
        {
            List<Category> categories = new List<Category>
            {
                new Category
                {
                    Id = 1,
                    Name = "Điện thoại",
                    Description = "Các loại điện thoại"
                },
                new Category
                {
                    Id = 2,
                    Name = "Laptop",
                    Description = "Máy tính xách tay"
                },
                new Category
                {
                    Id = 3,
                    Name = "Phụ kiện",
                    Description = "Phụ kiện công nghệ"
                }
            };

            return View(categories);
        }

        // 3. Danh sách sản phẩm
        public IActionResult Product()
        {
            return View(GetSampleProducts());
        }

        private static List<Product> GetSampleProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "iPhone 16",
                    CategoryId = 1,
                    Price = 22000000,
                    StockQuantity = 10,
                    ImageFileName = null,
                    IsActive = true
                },
                new Product
                {
                    Id = 2,
                    Name = "Dell Inspiron 15",
                    CategoryId = 2,
                    Price = 18000000,
                    StockQuantity = 5,
                    ImageFileName = null,
                    IsActive = true
                },
                new Product
                {
                    Id = 3,
                    Name = "Tai nghe Sony",
                    CategoryId = 3,
                    Price = 1290000,
                    StockQuantity = 20,
                    ImageFileName = null,
                    IsActive = true
                },
                new Product
                {
                    Id = 4,
                    Name = "Samsung Galaxy A55",
                    CategoryId = 1,
                    Price = 9990000,
                    StockQuantity = 12,
                    ImageFileName = null,
                    IsActive = true
                },
                new Product
                {
                    Id = 5,
                    Name = "ASUS Vivobook 15",
                    CategoryId = 2,
                    Price = 15990000,
                    StockQuantity = 7,
                    ImageFileName = null,
                    IsActive = true
                },
                new Product
                {
                    Id = 6,
                    Name = "Sạc nhanh Anker 30W",
                    CategoryId = 3,
                    Price = 490000,
                    StockQuantity = 0,
                    ImageFileName = null,
                    IsActive = false
                }
            };
        }

        // 4. Danh sách nhân viên
        public IActionResult Employee()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    FullName = "Nguyễn Văn An",
                    Phone = "0912345678",
                    Email = "an@example.com",
                    UserId = "user01",
                    IsActive = true
                },
                new Employee
                {
                    Id = 2,
                    FullName = "Trần Thị Bình",
                    Phone = "0987654321",
                    Email = "binh@example.com",
                    UserId = "user02",
                    IsActive = true
                },
                new Employee
                {
                    Id = 3,
                    FullName = "Lê Minh Tuấn",
                    Phone = "0901234567",
                    Email = "tuan@example.com",
                    UserId = "user03",
                    IsActive = true
                },
                new Employee
                {
                    Id = 4,
                    FullName = "Phạm Ngọc Mai",
                    Phone = "0934567890",
                    Email = "mai@example.com",
                    UserId = "user04",
                    IsActive = true
                },
                new Employee
                {
                    Id = 5,
                    FullName = "Đỗ Quốc Huy",
                    Phone = "0971234568",
                    Email = "huy@example.com",
                    UserId = "user05",
                    IsActive = true
                },
                new Employee
                {
                    Id = 6,
                    FullName = "Vũ Thu Hà",
                    Phone = "0918765432",
                    Email = "ha@example.com",
                    UserId = "user06",
                    IsActive = false
                }
            };

            return View(employees);
        }

        // 5. Danh sách hóa đơn
        public IActionResult Invoice()
        {
            List<Invoice> invoices = new List<Invoice>
            {
                new Invoice
                {
                    Id = 1,
                    CreatedAt = new DateTime(2026, 10, 20),
                    EmployeeId = 1,
                    CustomerName = "Lê Văn Nam",
                    CustomerPhone = "0901111222",
                    TotalAmount = 22500000
                },
                new Invoice
                {
                    Id = 2,
                    CreatedAt = new DateTime(2026, 10, 21),
                    EmployeeId = 2,
                    CustomerName = "Phạm Thị Hoa",
                    CustomerPhone = "0903333444",
                    TotalAmount = 18000000
                }
            };

            return View(invoices);
        }

        // 6. Chi tiết hóa đơn
        public IActionResult InvoiceDetail()
        {
            List<InvoiceDetail> details = new List<InvoiceDetail>
            {
                new InvoiceDetail
                {
                    Id = 1,
                    InvoiceId = 1,
                    ProductId = 1,
                    Quantity = 1,
                    UnitPrice = 22000000
                },
                new InvoiceDetail
                {
                    Id = 2,
                    InvoiceId = 1,
                    ProductId = 3,
                    Quantity = 1,
                    UnitPrice = 500000
                },
                new InvoiceDetail
                {
                    Id = 3,
                    InvoiceId = 2,
                    ProductId = 2,
                    Quantity = 1,
                    UnitPrice = 18000000
                }
            };

            return View(details);
        }
    }
}
