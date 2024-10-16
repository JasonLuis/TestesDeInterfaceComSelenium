[00:00] Entendemos como capturar e identificar o elemento na p�gina HTML e recuper�-lo no c�digo C#, no c�digo de teste, usando a biblioteca do Selenium WebDriver. Ent�o, vamos dar continuidade com os testes ,testando a funcionalidade de *login* da aplica��o. Al�m de capturarmos os elementos da p�gina, vamos manipular alguns campos de texto.

[00:23] Vou abrir a aplica��o, colocar para a rodar com �Ctrl + F5� e est� carregando a aplica��o. Na minha aplica��o, eu tenho o campo �Login�. Vamos inserir o e-mail, a senha e vou logar. Esse � um teste que eu quero fazer na p�gina principal, p�gina �Login�.

[00:47] Vou fechar. Para come�ar esses testes, vamos criar uma nova classe de testes. No projeto da �Alura.ByteBank.WebApp.Testes�, clico com o bot�o direito, vou adicionar uma classe.

[01:05] Essa classe vai se chamar �AposRealizarLogin�. Vamos fazer os testes referentes a *login* nessa classe. Essa classe vou marcar como �Public� e, para ela, j� vou colocar um m�todo para testar o *login* v�lido. 

[01:35] Vou fechar o gerenciador de solu��es para ficar mais vis�vel e vou corrigir as importa��es referentes ao xUnit da biblioteca do Selenium WebDriver. `Fact` � o primeiro, �Ctrl + .�, no lado esquerdo da tela do Visual Studio, �Importar > using xUnit�, vou acertar as importa��es do `IWebDriver`. 

[01:58] Clico com o bot�o direito e seleciono em �using OpenQA.Selenium�. Do Chrome Driver tamb�m, inclusive, identificando onde est� o DLL, que vai ser importante para carregar o navegador de homologa��o, que � o Chrome, �Selenium.Chrome�;

[02:19] No `Path`, clico em "using Sytem.IO�, e no `Assembly ` clico em �using System.Reflection�. Corrigi, agora vamos usar o m�todo. No `Arrange`, estou preparando o cen�rio. Eu preciso da biblioteca do WebDriver, eu tenho que navegar para a URL do *login*, eu capturo os elementos da tela de �Login� usando a classe `By` da biblioteca WebDriver, ent�o vou procurar pelo id.

[02:51] Na p�gina, o elemento `Email` e o elemento `Senha` t�m o id `Email` e id `Senha`, e o bot�o tem o id `btn-logar`. Deixa eu abrir novamente nosso navegador, �Ctrl + F5�.

[03:09] Chrome, �Login�. O elemento "Email" na p�gina tem um id, esse elemento �Senha� tamb�m tem um id e o bot�o tamb�m tem um id. Bot�o direito, �Inspecionar c�digo-fonte da p�gina� ou �Ctrl + F11� para acessar os recursos desenvolvedores do navegador.

[03:26] Eu tenho que entender um pouco do HTML, entender os elementos. Por exemplo, o `Email`, j� identifiquei, tem o `id=Email` e `name=Email`. Ent�o, isso � f�cil recuperar depois no c�digo.

[03:42] Mesma coisa com a `Senha`, `id=Senha`, `name=Senha`. Vou fechar e deixa o navegador de lado, por enquanto. A partir do momento que capturei os elementos da p�gina, eu j� posso trabalhar em cima deles. 

[03:56] Ent�o, para os campos de texto `Login` e `Senha`, existe um m�todo da biblioteca WebDriver que � o `SendKeys`, que vai me impedir setar valor para esse elemento. Naquele campo de texto, eu vou passar esse valor, `andre@email.com`.

[04:15] Para a `Senha`, a mesma coisa, `Senha01`, que � a senha de testes da aplica��o. No bot�o, que � o `btn-logar`, que eu recuperei tamb�m usando a biblioteca WebDriver pelo id, eu vou colocar um evento de tela `Click`.

[04:33] Vou capturar as informa��es da tela, inserir as informa��es nos campos e clicar no bot�o �Logar�. Assim que eu logar na aplica��o, eu vou ser redirecionado para outra p�gina, e vou verificar nessa p�gina se eu encontro, no corpo da p�gina, o texto `Ag�ncia`.

