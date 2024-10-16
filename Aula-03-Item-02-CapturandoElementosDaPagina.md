[00:00] Continuando, j� criamos alguns testes usando o Selenium e j� automatizamos algumas tarefas bem interessantes. N�s temos, no nosso projeto at� agora, tr�s testes, alguns bem simples, verificando se existe um elemento na p�gina, navegando para determinada URL e verificando se existem alguns elementos naquela p�gina. 

[00:23] Os dois primeiros testes fazem isso. Estou no meu projeto aberto, na classe �NavegandoNaPaginaHome.cs�. Aumentei o zoom da aplica��o para ficar melhor a visualiza��o de voc�s. 

[00:35] Inclusive, consegui recuperar um c�digo gerado usando outra solu��o do Selenium, que � o Selenium IDE, que me permite gravar uma macro, um conjunto de passos, usando a interface gr�fica.

[00:46] Passo a passo, voc� vai gravando a execu��o da a��o dentro da p�gina web, e eu consigo recuperar isso depois e exportar para um *script*, que eu consigo recuperar dentro do c�digo C# com xUnit. 

[01:01] Fomos at� o �LogandoNoSistema� e n�s automatizamos o *login* do usu�rio no sistema. Inclusive, essa ferramenta gerou alguns c�digos para n�s de maneira autom�tica, que conseguimos recuperar no c�digo de teste. 

[01:17] Agora vamos evoluir, identificando melhor esses c�digos gerados e entendendo melhor o que � esse `By.Id` que eu tenho na linha 47 e o que � esse `LinkText`, que s�o maneiras que temos para recuperarmos e identificarmos um elemento na p�gina HTML, e trabalharmos em cima dele.

[01:36] Vamos criar um novo teste que vai ser um teste bem simples de funcionalidade: navegar para a p�gina que eu quero, identificar um elemento HTML dentro do c�digo, que vai ser um link, navegar para esse link e clicar nesse link.

[01:56] Ent�o, vou colar agora o c�digo que eu criei para voc�s verem. O novo teste � o seguinte: `ValidaLinkDeLoginNaHome`. No `Arrange`, eu preparo as vari�veis e o ambiente que eu preciso para o meu teste, e eu preciso de uma nova inst�ncia do `ChromeDriver` instalada no projeto. 

![Trecho do c�digo mostrando a estrutura do ValidaLinkDeLoginNaHome](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/03/NET_valida_link_de_login.png)

[02:24] A partir desse momento, eu consigo navegar nesse objeto para determinada URL, com o `Navigate().GoToUrl()`. E aqui � a cereja do bolo: como eu consigo identificar um elemento do HTML e recuperar dentro do c�digo C#.

[02:47] Ent�o,  temo o c�digo `driver.FindElement(By.Linktext("Login"));`. Basicamente, est� falando o seguinte: �navegador Chrome, procura o elemento para mim na p�gina que tenha o `LinkText` chamado `Login`�.

[03:08] Se voc�s passarem o mouse em cima do m�todo `FindElement`, ele retorna para mim uma inst�ncia de web *element*. E a partir desse momento, eu consigo clicar nesse elemento. 

[03:18] Eu estou na p�gina, estou clicando agora no link de `Login`, e quando eu clico, eu vou ser redirecionado para a p�gina de *login*. Na p�gina de *login*, eu vou verificar se encontro, dentro do corpo da p�gina, no *page source*, o texto �img�.

[03:37] Vou startar, com o �Ctrl + F5�, o nosso projeto. Vai carregar essa p�gina para mim, com essa URL �44309� e o link de *login*. �Poxa, mas eu preciso recuperar o �Login�, o �Home�, um bot�o que eu tenho na minha p�gina, como fa�o isso?�.

[04:02] Vamos usar aquele `FindElement.ById` ou `ByLinkText`. Vou abrir s� para entendermos como conseguimos identificar esses elementos HTML. � uma das formas. Vou exibir o c�digo-fonte da p�gina.

[04:23] Eu tenho aqui embaixo, na linha 27, o meu link, a *tag* `<a>`, que vai direcionar para `usuarios/login`, que � a minha p�gina de *login*. Ent�o, o `LinkText` que eu tenho � o `Login`. Deixa eu minimizar e voltar para o c�digo.

[04:46] Agora � procurar o `LinkText`.Vou testar agora se meu c�digo est� funcionando. Vou salvar o que eu fiz, � importante, e vou abrir o gerenciador de solu��es.

[05:00] E vou no m�todo �ValidaLinkLoginNaHome�. Bot�o direito sobre o m�todo e vou mandar executar. Pode demorar um pouco no come�o porque est� inicializando o servidor e carregando a p�gina do navegador. 

[05:14] Ele vem para p�gina "Login", s� que n�o fechou a p�gina, vamos corrigir isso mais a frente. Ele abriu a p�gina, essa n�o � a �Home�, ele carregou essa p�gina, clicou no *link* �Login�, que aparece na p�gina, e veio para c�, para a p�gina �Login�.

[05:36] E verificou, na p�gina �Login�, se eu tenho uma *tag* chamada �img�. Vou abrir o c�digo-fonte. Tem que ter o �img� em algum lugar aqui. Tem aqui, `img`, na linha 35 do meu navegador. 

[06:03] Nosso teste passou, ent�o essa � uma maneira que eu tenho para recuperar o elemento na minha p�gina. No caso, eu quero recuperar um `LinkText`. 

[06:18] Outra maneira seria voltarmos no c�digo que salvamos na �ltima aula, que geramos automaticamente usando o Selenium IDE, e utilizar outro recurso que � o `By.Id`. No HTML � interessante que voc�s conhe�am o b�sico: o que � uma *tag*, o que � um atributo. 

[06:42] Um dos tributos que temos no HTML � o "id" para identificar a *tag*, o elemento HTML na minha p�gina. No caso do teste que fizemos, o `ValidaLinkLoginNaHome`, n�o existe esse id, ent�o eu usei esse recurso `ByLinkText`. 

[07:01] Se tivesse o id, eu poderia mudar e, em vez de `FindElement(By.LinkText())`, seria `(By.Id())`. N�o existe esse id no c�digo, ent�o o meu c�digo vai dar um erro agora. S� para mostrar aqui o teste.

[07:20] Abrir o gerenciador de testes novamente, vou �Executar�. Ele n�o foi para a p�gina �Login�, ele s� abriu a p�gina, o teste falhou. Por qu�? Eu n�o consigo encontrar o elemento da minha p�gina HTML que tem o `Id(�Login�)`. O id "*login*" n�o existe, existe o `LinkText`.

[07:50] Existem outras formas de capturarmos esses elementos da p�gina HTML, mas esses s�o os dois principais: `LinkText()` e `By.Id()`. N�s criamos mais um teste e identificamos como recuperar um elemento na p�gina para dentro do meu c�digo C#, meu c�digo de teste. 

[08:09] N�s continuaremos, na sequ�ncia, validando essa p�gina de �Login�. Agora vamos verificar como eu consigo imputar informa��es em um campo de texto e trabalhar em cima do �Login�.