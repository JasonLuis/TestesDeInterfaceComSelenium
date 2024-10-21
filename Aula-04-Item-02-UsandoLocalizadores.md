[00:00] Já sabemos como identificar um elemento HTML na página e como recuperar isso dentro do nosso código C#, o nosso código de teste utilizando a biblioteca Selenium WebDriver.

[00:15] Podemos recorrer ao recurso de pesquisar pelo id, com esse método `driver.FindElement(By.Id())`. Faço uma busca no código pesquisando pelo id do elemento ou pelo `LinkText` do elemento. Preciso recuperar esse elemento específico para o meu código e, assim, trabalhar com o meu teste. 

[00:39] Existem outras maneiras que podemos recorrer para identificarmos o elemento HTML na nossa biblioteca Selenium WebDriver. Para isso, vou abrir o gerenciador de soluções do meu lado direito e vou escrever um novo código de teste para verificarmos as outras formas que temos disponíveis na biblioteca para fazermos isso.

[01:06] Eu quero fazer um teste da seguinte maneira: eu quero logar na página, acessar o “Adicionar clientes” e adicionar um cliente. Então no final do meu código `AposRealizarLogin`, onde estão as duas últimas chaves, vou colocar o seguinte método. 

[01:28] Vamos analisar linha por linha agora com o `public void RealizarLoginAcessaMenuCadastraCliente` . Esse é o método que eu quero executar. Vou navegar para essa URL para fazer o *login*, já vimos como fazer isso. Vamos recuperar os elementos `login` e `senha` usando o recurso `By.Name()`.

[01:54] Fizemos antes usando o recurso `By.Id()`, então outro recurso que eu quero apresentar para vocês é o `By.Name()`. A primeira alteração aqui.

[02:04] Para inserir informações no campo HTML, uso o `SendKeys()` para o campo `login` e `senha`. Inserir esses valores, vai permitir fazer o *login*. Eu vou clicar no botão, então escrrevo `.Click`, mas repare bem, eu não estou usando nenhum `By.Name`, estou usando o `.CssSelector`.

[02:30] Posso recuperar um elemento usando o id, posso recuperar um elemento usando o `LinkText`, posso recuperar um elemento pelo nome dele, mas se eu não tiver o nome, nem o id, nem o *link* de texto, eu posso recuperar através de um seletor de CSS do elemento HTML específico.

[02:50] Isso expande bastante a nossa possibilidade de utilização do Selenium WebDriver. Vão ter algumas situações que você não vai ter acesso ao HTML da página, ou você vai ter acesso ao HTML da página, mas não vai conseguir acesso ao código-fonte da página para fazer alteração. No caso do produto que estamos testando, que é o ByteBank WebApp, nós temos acesso ao projeto, inclusive ao HTML de determinadas páginas, mas nem sempre vamos ter acesso.

[03:25] Pode ser que, em determinado momento, eu tenha um elemento HTML que não tenha id, nome ou *link* de texto. Como faço? Eu posso usar o recurso `CssSelector`. 

[03:40] Ele é um pouco mais complexo de se utilizar, comparado aos anteriores, porque o *name* e o id você vai encontrar rápido no elemento HTML que está testando, mas para o `By.CssSelector()`, você tem que entender um pouco de CSS.

[04:02] Vou recuperar o botão pelo `CssSelector` dele nessa página, e vou dar um clique, usando o comando`.Click()`. Quando clicar no botão, eu vou para a página “Home” da aplicação e vou clicar em “Cliente”, vou acessar a página de “Cliente”.

[04:21] Depois, vou clicar no “Adicionar Cliente” no *link* texto. Vou clicar no identificador e vou inserir a informação no identificador, usando o método `.SendKeys()`. 

[04:46] Vou procurar o elemento pelo nome CPF e vou clicar. Depois, vou digitar um CPF válido. Para o nome, eu repito o mesmo processo. Insiro a informação do nome e da profissão.

