using Microsoft.AspNetCore.Mvc;

namespace MvcCalculatorApp.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Add(int a, int b)
        {
            int result = a + b;
            return Content($"Add Result: {result}");
        }

        public IActionResult Subtract(int a, int b)
        {
            int result = a - b;
            return Content($"Subtract Result: {result}");
        }

        public IActionResult Multiply(int a, int b)
        {
            int result = a * b;
            return Content($"Multiply Result: {result}");
        }

        public IActionResult Divide(int a, int b)
        {
            if (b == 0)
                return Content("Cannot divide by zero");

            int result = a / b;
            return Content($"Divide Result: {result}");
        }
    }
}