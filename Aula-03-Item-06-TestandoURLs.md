[00:00] Fizemos testes na funcionalidade de *login* do Alura WebApp. Testamos `AposRealizarLoginVerificaSeExisteOpcaoAgenciaMenu`, `TentaRealizarLoginSemPreencherCampos` do formulário, entendemos como capturar e inserir informações no formulário web usando o WebDriver. 

[00:31] Basicamente, testamos a funcionalidade de *login*. Vamos dar sequência agora, vou abrir a aplicação, dar um “Ctrl + F5”, está carregando no navegador, vou deixar bem visível para vocês, e vou fazer o *login* na aplicação. 

[00:45] Estou usando o usuário “andre@email.com”, a senha “senha01”, vou logar. Aqui eu tenho acesso à minha aplicação através da autenticação usando usuário e senha. 

[00:59] Posso acessar o menu, “Agência”, “Cliente” e “Conta-Corrente”. Ao acessar a “Agência”, por exemplo, a URL é “localhost:44309/Agencia/Index”.

[01:20] Eu só consigo acessar essa página quando estou logado na aplicação. Vou copiar essa URL no navegador, fazer o *logout*, sair da aplicação, e agora vou tentar acessar essa página novamente sem estar logado.

[01:36] Colo a URL e aperto “Enter” no navegador. Mostra a mensagem de erro “HTTP ERROR 401”. Vai ter um material adicional falando sobre códigos de erro em páginas web também. Eu não consigo acessar essa página se não estiver logado na aplicação. Esse é um teste de URL, essa é uma maneira de testarmos a segurança da nossa aplicação web.

[02:03] Isso tem que estar contemplado no código de teste, usando o xUnit e o Selenium WebDriver. Vou fechar o gerenciador de testes, vou fechar o arquivo de *login* e vou abrir o gerenciador de soluções.

[02:21] Vou fixá-lo no lado direito e vou testar agora o acesso às páginas sem permissão. Eu sei que, se eu tentar acessar essa página e retornar para mim o “Error 401”, quer dizer que eu não estou logado na aplicação e que estou sem autorização para acessar a página.

[02:41] No gerenciador de soluções, eu vou abrir novamente a “NavegandoNaPaginaHome.cs”. Ao final do arquivo, vou adicionar um novo método para testar esse acesso a essa URL. 

[03:00] Pegar minha cola, “Ctrl + V”. Então, `TentaAcessarPaginaSemEstarLogado`. Vou fechar o gerenciador de soluções rapidamente. Vou tentar navegar para essa URL sem passar pelo processo de *login* da aplicação.

[03:20] Eu espero que, no corpo da página, apareça para mim o código 401. Outros problemas podem surgir durante o acesso à página web, mas geralmente é o acesso não autorizado a determinado recurso, como essa URL de cima.

[03:44] Vou codar o `driver`, vou navegar para essa página. O meu `Arrange` e `Act`, a preparação e o cenário para testar, vão navegar para essa URL. Vou dar `Assert`, se eu encontrar o 401, quer dizer que eu tentei acessar um recurso não autorizado na minha aplicação.

[04:08] Vou salvar, abrir o gerenciador de testes novamente. Em “NavegandoNaPaginaHome”, vou ter um novo método de teste, “TentaAcessarPaginaSemEstarLogado”. Botão direito no arquivo e clico em “Executar”.

[04:32] Está processando, olha só, executou. Tentou acessar diretamente “local:44309/Agencia/Index” e retornou “Esta página não está funcionando”, deu um código de “ERROR 401”.

[04:53] Está acontecendo o esperado, eu não consegui acessar a página sem estar logado. Mais um teste que nós conseguimos executar usando o Selenium WebDriver e o xUnit.

[05:07] Fechei aqui, meu teste passou, está verde. Então esse é um teste que eu consigo validar e verificar se estou conseguindo ou não acessar uma URL, e eu preciso estar autorizado para poder acessar “Agencia/Index”.

[05:27] Vou rodar de novo esse teste, executei, a nossa aplicação está bem simples, a nossa mensagem de erro sem nenhum tratamento específico, mas esse não é o objetivo do curso, trabalhar em cima da aplicação web. Nós temos que testá-la, esse é o nosso objetivo.

[05:46] Continuando, vou fazer outro teste. Vou navegar para a página “Index” e vou fazer um `.Contains` diferente. Vou fechar o gerenciador de testes e vou criar um novo teste no nosso código.

[06:08] Só para fixar esse conceito de fazer um teste em uma URL que eu não tenho autorização. Então `AcessaPaginaSemEstarLogadoVerificaURL`. Enquanto eu navegar para essa página `Agencia/Index`, eu vou verificar se contém esse endereço na URL. 

[06:31] `driver.Url`, essa URL que estou verificando existe? É o que está aparecendo para mim? E continua fazendo aquele teste, se no corpo da página aparece para mim “401”, que é o código de erro que estamos verificando nesse momento.

[06:48] Vou salvar e abrir o gerenciador de testes novamente. Tem outro teste agora, “AcessaPaginaSemEstarLogadoVerificaURL”. Botão direito nele e executar. É praticamente o mesmo teste.

[07:15] Continua dando o erro 401. A URL que estou verificando agora na minha página, é essa, “/Agencia/Index”? É, então meu teste está ok, passou. 

[07:36] Eu navego para essa URL, `Agencia/Index`, verifico se a URL naquele momento, naquela página, é o “Agencia/Index”. Outra maneira de eu verificar é usando o WebDriver, usando a propriedade `Url`.

[07:53] O conteúdo da `Url` é igual ao `/Agencia/Index`? Se for, meu acesso está ok. E continuo fazendo aquele `Assert` com `Contains` com o 401 verificando se eu encontro no corpo da página o código de erro.

[08:12] O objetivo é verificarmos como validar URLs, que é um teste importante, principalmente quando testamos a validação de segurança na aplicação web. Além disso, nós conseguimos verificar a utilização da propriedade `Url` do objeto `driver`.

[08:32] Na sequência, vamos continuar falando sobre WebDriver, vou aprofundar um pouco mais falando sobre *locators* e como identificar vários elementos em uma mesma página.