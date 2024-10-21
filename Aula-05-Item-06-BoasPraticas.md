[00:00] Já entendemos o que são os `PageObjects` e como eles vão ser úteis para a manutenção futura do nosso código de teste. As alterações da interface, na interface web de um elemento ou componente, nós conseguimos centralizar em um local só a manutenção para o nosso código de teste. 

[00:21] Vamos evoluir o nosso conjunto de testes para gerenciar melhor o navegador. Ele é um recurso bastante demandado durante os testes e todos os testes que nós executamos estão abrindo sempre um novo navegador.

[00:34] Isso não é bacana porque ese recurso que demanda sistema operacional e processador. No conjunto de testes, temos para esse projeto de testes, pelo menos onze testes.

[00:54] `AposRealizarLogin` tem cinco testes e `NavegandoNaPaginaHome` tem seis testes, e todo teste está abrindo sempre um navegador. Então, vamos corrigir essa situação da seguinte maneira.

[01:06] Vou mostrar para vocês uma forma que seria interessante para executarmos. Quando executamos a classe de teste, vai ser invocado o método construtor que vai instanciar o `driver`, capturar o caminho da DLL do ChromeDriver, e vou sempre utilizar esse driver no meu método de teste. 

[01:32] Nesse teste, por exemplo, `AposRealizarLoginVerificaSeExisteOpcaoAgenciaMenu`, vou ter um `driver` aqui usando aquela estratégia dos `PageObjects`.

[01:44] Vou fazer essa classe, a princípio, `IDisposable`, isso me força a implementar o método `Dispose`, tenho que implementar o método dessa interface. Eu mandei implementar o método e o Visual Studio automaticamente criou para o método `public void Dispose`.

[02:09] Em que eu posso invocar o `driver.Quit()`. Sempre que eu invocar um método, no final vou chamar o `Dispose` que vai fechar o navegador para mim. Vou fixar novamente o gerenciador de testes e vou executar todos os testes dessa classe `AposRealizarLogin` novamente. 

[02:39] Botão direito, “Executar”. Está processando, carregando o IIS Express. Está executando e fechando; um teste executou, fechou. Próximo teste executou, fechou o navegador. 

[03:11] Já estou com o meu navegador mais gerenciado com essa estratégia. Quero mostrar para vocês uma estratégia bastante interessante que utiliza o xUnit, que é quando eu quero compartilhar um recurso, como é o navegador no objeto, entre vários testes. Eu posso utilizar também o *Fixture*. 

[03:31] Vamos fazer algumas alterações no nosso código, vou remover essa implementação de `Disposable` em `AposRealizarLogin:Disposable`, e remover o `void Dispose`. Vou criar agora uma classe, “Utilitários”, “Ctrl + Z”, vou fechar o gerenciador de testes.

[03:58] No gerenciador de soluções, vou criar uma nova pasta e vou chamá-la de “Utilitários”. Nessa pasta, vou definir duas classes: uma classe útil, porque também quero centralizar em um lugar só onde vou invocar o Chrome Driver que estou utilizando, então vou criar uma classe chamada `Util`.

[04:35] Essa classe `Util` vai ser pública e estática, `public static classe Util`. Vou fechar o gerenciador de soluções e dar uma quebra de linha após `public static sting CaminhoDriverNavegador()` para ficar melhor a visualização.

[04:53] Essa classe `Util` vai conter o caminho do navegador. Posso colocar vários caminhos, vou centralizar em um ponto só. Corrigi as importações, preciso corrigir o `path`, que é o “using SystemIO”, e o `Assembly`, que é o “using SystemReflection”.

[05:26] Corrigir essa parte vai ser útil para mim no meu código de teste daqui para frente. Abrimos o gerenciador de soluções, vamos criar agora uma nova classe. Essa classe vai ser o “Gerenciador”.

