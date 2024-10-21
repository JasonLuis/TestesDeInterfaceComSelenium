[00:00] Seguindo essa linha de raciocínio de capturar elementos de uma página HTML usando o WebDriver, já vimos como recuperar elementos por `.Id`, `.CssSelector`, `LinkText` e `Name`.

[00:16] Imagina o seguinte, eu quero recuperar mais de um elemento de uma vez só na página, quero recuperar uma lista de elementos que contém em uma página. 

[00:23] Para isso, eu vou começar a escrever um novo código de teste. Na classe `AposRealizarLogin`, eu vou adicionar o seguinte teste no final do arquivo. Comecei a escrever o código `RealizarLoginAcessarListagemDeContas`, de contas-correntes. 

[00:42] No `Arrange`, eu navego para a página de `Login` e executo o `login` usando o `email` e `senha`, que sabemos que é o padrão para a identificação. Nós clicamos e depois, na conta-corrente, vou clicar no elemento que tem o id `contacorrente`, que é o elemento do menu da minha aplicação.

[01:07] Deixa eu só fechar aqui, está dando um erro porque não fechou o método com **`}`**. Essa primeira parte é normal, essa parte do `Arrange`, que é para ser o cenário.

[01:22] Vou navegar para a “Conta-corrente”, só que, quando eu clicar e tiver na listagem de contas-correntes, eu quero listar, por exemplo, todos os elementos "link" daquela página. 

[01:34] O que é um "link" no HTML? É a *tag* `<a>`, “href” que chama. Quando eu chegar nessa página, eu vou fazer o seguinte: vou fazer um `IReadOnlyCollection<IWebElement> elements`, aí vou chamar `FindElement.(By.TagName())`. Vai procurar todos os elementos que têm a `TagName(“a”)`, todos os elementos que são "link" na minha página. 

[02:18] Vou ter uma listagem de links na minha página. Vamos testar isso? Só que agora eu quero exibir isso no gerenciador de testes, no Console. Quando executar esse novo teste que eu criei, eu quero que exiba para mim os links da página. 

[02:44] Vou usar o recurso `ITestOutputHelper`. Vou criar uma propriedade nessa classe de teste e vou voltar ao início da classe. Já criei a propriedade `private IWebDriver driver`, que estamos usando nos métodos abaixo.

[03:07] Agora vou definir uma nova propriedade, deixá-la pública por enquanto, `public ITestOutputHelper`, que vai se chamar `SaidaConsoleTeste`, vamos deixar assim.

[03:22] Vou salvar, adicionar a importação de biblioteca do xUnit, “using Xunit.Abstraction”. Então, já tem uma nova propriedade. O que essa propriedade vai permitir? Escrever no Console do gerenciador de teste. 

[03:40] Vou fazer só mais um ajuste, vou injetar esse objeto via injeção dependência do construtor. O construtor da classe, que é `public AposRealizarLogin`, vou adicionar o seguinte código, `saidaConsoleTeste`, que está no `ITestOutputHelper`.

[03:59] Em `AposRealizarLogin(ITestOutputHelper saidaConsoleTeste)` vou fazer o seguinte: a minha propriedade `saidaConsoleTeste` vai receber o objeto de construção. Agora vou conseguir escrever usando essa propriedade da minha classe no console de teste.

[04:20] Isso vai identificar se nós encontramos os elementos usando a biblioteca do WebDriver. Identifiquei aqui, feito isso, vou ter uma listagem de elementos, fazer um `foreach` nessa listagem e invocar o texto da propriedade *text* daquele elemento.

[04:45] O código vai ser esse `.foreach (IWebElement e in elements)`. O meu vetor de objetos é do tipo `IWebElements`, e para a propriedade `e`, vamos colocar a propriedade `.Text`.

[05:09] Então `foreach (IWebElement e in elements) SaidaConsoleTeste.WriteLine(e.Text)`. Salvei e vou executar agora o método de teste. O que esse método vai fazer?

[05:23] Não está testando nada, a princípio, só estou exibindo para vocês os elementos que tenho nessa página de contas-correntes. Então `AposRealizarLoginAcessaListagemDeContas`, botão direito, vou “Executar”.

