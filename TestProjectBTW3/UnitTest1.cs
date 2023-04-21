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
        public async Task Dividir_Diego()
        {
            CalculadoraController controlador = new CalculadoraController();
            CalculadoraViewModel modelo = new CalculadoraViewModel();
            modelo.Numero1 = 8;
            modelo.Numero2 = 2;
            modelo.Operacion = "/";
            var respuesta = await controlador.Enter(modelo);
            var resultado = (((ViewResult)respuesta).Model) as CalculadoraViewModel;
            Assert.That(resultado?.Resultado, Is.EqualTo(4));
        }



        [Test]
        public async Task PromedioDosNumeros_Jordan()
        {

            var controlador = new CalculadoraController();

            var modelo = new CalculadoraViewModel();

            modelo.Numero1 = 1;
            modelo.Numero2 = 5;
            modelo.Operacion = "promedio";

            var respuesta = await controlador.Enter(modelo);



            var resultado = (CalculadoraViewModel)(((ViewResult)respuesta).Model);

            Assert.That(resultado.Resultado, Is.EqualTo(3));
        }
    }
}