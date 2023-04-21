using DemoBTW3.Controllers;
using DemoBTW3.Models;
using Microsoft.AspNetCore.Mvc;

namespace TestProjectBTW3
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task MultiplicarDosNumero()
        {

            var controlador = new CalculadoraController();

            var modelo = new CalculadoraViewModel();

            modelo.Numero1 = 1;
            modelo.Numero2 = 5;
            modelo.Operacion = "+";

            var respuesta = await controlador.Enter(modelo);



            var respuesta3 = (CalculadoraViewModel)(((ViewResult)respuesta).Model);

            Assert.That(respuesta3.Resultado, Is.EqualTo(6));
        }

        [Test]
        public async Task ExponenteNumeros098701()
        {

            var controlador = new CalculadoraController();

            var modelo = new CalculadoraViewModel();

            modelo.Numero1= 4;
            modelo.Numero2 = 2;
            {
                modelo.Operacion = "^";

                var respuesta = await controlador.Enter(modelo);

                var respuesta3 = (CalculadoraViewModel)(((ViewResult)respuesta).Model);

                Assert.That(respuesta3.Resultado, Is.EqualTo(16));

            }
        }
    }
}