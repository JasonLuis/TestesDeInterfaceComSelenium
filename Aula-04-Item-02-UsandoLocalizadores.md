[00:00] J� sabemos como identificar um elemento HTML na p�gina e como recuperar isso dentro do nosso c�digo C#, o nosso c�digo de teste utilizando a biblioteca Selenium WebDriver.

[00:15] Podemos recorrer ao recurso de pesquisar pelo id, com esse m�todo `driver.FindElement(By.Id())`. Fa�o uma busca no c�digo pesquisando pelo id do elemento ou pelo `LinkText` do elemento. Preciso recuperar esse elemento espec�fico para o meu c�digo e, assim, trabalhar com o meu teste. 

[00:39] Existem outras maneiras que podemos recorrer para identificarmos o elemento HTML na nossa biblioteca Selenium WebDriver. Para isso, vou abrir o gerenciador de solu��es do meu lado direito e vou escrever um novo c�digo de teste para verificarmos as outras formas que temos dispon�veis na biblioteca para fazermos isso.

[01:06] Eu quero fazer um teste da seguinte maneira: eu quero logar na p�gina, acessar o �Adicionar clientes� e adicionar um cliente. Ent�o no final do meu c�digo `AposRealizarLogin`, onde est�o as duas �ltimas chaves, vou colocar o seguinte m�todo. 

[01:28] Vamos analisar linha por linha agora com o `public void RealizarLoginAcessaMenuCadastraCliente` . Esse � o m�todo que eu quero executar. Vou navegar para essa URL para fazer o *login*, j� vimos como fazer isso. Vamos recuperar os elementos `login` e `senha` usando o recurso `By.Name()`.

[01:54] Fizemos antes usando o recurso `By.Id()`, ent�o outro recurso que eu quero apresentar para voc�s � o `By.Name()`. A primeira altera��o aqui.

[02:04] Para inserir informa��es no campo HTML, uso o `SendKeys()` para o campo `login` e `senha`. Inserir esses valores, vai permitir fazer o *login*. Eu vou clicar no bot�o, ent�o escrrevo `.Click`, mas repare bem, eu n�o estou usando nenhum `By.Name`, estou usando o `.CssSelector`.

[02:30] Posso recuperar um elemento usando o id, posso recuperar um elemento usando o `LinkText`, posso recuperar um elemento pelo nome dele, mas se eu n�o tiver o nome, nem o id, nem o *link* de texto, eu posso recuperar atrav�s de um seletor de CSS do elemento HTML espec�fico.

[02:50] Isso expande bastante a nossa possibilidade de utiliza��o do Selenium WebDriver. V�o ter algumas situa��es que voc� n�o vai ter acesso ao HTML da p�gina, ou voc� vai ter acesso ao HTML da p�gina, mas n�o vai conseguir acesso ao c�digo-fonte da p�gina para fazer altera��o. No caso do produto que estamos testando, que � o ByteBank WebApp, n�s temos acesso ao projeto, inclusive ao HTML de determinadas p�ginas, mas nem sempre vamos ter acesso.

[03:25] Pode ser que, em determinado momento, eu tenha um elemento HTML que n�o tenha id, nome ou *link* de texto. Como fa�o? Eu posso usar o recurso `CssSelector`. 

[03:40] Ele � um pouco mais complexo de se utilizar, comparado aos anteriores, porque o *name* e o id voc� vai encontrar r�pido no elemento HTML que est� testando, mas para o `By.CssSelector()`, voc� tem que entender um pouco de CSS.

[04:02] Vou recuperar o bot�o pelo `CssSelector` dele nessa p�gina, e vou dar um clique, usando o comando`.Click()`. Quando clicar no bot�o, eu vou para a p�gina �Home� da aplica��o e vou clicar em �Cliente�, vou acessar a p�gina de �Cliente�.

[04:21] Depois, vou clicar no �Adicionar Cliente� no *link* texto. Vou clicar no identificador e vou inserir a informa��o no identificador, usando o m�todo `.SendKeys()`. 

[04:46] Vou procurar o elemento pelo nome CPF e vou clicar. Depois, vou digitar um CPF v�lido. Para o nome, eu repito o mesmo processo. Insiro a informa��o do nome e da profiss�o.

