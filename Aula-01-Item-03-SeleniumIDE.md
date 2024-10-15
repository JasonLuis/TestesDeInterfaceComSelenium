[00:00] Ol�, pessoal, tudo bom? Continuando, j� temos a nossa aplica��o configurada. Vou inciar a aplica��o web agora ASP .NET MVC. Vou startar a aplica��o pelo Visual Studio Community, apertando o play na barra superior do Visual Studio.

[00:20] Essa a��o iniciar� o IIS, o nosso servidor web da Microsoft, e implantar� uma solu��o, que � o Alura ByteBank, o ABB app.

[00:31] Carregou a aplica��o. Vou fazer o *login* na aplica��o. Cliquei em �Login�, vou usar o e-mail para logar, �andre@email.com�, e a senha � �senha01�. Loguei.

[00:49] Foi habilitado para mim os menus �Home�, �Ag�ncia�, �Cliente� e �Conta Corrente�. Vou cadastrar agora uma ag�ncia. O ByteBank j� carrega no banco as informa��es de ag�ncia que eu tenho aqui.

[01:03] Vou adicionar uma nova ag�ncia, o n�mero da ag�ncia �17896�; o nome da ag�ncia, �Ag�ncia Central�; o endere�o, �Rua Jer�nimo Monteiro�; e o identificador que � um *guide*, j� tenho na mem�ria e vou utiliz�-lo. 

[01:33] Cliquei em �Novo�, cadastrou a �Ag�ncia Central� � tem duas ag�ncias centrais agora, posso excluir. Vou fazer o *logout* da aplica��o e voltei para a tela de *login*.

[01:47] Existem alguns passos repetitivos que eu posso automatizar, como a maneira de testar, evitar retrabalho. Eu tenho um dos *frameworks* recentes no mercado para trabalhar com aplica��es web, o Selenium WebDriver. Vou abrir para voc�s o site <a href="https://www.selenium.dev/" target="_blank">selenium.dev</a>.

[02:16] Esse � o site oficial do Selenium. O Selenium hoje � composto por algumas solu��es. Eu tenho o Selenium WebDriver, o nosso foco do curso, que � uma biblioteca para criar testes de interface e testes *end-to-end*.

[02:32] O Selenium IDE e o Selenium Grid. O Selenium Grid permite fazer testes de maneira distribu�da, com outros navegadores, outros servidores, outros centros operacionais, ent�o � interessante usar essa solu��o.

[02:45] O Selenium � a biblioteca que vamos usar dentro do **C# (C Sharp)**, do c�digo de teste. Temos tamb�m o Selenium IDE, uma solu��o *open source*, e tem dispon�vel para o Chrome e para o Firefox. Por qu�?

[03:06] Porque ele � um *plugin* de navegador que vai nos permitir gravar uma macro, executando passos repetitivos de uma interface web. Imagine, por exemplo, eu preciso acessar o painel administrativo e executar uma s�rie de rotinas. Isso � repetitivo, os dados v�o ser sempre os mesmos, por exemplo.

[03:27] Ent�o, � interessante voc� gravar isso e mandar rodar depois em determinado momento. O Selenium IDE ajudar com isso. De novo, hoje temos o Selenium IDE dispon�vel para o Chrome e para o Firefox.

[03:41] Ent�o, ele � um *plugin* e � bem simples de instalar. Vai ter um material adicional falando sobre o Selenium IDE e comentando sobre Selenium Grid no nosso curso.

[03:52] Nos *plug-in*'s do navegador, vou clicar no bot�o que abre a lista de *plug-is*'s, j� tenho a extens�o �Selenium IDE� instalada para o Chrome. Vou clicar nela e iniciar. Essa � interface do Selenium IDE. Deixa s� eu fechar a janela aberta atr�s. 

[04:11] O Selenium IDE me permite fazer o qu�? Que eu grave uma s�rie de passos e eu repito isso depois de maneira automatizada, esse passo a passo. Ent�o, vou criar um novo teste de exemplo.

[04:24] Vou chamar de �LogandoNoSistema�, clicar em �Ok�, e eu preciso usar a URL base. Tenho que voltar para o meu projeto. Vou par�-lo e execut�-lo utilizando o �Ctrl + F5�.

[04:48] Ele startou a janela aberta. Essa � a URL que eu quero testar, �localhost:44309�. �Ctrl + C�, vou minimizar a janela que abriu e a janela do programa e voltar para a tela do Selenium IDE. 

[05:07] Vou colocar aqui a URL base, que � a URL para testar. Repare bem que agora que coloquei a URL, apareceu para mim a op��o �START RECORDING�, o bot�o ao lado do "CANCEL" para eu poder gravar. 

[05:18] Come�ou a gravar, abriu o *start* da minha aplica��o, vou clicar em �Login�, vou colocar o e-mail e a senha �senha01�, e vou logar. Repare que no canto inferior esquerdo est� escrito �START RECORDING� porque est� gravando, .

