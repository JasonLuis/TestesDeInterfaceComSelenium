[00:00] Ol�, pessoal, vamos continuar aqui? Eu queria agora recuperar com voc�s aquele c�digo de teste que n�s fizemos utilizando o Selenium IDE. S� relembrando, o Selenium � esse *plugin* que temos dispon�vel para alguns navegadores, e n�s usamos o *plugin* para o Chrome. 

[00:18] Desenvolvemos um *script* de teste na nossa ferramenta que naveg�vamos pela p�gina principal, fazendo o *login* na aplica��o, e qual a vantagem disso? Eu n�o preciso trabalhar com nenhum c�digo, a princ�pio, nenhum elemento de programa��o.

[00:33] Simplesmente, eu tenho que dar um *play* e come�ar a gravar a utiliza��o da interface web que eu estou querendo testar. Isso vai ser �til depois para podermos mandar executar esses testes de maneiras repetidas.

[00:46] E fazer tipo um teste de carga, executando v�rias vezes, usando os mesmos c�digos ou fazendo pequenas altera��es para termos resultados diferentes, para testarmos, de maneira mais pesada, a minha aplica��o. 

[01:01] Mas qual a vantagem do Selenium IDE? Ele me permite gerar um *script*, que n�s geramos em momento anterior aqui. Esse *script* eu recuperei dentro do meu projeto. Criei, dentro do �WebAppTestes� uma pasta chamada �_SeleniumIDEScripts�, estou no selecionador de solu��es.

[01:22] Aqui dentro, copiei simplesmente o arquivo que foi gerado, salvei com o nome �LogandoNoSistemaTestes� e, olha s�, ele gera para mim um c�digo, uma classe e um c�digo de testes, usando como padr�o, na hora que eu exportei, o xUnit.

[01:40] Ele cria para mim uma classe, `IDisposable`, cria o `IWebDriver`, o `IJavaScriptExecutor`, enfim, ele cria uma s�rie de c�digos e cria, inclusive, o teste.

[01:58] O teste � `LogandoNoSistema`, por exemplo, que est� no meu c�digo. Vou pegar esse c�digo gerado e vou salvar com um novo teste, o teste que eu estava criando. Vou dar um �Ctrl + C� nesse `LogandoNoSistema`, nesse m�todo, at� o `Fact`. 

[02:17] Vou �Copiar�, vou abrir a minha classe �NavegandoNaPaginaHome� e ao fim da classe vou adicionar o c�digo, esse c�digo de teste. Tenho que fazer alguns ajustes, sen�o n�o vai rodar meu teste.

[02:34] O `driver`, esse objeto, � criado em cada m�todo desenvolvido at� agora: em `CarregaPaginaHomeEVerificaTituloDaPagina`, em `CarregaPaginaHomeVerificaExistenciaLinkLoginHome`.

[02:48] Vou replicar a parte do `Arrange`. Vou copiar a linha 33, vou at� o final, copiei at� o ponto e v�rgula e vou salvar em `publica void LogandoNoSistema(){}`. Fazer uns ajustes s� para poder rodar. 

[03:11] Salvei. Esse c�digo est� dentro do *script* �SeleniumIDEScript�, nessa pasta, essa classe n�o tem nem um *namespace* correto, e pode verificar, no gerenciador de testes, que ele leu para mim que existe um *namespace* diferente aqui dentro.

[03:36] Como esse teste gerado eu quero somente para poder entender melhor o c�digo gerado automaticamente, e aproveitar tamb�m os meus *scripts* que eu vou criar, minha codifica��o de testes, o que eu vou fazer? Vou comentar toda essa classe. 

[03:53] �Ctrl + A� e vou dar um �Ctrl + K + C�, salvei. Meu gerenciador de testes j� recompilou, j� deu *refresh*. Isso n�o vai afetar em nada. Vou fechar e, voltando para o `NavegandoNaPaginaHome`, a classe de testes, eu estou no m�todo `LogandoNoSistema`, o m�todo que eu copiei.

[04:22] Ajustei o `WebDriver` e o `driver` tem o m�todo `navigate` que vai navegar para a URL que est� testando, a 4403 no �localhost�. No `driver` tem um m�todo dispon�vel, que � o `Manage`, que vai gerenciar a janela Windows no navegador.

[04:41] Existe a possibilidade de procurar um elemento pelo `LinkText`, o texto do *link*, e por ID. Est� vendo no c�digo `driver.FindElementByID`? E passa o ID do elemento.

[04:54] Parece interessante, vamos ver com mais profundidade na sequ�ncia, mas s� queria mostrar para voc�s como recuperamos aquele *script* de teste criado com o Selenium IDE.

[05:05] Vou salvar e vou executar o teste. Repare bem que eu tenho agora o �Navegando� no gerenciador de testes. Vou executar o teste agora, �LogandoNoSistema�.

[05:20] Clica com o bot�o direito no arquivo e clica em �Executar�. Vamos ver se vai rodar. Perfeito, logou na aplica��o e executou o teste. Essa � uma maneira que eu tenho para recuperar esse *script* no meu c�digo de teste que estou desenvolvendo para a nossa aplica��o, usando o Selenium WebDriver. 

[05:46] Qual a vantagem que eu tenho de gerar o *script* em uma ferramenta e depois exportar? Primeiro, vai me ajudar a estudar como � o c�digo do Selenium WebDriver, com o `FindElementByID`, que vamos verificar um pouco mais a frente. N�s conseguimos ver como ele funciona, como � a sintaxe e vai nos ajudar bastante nisso.

[06:05] Na sequ�ncia, vamos nos aprofundar um pouco mais no WebDriver e entender melhor esse `FindElementByID` e as variantes que temos desses m�todos.