Quando estamos trabalhando com aplica��es Web, � importante entender que toda a comunica��o gira em torno de uma comunica��o HTTP (HyperText Transfer Protocol), sendo o principal protocolo em uso por aplica��es de internet que faz uso da arquitetura cliente-servidor. A  estrutura de comunica��o HTTP � uma sequ�ncia simples de requisi��o e resposta.

![alt text: A imagem mostra a arquitetura cliente-servidor, do lado esquerdo um computador que representa um cliente e no lado direito um computador que representa um servidor.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/03/aula3-img1.png)


Neste di�logo temos aplica��es clientes como um navegador, requisitando algum recurso ou informa��o do servidor web e, em cada solicita��o feita, o protocolo responde com um c�digo de status daquela comunica��o. 


Como h� a possibilidade que durante a comunica��o haja um grande n�meros de status de respostas, existe uma divis�o destes por classes de respostas. Temos a seguir algumas classes e exemplos:

* Status 1XX, s�o status de informa��o, por exemplo: 100,101.
* Status 2xx, s�o respostas �s solicita��es que obtiveram sucesso como: 200(OK), 201 (criado)
* Status 3xx, informa redirecionamento como 300(M�ltipla escolha), 302(encontrado).
* Status 4xx, esses revelam status de erro do cliente onde temos de exemplos o 400(requisi��o inv�lida), 401(n�o autorizado), 404 (recurso n�o encontrado).


Portanto, toda conex�o usando HTTP retornar� algum status de sucesso ou falha referente � comunica��o estabelecida. A lista de c�digos � bem extensa, mas entend�-la e conseguir identificar a que situa��o se refere � de grande ajuda para o trabalho e desenvolvimento de aplica��es web modernas.

- [ C�digos de status de respostas HTTP
](https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status).