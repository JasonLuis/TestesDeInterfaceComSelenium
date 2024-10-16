[00:00] Ol�, pessoal, tudo bem? Vamos continuar?  J� temos configurada a nossa aplica��o, inclusive, j� criamos o banco de dados, rodamos migra��es utilizando o *lightweight framework core*. Vimos tamb�m as ferramentas de testes de interface, e uma dessas ferramentas comp�e o Selenium, que � o Selenium IDE.

[00:17] Que � um *plugin* que temos para os principais navegadores que permitem testar, de maneira gr�fica, uma interface de uma aplica��o web. Mas o nosso objetivo agora � configurar a biblioteca Selenium WebDriver, que vai nos permitir escrever c�digos dentro do c�digo C# para podermos manipular esses testes de interface.

[00:37] Vou fechar a aplica��o web app, parei a aplica��o. Na camada 4 de testes, vou adicionar um novo projeto. Esse projeto vai se chamar �Alura.ByteBank.WebApp.Testes�, vamos seguir um padr�o. 

[00:57] Ent�o, clico na pasta teste com o bot�o direito, vou em �Adicionar > Novo projeto�. Vamos trabalhar esse projeto usando uma biblioteca bem conhecida que � o xUnit. Vou adicionar um projeto de teste usando o xUnit e, dentro do xUnit, vamos trabalhar com o xUnit e Selenium WebDriver.

[01:16] Vou selecionar o projeto, tamb�m posso pesquisar na barra de busca �xUnit�, clicar em "Projeto de Teste do xUnit" e clicar em �Pr�ximo� no canto inferior direito da janela. O nome do nosso projeto vai ser �Alura.ByteBank.WebApp.Testes�, seguindo o padr�o que estou seguindo nesse projeto. 

[01:50] Clico �Pr�ximo�, vou marcar a �Estrutura de Destino� como �.NET5.0�, vamos pedir para �Criar�. Est� rodando a estrutura do projeto. Perfeito, j� criou at�, inclusive, uma classe de teste do xUnit.

[02:11] S� vou adicionar no c�digo �UnitTest1.cs�, s� salvar e j� corrigiu as importa��es. Qual o objetivo agora? � configurarmos o Selenium WebDriver, porque essa biblioteca vai nos permitir criar c�digos para oara essa interface web.

[02:34] Virei no projeto de testes, �Alura.ByteBank.WebApp.Testes > Depend�ncias > Pacotes�. J� tenho alguns pacotes aqui, �xunit�, �Microsoft.net.Test.sdk� e �coverlet.collector�. Vou adicionar, clicando com o bot�o direito sobre "Pacotes",  e clicar em �Gerenciador de Pacotes NuGet�.

[02:57] Na janela que abre, vou selecionar o Selenium WebDriver. Vou pedir para procurar na barra de busca do NuGet �Selenium�. J� apareceu para mim �Selenium WebDriver�. Vou selecionar a biblioteca a vers�o 4.1.0, que � a est�vel recente. 

[03:26] Selecionei �Selenium WebDriver�, vou pedir para instalar e vou adicionar essa biblioteca ao meu projeto. Deu algumas mensagens aqui. O NuGet instalou a vers�o para mim. Vamos verificar nos pacotes.

[03:47] Perfeito, instalou o Selenium WebDriver. S� que � o seguinte, eu preciso de um navegador alvo para fazer os testes. Eu vou trabalhar usando o Chrome e, para o Selenium, para eu utilizar o Chrome como meu navegador, eu preciso tamb�m instalar um pacote adicional, uma nova biblioteca para o Chrome. 

[04:10] Procurando no NuGet, eu tenho aqui o pacote �Selenium.WebDriver.ChromeDriver�. Eu preciso dessa biblioteca configurada para fazer os testes no Chrome. 

[04:22] Se eu quisesse testar, por exemplo, usando o Firefox ou o Internet Explorer, eu precisaria tamb�m procurar a biblioteca relacionada a esse navegador. Ent�o, vamos selecionar o �ChromeDriver�. Cliquei em cima dele e vou clicar em �Instalar� tamb�m.

[04:41] A vers�o mais recente e mais inst�vel. Vou clicar em �Instalar�, j� instalou no meu projeto. Vou fechar o gerenciador de pacotes do NuGet. Agora, na minha solu��o, eu j� tenho instalado e configurado o �WebDriver�, que � a biblioteca que eu preciso usar nos testes.

[04:57] E tamb�m tenho adicionado a biblioteca referente ao navegador que eu vou usar como alvo dos meus testes, que � o �ChromeDriver�. No gerenciador de solu��es do meu projeto, na camada 4, de testes, eu tenho dois projetos: de testes de dom�nio e da infraestrutura, e tenho agora tamb�m um novo projeto de testes, para testar a aplica��o web com o Selenium WebDriver. 

[05:20] Qual a import�ncia disso? Precisamos ter esse ambiente configurado para come�armos os nossos testes. Na sequ�ncia, vamos criar o nosso primeiro teste de interface usando a biblioteca Selenium WebDriver.