[05:05] Depois, no `Act`, eu vou procurar o elemento usando o `(By.CssSelector(“.btn-primary”)).Click()`, depois o `driver.FindElement(By.LinkText(“Home”))`. Vou procurar se existe o link de retorno para a página “Home” na página de cadastro.

[05:25] No final, dou um `Assert` para verificar se encontro no corpo da página o texto o `Logout`. Estou até com a página aberta da aplicação. Basicamente, vou logar na aplicação, vou em “Clientes”, clicar em “Adicionar Cliente”, inserir as informações que eu preciso e clicar em “Novo”. Quando eu clicar em “Novo”, eu retorno para a página anterior. 

[05:56] Vou acessar o código-fonte da página só para te mostrar detalhes importantes. Aqui tem o menu em HTML. Vai ter material adicional no nosso curso falando sobre HTML, vai ter uma atividade. 

[06:14] Aqui eu tenho o botão, que é `input type=”submit”`. Ele tem valor, não tem o id, mas tem uma classe CSS, `btn btn-primary`. Então, no código, quando eu peço para ele clicar, ele vai procurar essa propriedade `.btn-primary` no botão do elemento da página, ele vai invocar o `Click` do elemento que, no nosso caso, é um botão. 

[06:42] Vou executar agora o cadastro com o uso desse método. Estou na classe `AposRealizarLogin`, abri o gerenciador de soluções no lado esquerdo, e clico com o botão direito em `RealizarLoginAcessaMenuCadastraCliente`, vou executar o método.

[07:05] Deu um erro, vamos verificar o que está acontecendo? Voltando para o gerenciador de testes, ele não conseguiu encontrar um elemento na página usando o Selenium: o método `CssSelector.btn`. 

[07:19] Na linha 101, ele não conseguiu encontrar pelo CSS. Essa página é a página de login ainda. Então, vamos mudar para o `By.Id()`. Vamos acessar a página primeiro? Acho que é o mais recomendável. 

[07:39] “Ctrl + F5”, “Login”, botão direito, “Exibir código-fonte”. Vou usar pelo id porque está com o CSS quebrado. Isso é importante, tem que ter esses recursos adicionais para identificarmos o elemento na página HTML utilizando o Selenium WebDriver.

[08:06] Fechei, vou voltar para o meu código de teste. Aqui, no lugar do `By.CssSelector()`, vai ser o `By.Id()`. Vou logar, agora meu teste tem que passar porque deu erro aqui.

[08:23] Vamos executar de novo o teste? Botão direito, vou executar, está executando. Parou de novo aqui, vamos ver o que está acontecendo? Olha só, o id estava com um **`.`**, é `btn-logar` o nome do código. Vamos continuar, vamos executar o teste novamente. 

[08:43] Botão direito em cima do código, no gerenciador de testes, e vamos executar. Abriu o navegador, fez *login*, adicionou as informações e voltou à página principal. 

[08:57] Então, meu teste passou. O que está acontecendo? Meu `btn-logar` está tentando acessar o CSS dele, só que eu vi que o código da página HTML não está legal, então eu tenho que ajustar esse HTML.

[09:13] Voltei o recurso do id. Eu podia usar o `LinkText` também, o `name` do elemento etc. Essas são outras formas que eu tenho de acessar o elemento no HTML usando a biblioteca WebDriver.

[09:30] Eles são chamados de localizadores, ou *locators*, você pode encontrar em bibliografias e pesquisas por aí. São recursos adicionais que vão ajudar bastante quando não temos o id do elemento, o *link*, o *name*.

[09:47] Podemos utilizar o próprio `name`, o `CssSelector`, que quebrou na primeira parte, mas na segunda parte do método ele funcionou normal. Então, são recursos adicionais que a biblioteca WebDriver proporciona para nós.

[10:07] Na sequência, vamos ver como recuperar mais de um elemento HTML usando essa biblioteca.