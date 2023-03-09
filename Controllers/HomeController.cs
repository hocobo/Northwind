using System;
using Microsoft.AspNetCore.Mvc;

namespace Northwind.Controllers
{
    public class HomeController : Controller
    {
        private NorthwindContext _dataContext;
        public HomeController(NorthwindContext db) => _dataContext = db;
         public ActionResult Index() => View(_dataContext.Discounts.Where(d => d.StartTime <= DateTime.Now && d.EndTime > DateTime.Now).Take(3));
    }
}