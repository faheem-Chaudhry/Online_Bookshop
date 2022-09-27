using Microsoft.AspNetCore.Mvc;
using EAD_project.Models;
using Microsoft.AspNetCore.Http;

namespace EAD_project.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ViewResult login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult login(Login L)
        {
            LoginRepository loginRepository = new LoginRepository();
            loginRepository.login(L);
            if (loginRepository.login(L))
            {
                
                CookieOptions option = new CookieOptions();
                HttpContext.Response.Cookies.Append("first_request", L.Username);
                

                // FetchData();      //function call
                //
                //return View("Home/Home");
                return RedirectToAction("home", "Home");


            }
            else
            {
                return View();
            }

        }
    }
}
