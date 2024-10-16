[00:00] Continuando, já temos o nosso projeto de testes para testar o Web App do Alura Byte Bank e já configuramos as bibliotecas necessárias. Estou no gerenciador de soluções, no projeto de testes, segui o “WebApp > Pacotes”. Configuramos o Selenium WebDriver, nossa biblioteca, e o “SeleniumWebDriver.ChromeDriver”.

[00:26] Vamos trabalhar com o navegador de teste, para homologação do nosso projeto, o Chrome. Agora vamos criar o nosso primeiro teste usando o Selenium. Nosso primeiro código.

[00:39] O que vou começar fazendo? Vamos criar uma nova classe de testes, vou excluir essa classe “UnitTest”, que foi criada automaticamente quando nós criamos o projeto. 

[00:52] Clico em cima da classe “UnitTest” com o botão direito, clico “Excluir”, foi removido o projeto. Agora, no nosso projeto, clica com o botão direito em cima do “Alura.ByteBank.WebApp.Testes”, vou em “Adicionar > Nova classe”. 

[01:12] Essa classe vai se chamar “NavengandoNaPaginaHome”. Quero testar, usando o WebDriver, alguns elementos da página *home* da nossa aplicação. Vou clicar em "Adicionar" no final da janela aberta. já criou a classe no menu de solução.

[01:32] Essa classe tem que ser marcada como `public` no código. Agora vou criar o nosso primeiro método de teste. Já tenho ele copiado e vou só dar um “Ctrl + C” e “Ctrl + V”, um recurso muito importante para os programadores. Vamos fazer uma análise. 

[01:54] Esse é o primeiro método, estou usando xUnit, só para relembrar, tenho que anotar o código como `[Fact]`, estou importando as bibliotecas agora no nosso projeto. 

[02:11] Importei o xUnit, como mostra as primeiras linhas, onde está escrito `using Xunit`. Olha só, estão marcados em vermelho, no código, alguns pontos. O `WebDriver`, onde eu crio um `driver`, o `ChromeDriver`, o `Path` e o `Assembly`. 

[02:32] Primeiro, estou criando esse código de teste usando o padrão de escrita de método de teste, usando o `Arrange`, que é a preparação do cenário para o teste, ou seja, preciso de uma variável ou de um objeto, é no `Arrange` que eu faço isso. 

[02:45] Tenho um `Act`, que é o método sobre teste, e o `Assert`, que é a validação, se o resultado esperado está de acordo com o obtido. Eu preciso criar uma instância do WebDriver, que é a biblioteca do Selenium. 

[03:05] Farei uma exportação, clicando com o botão direito em cima do que está sendo destacado em vermelho no código, ou posso clicar na lâmpada do lado esquerdo. Clico em “using OpenQA.Selenium”, vamos exportar essa biblioteca e já corrigiu o erro que estava no meu código.

[03:30] Agora eu tenho que importar também a biblioteca referente ao ChromeDriver. Posso apertar o “Ctrl + .” também em cima do vermelho que está destacado, e clicar em “using OpenQA.Selenium.Chrome”. Importei essa biblioteca.

[03:50] Para eu importar a biblioteca do ChromeDriver, eu preciso saber onde a DLL foi instalada no meu projeto. Como faço isso? Preciso identificar, no meu projeto, onde está a DLL do Chrome para eu poder fazer essa importação e, na hora que eu rodar o teste, acessar os recursos dessa DLL e acessar o Chrome na minha aplicação. 

[04:12] Então, como vamos fazer isso? Deixa eu só mostrar primeiro para vocês. Estou dentro do projeto da aula 2 “AluraByteBank > AluraByteBank.WebApp.Testes > bin > Dbug > .net5.0”. 

[04:29] Aqui dentro eu tenho o “chromedriver.exe”, é esse executável, eu falei DLL, perdão, que eu preciso reconhecer dentro do código para poder testar.

[04:43] Vou usar o recurso do próprio .NET. Vou na classe `Path`, onde tem a mensagem “Não existe referência no contexto atual”, então eu preciso importar essa biblioteca também. Botão direito em `Path` ou “Ctrl + .”. Vou apertar a lâmpada no lado esquerdo, “Ações rápidas > using System.IO”, corrigi o erro do `path`. Agora o `Assembly`.

[05:06] Botão direito no `Assembly`, “Ctrl + .”, “using System.Reflection”. Esse código, quando eu passo para o construtor do ChromeDriver, vai reconhecer onde está o “chromedriver.exe” para poder fazer os testes, escrever e acessar o aplicativo do Chrome na minha máquina.

[05:30] No `Act`, usando a instancia do `driver`, vou usar o método `Navigate()` e vou falar para qual URL tem que navegar. `GoToUrl`, vai navegar para a URL `logalhost:44309`, que é a minha aplicação.

[05:47] Vou rodar a aplicação usando o Visual Studio. Na parte superior, vou clicar em “Play”, ele vai subir o servidor “IIS Express” e vai rodar a aplicação. Está carregando, olha só, a porta que é a URL que eu quero testar a “localhost:44309”.

