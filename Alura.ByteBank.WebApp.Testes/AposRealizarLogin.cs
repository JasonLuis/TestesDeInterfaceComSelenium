using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using Xunit;

namespace Alura.ByteBank.WebApp.Testes
{

    public class AposRealizarLogin
    {

        private IWebDriver driver;

        public AposRealizarLogin()
        {
            this.driver = new ChromeDriver(Path.GetDirectoryName(
                Assembly.GetExecutingAssembly().Location));
        }

        [Fact]
        public void AposRealiarLoginVerificarSeExisteOpcaoAgenciaMenu()
        {
            //Arrange
           driver.Navigate().GoToUrl("https://localhost:44309/UsuarioApps/Login");
            var login = driver.FindElement(By.Id("Email"));
            var senha = driver.FindElement(By.Id("Senha"));
            var btnLogar = driver.FindElement(By.Id("btn-logar"));

            login.SendKeys("andre@email.com");
            senha.SendKeys("senha01");

            //Act - Faz o Login
            btnLogar.Click();

            //Assert
            Assert.Contains("Agência", driver.PageSource);

        }

        [Fact]
        public void TentaRealizarLoginSemPreencherCampos()
        {
            //Arrange
            driver.Navigate().GoToUrl("https://localhost:44309/UsuarioApps/Login");
            var login = driver.FindElement(By.Id("Email"));
            var senha = driver.FindElement(By.Id("Senha"));
            var btnLogar = driver.FindElement(By.Id("btn-logar"));

            //login.SendKeys("andre@email.com");
            //senha.SendKeys("senha01");

            //Act - Faz o Login
            btnLogar.Click();

            //Assert
            Assert.Contains("The Email field is required.", driver.PageSource);
            Assert.Contains("The Senha field is required.", driver.PageSource);

        }

        [Fact]
        public void TentandoAcessarPaginaAgenciaSemEstarLogado()
        {
            //Arrange
            //Act
            driver.Navigate().GoToUrl("https://localhost:44309/Agencia/Index");

            //Assert
            Assert.Contains("401", driver.PageSource);
        }

        [Fact]
        public void AcessarPaginaSemEstarLogadoVerificaURL()
        {
            //Arrange
            //Act
            driver.Navigate().GoToUrl("https://localhost:44309/Agencia/Index");

            //Assert
            Assert.Contains("https://localhost:44309/Agencia/Index", driver.Url);
            Assert.Contains("401", driver.PageSource);
        }

        [Fact]
        public void TentandoAcessarPaginaClientesSemEstarLogado()
        {
            //Arrange
            //Act
            driver.Navigate().GoToUrl("https://localhost:44309/Clientes/Index");

            //Assert
            Assert.Contains("401", driver.PageSource);
        }

    }
}
