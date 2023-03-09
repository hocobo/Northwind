using System;
using Microsoft.AspNetCore.Mvc;


namespace Northwind.Controllers
{
    public class ProductController : Controller
    {
        private NorthwindContext _northwindContext;
        public ProductController(NorthwindContext db) => _northwindContext = db;
        public IActionResult Category() => View(_northwindContext.Categories.OrderBy(c=>c.CategoryName));
        public IActionResult Index(int Id) => View(_northwindContext.Products.Where(c=>c.CategoryId == Id && c.Discontinued == false).OrderBy(p=>p.ProductName));
        public IActionResult Discount() => View(_northwindContext.Discounts.Where(c=>c.EndTime>=DateTime.Today));
    }
}