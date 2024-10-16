[00:00] Entendemos como capturar e identificar o elemento na página HTML e recuperá-lo no código C#, no código de teste, usando a biblioteca do Selenium WebDriver. Então, vamos dar continuidade com os testes ,testando a funcionalidade de *login* da aplicação. Além de capturarmos os elementos da página, vamos manipular alguns campos de texto.

[00:23] Vou abrir a aplicação, colocar para a rodar com “Ctrl + F5” e está carregando a aplicação. Na minha aplicação, eu tenho o campo “Login”. Vamos inserir o e-mail, a senha e vou logar. Esse é um teste que eu quero fazer na página principal, página “Login”.

[00:47] Vou fechar. Para começar esses testes, vamos criar uma nova classe de testes. No projeto da “Alura.ByteBank.WebApp.Testes”, clico com o botão direito, vou adicionar uma classe.

[01:05] Essa classe vai se chamar “AposRealizarLogin”. Vamos fazer os testes referentes a *login* nessa classe. Essa classe vou marcar como “Public” e, para ela, já vou colocar um método para testar o *login* válido. 

[01:35] Vou fechar o gerenciador de soluções para ficar mais visível e vou corrigir as importações referentes ao xUnit da biblioteca do Selenium WebDriver. `Fact` é o primeiro, “Ctrl + .”, no lado esquerdo da tela do Visual Studio, “Importar > using xUnit”, vou acertar as importações do `IWebDriver`. 

[01:58] Clico com o botão direito e seleciono em “using OpenQA.Selenium”. Do Chrome Driver também, inclusive, identificando onde está o DLL, que vai ser importante para carregar o navegador de homologação, que é o Chrome, “Selenium.Chrome”;

[02:19] No `Path`, clico em "using Sytem.IO”, e no `Assembly ` clico em “using System.Reflection”. Corrigi, agora vamos usar o método. No `Arrange`, estou preparando o cenário. Eu preciso da biblioteca do WebDriver, eu tenho que navegar para a URL do *login*, eu capturo os elementos da tela de “Login” usando a classe `By` da biblioteca WebDriver, então vou procurar pelo id.

[02:51] Na página, o elemento `Email` e o elemento `Senha` têm o id `Email` e id `Senha`, e o botão tem o id `btn-logar`. Deixa eu abrir novamente nosso navegador, “Ctrl + F5”.

[03:09] Chrome, “Login”. O elemento "Email" na página tem um id, esse elemento “Senha” também tem um id e o botão também tem um id. Botão direito, “Inspecionar código-fonte da página” ou “Ctrl + F11” para acessar os recursos desenvolvedores do navegador.

[03:26] Eu tenho que entender um pouco do HTML, entender os elementos. Por exemplo, o `Email`, já identifiquei, tem o `id=Email` e `name=Email`. Então, isso é fácil recuperar depois no código.

[03:42] Mesma coisa com a `Senha`, `id=Senha`, `name=Senha`. Vou fechar e deixa o navegador de lado, por enquanto. A partir do momento que capturei os elementos da página, eu já posso trabalhar em cima deles. 

[03:56] Então, para os campos de texto `Login` e `Senha`, existe um método da biblioteca WebDriver que é o `SendKeys`, que vai me impedir setar valor para esse elemento. Naquele campo de texto, eu vou passar esse valor, `andre@email.com`.

[04:15] Para a `Senha`, a mesma coisa, `Senha01`, que é a senha de testes da aplicação. No botão, que é o `btn-logar`, que eu recuperei também usando a biblioteca WebDriver pelo id, eu vou colocar um evento de tela `Click`.

[04:33] Vou capturar as informações da tela, inserir as informações nos campos e clicar no botão “Logar”. Assim que eu logar na aplicação, eu vou ser redirecionado para outra página, e vou verificar nessa página se eu encontro, no corpo da página, o texto `Agência`.

[04:49] Vou salvar, vou abrir o gerenciador de testes e vou executar o teste. Então, “AposRealizarLogin”, a classe que eu quero testar com o meu método de teste, `AposRealizarLoginVerificaSeExisteOpcaoAgenciaMenu`.

[05:14] Botão direito nesse arquivo, seleciona o gerenciador de testes, clicar em “Executar”. Está processando, ele tem que abrir o navegador, navegar para a página de “Login”, inserir as informações, ir para a página “Home” da minha aplicação e verificar se tem o texto “Agência”.

[05:39] Meu teste passou? Passou, está verde. Vamos continuar testando aplicações. Já tentamos o *login* válido. E se quisermos fazer um teste passando para os campos um valor e tentarmos logar?

[05:56] O próximo método de teste é tentar realizar o *login* sem preencher os campos. Vou pegar minha ajuda, deixa eu ir no gerenciador de testes, compilando meu método, vamos adicionar um novo método.

[06:15] Estão dando alguns erros. Por quê? Aqui estou invocando o `driver`, mas esse método não reconhece o `driver`. Então eu preciso desse código do teste de cima, da parte do `Arrange`, em que eu instancio meu `WebDriver`.

[06:33] “Ctrl + V”. Já concluí as todas as importações, é praticamente o mesmo teste, só que, nesse momento, eu não passo as informações para os campos de `Login` e `Senha`, eu já vou direto para o evento `Click` do botão.

[06:49] Tenho que identificar o seguinte, se na minha tela de “Login” vai aparecer a mensagem de erro “The Email field is required”quando está tentando logar na aplicação sem ter as informações requeridas. 

[07:07] Salvei. O próximo método `TentaRealizarLoginSemPreencherCampos`. Abrir o gerenciador de testes novamente, ou fixá-lo, botão direito sobre o gerenciador de testes, em cima do método que quero testar. Acabei de escrevê-lo, mas ainda não o executei. Então “Executar”.

[07:31] Está carregando, processando, vai abrir minha aplicação. Ele tentou abrir a aplicação, “The Email field is required”, “The Senha field is required”, tentou logar e não conseguiu. 

[07:46] Vamos ver o teste? Meu teste já está se comportando da maneira esperada. Vamos fazer mais um teste no “Login” tentando uma senha inválida. Da mesma maneira, é praticamente o mesmo método, só que vou passar no `SendKeys` uma senha inválida. `Senha010`, por exemplo.

[08:12] No final, vou adicionar um novo método de teste com a senha inválida. O próximo método é `TentaRealizarLoginComSenhaInvalida`. Tenho que conhecer primeiro o `driver`. No `Arrange`, vou copiar do método anterior. Na sequência, vamos corrigir esses métodos. 

[08:36] No `Arrange`, eu adicionei o objeto `WebDriver`. Navego para a página de “Login”, capturo os elementos da página, informo um `Login` válido, uma `Senha` inválida e o evento `Click` do botão.

[08:58] Nesse momento, eu não posso sair da página, tenho que permanecer na página. Se eu permanecer nessa página, eu vou verificar se tem o texto “Login” no corpo dela.

[09:09] Salvei, volto no gerenciador de testes, fixo a coluna, botão direito no arquivo e clico em "Executar”. Processando, carregou meu navegador, inseriu o e-mail, a senha inválida, tentou logar e permaneceu na página, não logou.

[09:34] Vou fechar aqui, vamos ver se passou? O teste passou. Então, fizemos três testes na tela de “Login”: *login* inválido, tentando logar sem informar os dados para os campos, e com a senha inválida. 

[09:50] Na sequência, vamos continuar testando a funcionalidade de segurança da aplicação, testando URLs válidas e inválidas, com permissões de acesso ou não. Nós continuamos evoluindo a nossa aplicação, com WebDriver, usando o Selenium.