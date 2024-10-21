[00:00] Já entendemos como capturar os elementos de uma página HTML e recuperar esse código dentro do C#, do nosso código de teste. 

[00:11] Podemos usar as tags, da biblioteca WebDriver, `By.LinkText`, `By.Id`, `By.Name`. Vamos estudar agora um padrão de projeto que vai facilitar a manutenção futura do nosso código de teste.

[00:27] Imagina só, eu tenho um método de teste logando no sistema em que estou capturando exatamente o `LinkText` e o `Id` no componente visual. No próximo método, também estou trabalhando com `LinkText`.

[00:43] Então se esse elemento na página mudar, pode afetar meus dois testes. Vamos estudar uma maneira de nos precaver quanto às mudanças repentinas de interface para não afetarem todos os nossos testes criados.

[00:57] Por exemplo, temos um elemento no "Login" chamado `Login`, o `Click`, o `Email` e `Senha`. Se eu simplesmente alterar o código-fonte. Deixa eu abrir o código no gerenciador de soluções e fechar o gerenciador de fontes.

[01:18] Vou no projeto de interface da nossa solução e vou na tela de “Login”. Meu “Login” tem um `btn`, tem um botão chamado `Logar`, e vou mudar esse `btn` para `teste`. Vou salvar e compilar meu projeto.

[01:52] Mudou, o desenvolvedor do *front* alterou meu HTML. Agora meu teste vai começar a quebrar, meu teste de *login* que depende daquele botão `btn-logar` com aquele id. 

[02:05] Então vou executar de novo a classe `RealizarLogin`. Vai abrir todos os testes, abrir o navegador várias vezes. Meu código procura o `btn-logar` que não existe mais, foi alterada a interface. Meu teste vai começar a falhar.

[02:28] Isso é um problema que vamos ter quando precisarmos dar manutenção no código. Imagina que eu tenho uma bateria de código de teste, só que ele está dependente de códigos da interface.

[02:40] Eu vou ter que alterar todos esses métodos de testes já criados, o `TentaRealizarLoginComSenhaInvalida`, `AposRealizarLoginVerificaSeExisteComponenteNaTela`, `RealizaLoginAcessaListagemDeClientes`, enfim, vou ter que alterar todos esses códigos de teste para ajustar. 

[02:57] Isso, para manutenção do código, não ajuda muito. Existe um recurso muito interessante que vamos aplicar agora. Vou tentar isolar o HTML do código Selenium.

[03:12] Vou deixar o Selenium em uma camada e o código de teste em outra camada. Vou fechar o gerenciador de testes, vou abrir o gerenciador de soluções. No projeto de testes, vou adicionar um novo diretório. 

[03:36] Botão direito em cima do projeto de testes e vou adicionar uma nova pasta que vou chamar de “PageObjects”. Nessa “PageObjects”, vou criar uma classe que vai ser responsável por encapsular esses elementos de interface do “Login”. 

[04:03] Vou dar um “Ctrl + C” no código disponível na memória e vou criar uma nova classe. Essa nova classe vai se chamar “LoginPO”. No diretório, vou criar uma nova classe e vou chamar de “LoginPO”, de *Page Objects*. 

[04:30] Essa classe vai representar os elementos da interface. Já tenho o código, vou ajustar, dou “Ctrl + V” para adiantar o nosso lado. Essa classe tem que conhecer o meu WebDriver, a minha biblioteca de acesso à interface web da minha aplicação. 

[04:55] Nessa interface, eu preciso do `campoEmail`, do `campoSenha` e do botão `btnLogar`. Fiz ajustes para corrigir esses erros que estão acontecendo porque preciso importar a biblioteca. 

[05:15] “Ctrl + .” ou, no lado esquerdo, você vai acessar “using OpenQASelenium”. É só importar a biblioteca. No construtor dessa classe, vou passar para ela o `WebDriver`.

[05:38] Eu tenho uma classe que vai encapsular para mim os elementos de interface. Eu tenho o `WebDriver` que conhece a interface web, consegue capturar os elementos dessa interface, e, no construtor, eu vou inicializar os campos que eu defini na minha classe `LoginPO` com os elementos capturados pelo ID.

[06:04] Vou criar também um método para navegar para determinada URL e vou fazer um método para preencher os campos da interface. Eu já sei que a funcionalidade que permite que eu insira informações é o `SendKeys()`, então, nesse método eu vou colocar o `SendKeys()` do elemento que eu capturei, vou passar usuário e senha e invocar o `Click` do botão.

