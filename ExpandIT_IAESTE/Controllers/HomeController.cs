using System.Web.Mvc;

namespace ExpandIT_IAESTE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FizzBuzz()
        {
            ViewBag.Message = "Write a program that prints the numbers from 1 to 100. But for multiples of three print \"Fizz\" instead of the number and for the multiples of five print \"Buzz\". For numbers which are multiples of both three and five print \"FizzBuzz\".";

            return View();
        }
    }
}