[04:49] Vou salvar, vou abrir o gerenciador de testes e vou executar o teste. Ent�o, �AposRealizarLogin�, a classe que eu quero testar com o meu m�todo de teste, `AposRealizarLoginVerificaSeExisteOpcaoAgenciaMenu`.

[05:14] Bot�o direito nesse arquivo, seleciona o gerenciador de testes, clicar em �Executar�. Est� processando, ele tem que abrir o navegador, navegar para a p�gina de �Login�, inserir as informa��es, ir para a p�gina �Home� da minha aplica��o e verificar se tem o texto �Ag�ncia�.

[05:39] Meu teste passou? Passou, est� verde. Vamos continuar testando aplica��es. J� tentamos o *login* v�lido. E se quisermos fazer um teste passando para os campos um valor e tentarmos logar?

[05:56] O pr�ximo m�todo de teste � tentar realizar o *login* sem preencher os campos. Vou pegar minha ajuda, deixa eu ir no gerenciador de testes, compilando meu m�todo, vamos adicionar um novo m�todo.

[06:15] Est�o dando alguns erros. Por qu�? Aqui estou invocando o `driver`, mas esse m�todo n�o reconhece o `driver`. Ent�o eu preciso desse c�digo do teste de cima, da parte do `Arrange`, em que eu instancio meu `WebDriver`.

[06:33] �Ctrl + V�. J� conclu� as todas as importa��es, � praticamente o mesmo teste, s� que, nesse momento, eu n�o passo as informa��es para os campos de `Login` e `Senha`, eu j� vou direto para o evento `Click` do bot�o.

[06:49] Tenho que identificar o seguinte, se na minha tela de �Login� vai aparecer a mensagem de erro �The Email field is required�quando est� tentando logar na aplica��o sem ter as informa��es requeridas. 

[07:07] Salvei. O pr�ximo m�todo `TentaRealizarLoginSemPreencherCampos`. Abrir o gerenciador de testes novamente, ou fix�-lo, bot�o direito sobre o gerenciador de testes, em cima do m�todo que quero testar. Acabei de escrev�-lo, mas ainda n�o o executei. Ent�o �Executar�.

[07:31] Est� carregando, processando, vai abrir minha aplica��o. Ele tentou abrir a aplica��o, �The Email field is required�, �The Senha field is required�, tentou logar e n�o conseguiu. 

[07:46] Vamos ver o teste? Meu teste j� est� se comportando da maneira esperada. Vamos fazer mais um teste no �Login� tentando uma senha inv�lida. Da mesma maneira, � praticamente o mesmo m�todo, s� que vou passar no `SendKeys` uma senha inv�lida. `Senha010`, por exemplo.

[08:12] No final, vou adicionar um novo m�todo de teste com a senha inv�lida. O pr�ximo m�todo � `TentaRealizarLoginComSenhaInvalida`. Tenho que conhecer primeiro o `driver`. No `Arrange`, vou copiar do m�todo anterior. Na sequ�ncia, vamos corrigir esses m�todos. 

[08:36] No `Arrange`, eu adicionei o objeto `WebDriver`. Navego para a p�gina de �Login�, capturo os elementos da p�gina, informo um `Login` v�lido, uma `Senha` inv�lida e o evento `Click` do bot�o.

[08:58] Nesse momento, eu n�o posso sair da p�gina, tenho que permanecer na p�gina. Se eu permanecer nessa p�gina, eu vou verificar se tem o texto �Login� no corpo dela.

[09:09] Salvei, volto no gerenciador de testes, fixo a coluna, bot�o direito no arquivo e clico em "Executar�. Processando, carregou meu navegador, inseriu o e-mail, a senha inv�lida, tentou logar e permaneceu na p�gina, n�o logou.

[09:34] Vou fechar aqui, vamos ver se passou? O teste passou. Ent�o, fizemos tr�s testes na tela de �Login�: *login* inv�lido, tentando logar sem informar os dados para os campos, e com a senha inv�lida. 

[09:50] Na sequ�ncia, vamos continuar testando a funcionalidade de seguran�a da aplica��o, testando URLs v�lidas e inv�lidas, com permiss�es de acesso ou n�o. N�s continuamos evoluindo a nossa aplica��o, com WebDriver, usando o Selenium.