using Microsoft.AspNetCore.Mvc;

namespace Apetrei_Alexandru_Lab1.Controllers
{
    public class DemoController : Controller
    {
        // Rulare la /hello
        [Route("hello")]
        public string Hello() => "Salut!";

        // Rulare la /hello/Nume
        [HttpGet("hello/{name}")]
        public string HelloByName(string name) => $"Salut, {name}!";

        // Rulare la /calc/a/b (numere întregi)
        [HttpGet("calc/{a:int}/{b:int}")]
        public string Calculate(int a, int b) => $"Suma este: {a + b}";
    }
}
