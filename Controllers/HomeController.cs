using FirstHomework_INCI_KILIC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstHomework_INCI_KILIC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //LoginForm'a ait action tanımlanıyor.
        //Yine aynı isimle Views/Home altında LoginForm.cshtml bulunmaktadır.
        public IActionResult LoginForm()
        {
            //return View();
            var user = new UserViewModel
            {

            };

            return View(user);
        }


        //API, method post, sunucuya veri gönderimi için kullanıyoruz.
        //Parametre olarak UserViewModel'den bir model alıyoruz.
        //İşlemlerimizin başarı durumlarına ait dönüşler yapılıyor.
        //İşlem başarılı ise Data = "Giriş işlemi başarılı", Success = true,  Error = "Null"
        //İşlem başarılı değil ise Data = "Null", Success = false,  Error = "Hatalı giriş"

        [HttpPost]
        public IActionResult LoginForm(UserViewModel model)
        {
            var user = new ResponseViewModel
            {
                Data = "Giriş işlemi başarılı",
                Success = true,
                Error = "Null"

            };
            if (!ModelState.IsValid) //null değerler olması durumunda hata verecek 
            {
                var user2 = new ResponseViewModel
                {
                    Data = "Null",
                    Success = false,
                    Error = "Hatalı giriş"

                };

                ViewData["message"] = "<div class='alert alert-danger col-sm-6 ml-3 mt-5'>" + "Data :" + user2.Data + ", Success: " + user2.Success + ", Error: " + user2.Error + "</div>";



                return View();
            }
            ViewData["message"] = "<div class='alert alert-success col-sm-6 ml-3 mt-5'>" + "Data :" + user.Data + ", Success: " + user.Success + ", Error: " + user.Error + "</div>";
            return View(model);
        }
     

        public IActionResult Index()
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
