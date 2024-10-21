[00:00] J� sabemos o que s�o os *Page Objectos*. J� fizemos at� uma refatora��o em um m�todo de teste. Vamos ampliar um pouco mais essa refatora��o para todos os m�todos da classe `AposRealizarLogin` e vamos implementar para a p�gina �Home�, vamos criar um `PageObject` para a p�gina �Home�.

[00:23] Vou fechar o gerenciador de teste em que est�o falhando os testes, ent�o precisamos refator�-los para passarem todos. Em `AposRealizarLogin`, esse `Arrange` e esse `Act`, presentes na refatora��o feita, v�o se repetir para outros m�todos de teste. 

[00:49] Eu posso substituir esse `Arrange` pelo `TentaRealizarLoginSemPreencherCampos`. Vou deletar isso daqui e � esse campo que preciso passar. Esse campo, `PreencherCampos`, vou passar vazio.

[01:14] Meu c�digo ficou um pouco mais enxuto. Em `TentaRealizarLoginComSenhaInvalida` vai meio que repetir, posso apagar at� o `Act`.

[01:32] S� que a senha � inv�lida, vou colocar `senha010`. Vou no `Arrange` do `RealizaLoginAcessaMenuECadastraCliente`. Nessa parte eu vou aproveitar parte do meu c�digo para n�o precisar refatorar. O `Arrange` posso excluir, at� o `Click`.

[01:59] E parte de `Login`, vou substituir pelo nosso `PageObjects`, `loginPO`. Est� refatorado quase tudo. Vou excluir o `//Arrange` do �ltimo m�todo.

[02:16] Dessa maneira, eu estou refatorando o nosso c�digo de teste. Vamos ver se tudo vai passar agora? Vou fechar o gerenciador de solu��es e fixar o gerenciador de testes.

[02:29] Deixa eu verificar se o nosso servi�o est� rodando. Subiu. Vou rodar todos os testes, os cinco testes do `AposRealizarLogin`. Bot�o direito em cima do m�todo da classe de teste, �Executar�.

[02:48] Um m�todo foi, o outro parou, logou, percebam que est�o abrindo outras abas do navegador. Nossos testes n�o est�o quebrando mais, todos devem ter passado, espero eu.

[03:12] Vamos voltar ao gerenciador de testes. Fechei o navegador, tudo passou. Agora, vamos fazer o mesmo procedimento para a p�gina �Home�. Vou fixar o gerenciador de solu��es, do lado direito, e vou criar, dentro da classe do `PageObjects`, uma nova classe `HomePO`.

[03:33] �Adicionar > Nova classe�, �HomePO�. N�s adicionamos essa nova classe e eu tenho uma ajuda no bloco de notas em que eu tenho a defini��o dessa classe. Vou apagar esse conte�do, vou col�-la aqui e vamos analis�-la agora. 

[04:04] Eu percorri as importa��es do `WebDriver` do Selenium. Ent�o, �Ctrl + .�, bot�o direito e �using OpenQASelenium�. J� ocorreram muitos erros. Eu defini alguns elementos que eu quero recuperar nessa p�gina. 

[04:28] O `linkHome`, `linkContaCorrentes`, `linkClientes` e `linkAgencias`. Na defini��o do construtor da classe, `homePO`, eu capturo esses elementos usando o Selenium WebDriver.

[04:45] Desenvolvi um m�todo de navega��o que � o padr�o. Acho que coloquei na outra classe tamb�m, vamos ver aqui, `loginPO`, tenho o m�todo de navega��o. Eu recebo a URL e navego para aquela p�gina.

[04:59] Voltando para `homePO`, eu tenho o m�todo de clicar no `linkHome`, `linkContaCorrente`, `linkClientes` e `linkAgenciasClick`. Vou fazer uma nova inst�ncia da p�gina, novo servi�o, �Ctrl + F5�.

[05:32] Est� carregando, est� compilando, ele abre em outra p�gina. Vou logar na aplica��o, �andre@email.com�, �senha01�. Tenho o link da �Home�, da �Ag�ncia�, do �Cliente�, �Conta-Corrente� e �Logout�.

[05:57] Essa classe `homePO` que n�s criamos vai estar representando esses elementos na nossa p�gina. 

[06:07] Agora, vamos criar novos m�todos. Eu preciso refatorar o m�todo `RealizarLoginAcessaListagemDeContas`. Vamos definir outro m�todo para podermos testar essa op��o de *home* que temos agora dispon�vel.