[05:39] Ele tem que abrir a página, logar na página, clicar em “Contas-correntes” e listar todos os elementos link daquela página. Esse é o objetivo, ele não é um teste completo. 

[05:51] Ele acessou a página de contas, não deu erro porque não está acontecendo nada ainda, mas na saída do Console, usando aquele objeto, eu consegui listar todos os links que tem na minha página, todas as tags `<a>`.

[06:04] Tenho o “ByBank-WebApp”, o “Home”, “Agência”, “Clientes”, “Conta-correntes”, “Adicionar conta-corrente”, “Editar”, “Detalhes”, “Excluir”, “Editar”, “Detalhes” e “Excluir”.

[06:17] Então, ele encontrou todos os links da página. Vamos ver a página? Está aberta aqui. Isso é link, na parte superior do menu. Tenho também “Editar”, “Detalhes” e “Excluir”, são os *links*. Identifiquei todas as tags `<a>` dessa página. 

[06:37] “Exibir código-fonte”, deixa eu aumentar. Todas as tags `<a>` que eu tenho, `Excluir`, outras tags `<a>` que são link. Tenho três aqui embaixo, um pouco mais para cima, no código-fonte, tenho mais três, são seis. No menu, na parte superior da página, o `Home`, `Agência`, `Cliente` e `Contas-correntes`.

[07:18] Então eu consegui identificar se tenho elementos na página, já é o primeiro passo que queremos verificar. Voltando para o método de teste, vou fazer um `Assert` só para validarmos uma situação, se encontra a quantidade de elementos.

[07:42] Vou fazer um `Assert.True(elements.Count == 12)`, só para ter `Arrange`, `Act` e `Assert`. Vou executar meu método novamente, no gerenciador de testes. Botão direito, “Executar”. Não deve quebrar em nada. 

[08:06] Vai abrir de novo a página e chega nessa página aqui de “Contas-correntes”. Deixa eu abrir o gerenciador de testes novamente, o teste está passando, estamos conseguindo capturar todos os elementos que têm uma mesma tag em uma página, usando o WebDriver. 

[08:29] Vou continuar escrevendo o nosso código de testes e fazendo ajustes. Eu não preciso exibir as informações no Console em um teste real. Então, eu vou brincar um pouco agora. 

[08:44] Eu vou capturar um elemento específico e dar um `Click`. Essa parte `foreach` é só para mostrar como escrever no Console usando o xUnit. Vou apagar o `foreach` e usar o seguinte código. Vou usar um link, vou trabalhar em cima da coleção de objetos.

[09:11] Vou fazer uma consulta nesse `elements`, nesse *array* de objetos que eu tenho, e vou procurar o elemento que contém o texto `Detalhes` e retornar o primeiro que eu encontrar. 

[09:33] Vou ter um `web element` aqui, um específico, o primeiro que encontrar o texto `Detalhes`. Depois, eu posso clicar no botão, nesse elemento que, a princípio, é um *link*. 

[09:54] No meu `Act`, que está faltando aqui, eu clico no botão, clico nesse elemento. Esse `Assert.True` não funciona mais, vou tirá-lo daqui. Vou fazer um `Assert` nessa página. Para onde vou navegar, existe o texto de voltar. 

[10:13] Estou nos detalhes daquela conta. Então, `Assert`, vou verificar no código-fonte se encontro o texto “Voltar”. Salvei, fiz meu ajuste de teste, vou clicar no gerenciador de testes e novamente vou executar.

[10:35] Está carregando o servidor, carregando a instância do navegador para poder executar o teste. Logou, tem um botão “Voltar” aqui, então tem um link “Voltar”.

[10:49] O teste passou. Esse é um teste que permite encontrar vários elementos na página e fazer um filtro. Nessa consulta *link* que estou fazendo aqui, basicamente eu faço um filtro desses elementos, escolho um de maneira aleatória e clico no evento `Click` desse elemento.

[11:10] Na página seguinte, verifico se encontro o texto “Voltar” no corpo da minha página. Essa é outra maneira que possuímos de encontrar elementos usando a biblioteca WebDriver.

[11:24] Tem o `driver.FindElement` e o `driver.FindElements`. Podemos passar o id ou, nesse caso, `By.TagName`. Na sequência, vamos ver boas práticas usando a biblioteca WebDriver e, nos nossos testes, usando o Selenium.