[00:00] J� entendemos o que s�o os `PageObjects` e como eles v�o ser �teis para a manuten��o futura do nosso c�digo de teste. As altera��es da interface, na interface web de um elemento ou componente, n�s conseguimos centralizar em um local s� a manuten��o para o nosso c�digo de teste. 

[00:21] Vamos evoluir o nosso conjunto de testes para gerenciar melhor o navegador. Ele � um recurso bastante demandado durante os testes e todos os testes que n�s executamos est�o abrindo sempre um novo navegador.

[00:34] Isso n�o � bacana porque ese recurso que demanda sistema operacional e processador. No conjunto de testes, temos para esse projeto de testes, pelo menos onze testes.

[00:54] `AposRealizarLogin` tem cinco testes e `NavegandoNaPaginaHome` tem seis testes, e todo teste est� abrindo sempre um navegador. Ent�o, vamos corrigir essa situa��o da seguinte maneira.

[01:06] Vou mostrar para voc�s uma forma que seria interessante para executarmos. Quando executamos a classe de teste, vai ser invocado o m�todo construtor que vai instanciar o `driver`, capturar o caminho da DLL do ChromeDriver, e vou sempre utilizar esse driver no meu m�todo de teste. 

[01:32] Nesse teste, por exemplo, `AposRealizarLoginVerificaSeExisteOpcaoAgenciaMenu`, vou ter um `driver` aqui usando aquela estrat�gia dos `PageObjects`.

[01:44] Vou fazer essa classe, a princ�pio, `IDisposable`, isso me for�a a implementar o m�todo `Dispose`, tenho que implementar o m�todo dessa interface. Eu mandei implementar o m�todo e o Visual Studio automaticamente criou para o m�todo `public void Dispose`.

[02:09] Em que eu posso invocar o `driver.Quit()`. Sempre que eu invocar um m�todo, no final vou chamar o `Dispose` que vai fechar o navegador para mim. Vou fixar novamente o gerenciador de testes e vou executar todos os testes dessa classe `AposRealizarLogin` novamente. 

[02:39] Bot�o direito, �Executar�. Est� processando, carregando o IIS Express. Est� executando e fechando; um teste executou, fechou. Pr�ximo teste executou, fechou o navegador. 

[03:11] J� estou com o meu navegador mais gerenciado com essa estrat�gia. Quero mostrar para voc�s uma estrat�gia bastante interessante que utiliza o xUnit, que � quando eu quero compartilhar um recurso, como � o navegador no objeto, entre v�rios testes. Eu posso utilizar tamb�m o *Fixture*. 

[03:31] Vamos fazer algumas altera��es no nosso c�digo, vou remover essa implementa��o de `Disposable` em `AposRealizarLogin:Disposable`, e remover o `void Dispose`. Vou criar agora uma classe, �Utilit�rios�, �Ctrl + Z�, vou fechar o gerenciador de testes.

[03:58] No gerenciador de solu��es, vou criar uma nova pasta e vou cham�-la de �Utilit�rios�. Nessa pasta, vou definir duas classes: uma classe �til, porque tamb�m quero centralizar em um lugar s� onde vou invocar o Chrome Driver que estou utilizando, ent�o vou criar uma classe chamada `Util`.

[04:35] Essa classe `Util` vai ser p�blica e est�tica, `public static classe Util`. Vou fechar o gerenciador de solu��es e dar uma quebra de linha ap�s `public static sting CaminhoDriverNavegador()` para ficar melhor a visualiza��o.

[04:53] Essa classe `Util` vai conter o caminho do navegador. Posso colocar v�rios caminhos, vou centralizar em um ponto s�. Corrigi as importa��es, preciso corrigir o `path`, que � o �using SystemIO�, e o `Assembly`, que � o �using SystemReflection�.

[05:26] Corrigir essa parte vai ser �til para mim no meu c�digo de teste daqui para frente. Abrimos o gerenciador de solu��es, vamos criar agora uma nova classe. Essa classe vai ser o �Gerenciador�.