[06:36] Vou fazer um m�todo. No final do arquivo, vou criar um novo m�todo, �Ctrl + C� e �Ctrl + V�, porque estou exportando do desenvolvedor. Est� dando erro porque n�o tenho o m�todo `Logar`, � o m�todo de `Clik`, `.btnkClick`.

[07:03] Continua dando erro porque j� tem esse m�todo definido nessa classe. Vou definir outro nome para esse m�todo, `RealizaLoginAcessaListagemDeContasUsandoHomePO`. S� para diferenciar de um m�todo para o outro.

[07:38] Vou fazer o `Arrange` e o `Act`. Vou fazer o `login` usando o `loginPO`; vou fazer o `Act`, vou logar na aplica��o. Quando logar na aplica��o, eu vou estar na p�gina �Home�, ent�o vou criar um objeto `homePO`.

[07:55] Vou passar o `driver` como refer�ncia, para poder navegar e encontrar os objetos daquela p�gina, e vou invocar o m�todo `linkContaCorrenteClick`.

[08:06] Vou navegar para `ContaCorrente`. Quando eu navegar para a p�gina �Conta-Corrente�, que � a p�gina *home* da �Conta-Corrente� e que tem a listagem, o que vai acontecer para mim? Verificar se tem o `Adicionar Conta-Corrente` no corpo da p�gina.

[08:18] Vamos testar esse m�todo agora? Salvei meu c�digo, vou abrir o gerenciador de testes, vou fix�-lo novamente. Est� em exclama��o porque n�o foi executado ainda, est� criado, mas n�o foi executado. Vamos execut�-lo?

[08:26] Bot�o direito, �Executar�. Logou. Est� funcionando o nosso teste, e agora, em vez de eu adicionar muito c�digo nessa classe teste, referente ao Selenium, eu s� tenho basicamente o Selenium quando precisa identificar o conte�do da p�gina. 

[09:00] Ent�o, eu desacoplo, deixo menos dependente o c�digo de teste do c�digo de Selenium, porque eu separei a responsabilidade, eu deixei a responsabilidade de conhecer a biblioteca Selenium para as classes de `PageObjects`.

[09:14] Esse � o principal motivo de usarmos `PageObjects`. � at� uma recomenda��o do pr�prio Selenium. Estou com a p�gina do Selenium aberta para mostrar para voc�s. 

[09:26] Essa p�gina � da documenta��o do Selenium WebDriver. Entre outras boas pr�ticas, tem o `PageObjects`. Est� em ingl�s, mas podemos mudar em cima, no menu superior, para portugu�s. 

[09:40] �Modelos de objetos de p�gina�, �Linguagem espec�fica�, �Gerando estado da aplica��o�, �Simula��o de servi�os externos�, �Relat�rios melhorados�, enfim, na p�gina da documenta��o oficial do Selenium existe tamb�m recomenda��es de boas pr�ticas, e uma delas � o `PageObjects`.

[09:56] Na sequ�ncia, vamos implementar algumas refatora��es no nosso c�digo para podermos deix�-lo mais resistente a mudan�as e mais perform�tico. Percebam s�, com bot�o direito em cima do m�todo, vou executar todos testes de uma vez s�, classe `AposRealizarLogin` , sempre que eu executo todos os testes,abre sempre um navegador diferente para cada teste. 

[10:27] Abriu um navegador, mais um navegador e mais um navegador. Isso � um recurso caro para o processamento. A princ�pio est� com poucos testes, mas o conjunto de testes vai estar enorme em algum momento.

[10:42] Note o seguinte, sempre que mandamos executar todos os testes de uma vez, ele executa teste por teste, e cada teste ele abre um pr�prio navegador para executar.

[10:50] Isso � um recurso que demanda do processador, do sistema operacional, e tem como otimizar a utiliza��o do navegador, porque o teste que estamos fazendo depende de outros recursos, n�o s� do c�digo em si rodando, mas do servidor carregado e tamb�m do navegador funcionando. 

[11:16] Dependendo do ambiente que voc� tem para testar, os recursos, como processador, mem�ria, e o pr�prio tempo, isso vai influenci�-los bastante. Ent�o, na sequ�ncia, vamos ver como otimizar essa situa��o do nosso c�digo.