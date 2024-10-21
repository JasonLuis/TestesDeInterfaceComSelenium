[00:00] Já sabemos o que são os *Page Objectos*. Já fizemos até uma refatoração em um método de teste. Vamos ampliar um pouco mais essa refatoração para todos os métodos da classe `AposRealizarLogin` e vamos implementar para a página “Home”, vamos criar um `PageObject` para a página “Home”.

[00:23] Vou fechar o gerenciador de teste em que estão falhando os testes, então precisamos refatorá-los para passarem todos. Em `AposRealizarLogin`, esse `Arrange` e esse `Act`, presentes na refatoração feita, vão se repetir para outros métodos de teste. 

[00:49] Eu posso substituir esse `Arrange` pelo `TentaRealizarLoginSemPreencherCampos`. Vou deletar isso daqui e é esse campo que preciso passar. Esse campo, `PreencherCampos`, vou passar vazio.

[01:14] Meu código ficou um pouco mais enxuto. Em `TentaRealizarLoginComSenhaInvalida` vai meio que repetir, posso apagar até o `Act`.

[01:32] Só que a senha é inválida, vou colocar `senha010`. Vou no `Arrange` do `RealizaLoginAcessaMenuECadastraCliente`. Nessa parte eu vou aproveitar parte do meu código para não precisar refatorar. O `Arrange` posso excluir, até o `Click`.

[01:59] E parte de `Login`, vou substituir pelo nosso `PageObjects`, `loginPO`. Está refatorado quase tudo. Vou excluir o `//Arrange` do último método.

[02:16] Dessa maneira, eu estou refatorando o nosso código de teste. Vamos ver se tudo vai passar agora? Vou fechar o gerenciador de soluções e fixar o gerenciador de testes.

[02:29] Deixa eu verificar se o nosso serviço está rodando. Subiu. Vou rodar todos os testes, os cinco testes do `AposRealizarLogin`. Botão direito em cima do método da classe de teste, “Executar”.

[02:48] Um método foi, o outro parou, logou, percebam que estão abrindo outras abas do navegador. Nossos testes não estão quebrando mais, todos devem ter passado, espero eu.

[03:12] Vamos voltar ao gerenciador de testes. Fechei o navegador, tudo passou. Agora, vamos fazer o mesmo procedimento para a página “Home”. Vou fixar o gerenciador de soluções, do lado direito, e vou criar, dentro da classe do `PageObjects`, uma nova classe `HomePO`.

[03:33] “Adicionar > Nova classe”, “HomePO”. Nós adicionamos essa nova classe e eu tenho uma ajuda no bloco de notas em que eu tenho a definição dessa classe. Vou apagar esse conteúdo, vou colá-la aqui e vamos analisá-la agora. 

[04:04] Eu percorri as importações do `WebDriver` do Selenium. Então, “Ctrl + .”, botão direito e “using OpenQASelenium”. Já ocorreram muitos erros. Eu defini alguns elementos que eu quero recuperar nessa página. 

[04:28] O `linkHome`, `linkContaCorrentes`, `linkClientes` e `linkAgencias`. Na definição do construtor da classe, `homePO`, eu capturo esses elementos usando o Selenium WebDriver.

[04:45] Desenvolvi um método de navegação que é o padrão. Acho que coloquei na outra classe também, vamos ver aqui, `loginPO`, tenho o método de navegação. Eu recebo a URL e navego para aquela página.

[04:59] Voltando para `homePO`, eu tenho o método de clicar no `linkHome`, `linkContaCorrente`, `linkClientes` e `linkAgenciasClick`. Vou fazer uma nova instância da página, novo serviço, “Ctrl + F5”.

[05:32] Está carregando, está compilando, ele abre em outra página. Vou logar na aplicação, “andre@email.com”, “senha01”. Tenho o link da “Home”, da “Agência”, do “Cliente”, “Conta-Corrente” e “Logout”.

[05:57] Essa classe `homePO` que nós criamos vai estar representando esses elementos na nossa página. 