[06:14] Fechei a janela que abriu, só que agora eu preciso testar esse código. Fechei o navegador, vou parar de rodar aqui. Percebam o seguinte, vou rodar a aplicação e começar a testar.

[06:26] No gerenciador de teste, no lado esquerdo, vou fixá-lo para permanecer aberto, vou abrir o projeto de teste do Alura ByteBank, esse último, só tem um teste, “NavegandoNaPagina”, eu tenho um método de teste, que é o “CarregaPaginaHomeEVerificaOTitulodaPagina”. A partir do momento que carregar o `WebDriver` e navegar para essa URL, eu quero verificar se, no título da minha página, eu consigo encontrar o texto `WebApp`. 

[07:06] Vou sondar a aplicação para verificarmos se tem isso no título da página. Está rodando a aplicação, vai demorar um pouco na máquina. Carregou. Então, aqui no título da página tem “WebApp”. Estou passando o mouse em cima, na parte superior do navegador, “Alura.ByteBank.WebApp”, contém esse texto lá.

[07:34] Vou testar agora, fechei o navegador e vou rodar para testar. Vou executar o meu teste. No gerenciador de testes, clicar em “Executar” em cima do teste “CarregaPaginaHomeEVerificaOTituloDaPagina”.

[07:53] Executei. Tive um problema, olha só, ele não conseguiu reconhecer o meu navegador. Por quê? Eu estava rodando dentro da aplicação e falhou o meu teste. Vai dar erro mesmo se eu tentar executar o teste assim. Por quê?

[08:10] Quando eu clico no “Play” dentro do Visual Studio, ele carrega para uma instância do IIS Expresse, carrega a minha aplicação. Como eu fechei a aplicação e rodei por aqui, não vou conseguir, porque não está encontrando o IIS para fazer o teste da URL.

[08:29] Então, o que eu tenho que fazer? Eu tenho que startar primeiro o meu servidor. Uma dica é usar o “Ctrl + F5”. Dentro do Visual Studio, vou apertar “Ctrl + F5”, e o que vai acontecer?

[08:44] O Visual Studio vai startar uma instância IIS Express, que aparece na barra inferior da janela, e já rodar a minha aplicação. Dessa maneira, eu posso fechar o navegador. Note que o Visual Studio não está em modo de execução.

[09:06] Mas se você reparar na barra inferior do seu navegador, eu vou ter os IIS Express rodando. O que vai acontecer agora com esse teste? Eu vou abrir o navegador do Chrome nessa URL e verificar se encontro o “WebApp”.

[09:26] Botão direito para simular o teste e vou clicar em “Executar”. Encontrou a aplicação, abriu, tinha que fazer isso mesmo. Meu teste passou agora, ele carregou o navegador nessa URL usando a biblioteca como `driver` , e encontrou, no título da minha página, o texto “WebApp”.

[09:52] Vamos fazer mais um teste com a mesma lógica, trabalhando a página “Home” da aplicação. Vou criar um novo teste. Eu quero carregar “CarregaPaginaHomeEVerificaSeExisteOLinkLoginEHome”.

[10:15] Vou seguir o mesmo conceito, usando o padrão de escrita `Arrange`, `Act` e `Assert` . Aqui nós temos o `IWebDriver driver`, porque a partir dessa instância eu tenho uma série de métodos disponíveis para poder trabalhar com essa interface web da aplicação.

[10:29] Vou navegar para a mesma URL, só que agora, do `driver`. Eu quero encontrar no código-fonte da página, no *page source*, o texto `Login` e o texto `Home`.

[10:46] Deixa só eu apagar rapidamente, tenho disponível “URL”, “PageSource”, “Title”, procurar elemento, navegar para um link, fechar a página, enfim, eu tenho uma série de recursos disponíveis no WebDriver. 

[11:05] Vamos rodar o teste. Ele tem que abrir o Chrome, navegar para a sua URL e encontrar no corpo da página do `Login` e o `Home`. Percebam bem que, no Visual Studio, no gerenciador de testes, já carregou um novo teste.

[11:19] Então, carregar a página “Home” e verificar a existência do *link* “Login” e “Home”. Clica com o botão direito em “CarregaPaginaHomeEVerificaSeExisteOLinkLoginEHome”, clica em "Executar" e vou executar meu teste. Pode demorar um pouco. 

[11:32] Meu teste passou. Perceba bem, ele chegou no final, no `Assert`, onde ele verifica que realmente encontrou no código-fonte da página o texto “Login” e o texto “Home”. 

[11:46] Esses foram os primeiros testes que criamos usando a biblioteca WebDriver. Já fizemos a configuração dela, já criamos uma instância. Precisamos criar uma instância dela, que é o *arrange*.

[11:56] Utilizamos métodos de navegação para encontrar a URL que queremos testar, e usamos *assert*, que verifica alguns elementos da página, como título, ou até no próprio corpo, no código-fonte da página.

[12:06] Na sequência, vamos continuar evoluindo nossos testes de interface usando a biblioteca Selenium WebDriver e o Chrome como nosso navegador para homologação desses testes.