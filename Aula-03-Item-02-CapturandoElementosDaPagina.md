[00:00] Continuando, já criamos alguns testes usando o Selenium e já automatizamos algumas tarefas bem interessantes. Nós temos, no nosso projeto até agora, três testes, alguns bem simples, verificando se existe um elemento na página, navegando para determinada URL e verificando se existem alguns elementos naquela página. 

[00:23] Os dois primeiros testes fazem isso. Estou no meu projeto aberto, na classe “NavegandoNaPaginaHome.cs”. Aumentei o zoom da aplicação para ficar melhor a visualização de vocês. 

[00:35] Inclusive, consegui recuperar um código gerado usando outra solução do Selenium, que é o Selenium IDE, que me permite gravar uma macro, um conjunto de passos, usando a interface gráfica.

[00:46] Passo a passo, você vai gravando a execução da ação dentro da página web, e eu consigo recuperar isso depois e exportar para um *script*, que eu consigo recuperar dentro do código C# com xUnit. 

[01:01] Fomos até o “LogandoNoSistema” e nós automatizamos o *login* do usuário no sistema. Inclusive, essa ferramenta gerou alguns códigos para nós de maneira automática, que conseguimos recuperar no código de teste. 

[01:17] Agora vamos evoluir, identificando melhor esses códigos gerados e entendendo melhor o que é esse `By.Id` que eu tenho na linha 47 e o que é esse `LinkText`, que são maneiras que temos para recuperarmos e identificarmos um elemento na página HTML, e trabalharmos em cima dele.

[01:36] Vamos criar um novo teste que vai ser um teste bem simples de funcionalidade: navegar para a página que eu quero, identificar um elemento HTML dentro do código, que vai ser um link, navegar para esse link e clicar nesse link.

[01:56] Então, vou colar agora o código que eu criei para vocês verem. O novo teste é o seguinte: `ValidaLinkDeLoginNaHome`. No `Arrange`, eu preparo as variáveis e o ambiente que eu preciso para o meu teste, e eu preciso de uma nova instância do `ChromeDriver` instalada no projeto. 

![Trecho do código mostrando a estrutura do ValidaLinkDeLoginNaHome](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/03/NET_valida_link_de_login.png)

[02:24] A partir desse momento, eu consigo navegar nesse objeto para determinada URL, com o `Navigate().GoToUrl()`. E aqui é a cereja do bolo: como eu consigo identificar um elemento do HTML e recuperar dentro do código C#.

[02:47] Então,  temo o código `driver.FindElement(By.Linktext("Login"));`. Basicamente, está falando o seguinte: “navegador Chrome, procura o elemento para mim na página que tenha o `LinkText` chamado `Login`”.

[03:08] Se vocês passarem o mouse em cima do método `FindElement`, ele retorna para mim uma instância de web *element*. E a partir desse momento, eu consigo clicar nesse elemento. 

[03:18] Eu estou na página, estou clicando agora no link de `Login`, e quando eu clico, eu vou ser redirecionado para a página de *login*. Na página de *login*, eu vou verificar se encontro, dentro do corpo da página, no *page source*, o texto “img”.

[03:37] Vou startar, com o “Ctrl + F5”, o nosso projeto. Vai carregar essa página para mim, com essa URL “44309” e o link de *login*. “Poxa, mas eu preciso recuperar o ‘Login’, o ‘Home’, um botão que eu tenho na minha página, como faço isso?”.

[04:02] Vamos usar aquele `FindElement.ById` ou `ByLinkText`. Vou abrir só para entendermos como conseguimos identificar esses elementos HTML. É uma das formas. Vou exibir o código-fonte da página.

[04:23] Eu tenho aqui embaixo, na linha 27, o meu link, a *tag* `<a>`, que vai direcionar para `usuarios/login`, que é a minha página de *login*. Então, o `LinkText` que eu tenho é o `Login`. Deixa eu minimizar e voltar para o código.

[04:46] Agora é procurar o `LinkText`.Vou testar agora se meu código está funcionando. Vou salvar o que eu fiz, é importante, e vou abrir o gerenciador de soluções.

[05:00] E vou no método “ValidaLinkLoginNaHome”. Botão direito sobre o método e vou mandar executar. Pode demorar um pouco no começo porque está inicializando o servidor e carregando a página do navegador. 

[05:14] Ele vem para página "Login", só que não fechou a página, vamos corrigir isso mais a frente. Ele abriu a página, essa não é a “Home”, ele carregou essa página, clicou no *link* “Login”, que aparece na página, e veio para cá, para a página “Login”.

[05:36] E verificou, na página “Login”, se eu tenho uma *tag* chamada “img”. Vou abrir o código-fonte. Tem que ter o “img” em algum lugar aqui. Tem aqui, `img`, na linha 35 do meu navegador. 

[06:03] Nosso teste passou, então essa é uma maneira que eu tenho para recuperar o elemento na minha página. No caso, eu quero recuperar um `LinkText`. 

[06:18] Outra maneira seria voltarmos no código que salvamos na última aula, que geramos automaticamente usando o Selenium IDE, e utilizar outro recurso que é o `By.Id`. No HTML é interessante que vocês conheçam o básico: o que é uma *tag*, o que é um atributo. 

[06:42] Um dos tributos que temos no HTML é o "id" para identificar a *tag*, o elemento HTML na minha página. No caso do teste que fizemos, o `ValidaLinkLoginNaHome`, não existe esse id, então eu usei esse recurso `ByLinkText`. 

[07:01] Se tivesse o id, eu poderia mudar e, em vez de `FindElement(By.LinkText())`, seria `(By.Id())`. Não existe esse id no código, então o meu código vai dar um erro agora. Só para mostrar aqui o teste.

[07:20] Abrir o gerenciador de testes novamente, vou “Executar”. Ele não foi para a página “Login”, ele só abriu a página, o teste falhou. Por quê? Eu não consigo encontrar o elemento da minha página HTML que tem o `Id(“Login”)`. O id "*login*" não existe, existe o `LinkText`.

[07:50] Existem outras formas de capturarmos esses elementos da página HTML, mas esses são os dois principais: `LinkText()` e `By.Id()`. Nós criamos mais um teste e identificamos como recuperar um elemento na página para dentro do meu código C#, meu código de teste. 

[08:09] Nós continuaremos, na sequência, validando essa página de “Login”. Agora vamos verificar como eu consigo imputar informações em um campo de texto e trabalhar em cima do “Login”.