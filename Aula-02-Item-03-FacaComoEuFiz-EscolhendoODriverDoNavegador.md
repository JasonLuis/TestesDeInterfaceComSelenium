Nesta aula vimos como criar e fazer a configura��o inicial do projeto de teste com xUnit e o Selenium WebDriver. Estamos usando o Chrome como nosso navegador de homologa��o, mas  podemos ter como requisito escrever um teste automatizado que rode em outros navegadores. Quais temos dispon�veis? Como adiciono a biblioteca para o Internet Explorer? Como criar um teste acessando o site do MusicDot?



O Selenium WebDriver est� dispon�vel n�o somente para o Chrome ou Mozilla FireFox. Para sabermos quais outras op��es temos, podemos fazer uma pesquisa no reposit�rio do Nuget via linha de comando ou interface gr�fica:
  

![alt text: A imagem mostra o gerenciador de pacotes do NuGet, onde no campo procurar foi informando o texto �selenium� e exibindo uma listagem com as bibliotecas dispon�veis inclusive de outros navegadores como o Firefox e Internet Explorer.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/02/aula2-img1.png)
Escolhido o navegador, basta instalar e escrever o teste para ele:
  

![alt text: A imagem mostra o gerenciador de pacotes do NuGet, a op��o de instala��o do Selenium WebDriver para o Internet Explorer.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/02/aula2-img2.png)

Podemos escrever um c�digo de teste utilizando a biblioteca do Internet Explorer, com as devidas configura��es, vide documenta��o:

```
        [Fact]
        public void AcessandoPaginaDaMusicDot()
        {
            //Arrange
            InternetExplorerOptions options = new InternetExplorerOptions()
            {
                                IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                IgnoreZoomLevel = true,
                EnableNativeEvents = false
            };
            IWebDriver driver = new InternetExplorerDriver(Path.GetDirectoryName(
                Assembly.GetExecutingAssembly().Location), options);
           
            //Act
            driver.Navigate().GoToUrl("https://www.musicdot.com.br/");
            
           //Assert
            Assert.Contains("Music", driver.Title);

        }

```

Para se aprofundar mais sobre a biblioteca Selenium WebDriver para IE, consulte a documenta��o:

- [Documenta��o Selenium WebDriver](https://www.selenium.dev/documentation/ie_driver_server/)