[05:05] Depois, no `Act`, eu vou procurar o elemento usando o `(By.CssSelector(�.btn-primary�)).Click()`, depois o `driver.FindElement(By.LinkText(�Home�))`. Vou procurar se existe o link de retorno para a p�gina �Home� na p�gina de cadastro.

[05:25] No final, dou um `Assert` para verificar se encontro no corpo da p�gina o texto o `Logout`. Estou at� com a p�gina aberta da aplica��o. Basicamente, vou logar na aplica��o, vou em �Clientes�, clicar em �Adicionar Cliente�, inserir as informa��es que eu preciso e clicar em �Novo�. Quando eu clicar em �Novo�, eu retorno para a p�gina anterior. 

[05:56] Vou acessar o c�digo-fonte da p�gina s� para te mostrar detalhes importantes. Aqui tem o menu em HTML. Vai ter material adicional no nosso curso falando sobre HTML, vai ter uma atividade. 

[06:14] Aqui eu tenho o bot�o, que � `input type=�submit�`. Ele tem valor, n�o tem o id, mas tem uma classe CSS, `btn btn-primary`. Ent�o, no c�digo, quando eu pe�o para ele clicar, ele vai procurar essa propriedade `.btn-primary` no bot�o do elemento da p�gina, ele vai invocar o `Click` do elemento que, no nosso caso, � um bot�o. 

[06:42] Vou executar agora o cadastro com o uso desse m�todo. Estou na classe `AposRealizarLogin`, abri o gerenciador de solu��es no lado esquerdo, e clico com o bot�o direito em `RealizarLoginAcessaMenuCadastraCliente`, vou executar o m�todo.

[07:05] Deu um erro, vamos verificar o que est� acontecendo? Voltando para o gerenciador de testes, ele n�o conseguiu encontrar um elemento na p�gina usando o Selenium: o m�todo `CssSelector.btn`. 

[07:19] Na linha 101, ele n�o conseguiu encontrar pelo CSS. Essa p�gina � a p�gina de login ainda. Ent�o, vamos mudar para o `By.Id()`. Vamos acessar a p�gina primeiro? Acho que � o mais recomend�vel. 

[07:39] �Ctrl + F5�, �Login�, bot�o direito, �Exibir c�digo-fonte�. Vou usar pelo id porque est� com o CSS quebrado. Isso � importante, tem que ter esses recursos adicionais para identificarmos o elemento na p�gina HTML utilizando o Selenium WebDriver.

[08:06] Fechei, vou voltar para o meu c�digo de teste. Aqui, no lugar do `By.CssSelector()`, vai ser o `By.Id()`. Vou logar, agora meu teste tem que passar porque deu erro aqui.

[08:23] Vamos executar de novo o teste? Bot�o direito, vou executar, est� executando. Parou de novo aqui, vamos ver o que est� acontecendo? Olha s�, o id estava com um **`.`**, � `btn-logar` o nome do c�digo. Vamos continuar, vamos executar o teste novamente. 

[08:43] Bot�o direito em cima do c�digo, no gerenciador de testes, e vamos executar. Abriu o navegador, fez *login*, adicionou as informa��es e voltou � p�gina principal. 

[08:57] Ent�o, meu teste passou. O que est� acontecendo? Meu `btn-logar` est� tentando acessar o CSS dele, s� que eu vi que o c�digo da p�gina HTML n�o est� legal, ent�o eu tenho que ajustar esse HTML.

[09:13] Voltei o recurso do id. Eu podia usar o `LinkText` tamb�m, o `name` do elemento etc. Essas s�o outras formas que eu tenho de acessar o elemento no HTML usando a biblioteca WebDriver.

[09:30] Eles s�o chamados de localizadores, ou *locators*, voc� pode encontrar em bibliografias e pesquisas por a�. S�o recursos adicionais que v�o ajudar bastante quando n�o temos o id do elemento, o *link*, o *name*.

[09:47] Podemos utilizar o pr�prio `name`, o `CssSelector`, que quebrou na primeira parte, mas na segunda parte do m�todo ele funcionou normal. Ent�o, s�o recursos adicionais que a biblioteca WebDriver proporciona para n�s.

[10:07] Na sequ�ncia, vamos ver como recuperar mais de um elemento HTML usando essa biblioteca.