[00:00] Seguindo essa linha de racioc�nio de capturar elementos de uma p�gina HTML usando o WebDriver, j� vimos como recuperar elementos por `.Id`, `.CssSelector`, `LinkText` e `Name`.

[00:16] Imagina o seguinte, eu quero recuperar mais de um elemento de uma vez s� na p�gina, quero recuperar uma lista de elementos que cont�m em uma p�gina. 

[00:23] Para isso, eu vou come�ar a escrever um novo c�digo de teste. Na classe `AposRealizarLogin`, eu vou adicionar o seguinte teste no final do arquivo. Comecei a escrever o c�digo `RealizarLoginAcessarListagemDeContas`, de contas-correntes. 

[00:42] No `Arrange`, eu navego para a p�gina de `Login` e executo o `login` usando o `email` e `senha`, que sabemos que � o padr�o para a identifica��o. N�s clicamos e depois, na conta-corrente, vou clicar no elemento que tem o id `contacorrente`, que � o elemento do menu da minha aplica��o.

[01:07] Deixa eu s� fechar aqui, est� dando um erro porque n�o fechou o m�todo com **`}`**. Essa primeira parte � normal, essa parte do `Arrange`, que � para ser o cen�rio.

[01:22] Vou navegar para a �Conta-corrente�, s� que, quando eu clicar e tiver na listagem de contas-correntes, eu quero listar, por exemplo, todos os elementos "link" daquela p�gina. 

[01:34] O que � um "link" no HTML? � a *tag* `<a>`, �href� que chama. Quando eu chegar nessa p�gina, eu vou fazer o seguinte: vou fazer um `IReadOnlyCollection<IWebElement> elements`, a� vou chamar `FindElement.(By.TagName())`. Vai procurar todos os elementos que t�m a `TagName(�a�)`, todos os elementos que s�o "link" na minha p�gina. 

[02:18] Vou ter uma listagem de links na minha p�gina. Vamos testar isso? S� que agora eu quero exibir isso no gerenciador de testes, no Console. Quando executar esse novo teste que eu criei, eu quero que exiba para mim os links da p�gina. 

[02:44] Vou usar o recurso `ITestOutputHelper`. Vou criar uma propriedade nessa classe de teste e vou voltar ao in�cio da classe. J� criei a propriedade `private IWebDriver driver`, que estamos usando nos m�todos abaixo.

[03:07] Agora vou definir uma nova propriedade, deix�-la p�blica por enquanto, `public ITestOutputHelper`, que vai se chamar `SaidaConsoleTeste`, vamos deixar assim.

[03:22] Vou salvar, adicionar a importa��o de biblioteca do xUnit, �using Xunit.Abstraction�. Ent�o, j� tem uma nova propriedade. O que essa propriedade vai permitir? Escrever no Console do gerenciador de teste. 

[03:40] Vou fazer s� mais um ajuste, vou injetar esse objeto via inje��o depend�ncia do construtor. O construtor da classe, que � `public AposRealizarLogin`, vou adicionar o seguinte c�digo, `saidaConsoleTeste`, que est� no `ITestOutputHelper`.

[03:59] Em `AposRealizarLogin(ITestOutputHelper saidaConsoleTeste)` vou fazer o seguinte: a minha propriedade `saidaConsoleTeste` vai receber o objeto de constru��o. Agora vou conseguir escrever usando essa propriedade da minha classe no console de teste.

[04:20] Isso vai identificar se n�s encontramos os elementos usando a biblioteca do WebDriver. Identifiquei aqui, feito isso, vou ter uma listagem de elementos, fazer um `foreach` nessa listagem e invocar o texto da propriedade *text* daquele elemento.

[04:45] O c�digo vai ser esse `.foreach (IWebElement e in elements)`. O meu vetor de objetos � do tipo `IWebElements`, e para a propriedade `e`, vamos colocar a propriedade `.Text`.

[05:09] Ent�o `foreach (IWebElement e in elements) SaidaConsoleTeste.WriteLine(e.Text)`. Salvei e vou executar agora o m�todo de teste. O que esse m�todo vai fazer?

[05:23] N�o est� testando nada, a princ�pio, s� estou exibindo para voc�s os elementos que tenho nessa p�gina de contas-correntes. Ent�o `AposRealizarLoginAcessaListagemDeContas`, bot�o direito, vou �Executar�.

[05:39] Ele tem que abrir a p�gina, logar na p�gina, clicar em �Contas-correntes� e listar todos os elementos link daquela p�gina. Esse � o objetivo, ele n�o � um teste completo. 

