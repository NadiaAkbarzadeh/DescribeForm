using DescribeForm.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DescribeForm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;

        public HomeController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            //var describe = new Describe()
            //{
            //    Name = "test",
            //};
            //db.Describes.Add(describe);
            //db.SaveChanges();
            return View();
        }
    }
}
