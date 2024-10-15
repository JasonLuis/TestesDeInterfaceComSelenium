[00:00] Olá, pessoal, tudo bom? Continuando, já temos a nossa aplicação configurada. Vou inciar a aplicação web agora ASP .NET MVC. Vou startar a aplicação pelo Visual Studio Community, apertando o play na barra superior do Visual Studio.

[00:20] Essa ação iniciará o IIS, o nosso servidor web da Microsoft, e implantará uma solução, que é o Alura ByteBank, o ABB app.

[00:31] Carregou a aplicação. Vou fazer o *login* na aplicação. Cliquei em “Login”, vou usar o e-mail para logar, “andre@email.com”, e a senha é “senha01”. Loguei.

[00:49] Foi habilitado para mim os menus “Home”, “Agência”, “Cliente” e “Conta Corrente”. Vou cadastrar agora uma agência. O ByteBank já carrega no banco as informações de agência que eu tenho aqui.

[01:03] Vou adicionar uma nova agência, o número da agência “17896”; o nome da agência, “Agência Central”; o endereço, “Rua Jerônimo Monteiro”; e o identificador que é um *guide*, já tenho na memória e vou utilizá-lo. 

[01:33] Cliquei em “Novo”, cadastrou a “Agência Central” – tem duas agências centrais agora, posso excluir. Vou fazer o *logout* da aplicação e voltei para a tela de *login*.

[01:47] Existem alguns passos repetitivos que eu posso automatizar, como a maneira de testar, evitar retrabalho. Eu tenho um dos *frameworks* recentes no mercado para trabalhar com aplicações web, o Selenium WebDriver. Vou abrir para vocês o site <a href="https://www.selenium.dev/" target="_blank">selenium.dev</a>.

[02:16] Esse é o site oficial do Selenium. O Selenium hoje é composto por algumas soluções. Eu tenho o Selenium WebDriver, o nosso foco do curso, que é uma biblioteca para criar testes de interface e testes *end-to-end*.

[02:32] O Selenium IDE e o Selenium Grid. O Selenium Grid permite fazer testes de maneira distribuída, com outros navegadores, outros servidores, outros centros operacionais, então é interessante usar essa solução.

[02:45] O Selenium é a biblioteca que vamos usar dentro do **C# (C Sharp)**, do código de teste. Temos também o Selenium IDE, uma solução *open source*, e tem disponível para o Chrome e para o Firefox. Por quê?

[03:06] Porque ele é um *plugin* de navegador que vai nos permitir gravar uma macro, executando passos repetitivos de uma interface web. Imagine, por exemplo, eu preciso acessar o painel administrativo e executar uma série de rotinas. Isso é repetitivo, os dados vão ser sempre os mesmos, por exemplo.

[03:27] Então, é interessante você gravar isso e mandar rodar depois em determinado momento. O Selenium IDE ajudar com isso. De novo, hoje temos o Selenium IDE disponível para o Chrome e para o Firefox.

[03:41] Então, ele é um *plugin* e é bem simples de instalar. Vai ter um material adicional falando sobre o Selenium IDE e comentando sobre Selenium Grid no nosso curso.

[03:52] Nos *plug-in*'s do navegador, vou clicar no botão que abre a lista de *plug-is*'s, já tenho a extensão “Selenium IDE” instalada para o Chrome. Vou clicar nela e iniciar. Essa é interface do Selenium IDE. Deixa só eu fechar a janela aberta atrás. 

[04:11] O Selenium IDE me permite fazer o quê? Que eu grave uma série de passos e eu repito isso depois de maneira automatizada, esse passo a passo. Então, vou criar um novo teste de exemplo.

[04:24] Vou chamar de “LogandoNoSistema”, clicar em “Ok”, e eu preciso usar a URL base. Tenho que voltar para o meu projeto. Vou pará-lo e executá-lo utilizando o “Ctrl + F5”.

[04:48] Ele startou a janela aberta. Essa é a URL que eu quero testar, “localhost:44309”. “Ctrl + C”, vou minimizar a janela que abriu e a janela do programa e voltar para a tela do Selenium IDE. 

[05:07] Vou colocar aqui a URL base, que é a URL para testar. Repare bem que agora que coloquei a URL, apareceu para mim a opção “START RECORDING”, o botão ao lado do "CANCEL" para eu poder gravar. 

[05:18] Começou a gravar, abriu o *start* da minha aplicação, vou clicar em “Login”, vou colocar o e-mail e a senha “senha01”, e vou logar. Repare que no canto inferior esquerdo está escrito “START RECORDING” porque está gravando, .

[05:41] Vou parar aqui, dei um clique, tudo está sendo gravado. Vou fazer o *logout*, voltei para o meunu principal, vou fechar o navegador e aqui vou parar a gravação dentro do Selenium IDE.

