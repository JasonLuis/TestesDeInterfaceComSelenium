using Alura.ByteBank.WebApp.Testes.PageObjects;
using Alura.ByteBank.WebApp.Testes.Utilitarios;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Xunit;
using Xunit.Abstractions;

namespace Alura.ByteBank.WebApp.Testes
{

    public class AposRealizarLogin:IClassFixture<Gerenciador>
    {
        private IWebDriver driver;
        public ITestOutputHelper SaidaConsoleTeste;

        public AposRealizarLogin(Gerenciador gerenciador, ITestOutputHelper _saidaConsoleTeste)
        {
            //this.driver = new ChromeDriver(Path.GetDirectoryName(
            //    Assembly.GetExecutingAssembly().Location));

            //SaidaConsoleTeste = _saidaConsoleTeste;

            driver = gerenciador.Driver;
        }

        [Fact]
        public void AposRealiarLoginVerificarSeExisteOpcaoAgenciaMenu()
        {
            // //Arrange
            //driver.Navigate().GoToUrl("https://localhost:44309/UsuarioApps/Login");
            // var login = driver.FindElement(By.Id("Email"));
            // var senha = driver.FindElement(By.Id("Senha"));
            // var btnLogar = driver.FindElement(By.Id("btn-logar"));

            // login.SendKeys("andre@email.com");
            // senha.SendKeys("senha01");

            // //Act - Faz o Login
            // btnLogar.Click();

            //Arrange
            var loginPO = new LoginPO(driver);
            loginPO.Navegar("https://localhost:44309/UsuarioApps/Login");

            //Act
            loginPO.PreencherCampos("andre@email.com", "senha01");
            loginPO.Logar();

            //Assert
            Assert.Contains("Agência", driver.PageSource);

        }

        [Fact]
        public void TentaRealizarLoginSemPreencherCampos()
        {
            ////Arrange
            //driver.Navigate().GoToUrl("https://localhost:44309/UsuarioApps/Login");
            //var login = driver.FindElement(By.Id("Email"));
            //var senha = driver.FindElement(By.Id("Senha"));
            //var btnLogar = driver.FindElement(By.Id("btn-logar"));
            ////login.SendKeys("andre@email.com");
            ////senha.SendKeys("senha01");

            ////Act - Faz o Login
            //btnLogar.Click();

            //Arrange
            var loginPO = new LoginPO(driver);
            loginPO.Navegar("https://localhost:44309/UsuarioApps/Login");

            //Act
            loginPO.PreencherCampos("", "");
            loginPO.Logar();

            //Assert
            Assert.Contains("The Email field is required.", driver.PageSource);
            Assert.Contains("The Senha field is required.", driver.PageSource);

        }

        [Fact]
        public void TentaRealizarLoginComSenhaInvalida()
        {
            //Arrange          
            //driver.Navigate().GoToUrl("https://localhost:44309/UsuarioApps/Login");
            //var login = driver.FindElement(By.Id("Email"));//Selecionar elementos do HTML
            //var senha = driver.FindElement(By.Id("Senha"));//Selecionar elementos do HTML
            //var btnLogar = driver.FindElement(By.Id("btn-logar"));//Selecionar elementos do HTML

            //login.SendKeys("andre@email.com");
            //senha.SendKeys("senha010");//senha inválida.

            ////act - Faz o login
            //btnLogar.Click();

            ////Assert
            //Assert.Contains("Login", driver.PageSource);

            //Arrange
            var loginPO = new LoginPO(driver);
            loginPO.Navegar("https://localhost:44309/UsuarioApps/Login");

            //Act
            loginPO.PreencherCampos("andre@email.com", "senha01x");
            loginPO.Logar();

            //Assert
            Assert.Contains("Login", driver.PageSource);
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

        [Fact]
        public void RealizaLoginAcessaMenuECadastraCliente()
        {
            //Arrange
            //driver.Navigate().GoToUrl("https://localhost:44309/UsuarioApps/Login");

            //var login = driver.FindElement(By.Name("Email"));
            //var senha = driver.FindElement(By.Name("Senha"));

            //login.SendKeys("andre@email.com");
            //senha.SendKeys("senha01");

            //driver.FindElement(By.Id("btn-logar")).Click();

            var loginPO = new LoginPO(driver);
            loginPO.Navegar("https://localhost:44309/UsuarioApps/Login");


            //Act
            loginPO.PreencherCampos("andre@email.com", "senha01");
            loginPO.Logar();

            driver.FindElement(By.LinkText("Cliente")).Click();

            driver.FindElement(By.LinkText("Adicionar Cliente")).Click();

            driver.FindElement(By.Name("Identificador")).Click();
            driver.FindElement(By.Name("Identificador")).SendKeys("531e5270-8a80-4a2c-8b20-f10182f728fc");
            driver.FindElement(By.Name("CPF")).Click();
            driver.FindElement(By.Name("CPF")).SendKeys("307.522.040-09");
            driver.FindElement(By.Name("Nome")).Click();            
            driver.FindElement(By.Name("Nome")).SendKeys("André Silva");
            driver.FindElement(By.Name("Profissao")).Click();
            driver.FindElement(By.Name("Profissao")).SendKeys("Developer");

            driver.FindElement(By.CssSelector(".btn-primary")).Click();
            driver.FindElement(By.LinkText("Home")).Click();

            //Assert
            Assert.Contains("Logout", driver.PageSource);
        }

        [Fact]
        public void RealizarLoginAcessaListagemDeContas()
        {
            //Arrange
            //driver.Navigate().GoToUrl("https://localhost:44309/UsuarioApps/Login");
            //var login = driver.FindElement(By.Name("Email"));
            //var senha = driver.FindElement(By.Name("Senha"));
            //login.SendKeys("andre@email.com");
            //senha.SendKeys("senha01");
            //driver.FindElement(By.Id("btn-logar")).Click();

            var loginPO = new LoginPO(driver);
            loginPO.Navegar("https://localhost:44309/UsuarioApps/Login");
            loginPO.PreencherCampos("andre@email.com", "senha01");
            loginPO.Logar();

            //Conta Corrente
            driver.FindElement(By.Id("contacorrente")).Click();

            IReadOnlyCollection<IWebElement> elements = 
                driver.FindElements(By.TagName("a"));

            var element = (from webElemento in elements
                           where webElemento.Text.Contains("Detalhes")
                           select webElemento).First();

            //Act
            element.Click();

           //Assert
           Assert.Contains("Voltar", driver.PageSource);
        }

        [Fact]
        public void RealizarLoginAcessaListagemDeContasUsandoHomePO()
        {
            //Arrange
            var loginPO = new LoginPO(driver);
            loginPO.Navegar("https://localhost:44309/UsuarioApps/Login");
            
            //Act
            loginPO.PreencherCampos("andre@email.com", "senha01");
            loginPO.Logar();
            
            var homePO = new HomePO(driver);
            homePO.LinkContaCorrenteClick();

            //Assert
            Assert.Contains("Adicionar Conta-Corrente", driver.PageSource);
        }
    }
}
