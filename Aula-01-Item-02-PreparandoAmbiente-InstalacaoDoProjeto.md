No processo de configura��o do nosso ambiente, utilizaremos o banco de dados MySQL e portanto precisamos realizar a instala��o dele. Agora veremos como fazer o download e a configura��o b�sica.

Na [p�gina oficial da ferramenta](https://dev.mysql.com/downloads) selecione a op��o de download. Estamos trabalhando com a vers�o para Windows:
  
![alt text: Na imagem vemos a p�gina de download da ferramenta MySQL Community](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/01/aula1-img1.png)






Execute o instalador ap�s o t�rmino do download e selecione  �Developer Default�, que traz como op��o a instala��o do MySQL Workbench tamb�m.

![alt text: Na imagem vemos a tela do instalador Windows do MySQL Community com a op��o �Developer Default� selecionada.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/01/aula1-img2.png)


Proceda a instala��o dos componentes clicando no bot�o �Execute�, como mostrado na imagem:
  

![alt text: Na imagem � apresentada a tela do instalador Windows do MySQL Community, mostrando os componentes que ser�o instalados,incluindo o MySQL e MySQL Worbench.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/01/aula1-img3.png)


Durante o processo de instala��o devemos prestar aten��o � configura��o da senha de acesso ao servi�o de banco de dados do MySQL, porque na cria��o da string de conex�o vamos utilizar essa informa��o.


Com as ferramentas instaladas, acesse o MySQL Workbench e crie um schema `bytebankbd`, como na imagem abaixo:
 

![alt text: Na imagem � apresentado a tela do instalador MySQL Worbench com o schema `bytebankbd` criado.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/01/aula1-img4.png)

Baixe o projeto do curso aqui: https://github.com/alura-cursos/Alura.ByteBank.WebApp/archive/refs/heads/aula01.zip

Para execu��o do projeto estamos trabalhando com a `IDE Visual Studio Community 2019` e na vers�o `.NET 5`, lembre-se de verificar esses pontos antes de iniciar, beleza?

Abrindo a nossa solu��o �Alura.ByteBank�, v� at� a classe `ByteBankContexto` no projeto e configure a string de conex�o no m�todo `OnConfiguring`.

![alt text: Tela do MS Visual Studio Community, para o projeto `Alura.ByteBank.Dados` com a classe `ByteBankContexto` exibindo a string de conex�o no m�todo `OnConfiguring`.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/01/aula1-img5.png)


Com o projeto de dados aberto verificar e instalar as depend�ncias do entity framework e pomelo (provedor de acesso ao banco de dados do MySQL, ferramenta que vai possibilitar o projeto se comunicar com o banco do MySQL).

![alt text: Na imagem � apresentado um recorte do gerenciador de solu��es do visual studio, no projeto de dados e apresentando os pacotes de instala��o necess�rios: EntityFramework Core e Pomelo.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/01/aula1-img6.png)

Verificar e adicionar o projeto de dom�nio, que cont�m as entidades.
  
![alt text: Na imagem � apresentado um recorte do gerenciador de solu��es do visual studio, no projeto de dados e apresentando a adi��o do projeto de dom�nio da solu��o.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/01/aula1-img7.png)


Para configurar o banco de dados, devemos executar todas as migra��es da pasta �Migrations� executando o comando `dotnet ef database update`. Voc� pode abrir o projeto de dados pelo prompt de comando do `gerenciador de pcotes do nuget`, e acessar o projeto usando `cd .\Alura.ByteBank.Dados` observe a imagem abaixo:

![Insira aqui a descri��o dessa imagem para ajudar na acessibilidade](https://cdn1.gnarususercontent.com.br/1/787997/df426626-7e36-4dda-a7bd-327f885fa962.png)  

![alt text: Na imagem � apresentado um recorte do gerenciador de solu��es do visual studio, no projeto de dados as migra��es que devem ser executadas.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/01/aula1-img8.png)


Ap�s a execu��o, abrir a ferramenta de gest�o da base de dados MySQL Workbench e verificar se as tabelas foram criadas e os dados inseridos corretamente.
  

![alt text: Na imagem � apresentado um recorte do MySQL WorkBench mostrando as tabelas do banco de dados.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/01/aula1-img9.png)

Agora podemos come�ar!