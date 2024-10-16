[00:00] Olá, pessoal, tudo bem? Vamos continuar?  Já temos configurada a nossa aplicação, inclusive, já criamos o banco de dados, rodamos migrações utilizando o *lightweight framework core*. Vimos também as ferramentas de testes de interface, e uma dessas ferramentas compõe o Selenium, que é o Selenium IDE.

[00:17] Que é um *plugin* que temos para os principais navegadores que permitem testar, de maneira gráfica, uma interface de uma aplicação web. Mas o nosso objetivo agora é configurar a biblioteca Selenium WebDriver, que vai nos permitir escrever códigos dentro do código C# para podermos manipular esses testes de interface.

[00:37] Vou fechar a aplicação web app, parei a aplicação. Na camada 4 de testes, vou adicionar um novo projeto. Esse projeto vai se chamar “Alura.ByteBank.WebApp.Testes”, vamos seguir um padrão. 

[00:57] Então, clico na pasta teste com o botão direito, vou em “Adicionar > Novo projeto”. Vamos trabalhar esse projeto usando uma biblioteca bem conhecida que é o xUnit. Vou adicionar um projeto de teste usando o xUnit e, dentro do xUnit, vamos trabalhar com o xUnit e Selenium WebDriver.

[01:16] Vou selecionar o projeto, também posso pesquisar na barra de busca “xUnit”, clicar em "Projeto de Teste do xUnit" e clicar em “Próximo” no canto inferior direito da janela. O nome do nosso projeto vai ser “Alura.ByteBank.WebApp.Testes”, seguindo o padrão que estou seguindo nesse projeto. 

[01:50] Clico “Próximo”, vou marcar a “Estrutura de Destino” como “.NET5.0”, vamos pedir para “Criar”. Está rodando a estrutura do projeto. Perfeito, já criou até, inclusive, uma classe de teste do xUnit.

[02:11] Só vou adicionar no código “UnitTest1.cs”, só salvar e já corrigiu as importações. Qual o objetivo agora? É configurarmos o Selenium WebDriver, porque essa biblioteca vai nos permitir criar códigos para oara essa interface web.

[02:34] Virei no projeto de testes, “Alura.ByteBank.WebApp.Testes > Dependências > Pacotes”. Já tenho alguns pacotes aqui, “xunit”, “Microsoft.net.Test.sdk” e “coverlet.collector”. Vou adicionar, clicando com o botão direito sobre "Pacotes",  e clicar em “Gerenciador de Pacotes NuGet”.

[02:57] Na janela que abre, vou selecionar o Selenium WebDriver. Vou pedir para procurar na barra de busca do NuGet “Selenium”. Já apareceu para mim “Selenium WebDriver”. Vou selecionar a biblioteca a versão 4.1.0, que é a estável recente. 

[03:26] Selecionei “Selenium WebDriver”, vou pedir para instalar e vou adicionar essa biblioteca ao meu projeto. Deu algumas mensagens aqui. O NuGet instalou a versão para mim. Vamos verificar nos pacotes.

[03:47] Perfeito, instalou o Selenium WebDriver. Só que é o seguinte, eu preciso de um navegador alvo para fazer os testes. Eu vou trabalhar usando o Chrome e, para o Selenium, para eu utilizar o Chrome como meu navegador, eu preciso também instalar um pacote adicional, uma nova biblioteca para o Chrome. 

[04:10] Procurando no NuGet, eu tenho aqui o pacote “Selenium.WebDriver.ChromeDriver”. Eu preciso dessa biblioteca configurada para fazer os testes no Chrome. 

[04:22] Se eu quisesse testar, por exemplo, usando o Firefox ou o Internet Explorer, eu precisaria também procurar a biblioteca relacionada a esse navegador. Então, vamos selecionar o “ChromeDriver”. Cliquei em cima dele e vou clicar em “Instalar” também.

[04:41] A versão mais recente e mais instável. Vou clicar em “Instalar”, já instalou no meu projeto. Vou fechar o gerenciador de pacotes do NuGet. Agora, na minha solução, eu já tenho instalado e configurado o “WebDriver”, que é a biblioteca que eu preciso usar nos testes.

[04:57] E também tenho adicionado a biblioteca referente ao navegador que eu vou usar como alvo dos meus testes, que é o “ChromeDriver”. No gerenciador de soluções do meu projeto, na camada 4, de testes, eu tenho dois projetos: de testes de domínio e da infraestrutura, e tenho agora também um novo projeto de testes, para testar a aplicação web com o Selenium WebDriver. 

[05:20] Qual a importância disso? Precisamos ter esse ambiente configurado para começarmos os nossos testes. Na sequência, vamos criar o nosso primeiro teste de interface usando a biblioteca Selenium WebDriver.