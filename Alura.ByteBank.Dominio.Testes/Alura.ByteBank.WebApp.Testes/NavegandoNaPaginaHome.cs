using OpenQA.Selenium;
using System.IO;
using System.Reflection;
using Xunit;



namespace Alura.ByteBank.WebApp.Testes
{

    public class NavegandoNaPaginaHome
    {
        [Fact]
        public void CarregaPaginaHomeÈVerificaTituloDaPagina()
        {
            //Arrange
            IWebDriver driver = new ChromeDriver(
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            //Act

            //Assert
        }

    }
}
