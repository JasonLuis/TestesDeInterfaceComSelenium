No processo de configuração do nosso ambiente, utilizaremos o banco de dados MySQL e portanto precisamos realizar a instalação dele. Agora veremos como fazer o download e a configuração básica.

Na [página oficial da ferramenta](https://dev.mysql.com/downloads) selecione a opção de download. Estamos trabalhando com a versão para Windows:
  
![alt text: Na imagem vemos a página de download da ferramenta MySQL Community](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/01/aula1-img1.png)






Execute o instalador após o término do download e selecione  “Developer Default”, que traz como opção a instalação do MySQL Workbench também.

![alt text: Na imagem vemos a tela do instalador Windows do MySQL Community com a opção “Developer Default” selecionada.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/01/aula1-img2.png)


Proceda a instalação dos componentes clicando no botão ”Execute”, como mostrado na imagem:
  

![alt text: Na imagem é apresentada a tela do instalador Windows do MySQL Community, mostrando os componentes que serão instalados,incluindo o MySQL e MySQL Worbench.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/01/aula1-img3.png)


Durante o processo de instalação devemos prestar atenção à configuração da senha de acesso ao serviço de banco de dados do MySQL, porque na criação da string de conexão vamos utilizar essa informação.


Com as ferramentas instaladas, acesse o MySQL Workbench e crie um schema `bytebankbd`, como na imagem abaixo:
 

![alt text: Na imagem é apresentado a tela do instalador MySQL Worbench com o schema `bytebankbd` criado.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/01/aula1-img4.png)

Baixe o projeto do curso aqui: https://github.com/alura-cursos/Alura.ByteBank.WebApp/archive/refs/heads/aula01.zip

Para execução do projeto estamos trabalhando com a `IDE Visual Studio Community 2019` e na versão `.NET 5`, lembre-se de verificar esses pontos antes de iniciar, beleza?

Abrindo a nossa solução “Alura.ByteBank”, vá até a classe `ByteBankContexto` no projeto e configure a string de conexão no método `OnConfiguring`.

![alt text: Tela do MS Visual Studio Community, para o projeto `Alura.ByteBank.Dados` com a classe `ByteBankContexto` exibindo a string de conexão no método `OnConfiguring`.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/01/aula1-img5.png)


Com o projeto de dados aberto verificar e instalar as dependências do entity framework e pomelo (provedor de acesso ao banco de dados do MySQL, ferramenta que vai possibilitar o projeto se comunicar com o banco do MySQL).

![alt text: Na imagem é apresentado um recorte do gerenciador de soluções do visual studio, no projeto de dados e apresentando os pacotes de instalação necessários: EntityFramework Core e Pomelo.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/01/aula1-img6.png)

Verificar e adicionar o projeto de domínio, que contém as entidades.
  
![alt text: Na imagem é apresentado um recorte do gerenciador de soluções do visual studio, no projeto de dados e apresentando a adição do projeto de domínio da solução.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/01/aula1-img7.png)


Para configurar o banco de dados, devemos executar todas as migrações da pasta “Migrations” executando o comando `dotnet ef database update`. Você pode abrir o projeto de dados pelo prompt de comando do `gerenciador de pcotes do nuget`, e acessar o projeto usando `cd .\Alura.ByteBank.Dados` observe a imagem abaixo:

![Insira aqui a descrição dessa imagem para ajudar na acessibilidade](https://cdn1.gnarususercontent.com.br/1/787997/df426626-7e36-4dda-a7bd-327f885fa962.png)  

![alt text: Na imagem é apresentado um recorte do gerenciador de soluções do visual studio, no projeto de dados as migrações que devem ser executadas.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/01/aula1-img8.png)


Após a execução, abrir a ferramenta de gestão da base de dados MySQL Workbench e verificar se as tabelas foram criadas e os dados inseridos corretamente.
  

![alt text: Na imagem é apresentado um recorte do MySQL WorkBench mostrando as tabelas do banco de dados.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/01/aula1-img9.png)

Agora podemos começar!