using L27ASPAddDeleteModify.Data;
using L27ASPAddDeleteModify.Models;

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace L27ASPAddDeleteModify.Controllers
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

            using StuDBContext _db = new StuDBContext();

            Student stu = new Student { id = "101", name = "Pickle", grade = 90 };
            _db.Students.Add(stu);

            stu = new Student { id = "102", name = "Rick", grade = 95 };
            _db.Students.Add(stu);

            stu = new Student { id = "102", name = "Morty", grade = 87 };
            _db.Students.Add(stu);

            _db.SaveChanges();


            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Student stu)
        {
            return View();
        }

        public IActionResult Show()
        {
            
            using StuDBContext db = new StuDBContext();

            Student[] stuArray = db.Students.ToArray<Student>();


            return View(stuArray);
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }






        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}