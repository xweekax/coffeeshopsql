using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using lab13._2_Coffee_Shop_SQL.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace lab13._2_Coffee_Shop_SQL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult LinkPage()
        {
            IDbConnection db = new SqlConnection("Server=GQJSN13\\SQLEXPRESS;Database=coffeeshop;user id=newuser;password=abc123;");
            db.Open();
            List<Product> cats = db.Query<Product>("select * from product").AsList<Product>();
            db.Close();

            return View(cats);

        }

        public IActionResult Category(int catid)
        {
            IDbConnection db = new SqlConnection("Server=GQJSN13\\SQLEXPRESS;Database=coffeeshop;user id=newuser;password=abc123;");
            db.Open();
            Product cat = db.QuerySingle<Product>($"select * from product where ID = {catid}");
            db.Close();

            return View(cat);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