[06:30] Vai fazer uma série de coisas em uma classe só, mas tudo relacionado ao login. Isso vai ser útil porque, imagine o seguinte, mudou a interface, eu não tenho mais o ID no elemento, ou não tenho mais o *Name*, eu vou alterar em um ponto só.

[06:47] Isso vai refletir para todos os códigos de testes que fazem uso desse `Login`. Adicionei minha classe, acho que posso fazer melhor ainda. Vou isolar esse `Logar` em outro método.

[07:05] Vou criar o `public void btnClick`. Qual a função do `Click()`? Invocar o método `Click()` do elemento. Removi isso dessa linha 34, deu um erro aqui, `public void btnClick()` da classe `LoginPO`.

[07:45] Vou voltar agora para a minha classe de teste `AposRealizarLogin`. Eu basicamente trabalho com login nessa classe, e vou fazer alterações também nos métodos de teste.

[08:00] Vamos começar pelo primeiro teste, `AposRealizarLogin`. Essa parte do `Arrange`, do `SendKeys()` e do `Click()`, agora vai ser encapsulado – vou dar um “Ctrl + K + C” para bloquear. 

[08:16] Vou criar uma variável `LoginPO`, vou navegar para determinada URL, dar um “Ctrl + C”, vou criar uma variável do tipo `loginPO`, vou passar, como parâmetro da construção, o `driver`.

[08:39] No `loginPO`, vou navegar para a URL que faz o login, vou invocar o método `PreencherCampos`. Aqui, o método que eu criei não é `Logar`, é `btnClick`.

[09:00] Tenho que importar a classe, senão não vai aparecer para mim. “using TestesPageObjects”. Corrigi o que está acontecendo aqui e agora tenho o `btnClick`.

[09:12] `PreencherCampos`, `PO`, está dando um erro aqui. Deixa eu ver o que está acontecendo. “Não existe uma definição de preencher campos”. O método mudou, ele só preenche campos agora, não loga. 

[09:30] Então, `PreencherCampos` e `btnClick`. “Ctrl + S” para salvar. Voltando para a "AposRealizarLogin”, vou criar uma nova variável do tipo `loginPO`, vou preencher os campos, vou clicar no botão e, ao fim disso, vou verificar se, na página que estou naquele momento, existe o texto da “Agência”.

[09:54] Vou até remover isso para cima. O meu `Arrange` passa a ser isso agora, estou criando as variáveis e pegando o ambiente do cenário para poder efetuar o preenchimento das informações do formulário e clicar no botão de login.

[10:11] Então, esse método é `AposRealizarLoginVerificaSeExisteOpcaoAgenciaMenu`. Vou abrir o gerenciador de testes novamente, esse teste não está passando. Botão direito, vou executar e o método não deve passar.

[10:34] Não passou, continua dando falha, porque o meu `loginPO` procura o elemento na página pelo id, o `btn-Logar` pelo id. Esse elemento não tem esse id mais, nem a página. 

[10:54] Vou até voltar na página e vou corrigir isso só para entender que agora eu centralizo em um lugar só, onde vou alterar essas informações. Isso ia ser muito útil na manutenção do código.

[11:08] Em “Apresentação”, na página de “Login”, vou ajustar o teste. Em vez de `teste`, vai ser `btn-Logar`. Salvei, vou fechar, vou abrir o gerenciador de testes novamente, botão direito em cima do método que não passou, e vou pedir para “Executar”.

[11:36] Logou, o teste começou a passar. Então, reparem bem, dessa maneira eu consigo isolar o código do Selenium e o acesso aos elementos da página em uma classe separada, no caso, a `loginPO`.

[11:56] O conceito de `PageObjects` vai nos ajudar bastante no intuito de manter um código de maneira mais fácil. Alterou um elemento da interface que eu referenciei por `Id`, por `name`, por `TagName`, eu altero em um lugar só, só na minha classe de `PageObjects`.

[12:16] E isso eu consigo replicar em outros testes. Eu tenho quinze testes desenvolvidos usando a funcionalidade de `Login`. Essa funcionalidade `PageObjects` vai nos ajudar bastante a manter um código de maneira mais fácil. 

[12:30] Eu altero a interface, de alguma maneira o *name* mudou, o id mudou, o elemento não existe mais na interface. Em vez de refletir cada método de teste, eu vou alterar em um lugar só, na minha classe `PageObjects`.

[12:44] Essa é a principal vantagem que temos ao utilizar esse padrão de projeto. Na sequência, vamos acertar todos os métodos de teste para o padrão `PageObject` e vamos continuar evoluindo nossa aplicação.