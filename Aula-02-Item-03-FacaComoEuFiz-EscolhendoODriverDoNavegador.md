Nesta aula vimos como criar e fazer a configuração inicial do projeto de teste com xUnit e o Selenium WebDriver. Estamos usando o Chrome como nosso navegador de homologação, mas  podemos ter como requisito escrever um teste automatizado que rode em outros navegadores. Quais temos disponíveis? Como adiciono a biblioteca para o Internet Explorer? Como criar um teste acessando o site do MusicDot?



O Selenium WebDriver está disponível não somente para o Chrome ou Mozilla FireFox. Para sabermos quais outras opções temos, podemos fazer uma pesquisa no repositório do Nuget via linha de comando ou interface gráfica:
  

![alt text: A imagem mostra o gerenciador de pacotes do NuGet, onde no campo procurar foi informando o texto “selenium” e exibindo uma listagem com as bibliotecas disponíveis inclusive de outros navegadores como o Firefox e Internet Explorer.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/02/aula2-img1.png)
Escolhido o navegador, basta instalar e escrever o teste para ele:
  

![alt text: A imagem mostra o gerenciador de pacotes do NuGet, a opção de instalação do Selenium WebDriver para o Internet Explorer.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/02/aula2-img2.png)

Podemos escrever um código de teste utilizando a biblioteca do Internet Explorer, com as devidas configurações, vide documentação:

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

Para se aprofundar mais sobre a biblioteca Selenium WebDriver para IE, consulte a documentação:

- [Documentação Selenium WebDriver](https://www.selenium.dev/documentation/ie_driver_server/)