[06:07] Agora, vamos criar novos métodos. Eu preciso refatorar o método `RealizarLoginAcessaListagemDeContas`. Vamos definir outro método para podermos testar essa opção de *home* que temos agora disponível.

[06:36] Vou fazer um método. No final do arquivo, vou criar um novo método, “Ctrl + C” e “Ctrl + V”, porque estou exportando do desenvolvedor. Está dando erro porque não tenho o método `Logar`, é o método de `Clik`, `.btnkClick`.

[07:03] Continua dando erro porque já tem esse método definido nessa classe. Vou definir outro nome para esse método, `RealizaLoginAcessaListagemDeContasUsandoHomePO`. Só para diferenciar de um método para o outro.

[07:38] Vou fazer o `Arrange` e o `Act`. Vou fazer o `login` usando o `loginPO`; vou fazer o `Act`, vou logar na aplicação. Quando logar na aplicação, eu vou estar na página “Home”, então vou criar um objeto `homePO`.

[07:55] Vou passar o `driver` como referência, para poder navegar e encontrar os objetos daquela página, e vou invocar o método `linkContaCorrenteClick`.

[08:06] Vou navegar para `ContaCorrente`. Quando eu navegar para a página “Conta-Corrente”, que é a página *home* da “Conta-Corrente” e que tem a listagem, o que vai acontecer para mim? Verificar se tem o `Adicionar Conta-Corrente` no corpo da página.

[08:18] Vamos testar esse método agora? Salvei meu código, vou abrir o gerenciador de testes, vou fixá-lo novamente. Está em exclamação porque não foi executado ainda, está criado, mas não foi executado. Vamos executá-lo?

[08:26] Botão direito, “Executar”. Logou. Está funcionando o nosso teste, e agora, em vez de eu adicionar muito código nessa classe teste, referente ao Selenium, eu só tenho basicamente o Selenium quando precisa identificar o conteúdo da página. 

[09:00] Então, eu desacoplo, deixo menos dependente o código de teste do código de Selenium, porque eu separei a responsabilidade, eu deixei a responsabilidade de conhecer a biblioteca Selenium para as classes de `PageObjects`.

[09:14] Esse é o principal motivo de usarmos `PageObjects`. É até uma recomendação do próprio Selenium. Estou com a página do Selenium aberta para mostrar para vocês. 

[09:26] Essa página é da documentação do Selenium WebDriver. Entre outras boas práticas, tem o `PageObjects`. Está em inglês, mas podemos mudar em cima, no menu superior, para português. 

[09:40] “Modelos de objetos de página”, “Linguagem específica”, “Gerando estado da aplicação”, “Simulação de serviços externos”, “Relatórios melhorados”, enfim, na página da documentação oficial do Selenium existe também recomendações de boas práticas, e uma delas é o `PageObjects`.

[09:56] Na sequência, vamos implementar algumas refatorações no nosso código para podermos deixá-lo mais resistente a mudanças e mais performático. Percebam só, com botão direito em cima do método, vou executar todos testes de uma vez só, classe `AposRealizarLogin` , sempre que eu executo todos os testes,abre sempre um navegador diferente para cada teste. 

[10:27] Abriu um navegador, mais um navegador e mais um navegador. Isso é um recurso caro para o processamento. A princípio está com poucos testes, mas o conjunto de testes vai estar enorme em algum momento.

[10:42] Note o seguinte, sempre que mandamos executar todos os testes de uma vez, ele executa teste por teste, e cada teste ele abre um próprio navegador para executar.

[10:50] Isso é um recurso que demanda do processador, do sistema operacional, e tem como otimizar a utilização do navegador, porque o teste que estamos fazendo depende de outros recursos, não só do código em si rodando, mas do servidor carregado e também do navegador funcionando. 

[11:16] Dependendo do ambiente que você tem para testar, os recursos, como processador, memória, e o próprio tempo, isso vai influenciá-los bastante. Então, na sequência, vamos ver como otimizar essa situação do nosso código.