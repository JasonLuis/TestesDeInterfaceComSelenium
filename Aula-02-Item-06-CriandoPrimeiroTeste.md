[00:00] Continuando, j� temos o nosso projeto de testes para testar o Web App do Alura Byte Bank e j� configuramos as bibliotecas necess�rias. Estou no gerenciador de solu��es, no projeto de testes, segui o �WebApp > Pacotes�. Configuramos o Selenium WebDriver, nossa biblioteca, e o �SeleniumWebDriver.ChromeDriver�.

[00:26] Vamos trabalhar com o navegador de teste, para homologa��o do nosso projeto, o Chrome. Agora vamos criar o nosso primeiro teste usando o Selenium. Nosso primeiro c�digo.

[00:39] O que vou come�ar fazendo? Vamos criar uma nova classe de testes, vou excluir essa classe �UnitTest�, que foi criada automaticamente quando n�s criamos o projeto. 

[00:52] Clico em cima da classe �UnitTest� com o bot�o direito, clico �Excluir�, foi removido o projeto. Agora, no nosso projeto, clica com o bot�o direito em cima do �Alura.ByteBank.WebApp.Testes�, vou em �Adicionar > Nova classe�. 

[01:12] Essa classe vai se chamar �NavengandoNaPaginaHome�. Quero testar, usando o WebDriver, alguns elementos da p�gina *home* da nossa aplica��o. Vou clicar em "Adicionar" no final da janela aberta. j� criou a classe no menu de solu��o.

[01:32] Essa classe tem que ser marcada como `public` no c�digo. Agora vou criar o nosso primeiro m�todo de teste. J� tenho ele copiado e vou s� dar um �Ctrl + C� e �Ctrl + V�, um recurso muito importante para os programadores. Vamos fazer uma an�lise. 

[01:54] Esse � o primeiro m�todo, estou usando xUnit, s� para relembrar, tenho que anotar o c�digo como `[Fact]`, estou importando as bibliotecas agora no nosso projeto. 

[02:11] Importei o xUnit, como mostra as primeiras linhas, onde est� escrito `using Xunit`. Olha s�, est�o marcados em vermelho, no c�digo, alguns pontos. O `WebDriver`, onde eu crio um `driver`, o `ChromeDriver`, o `Path` e o `Assembly`. 

[02:32] Primeiro, estou criando esse c�digo de teste usando o padr�o de escrita de m�todo de teste, usando o `Arrange`, que � a prepara��o do cen�rio para o teste, ou seja, preciso de uma vari�vel ou de um objeto, � no `Arrange` que eu fa�o isso. 

[02:45] Tenho um `Act`, que � o m�todo sobre teste, e o `Assert`, que � a valida��o, se o resultado esperado est� de acordo com o obtido. Eu preciso criar uma inst�ncia do WebDriver, que � a biblioteca do Selenium. 

[03:05] Farei uma exporta��o, clicando com o bot�o direito em cima do que est� sendo destacado em vermelho no c�digo, ou posso clicar na l�mpada do lado esquerdo. Clico em �using OpenQA.Selenium�, vamos exportar essa biblioteca e j� corrigiu o erro que estava no meu c�digo.

[03:30] Agora eu tenho que importar tamb�m a biblioteca referente ao ChromeDriver. Posso apertar o �Ctrl + .� tamb�m em cima do vermelho que est� destacado, e clicar em �using OpenQA.Selenium.Chrome�. Importei essa biblioteca.

[03:50] Para eu importar a biblioteca do ChromeDriver, eu preciso saber onde a DLL foi instalada no meu projeto. Como fa�o isso? Preciso identificar, no meu projeto, onde est� a DLL do Chrome para eu poder fazer essa importa��o e, na hora que eu rodar o teste, acessar os recursos dessa DLL e acessar o Chrome na minha aplica��o. 

[04:12] Ent�o, como vamos fazer isso? Deixa eu s� mostrar primeiro para voc�s. Estou dentro do projeto da aula 2 �AluraByteBank > AluraByteBank.WebApp.Testes > bin > Dbug > .net5.0�. 

[04:29] Aqui dentro eu tenho o �chromedriver.exe�, � esse execut�vel, eu falei DLL, perd�o, que eu preciso reconhecer dentro do c�digo para poder testar.

[04:43] Vou usar o recurso do pr�prio .NET. Vou na classe `Path`, onde tem a mensagem �N�o existe refer�ncia no contexto atual�, ent�o eu preciso importar essa biblioteca tamb�m. Bot�o direito em `Path` ou �Ctrl + .�. Vou apertar a l�mpada no lado esquerdo, �A��es r�pidas > using System.IO�, corrigi o erro do `path`. Agora o `Assembly`.

[05:06] Bot�o direito no `Assembly`, �Ctrl + .�, �using System.Reflection�. Esse c�digo, quando eu passo para o construtor do ChromeDriver, vai reconhecer onde est� o �chromedriver.exe� para poder fazer os testes, escrever e acessar o aplicativo do Chrome na minha m�quina.

[05:30] No `Act`, usando a instancia do `driver`, vou usar o m�todo `Navigate()` e vou falar para qual URL tem que navegar. `GoToUrl`, vai navegar para a URL `logalhost:44309`, que � a minha aplica��o.

[05:47] Vou rodar a aplica��o usando o Visual Studio. Na parte superior, vou clicar em �Play�, ele vai subir o servidor �IIS Express� e vai rodar a aplica��o. Est� carregando, olha s�, a porta que � a URL que eu quero testar a �localhost:44309�.