[05:41] Vou parar aqui, dei um clique, tudo est� sendo gravado. Vou fazer o *logout*, voltei para o meunu principal, vou fechar o navegador e aqui vou parar a grava��o dentro do Selenium IDE.

[06:01] Vou colocar um nome para esse teste, que ele chama de teste, mas, na verdade, � uma macro. Vou chamar tamb�m de �LogandoNoSistema�. O �LogandoNoSitema�, o que ele faz? Aqui eu tenho uma s�rie de comandos que s�o executados pela ferramenta, que � aquele passo a passo que eu quero automatizar por ser uma execu��o repetitiva, enfim, eu quero automatizar aquele passo a passo.

[06:40] Primeiro, abre o navegador; segundo passo, configura o tamanho da janela do navegador da URL �localhost44309; vai clicar no *login*, vai clicar no ID, no e-mail; no pr�ximo, vai escrever o e-mail �andre@email.com�; em algum momento depois, vai inserir a senha e vai clicar no bot�o �btm-logar�.

[07:17] Vai dar um clique no �css-html� e vai fechar a janela. Esse � o passo a passo gerado pelo Selenium IDE. Mas no que isso vai me ajudar? Eu vou conseguir utilizar isso em algum momento?

[07:31] Eu quero automatizar a interface, abrir, fazer o *login* na aplica��o, achar uma funcionalidade que seja repetitiva, isso vai me ajudar bastante, mas o Selenium IDE tamb�m faz uso da ferramenta chamada Selenium WebDriver.

[07:46] A biblioteca vai nos permitir automatizar nossos c�digos e criar c�digos de teste para a interface. Repare que no um teste que foi criado � que n�o � um teste, � um *script*, nesse in�cio, eu consigo salvar isso para utilizar depois em outros momentos.

[08:06] Seja para repetir esse passo a passo, para executar, ou simplesmente para gerar esse c�digo e aproveit�-lo dentro do c�digo de teste. Ainda na Selenium IDE, vou clicar em �Play� s� para executar novamente, porque estou falando que ele executa, mas temos que testar tamb�m. 

[08:23] Vou testar executando �Run current test�. Vou clicar no *play* e notamos que abriu a aplica��o, logou, fechou. � bem r�pido. Ent�o, ele abre o navegador, seta as informa��es de *login*, faz o *login*, acesso o menu, faz o *logout* e sai da aplica��o.

[08:46] Esse teste eu vou salvar agora. Vou clicar com bot�o direito sobre o nome do arquivo na coluna do lado esquerdo, vou exportar esse *script*, porque eu quero reaproveit�-lo em algum momento futuro. Clico em �Export�. Repare bem, essa janela que abriu � interessante porque eu consigo salvar esse *script* gerado usando C#, com as bibliotecas de teste NUnit e xUnit, Java JUnit, JavaScript, Python e Ruby.

[09:16] Posso incluir coment�rios, enfim, vamos explorar muito o Selenium IDE. A principal vantagem � podermos exportar esse *script* para dentro do c�digo C# e utilizar esse *script* como um teste.

[09:31] Vou marcar C# com xUnit, que � a ferramenta que vamos utilizar durante o curso em conjunto com o Selenium. Vou clicar em �Export� e salvar na �rea de trabalho.

[09:43] Depois vamos recuperar esse arquivo. Salvei. J� salva na minha m�quina. Ent�o aparece o arquivo �LogandoNoSistemaTest.cs�. Vou abrir esse arquivo, vai abrir automaticamente para mim dentro do Visual Studio Community.

[10:07] Repare bem que tem uma classe `SuiteTests` e tem um teste aqui dentro chamado �LogandoNoSistema�, que � o que eu defini na interface do Selenium IDE. 

[10:19] Ele importa umas bibliotecas aqui de *Driver* e JavaScript. Como estou trabalhando com o navegador Chrome, ele importa tamb�m a biblioteca do `ChromeDriver`, que vamos utilizar na sequ�ncia para criar nossos testes usando o Selenium.

[10:39] Ele cria um teste, usando o xUnit, com o passo a passo do que foi feito e traduzindo o c�digo do *script* em um c�digo intelig�vel em C#. Isso � muito interessante. 

[10:55] N�o vai rodar a aplica��o agora porque eu tenho que fazer umas configura��es nesse arquivo que vamos ver na sequ�ncia, mas qual a vantagem de eu trabalhar com uma ferramenta como o Selenium IDE?

[11:07] Automatiza��o de tarefas repetitivas na interface e aproveitar o c�digo gerado para trabalhar como teste na minha su�te de testes usando o xUnit e usando o c�digo C#.

[11:24] Al�m de permitir que eu entenda como funciona e qual o c�digo gerado. Isso nos ajuda muito a entender e criar nossos pr�prios c�digos de testes dentro do xUnit.

[11:36] Na sequ�ncia, continuaremos falando sobre o Selenium WebDriver que � essa biblioteca do Selenium que vai nos ajudar bastante na escrita dos nossos testes para automatizar os testes de interface. 

[11:52] Nos vemos na sequ�ncia.