[05:51] Essa classe “Gerenciador” vai conhecer, para nós, o navegador, que pode ser Chrome, Internet Explorer, Mozilla, enfim. Essa classe vai ter essa responsabilidade.

[06:11] Colei aqui, deixa eu só fechar o gerenciador de soluções para darmos uma olhada com mais calma nela. Eu preciso ter uma instância de `WebDriver`, vou criar uma propriedade chamada `Driver` do tipo `WebDriver`. 

[06:24] Essa classe tem que conhecer a biblioteca do Selenium, vou adicionar a biblioteca, “using OpenQASelenium”. Ela também tem que conhecer o navegador `ChromeDriver`.

[06:38] Então, vou adicionar “usingOpenQASelenium.Chrome”. Aqui não é `Helper`, aqui é `Util`. Quando instancia um objeto dessa classe, ele já conhece o caminho do navegador, definindo a classe `Util`.

[06:59] Meu `Driver`, essa propriedade, quando eu instanciar essa classe, ela já vai me permitir acessar o navegador e vai implementar o `Dispose` da classe. Essa classe `Gerenciador` implementa o `IDisposable`. 

[07:15] Essa classe conhece o `Gerenciador`, então sabe como encontrar o navegador, carregá-lo e fechá-lo. Estamos evoluindo a nossa aplicação. 

[07:27] Voltando para o código de testes, essa classe `AposRealizarLogin`, existe uma estratégia que podemos usar, usando o xUnit, que é a implementação da `class Feature`, que nos permite gerenciar um objeto entre vários elementos em um mesmo teste.

[07:47] Eu quero utilizar esse `Gerenciador` em vários lugares, vai ser ele que vai cuidar agora do meu navegador. Então, `IClassFixture<>`, e nele tenho que passar, como parâmetro para essa interface, a classe que vai ter que gerenciar esse objeto, que vai ser o `<Gerenciador>`. 
 
[08:10] Não está aparecendo ainda porque eu preciso importar essa classe que eu adicionei agora para “Utilitarios”. Então, “Ctrl + .” ou clicando no lado esquerdo da linha 16, “using Alura.ByteBank.WebApp.Testes.Utilitarios”, importar a *namespace* `Gerenciador`.

[08:33] Está quase pronto. Vou salvar o que estou fazendo, só que agora preciso, no construtor, injetar uma dependência do `Gerenciador`. Vou fazer o seguinte: `Gerenciador`, quando eu criar a instância da classe de teste, vou passar como parâmetro do `gerenciador`.

[08:58] Continuo usando o Console de testes, caso eu precise, só que agora o `driver` que eu utilizo nessa classe eu não vou invocar toda vez, vou chamar o `gerenciador.Driver`.

[09:20] Daí em diante, eu já consigo executar meus testes. Esse `Gerenciador` vai cuidar do meu navegador. Salvei, abri o gerenciador de testes, vou executar todos os testes da classe.

[09:42] Na duração do tempo da execução da classe, o teste da última vez que foi rodado, “10,4”, “3,4”, “3,5” segundos. Vamos ver se vai alterar alguma coisa na duração dos testes. 

[09:56] Clicar com o botão direito e executar na classe. Usando essa estratégia, eu crio um gerenciador para o meu navegador. A execução dos meus testes, usando a classe `Fixture`, ficou bem mais rápida.

[10:17] Estava 19 segundos, está para 4 segundos agora. Eu consegui otimizar a utilização do meu recurso que vai ser compartilhado entre todos os meus testes, que é o navegador.

[10:28] Esse é o objetivo dessa refatoração que fizemos no código: otimizar a utilização de um recurso compartilhado, que é o navegador, e implementar recursos e estratégias presentes tanto no xUnit quanto no Selenium.

[10:46] Entra no *hall* de boas práticas que podemos aplicar no desenvolvimento de testes de interface usando o Selenium: a utilização de *Page Object*, a estratégia da *Fixture* e o gerenciamento do navegador com recurso compartilhado.