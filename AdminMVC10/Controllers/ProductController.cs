using Microsoft.AspNetCore.Mvc;
using AdminMVC10.Models;
namespace AdminMVC10.Controllers;
public class ProductController : Controller
{
    private static readonly List<Product> Items = new() {
      new(){Id=1,Name="Áo thun basic",Category="Quần áo",Price=150000,Stock=35,Status="Đang bán"},
      new(){Id=2,Name="Túi xách thời trang",Category="Túi xách",Price=320000,Stock=18,Status="Đang bán"},
      new(){Id=3,Name="Giày sneaker",Category="Giày dép",Price=450000,Stock=12,Status="Đang bán"},
      new(){Id=4,Name="Mũ lưỡi trai",Category="Phụ kiện",Price=90000,Stock=0,Status="Hết hàng"}
    };
    public IActionResult Index() => View(Items);
}
