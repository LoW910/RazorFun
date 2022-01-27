using Microsoft.AspNetCore.Mvc;

namespace RazorFun.Controllers
{
    public class HomeController : Controller{
        [HttpGet("")]
        public ViewResult Index(){
            return View();
        }

        [HttpGet("{favoriteResponse}")]
        public IActionResult ItDepends(string favoriteResponse){
            if(favoriteResponse == "Redirect"){
                return RedirectToAction("index");
            }
            else if(favoriteResponse == "Json"){
                return Json(new {FavoriteResponse = favoriteResponse});
            }
            return View();
        }



        [HttpGet("viewBag")]
        public IActionResult LearnViewBag(){
            ViewBag.hiWorld = "Hello World";
            ViewBag.para = "Both passed through ViewBag!";
            return View();
        }
    }
}