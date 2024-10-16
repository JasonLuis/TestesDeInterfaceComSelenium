[00:00] Fizemos testes na funcionalidade de *login* do Alura WebApp. Testamos `AposRealizarLoginVerificaSeExisteOpcaoAgenciaMenu`, `TentaRealizarLoginSemPreencherCampos` do formul�rio, entendemos como capturar e inserir informa��es no formul�rio web usando o WebDriver. 

[00:31] Basicamente, testamos a funcionalidade de *login*. Vamos dar sequ�ncia agora, vou abrir a aplica��o, dar um �Ctrl + F5�, est� carregando no navegador, vou deixar bem vis�vel para voc�s, e vou fazer o *login* na aplica��o. 

[00:45] Estou usando o usu�rio �andre@email.com�, a senha �senha01�, vou logar. Aqui eu tenho acesso � minha aplica��o atrav�s da autentica��o usando usu�rio e senha. 

[00:59] Posso acessar o menu, �Ag�ncia�, �Cliente� e �Conta-Corrente�. Ao acessar a �Ag�ncia�, por exemplo, a URL � �localhost:44309/Agencia/Index�.

[01:20] Eu s� consigo acessar essa p�gina quando estou logado na aplica��o. Vou copiar essa URL no navegador, fazer o *logout*, sair da aplica��o, e agora vou tentar acessar essa p�gina novamente sem estar logado.

[01:36] Colo a URL e aperto �Enter� no navegador. Mostra a mensagem de erro �HTTP ERROR 401�. Vai ter um material adicional falando sobre c�digos de erro em p�ginas web tamb�m. Eu n�o consigo acessar essa p�gina se n�o estiver logado na aplica��o. Esse � um teste de URL, essa � uma maneira de testarmos a seguran�a da nossa aplica��o web.

[02:03] Isso tem que estar contemplado no c�digo de teste, usando o xUnit e o Selenium WebDriver. Vou fechar o gerenciador de testes, vou fechar o arquivo de *login* e vou abrir o gerenciador de solu��es.

[02:21] Vou fix�-lo no lado direito e vou testar agora o acesso �s p�ginas sem permiss�o. Eu sei que, se eu tentar acessar essa p�gina e retornar para mim o �Error 401�, quer dizer que eu n�o estou logado na aplica��o e que estou sem autoriza��o para acessar a p�gina.

[02:41] No gerenciador de solu��es, eu vou abrir novamente a �NavegandoNaPaginaHome.cs�. Ao final do arquivo, vou adicionar um novo m�todo para testar esse acesso a essa URL. 

[03:00] Pegar minha cola, �Ctrl + V�. Ent�o, `TentaAcessarPaginaSemEstarLogado`. Vou fechar o gerenciador de solu��es rapidamente. Vou tentar navegar para essa URL sem passar pelo processo de *login* da aplica��o.

[03:20] Eu espero que, no corpo da p�gina, apare�a para mim o c�digo 401. Outros problemas podem surgir durante o acesso � p�gina web, mas geralmente � o acesso n�o autorizado a determinado recurso, como essa URL de cima.

[03:44] Vou codar o `driver`, vou navegar para essa p�gina. O meu `Arrange` e `Act`, a prepara��o e o cen�rio para testar, v�o navegar para essa URL. Vou dar `Assert`, se eu encontrar o 401, quer dizer que eu tentei acessar um recurso n�o autorizado na minha aplica��o.

[04:08] Vou salvar, abrir o gerenciador de testes novamente. Em �NavegandoNaPaginaHome�, vou ter um novo m�todo de teste, �TentaAcessarPaginaSemEstarLogado�. Bot�o direito no arquivo e clico em �Executar�.

[04:32] Est� processando, olha s�, executou. Tentou acessar diretamente �local:44309/Agencia/Index� e retornou �Esta p�gina n�o est� funcionando�, deu um c�digo de �ERROR 401�.

[04:53] Est� acontecendo o esperado, eu n�o consegui acessar a p�gina sem estar logado. Mais um teste que n�s conseguimos executar usando o Selenium WebDriver e o xUnit.

[05:07] Fechei aqui, meu teste passou, est� verde. Ent�o esse � um teste que eu consigo validar e verificar se estou conseguindo ou n�o acessar uma URL, e eu preciso estar autorizado para poder acessar �Agencia/Index�.

[05:27] Vou rodar de novo esse teste, executei, a nossa aplica��o est� bem simples, a nossa mensagem de erro sem nenhum tratamento espec�fico, mas esse n�o � o objetivo do curso, trabalhar em cima da aplica��o web. N�s temos que test�-la, esse � o nosso objetivo.

[05:46] Continuando, vou fazer outro teste. Vou navegar para a p�gina �Index� e vou fazer um `.Contains` diferente. Vou fechar o gerenciador de testes e vou criar um novo teste no nosso c�digo.

[06:08] S� para fixar esse conceito de fazer um teste em uma URL que eu n�o tenho autoriza��o. Ent�o `AcessaPaginaSemEstarLogadoVerificaURL`. Enquanto eu navegar para essa p�gina `Agencia/Index`, eu vou verificar se cont�m esse endere�o na URL. 

[06:31] `driver.Url`, essa URL que estou verificando existe? � o que est� aparecendo para mim? E continua fazendo aquele teste, se no corpo da p�gina aparece para mim �401�, que � o c�digo de erro que estamos verificando nesse momento.

[06:48] Vou salvar e abrir o gerenciador de testes novamente. Tem outro teste agora, �AcessaPaginaSemEstarLogadoVerificaURL�. Bot�o direito nele e executar. � praticamente o mesmo teste.

[07:15] Continua dando o erro 401. A URL que estou verificando agora na minha p�gina, � essa, �/Agencia/Index�? �, ent�o meu teste est� ok, passou. 

[07:36] Eu navego para essa URL, `Agencia/Index`, verifico se a URL naquele momento, naquela p�gina, � o �Agencia/Index�. Outra maneira de eu verificar � usando o WebDriver, usando a propriedade `Url`.

[07:53] O conte�do da `Url` � igual ao `/Agencia/Index`? Se for, meu acesso est� ok. E continuo fazendo aquele `Assert` com `Contains` com o 401 verificando se eu encontro no corpo da p�gina o c�digo de erro.

[08:12] O objetivo � verificarmos como validar URLs, que � um teste importante, principalmente quando testamos a valida��o de seguran�a na aplica��o web. Al�m disso, n�s conseguimos verificar a utiliza��o da propriedade `Url` do objeto `driver`.

[08:32] Na sequ�ncia, vamos continuar falando sobre WebDriver, vou aprofundar um pouco mais falando sobre *locators* e como identificar v�rios elementos em uma mesma p�gina.