using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
namespace MarisolSpecFlow.Features
{
    [Binding]
    public class EnfermeroSteps
    {
        IWebDriver driver;

        [Given(@"que ingreso al sitioo web")]
        public void DadoQueIngresoAlSitiooWeb()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://localhost:44378/");
        }

        [When(@"cuando registro el nombre usuario ""(.*)""")]
        public void CuandoCuandoRegistroElNombreUsuario(string nombre)
        {

            //Espera de 5 segs
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //Write username
            driver.FindElement(By.Name("txtNombre")).SendKeys(nombre);

        }
        [When(@"cuando registro del apellido usuario ""(.*)""")]
        public void CuandoCuandoRegistroDelApellidoUsuario(string apellido)
        {
            //Espera de 5 segs
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //Write username
            driver.FindElement(By.Name("txtApellido")).SendKeys(apellido);
        }


        [When(@"la cedula ""(.*)""")]
        public void CuandoLaCedula(string cedula)
        {
            //Espera de 5 segs
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //Write username
            driver.FindElement(By.Name("txtCedula")).SendKeys(cedula);
            //Logic secuence
        }

        [When(@"hospital de trabajo  ""(.*)""")]
        public void CuandoHospitalDeTrabajo(string LugTrabajo)
        {
            //Espera de 5 segs
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //Write username
            driver.FindElement(By.Name("txtLugTrabajo")).SendKeys(LugTrabajo);
            //Logic secuence
        }


        [When(@"salario es  (.*)")]
        public void CuandoSalarioEs(string salario)
        {
            //Espera de 5 segs
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //Write username
            driver.FindElement(By.Name("txtHoras")).SendKeys(salario + Keys.Enter);
        }


        [Then(@"mustra un mesaje se registró")]
        public void EntoncesMustraUnMesajeSeRegistro(string esperado)
        {
            var respuesta = driver.FindElement(By.Name("respuesta")).Text;
            Assert.AreEqual(esperado, respuesta);

        }
    }
}

