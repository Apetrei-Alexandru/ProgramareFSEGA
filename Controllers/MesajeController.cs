using Microsoft.AspNetCore.Mvc;

namespace Apetrei_Alexandru_Lab1.Controllers
{
    // Toate metodele vor fi accesibile direct fără prefixul controller-ului
    [Route("")]
    public class MesajeController : Controller
    {
        // Index va fi accesibil la / sau /Index
        [Route("")]
        [Route("Index")]
        public string Index()
        {
            return "Bine ai venit, utilizator!";
        }

        // Salut va fi accesibil la /Salut
        [Route("Salut")]
        public string Salut()
        {
            return "Salut, utilizator! Sper că ai o zi minunată!";
        }

        // AfisareDate va fi accesibil la /AfisareDate?nume=Alex&varsta=25
        [Route("AfisareDate")]
        public string AfisareDate(string nume, int varsta)
        {
            return $"Salut {nume}, ai {varsta} ani!";
        }
    }
}