[05:51] Essa classe �Gerenciador� vai conhecer, para n�s, o navegador, que pode ser Chrome, Internet Explorer, Mozilla, enfim. Essa classe vai ter essa responsabilidade.

[06:11] Colei aqui, deixa eu s� fechar o gerenciador de solu��es para darmos uma olhada com mais calma nela. Eu preciso ter uma inst�ncia de `WebDriver`, vou criar uma propriedade chamada `Driver` do tipo `WebDriver`. 

[06:24] Essa classe tem que conhecer a biblioteca do Selenium, vou adicionar a biblioteca, �using OpenQASelenium�. Ela tamb�m tem que conhecer o navegador `ChromeDriver`.

[06:38] Ent�o, vou adicionar �usingOpenQASelenium.Chrome�. Aqui n�o � `Helper`, aqui � `Util`. Quando instancia um objeto dessa classe, ele j� conhece o caminho do navegador, definindo a classe `Util`.

[06:59] Meu `Driver`, essa propriedade, quando eu instanciar essa classe, ela j� vai me permitir acessar o navegador e vai implementar o `Dispose` da classe. Essa classe `Gerenciador` implementa o `IDisposable`. 

[07:15] Essa classe conhece o `Gerenciador`, ent�o sabe como encontrar o navegador, carreg�-lo e fech�-lo. Estamos evoluindo a nossa aplica��o. 

[07:27] Voltando para o c�digo de testes, essa classe `AposRealizarLogin`, existe uma estrat�gia que podemos usar, usando o xUnit, que � a implementa��o da `class Feature`, que nos permite gerenciar um objeto entre v�rios elementos em um mesmo teste.

[07:47] Eu quero utilizar esse `Gerenciador` em v�rios lugares, vai ser ele que vai cuidar agora do meu navegador. Ent�o, `IClassFixture<>`, e nele tenho que passar, como par�metro para essa interface, a classe que vai ter que gerenciar esse objeto, que vai ser o `<Gerenciador>`. 
 
[08:10] N�o est� aparecendo ainda porque eu preciso importar essa classe que eu adicionei agora para �Utilitarios�. Ent�o, �Ctrl + .� ou clicando no lado esquerdo da linha 16, �using Alura.ByteBank.WebApp.Testes.Utilitarios�, importar a *namespace* `Gerenciador`.

[08:33] Est� quase pronto. Vou salvar o que estou fazendo, s� que agora preciso, no construtor, injetar uma depend�ncia do `Gerenciador`. Vou fazer o seguinte: `Gerenciador`, quando eu criar a inst�ncia da classe de teste, vou passar como par�metro do `gerenciador`.

[08:58] Continuo usando o Console de testes, caso eu precise, s� que agora o `driver` que eu utilizo nessa classe eu n�o vou invocar toda vez, vou chamar o `gerenciador.Driver`.

[09:20] Da� em diante, eu j� consigo executar meus testes. Esse `Gerenciador` vai cuidar do meu navegador. Salvei, abri o gerenciador de testes, vou executar todos os testes da classe.

[09:42] Na dura��o do tempo da execu��o da classe, o teste da �ltima vez que foi rodado, �10,4�, �3,4�, �3,5� segundos. Vamos ver se vai alterar alguma coisa na dura��o dos testes. 

[09:56] Clicar com o bot�o direito e executar na classe. Usando essa estrat�gia, eu crio um gerenciador para o meu navegador. A execu��o dos meus testes, usando a classe `Fixture`, ficou bem mais r�pida.

[10:17] Estava 19 segundos, est� para 4 segundos agora. Eu consegui otimizar a utiliza��o do meu recurso que vai ser compartilhado entre todos os meus testes, que � o navegador.

[10:28] Esse � o objetivo dessa refatora��o que fizemos no c�digo: otimizar a utiliza��o de um recurso compartilhado, que � o navegador, e implementar recursos e estrat�gias presentes tanto no xUnit quanto no Selenium.

[10:46] Entra no *hall* de boas pr�ticas que podemos aplicar no desenvolvimento de testes de interface usando o Selenium: a utiliza��o de *Page Object*, a estrat�gia da *Fixture* e o gerenciamento do navegador com recurso compartilhado.