[06:14] Fechei a janela que abriu, s� que agora eu preciso testar esse c�digo. Fechei o navegador, vou parar de rodar aqui. Percebam o seguinte, vou rodar a aplica��o e come�ar a testar.

[06:26] No gerenciador de teste, no lado esquerdo, vou fix�-lo para permanecer aberto, vou abrir o projeto de teste do Alura ByteBank, esse �ltimo, s� tem um teste, �NavegandoNaPagina�, eu tenho um m�todo de teste, que � o �CarregaPaginaHomeEVerificaOTitulodaPagina�. A partir do momento que carregar o `WebDriver` e navegar para essa URL, eu quero verificar se, no t�tulo da minha p�gina, eu consigo encontrar o texto `WebApp`. 

[07:06] Vou sondar a aplica��o para verificarmos se tem isso no t�tulo da p�gina. Est� rodando a aplica��o, vai demorar um pouco na m�quina. Carregou. Ent�o, aqui no t�tulo da p�gina tem �WebApp�. Estou passando o mouse em cima, na parte superior do navegador, �Alura.ByteBank.WebApp�, cont�m esse texto l�.

[07:34] Vou testar agora, fechei o navegador e vou rodar para testar. Vou executar o meu teste. No gerenciador de testes, clicar em �Executar� em cima do teste �CarregaPaginaHomeEVerificaOTituloDaPagina�.

[07:53] Executei. Tive um problema, olha s�, ele n�o conseguiu reconhecer o meu navegador. Por qu�? Eu estava rodando dentro da aplica��o e falhou o meu teste. Vai dar erro mesmo se eu tentar executar o teste assim. Por qu�?

[08:10] Quando eu clico no �Play� dentro do Visual Studio, ele carrega para uma inst�ncia do IIS Expresse, carrega a minha aplica��o. Como eu fechei a aplica��o e rodei por aqui, n�o vou conseguir, porque n�o est� encontrando o IIS para fazer o teste da URL.

[08:29] Ent�o, o que eu tenho que fazer? Eu tenho que startar primeiro o meu servidor. Uma dica � usar o �Ctrl + F5�. Dentro do Visual Studio, vou apertar �Ctrl + F5�, e o que vai acontecer?

[08:44] O Visual Studio vai startar uma inst�ncia IIS Express, que aparece na barra inferior da janela, e j� rodar a minha aplica��o. Dessa maneira, eu posso fechar o navegador. Note que o Visual Studio n�o est� em modo de execu��o.

[09:06] Mas se voc� reparar na barra inferior do seu navegador, eu vou ter os IIS Express rodando. O que vai acontecer agora com esse teste? Eu vou abrir o navegador do Chrome nessa URL e verificar se encontro o �WebApp�.

[09:26] Bot�o direito para simular o teste e vou clicar em �Executar�. Encontrou a aplica��o, abriu, tinha que fazer isso mesmo. Meu teste passou agora, ele carregou o navegador nessa URL usando a biblioteca como `driver` , e encontrou, no t�tulo da minha p�gina, o texto �WebApp�.

[09:52] Vamos fazer mais um teste com a mesma l�gica, trabalhando a p�gina �Home� da aplica��o. Vou criar um novo teste. Eu quero carregar �CarregaPaginaHomeEVerificaSeExisteOLinkLoginEHome�.

[10:15] Vou seguir o mesmo conceito, usando o padr�o de escrita `Arrange`, `Act` e `Assert` . Aqui n�s temos o `IWebDriver driver`, porque a partir dessa inst�ncia eu tenho uma s�rie de m�todos dispon�veis para poder trabalhar com essa interface web da aplica��o.

[10:29] Vou navegar para a mesma URL, s� que agora, do `driver`. Eu quero encontrar no c�digo-fonte da p�gina, no *page source*, o texto `Login` e o texto `Home`.

[10:46] Deixa s� eu apagar rapidamente, tenho dispon�vel �URL�, �PageSource�, �Title�, procurar elemento, navegar para um link, fechar a p�gina, enfim, eu tenho uma s�rie de recursos dispon�veis no WebDriver. 

[11:05] Vamos rodar o teste. Ele tem que abrir o Chrome, navegar para a sua URL e encontrar no corpo da p�gina do `Login` e o `Home`. Percebam bem que, no Visual Studio, no gerenciador de testes, j� carregou um novo teste.

[11:19] Ent�o, carregar a p�gina �Home� e verificar a exist�ncia do *link* �Login� e �Home�. Clica com o bot�o direito em �CarregaPaginaHomeEVerificaSeExisteOLinkLoginEHome�, clica em "Executar" e vou executar meu teste. Pode demorar um pouco. 

[11:32] Meu teste passou. Perceba bem, ele chegou no final, no `Assert`, onde ele verifica que realmente encontrou no c�digo-fonte da p�gina o texto �Login� e o texto �Home�. 

[11:46] Esses foram os primeiros testes que criamos usando a biblioteca WebDriver. J� fizemos a configura��o dela, j� criamos uma inst�ncia. Precisamos criar uma inst�ncia dela, que � o *arrange*.

[11:56] Utilizamos m�todos de navega��o para encontrar a URL que queremos testar, e usamos *assert*, que verifica alguns elementos da p�gina, como t�tulo, ou at� no pr�prio corpo, no c�digo-fonte da p�gina.

[12:06] Na sequ�ncia, vamos continuar evoluindo nossos testes de interface usando a biblioteca Selenium WebDriver e o Chrome como nosso navegador para homologa��o desses testes.