[06:01] Vou colocar um nome para esse teste, que ele chama de teste, mas, na verdade, é uma macro. Vou chamar também de “LogandoNoSistema”. O “LogandoNoSitema”, o que ele faz? Aqui eu tenho uma série de comandos que são executados pela ferramenta, que é aquele passo a passo que eu quero automatizar por ser uma execução repetitiva, enfim, eu quero automatizar aquele passo a passo.

[06:40] Primeiro, abre o navegador; segundo passo, configura o tamanho da janela do navegador da URL “localhost44309; vai clicar no *login*, vai clicar no ID, no e-mail; no próximo, vai escrever o e-mail “andre@email.com”; em algum momento depois, vai inserir a senha e vai clicar no botão “btm-logar”.

[07:17] Vai dar um clique no “css-html” e vai fechar a janela. Esse é o passo a passo gerado pelo Selenium IDE. Mas no que isso vai me ajudar? Eu vou conseguir utilizar isso em algum momento?

[07:31] Eu quero automatizar a interface, abrir, fazer o *login* na aplicação, achar uma funcionalidade que seja repetitiva, isso vai me ajudar bastante, mas o Selenium IDE também faz uso da ferramenta chamada Selenium WebDriver.

[07:46] A biblioteca vai nos permitir automatizar nossos códigos e criar códigos de teste para a interface. Repare que no um teste que foi criado – que não é um teste, é um *script*, nesse início, eu consigo salvar isso para utilizar depois em outros momentos.

[08:06] Seja para repetir esse passo a passo, para executar, ou simplesmente para gerar esse código e aproveitá-lo dentro do código de teste. Ainda na Selenium IDE, vou clicar em “Play” só para executar novamente, porque estou falando que ele executa, mas temos que testar também. 

[08:23] Vou testar executando “Run current test”. Vou clicar no *play* e notamos que abriu a aplicação, logou, fechou. É bem rápido. Então, ele abre o navegador, seta as informações de *login*, faz o *login*, acesso o menu, faz o *logout* e sai da aplicação.

[08:46] Esse teste eu vou salvar agora. Vou clicar com botão direito sobre o nome do arquivo na coluna do lado esquerdo, vou exportar esse *script*, porque eu quero reaproveitá-lo em algum momento futuro. Clico em “Export”. Repare bem, essa janela que abriu é interessante porque eu consigo salvar esse *script* gerado usando C#, com as bibliotecas de teste NUnit e xUnit, Java JUnit, JavaScript, Python e Ruby.

[09:16] Posso incluir comentários, enfim, vamos explorar muito o Selenium IDE. A principal vantagem é podermos exportar esse *script* para dentro do código C# e utilizar esse *script* como um teste.

[09:31] Vou marcar C# com xUnit, que é a ferramenta que vamos utilizar durante o curso em conjunto com o Selenium. Vou clicar em “Export” e salvar na área de trabalho.

[09:43] Depois vamos recuperar esse arquivo. Salvei. Já salva na minha máquina. Então aparece o arquivo “LogandoNoSistemaTest.cs”. Vou abrir esse arquivo, vai abrir automaticamente para mim dentro do Visual Studio Community.

[10:07] Repare bem que tem uma classe `SuiteTests` e tem um teste aqui dentro chamado “LogandoNoSistema”, que é o que eu defini na interface do Selenium IDE. 

[10:19] Ele importa umas bibliotecas aqui de *Driver* e JavaScript. Como estou trabalhando com o navegador Chrome, ele importa também a biblioteca do `ChromeDriver`, que vamos utilizar na sequência para criar nossos testes usando o Selenium.

[10:39] Ele cria um teste, usando o xUnit, com o passo a passo do que foi feito e traduzindo o código do *script* em um código inteligível em C#. Isso é muito interessante. 

[10:55] Não vai rodar a aplicação agora porque eu tenho que fazer umas configurações nesse arquivo que vamos ver na sequência, mas qual a vantagem de eu trabalhar com uma ferramenta como o Selenium IDE?

[11:07] Automatização de tarefas repetitivas na interface e aproveitar o código gerado para trabalhar como teste na minha suíte de testes usando o xUnit e usando o código C#.

[11:24] Além de permitir que eu entenda como funciona e qual o código gerado. Isso nos ajuda muito a entender e criar nossos próprios códigos de testes dentro do xUnit.

[11:36] Na sequência, continuaremos falando sobre o Selenium WebDriver que é essa biblioteca do Selenium que vai nos ajudar bastante na escrita dos nossos testes para automatizar os testes de interface. 

[11:52] Nos vemos na sequência.