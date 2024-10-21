[00:00] J� entendemos como capturar os elementos de uma p�gina HTML e recuperar esse c�digo dentro do C#, do nosso c�digo de teste. 

[00:11] Podemos usar as tags, da biblioteca WebDriver, `By.LinkText`, `By.Id`, `By.Name`. Vamos estudar agora um padr�o de projeto que vai facilitar a manuten��o futura do nosso c�digo de teste.

[00:27] Imagina s�, eu tenho um m�todo de teste logando no sistema em que estou capturando exatamente o `LinkText` e o `Id` no componente visual. No pr�ximo m�todo, tamb�m estou trabalhando com `LinkText`.

[00:43] Ent�o se esse elemento na p�gina mudar, pode afetar meus dois testes. Vamos estudar uma maneira de nos precaver quanto �s mudan�as repentinas de interface para n�o afetarem todos os nossos testes criados.

[00:57] Por exemplo, temos um elemento no "Login" chamado `Login`, o `Click`, o `Email` e `Senha`. Se eu simplesmente alterar o c�digo-fonte. Deixa eu abrir o c�digo no gerenciador de solu��es e fechar o gerenciador de fontes.

[01:18] Vou no projeto de interface da nossa solu��o e vou na tela de �Login�. Meu �Login� tem um `btn`, tem um bot�o chamado `Logar`, e vou mudar esse `btn` para `teste`. Vou salvar e compilar meu projeto.

[01:52] Mudou, o desenvolvedor do *front* alterou meu HTML. Agora meu teste vai come�ar a quebrar, meu teste de *login* que depende daquele bot�o `btn-logar` com aquele id. 

[02:05] Ent�o vou executar de novo a classe `RealizarLogin`. Vai abrir todos os testes, abrir o navegador v�rias vezes. Meu c�digo procura o `btn-logar` que n�o existe mais, foi alterada a interface. Meu teste vai come�ar a falhar.

[02:28] Isso � um problema que vamos ter quando precisarmos dar manuten��o no c�digo. Imagina que eu tenho uma bateria de c�digo de teste, s� que ele est� dependente de c�digos da interface.

[02:40] Eu vou ter que alterar todos esses m�todos de testes j� criados, o `TentaRealizarLoginComSenhaInvalida`, `AposRealizarLoginVerificaSeExisteComponenteNaTela`, `RealizaLoginAcessaListagemDeClientes`, enfim, vou ter que alterar todos esses c�digos de teste para ajustar. 

[02:57] Isso, para manuten��o do c�digo, n�o ajuda muito. Existe um recurso muito interessante que vamos aplicar agora. Vou tentar isolar o HTML do c�digo Selenium.

[03:12] Vou deixar o Selenium em uma camada e o c�digo de teste em outra camada. Vou fechar o gerenciador de testes, vou abrir o gerenciador de solu��es. No projeto de testes, vou adicionar um novo diret�rio. 

[03:36] Bot�o direito em cima do projeto de testes e vou adicionar uma nova pasta que vou chamar de �PageObjects�. Nessa �PageObjects�, vou criar uma classe que vai ser respons�vel por encapsular esses elementos de interface do �Login�. 

[04:03] Vou dar um �Ctrl + C� no c�digo dispon�vel na mem�ria e vou criar uma nova classe. Essa nova classe vai se chamar �LoginPO�. No diret�rio, vou criar uma nova classe e vou chamar de �LoginPO�, de *Page Objects*. 

[04:30] Essa classe vai representar os elementos da interface. J� tenho o c�digo, vou ajustar, dou �Ctrl + V� para adiantar o nosso lado. Essa classe tem que conhecer o meu WebDriver, a minha biblioteca de acesso � interface web da minha aplica��o. 

[04:55] Nessa interface, eu preciso do `campoEmail`, do `campoSenha` e do bot�o `btnLogar`. Fiz ajustes para corrigir esses erros que est�o acontecendo porque preciso importar a biblioteca. 

[05:15] �Ctrl + .� ou, no lado esquerdo, voc� vai acessar �using OpenQASelenium�. � s� importar a biblioteca. No construtor dessa classe, vou passar para ela o `WebDriver`.

[05:38] Eu tenho uma classe que vai encapsular para mim os elementos de interface. Eu tenho o `WebDriver` que conhece a interface web, consegue capturar os elementos dessa interface, e, no construtor, eu vou inicializar os campos que eu defini na minha classe `LoginPO` com os elementos capturados pelo ID.

[06:04] Vou criar tamb�m um m�todo para navegar para determinada URL e vou fazer um m�todo para preencher os campos da interface. Eu j� sei que a funcionalidade que permite que eu insira informa��es � o `SendKeys()`, ent�o, nesse m�todo eu vou colocar o `SendKeys()` do elemento que eu capturei, vou passar usu�rio e senha e invocar o `Click` do bot�o.

