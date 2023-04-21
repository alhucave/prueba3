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
                    switch (model.Operacion)
                    {
                        case "+":
                            model.Resultado = model.Numero1 + model.Numero2;
                            break;
                        case "^":
                            model.Resultado = Convert.ToInt32(Math.Pow(Convert.ToDouble(model.Numero1), Convert.ToDouble(model.Numero2)));
                            break;
                    }

                }
                catch (Exception)
                {

                }
            }

            return View(model);
        }
    }
}
