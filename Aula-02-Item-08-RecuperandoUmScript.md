[00:00] Olá, pessoal, vamos continuar aqui? Eu queria agora recuperar com vocês aquele código de teste que nós fizemos utilizando o Selenium IDE. Só relembrando, o Selenium é esse *plugin* que temos disponível para alguns navegadores, e nós usamos o *plugin* para o Chrome. 

[00:18] Desenvolvemos um *script* de teste na nossa ferramenta que navegávamos pela página principal, fazendo o *login* na aplicação, e qual a vantagem disso? Eu não preciso trabalhar com nenhum código, a princípio, nenhum elemento de programação.

[00:33] Simplesmente, eu tenho que dar um *play* e começar a gravar a utilização da interface web que eu estou querendo testar. Isso vai ser útil depois para podermos mandar executar esses testes de maneiras repetidas.

[00:46] E fazer tipo um teste de carga, executando várias vezes, usando os mesmos códigos ou fazendo pequenas alterações para termos resultados diferentes, para testarmos, de maneira mais pesada, a minha aplicação. 

[01:01] Mas qual a vantagem do Selenium IDE? Ele me permite gerar um *script*, que nós geramos em momento anterior aqui. Esse *script* eu recuperei dentro do meu projeto. Criei, dentro do “WebAppTestes” uma pasta chamada “_SeleniumIDEScripts”, estou no selecionador de soluções.

[01:22] Aqui dentro, copiei simplesmente o arquivo que foi gerado, salvei com o nome “LogandoNoSistemaTestes” e, olha só, ele gera para mim um código, uma classe e um código de testes, usando como padrão, na hora que eu exportei, o xUnit.

[01:40] Ele cria para mim uma classe, `IDisposable`, cria o `IWebDriver`, o `IJavaScriptExecutor`, enfim, ele cria uma série de códigos e cria, inclusive, o teste.

[01:58] O teste é `LogandoNoSistema`, por exemplo, que está no meu código. Vou pegar esse código gerado e vou salvar com um novo teste, o teste que eu estava criando. Vou dar um “Ctrl + C” nesse `LogandoNoSistema`, nesse método, até o `Fact`. 

[02:17] Vou “Copiar”, vou abrir a minha classe “NavegandoNaPaginaHome” e ao fim da classe vou adicionar o código, esse código de teste. Tenho que fazer alguns ajustes, senão não vai rodar meu teste.

[02:34] O `driver`, esse objeto, é criado em cada método desenvolvido até agora: em `CarregaPaginaHomeEVerificaTituloDaPagina`, em `CarregaPaginaHomeVerificaExistenciaLinkLoginHome`.

[02:48] Vou replicar a parte do `Arrange`. Vou copiar a linha 33, vou até o final, copiei até o ponto e vírgula e vou salvar em `publica void LogandoNoSistema(){}`. Fazer uns ajustes só para poder rodar. 

[03:11] Salvei. Esse código está dentro do *script* “SeleniumIDEScript”, nessa pasta, essa classe não tem nem um *namespace* correto, e pode verificar, no gerenciador de testes, que ele leu para mim que existe um *namespace* diferente aqui dentro.

[03:36] Como esse teste gerado eu quero somente para poder entender melhor o código gerado automaticamente, e aproveitar também os meus *scripts* que eu vou criar, minha codificação de testes, o que eu vou fazer? Vou comentar toda essa classe. 

[03:53] “Ctrl + A” e vou dar um “Ctrl + K + C”, salvei. Meu gerenciador de testes já recompilou, já deu *refresh*. Isso não vai afetar em nada. Vou fechar e, voltando para o `NavegandoNaPaginaHome`, a classe de testes, eu estou no método `LogandoNoSistema`, o método que eu copiei.

[04:22] Ajustei o `WebDriver` e o `driver` tem o método `navigate` que vai navegar para a URL que está testando, a 4403 no “localhost”. No `driver` tem um método disponível, que é o `Manage`, que vai gerenciar a janela Windows no navegador.

[04:41] Existe a possibilidade de procurar um elemento pelo `LinkText`, o texto do *link*, e por ID. Está vendo no código `driver.FindElementByID`? E passa o ID do elemento.

[04:54] Parece interessante, vamos ver com mais profundidade na sequência, mas só queria mostrar para vocês como recuperamos aquele *script* de teste criado com o Selenium IDE.

[05:05] Vou salvar e vou executar o teste. Repare bem que eu tenho agora o “Navegando” no gerenciador de testes. Vou executar o teste agora, “LogandoNoSistema”.

[05:20] Clica com o botão direito no arquivo e clica em “Executar”. Vamos ver se vai rodar. Perfeito, logou na aplicação e executou o teste. Essa é uma maneira que eu tenho para recuperar esse *script* no meu código de teste que estou desenvolvendo para a nossa aplicação, usando o Selenium WebDriver. 

[05:46] Qual a vantagem que eu tenho de gerar o *script* em uma ferramenta e depois exportar? Primeiro, vai me ajudar a estudar como é o código do Selenium WebDriver, com o `FindElementByID`, que vamos verificar um pouco mais a frente. Nós conseguimos ver como ele funciona, como é a sintaxe e vai nos ajudar bastante nisso.

[06:05] Na sequência, vamos nos aprofundar um pouco mais no WebDriver e entender melhor esse `FindElementByID` e as variantes que temos desses métodos.