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

            var respuesta =  await controlador.Enter(modelo);

            

            var respuesta3 = (CalculadoraViewModel)(((ViewResult)respuesta).Model);

            Assert.That(respuesta3.Resultado,Is.EqualTo(6));
        }

        [Test]
        public async Task MultiplicarDosNumero2() 
        {

            var controlador = new CalculadoraController();

            var modelo = new CalculadoraViewModel();

            modelo.Numero1 = 2;
            modelo.Numero2 = 3;
            modelo.Operacion = "^";

            var respuesta = await controlador.Enter(modelo);

            var respuestaModelo = (CalculadoraViewModel)(((ViewResult)respuesta).Model);

            Assert.That(respuestaModelo.Resultado, Is.EqualTo(8));

        }
    }
}