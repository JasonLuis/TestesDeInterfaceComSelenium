Quando estamos trabalhando com aplicações Web, é importante entender que toda a comunicação gira em torno de uma comunicação HTTP (HyperText Transfer Protocol), sendo o principal protocolo em uso por aplicações de internet que faz uso da arquitetura cliente-servidor. A  estrutura de comunicação HTTP é uma sequência simples de requisição e resposta.

![alt text: A imagem mostra a arquitetura cliente-servidor, do lado esquerdo um computador que representa um cliente e no lado direito um computador que representa um servidor.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/03/aula3-img1.png)


Neste diálogo temos aplicações clientes como um navegador, requisitando algum recurso ou informação do servidor web e, em cada solicitação feita, o protocolo responde com um código de status daquela comunicação. 


Como há a possibilidade que durante a comunicação haja um grande números de status de respostas, existe uma divisão destes por classes de respostas. Temos a seguir algumas classes e exemplos:

* Status 1XX, são status de informação, por exemplo: 100,101.
* Status 2xx, são respostas às solicitações que obtiveram sucesso como: 200(OK), 201 (criado)
* Status 3xx, informa redirecionamento como 300(Múltipla escolha), 302(encontrado).
* Status 4xx, esses revelam status de erro do cliente onde temos de exemplos o 400(requisição inválida), 401(não autorizado), 404 (recurso não encontrado).


Portanto, toda conexão usando HTTP retornará algum status de sucesso ou falha referente à comunicação estabelecida. A lista de códigos é bem extensa, mas entendê-la e conseguir identificar a que situação se refere é de grande ajuda para o trabalho e desenvolvimento de aplicações web modernas.

- [ Códigos de status de respostas HTTP
](https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status).