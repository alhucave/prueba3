using DemoBTW3.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoBTW3.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Enter(CalculadoraViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if(Convert.ToChar(model.Operacion)=='+')
                        model.Resultado = model.Numero1 + model.Numero2;
                    if(Convert.ToChar(model.Operacion)=='-')
                        model.Resultado = model.Numero1 - model.Numero2;

                }
                catch (Exception)
                {

                }
            }

            return View(model);
        }
    }
}