[05:51] Ele acessou a p�gina de contas, n�o deu erro porque n�o est� acontecendo nada ainda, mas na sa�da do Console, usando aquele objeto, eu consegui listar todos os links que tem na minha p�gina, todas as tags `<a>`.

[06:04] Tenho o �ByBank-WebApp�, o �Home�, �Ag�ncia�, �Clientes�, �Conta-correntes�, �Adicionar conta-corrente�, �Editar�, �Detalhes�, �Excluir�, �Editar�, �Detalhes� e �Excluir�.

[06:17] Ent�o, ele encontrou todos os links da p�gina. Vamos ver a p�gina? Est� aberta aqui. Isso � link, na parte superior do menu. Tenho tamb�m �Editar�, �Detalhes� e �Excluir�, s�o os *links*. Identifiquei todas as tags `<a>` dessa p�gina. 

[06:37] �Exibir c�digo-fonte�, deixa eu aumentar. Todas as tags `<a>` que eu tenho, `Excluir`, outras tags `<a>` que s�o link. Tenho tr�s aqui embaixo, um pouco mais para cima, no c�digo-fonte, tenho mais tr�s, s�o seis. No menu, na parte superior da p�gina, o `Home`, `Ag�ncia`, `Cliente` e `Contas-correntes`.

[07:18] Ent�o eu consegui identificar se tenho elementos na p�gina, j� � o primeiro passo que queremos verificar. Voltando para o m�todo de teste, vou fazer um `Assert` s� para validarmos uma situa��o, se encontra a quantidade de elementos.

[07:42] Vou fazer um `Assert.True(elements.Count == 12)`, s� para ter `Arrange`, `Act` e `Assert`. Vou executar meu m�todo novamente, no gerenciador de testes. Bot�o direito, �Executar�. N�o deve quebrar em nada. 

[08:06] Vai abrir de novo a p�gina e chega nessa p�gina aqui de �Contas-correntes�. Deixa eu abrir o gerenciador de testes novamente, o teste est� passando, estamos conseguindo capturar todos os elementos que t�m uma mesma tag em uma p�gina, usando o WebDriver. 

[08:29] Vou continuar escrevendo o nosso c�digo de testes e fazendo ajustes. Eu n�o preciso exibir as informa��es no Console em um teste real. Ent�o, eu vou brincar um pouco agora. 

[08:44] Eu vou capturar um elemento espec�fico e dar um `Click`. Essa parte `foreach` � s� para mostrar como escrever no Console usando o xUnit. Vou apagar o `foreach` e usar o seguinte c�digo. Vou usar um link, vou trabalhar em cima da cole��o de objetos.

[09:11] Vou fazer uma consulta nesse `elements`, nesse *array* de objetos que eu tenho, e vou procurar o elemento que cont�m o texto `Detalhes` e retornar o primeiro que eu encontrar. 

[09:33] Vou ter um `web element` aqui, um espec�fico, o primeiro que encontrar o texto `Detalhes`. Depois, eu posso clicar no bot�o, nesse elemento que, a princ�pio, � um *link*. 

[09:54] No meu `Act`, que est� faltando aqui, eu clico no bot�o, clico nesse elemento. Esse `Assert.True` n�o funciona mais, vou tir�-lo daqui. Vou fazer um `Assert` nessa p�gina. Para onde vou navegar, existe o texto de voltar. 

[10:13] Estou nos detalhes daquela conta. Ent�o, `Assert`, vou verificar no c�digo-fonte se encontro o texto �Voltar�. Salvei, fiz meu ajuste de teste, vou clicar no gerenciador de testes e novamente vou executar.

[10:35] Est� carregando o servidor, carregando a inst�ncia do navegador para poder executar o teste. Logou, tem um bot�o �Voltar� aqui, ent�o tem um link �Voltar�.

[10:49] O teste passou. Esse � um teste que permite encontrar v�rios elementos na p�gina e fazer um filtro. Nessa consulta *link* que estou fazendo aqui, basicamente eu fa�o um filtro desses elementos, escolho um de maneira aleat�ria e clico no evento `Click` desse elemento.

[11:10] Na p�gina seguinte, verifico se encontro o texto �Voltar� no corpo da minha p�gina. Essa � outra maneira que possu�mos de encontrar elementos usando a biblioteca WebDriver.

[11:24] Tem o `driver.FindElement` e o `driver.FindElements`. Podemos passar o id ou, nesse caso, `By.TagName`. Na sequ�ncia, vamos ver boas pr�ticas usando a biblioteca WebDriver e, nos nossos testes, usando o Selenium.