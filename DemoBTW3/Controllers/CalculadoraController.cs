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
                    if (model.Operacion == "promedio")
                        model.Resultado = (model.Numero1 + model.Numero2) / 2;
                    else if (model.Operacion == "^")
                        model.Resultado = Convert.ToInt32(Math.Pow(model.Numero1, model.Numero2));
                    else if (model.Operacion == "+")
                        model.Resultado = model.Numero1 + model.Numero2;

                    if (model.Operacion == "^")
                        model.Resultado = Convert.ToInt32(Math.Pow(model.Numero1, model.Numero2));
                }
                catch (Exception ex)
                {

                }
            }


            return View(model);
        }
    }
}