[06:30] Vai fazer uma s�rie de coisas em uma classe s�, mas tudo relacionado ao login. Isso vai ser �til porque, imagine o seguinte, mudou a interface, eu n�o tenho mais o ID no elemento, ou n�o tenho mais o *Name*, eu vou alterar em um ponto s�.

[06:47] Isso vai refletir para todos os c�digos de testes que fazem uso desse `Login`. Adicionei minha classe, acho que posso fazer melhor ainda. Vou isolar esse `Logar` em outro m�todo.

[07:05] Vou criar o `public void btnClick`. Qual a fun��o do `Click()`? Invocar o m�todo `Click()` do elemento. Removi isso dessa linha 34, deu um erro aqui, `public void btnClick()` da classe `LoginPO`.

[07:45] Vou voltar agora para a minha classe de teste `AposRealizarLogin`. Eu basicamente trabalho com login nessa classe, e vou fazer altera��es tamb�m nos m�todos de teste.

[08:00] Vamos come�ar pelo primeiro teste, `AposRealizarLogin`. Essa parte do `Arrange`, do `SendKeys()` e do `Click()`, agora vai ser encapsulado � vou dar um �Ctrl + K + C� para bloquear. 

[08:16] Vou criar uma vari�vel `LoginPO`, vou navegar para determinada URL, dar um �Ctrl + C�, vou criar uma vari�vel do tipo `loginPO`, vou passar, como par�metro da constru��o, o `driver`.

[08:39] No `loginPO`, vou navegar para a URL que faz o login, vou invocar o m�todo `PreencherCampos`. Aqui, o m�todo que eu criei n�o � `Logar`, � `btnClick`.

[09:00] Tenho que importar a classe, sen�o n�o vai aparecer para mim. �using TestesPageObjects�. Corrigi o que est� acontecendo aqui e agora tenho o `btnClick`.

[09:12] `PreencherCampos`, `PO`, est� dando um erro aqui. Deixa eu ver o que est� acontecendo. �N�o existe uma defini��o de preencher campos�. O m�todo mudou, ele s� preenche campos agora, n�o loga. 

[09:30] Ent�o, `PreencherCampos` e `btnClick`. �Ctrl + S� para salvar. Voltando para a "AposRealizarLogin�, vou criar uma nova vari�vel do tipo `loginPO`, vou preencher os campos, vou clicar no bot�o e, ao fim disso, vou verificar se, na p�gina que estou naquele momento, existe o texto da �Ag�ncia�.

[09:54] Vou at� remover isso para cima. O meu `Arrange` passa a ser isso agora, estou criando as vari�veis e pegando o ambiente do cen�rio para poder efetuar o preenchimento das informa��es do formul�rio e clicar no bot�o de login.

[10:11] Ent�o, esse m�todo � `AposRealizarLoginVerificaSeExisteOpcaoAgenciaMenu`. Vou abrir o gerenciador de testes novamente, esse teste n�o est� passando. Bot�o direito, vou executar e o m�todo n�o deve passar.

[10:34] N�o passou, continua dando falha, porque o meu `loginPO` procura o elemento na p�gina pelo id, o `btn-Logar` pelo id. Esse elemento n�o tem esse id mais, nem a p�gina. 

[10:54] Vou at� voltar na p�gina e vou corrigir isso s� para entender que agora eu centralizo em um lugar s�, onde vou alterar essas informa��es. Isso ia ser muito �til na manuten��o do c�digo.

[11:08] Em �Apresenta��o�, na p�gina de �Login�, vou ajustar o teste. Em vez de `teste`, vai ser `btn-Logar`. Salvei, vou fechar, vou abrir o gerenciador de testes novamente, bot�o direito em cima do m�todo que n�o passou, e vou pedir para �Executar�.

[11:36] Logou, o teste come�ou a passar. Ent�o, reparem bem, dessa maneira eu consigo isolar o c�digo do Selenium e o acesso aos elementos da p�gina em uma classe separada, no caso, a `loginPO`.

[11:56] O conceito de `PageObjects` vai nos ajudar bastante no intuito de manter um c�digo de maneira mais f�cil. Alterou um elemento da interface que eu referenciei por `Id`, por `name`, por `TagName`, eu altero em um lugar s�, s� na minha classe de `PageObjects`.

[12:16] E isso eu consigo replicar em outros testes. Eu tenho quinze testes desenvolvidos usando a funcionalidade de `Login`. Essa funcionalidade `PageObjects` vai nos ajudar bastante a manter um c�digo de maneira mais f�cil. 

[12:30] Eu altero a interface, de alguma maneira o *name* mudou, o id mudou, o elemento n�o existe mais na interface. Em vez de refletir cada m�todo de teste, eu vou alterar em um lugar s�, na minha classe `PageObjects`.

[12:44] Essa � a principal vantagem que temos ao utilizar esse padr�o de projeto. Na sequ�ncia, vamos acertar todos os m�todos de teste para o padr�o `PageObject` e vamos continuar evoluindo nossa aplica��o.