using System.Collections.Generic;
using System.Web.Mvc;
using Calculator.twoOperandsFunctionality;

namespace CalculatorWebInterfase.Controllers
{
    public class HomeController : Controller
    {
        private List<SelectListItem> operations = new List<SelectListItem>()
        {
            new SelectListItem()
            {
                Text = "+", Value = "+"
            },new SelectListItem()
            {
                Text = "-", Value = "-"
            },new SelectListItem()
            {
                Text = "*", Value = "*"
            },new SelectListItem()
            {
                Text = "/", Value = "/"
            },new SelectListItem()
            {
                Text = "x^y", Value = "x^y"
            }
        };

        [HttpPost]
        public ActionResult Index(double firstNumber, double secondNumber, string operation)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsCalculatorFactory.CreateCalculator(operation);
            ViewBag.result = calculator.Calculate(firstNumber, secondNumber);
            ViewBag.operations = operations;
            return View();
        }

        public ActionResult Index()
        {
            ViewBag.operations = operations;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}