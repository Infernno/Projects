using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/gallery")]
        public IActionResult Gallery()
        {
            var gallery = new Gallery("Породы собак");

            gallery.Images.Add(new Image("Хаски", "https://bigpicture.ru/wp-content/uploads/2016/09/husky-main.jpg"));
            gallery.Images.Add(new Image("Английский бульдог", "https://www.pedigree.ru/photos/Breed_615/179c9454-efeb-47b2-a36c-e97cb04def49.jpeg"));
            gallery.Images.Add(new Image("Лабрадор-ретривер", "https://doggiedog.ru/wp-content/uploads/2016/11/Labrador-Retriever-head-wallpaper-1.jpg"));
            gallery.Images.Add(new Image("Бигль", "http://mybarbos.com/wp-content/uploads/2015/12/16-bigl.jpg"));
            gallery.Images.Add(new Image("Антон", "https://pp.userapi.com/c845216/v845216954/15755c/kr4nB7w0sbE.jpg"));

            return Json(gallery);
        }
    }
}
