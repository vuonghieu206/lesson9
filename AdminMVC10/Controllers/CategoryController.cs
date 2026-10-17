using Microsoft.AspNetCore.Mvc;
using AdminMVC10.Models;
namespace AdminMVC10.Controllers;
public class CategoryController : Controller
{
    private static readonly List<Category> Items = new() { new(){Id=1,Name="Quần áo"}, new(){Id=2,Name="Túi xách"}, new(){Id=3,Name="Giày dép"}, new(){Id=4,Name="Phụ kiện"} };
    public IActionResult Index() => View(Items);
}
