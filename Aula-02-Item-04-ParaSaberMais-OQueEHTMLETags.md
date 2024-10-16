![alt text: A imagem mostra o texto HTML.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/02/aula2-img3.png)


O HTML existe desde os prim�rdios da web e � a maneira padronizada de estruturarmos uma p�gina Web. O HTML ou HyperText Markup Language, � uma linguagem de marca��o que nos permite construir uma p�gina Web, que poder� ser renderizada em um navegador de sua escolha e assim compor um website ou sistema web. 


At� o momento da publica��o deste curso, o HTML encontra-se na vers�o 5 e � mantida pelo W3C (World Wide Web Consortium) - um cons�rcio internacional que tem por objetivo definir os padr�es da internet.

A estrutura b�sica de um documento HTML � apresentada abaixo:

```
<!DOCTYPE html>
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>T�tulo da p�gina</title>
</head>
<body>
    <!-- Corpo da p�gina -->
</body>
</html>
```

Todo documento HTML � composto por uma s�rie de tags, que representam elementos, e possuem um nome, identifica��o e s�o escritas entre os sinais de `<` e `>`. Conforme apresentado na codifica��o acima, temos algumas tags:  

- `<html></html>`: define o documento como p�gina html;
- `<head></head>`: define o cabe�alho da p�gina, e onde geralmente definimos metadados �teis para pesquisa de buscadores;
- `<title></title>`: define o t�tulo que ir� aparecer na p�gina html;
- `<body></body>`: � onde definimos o corpo da p�gina, nela inserimos outros elementos do html como links( `<a>`), bot�es( `<button>`), imagens (`<img>`), campos de texto (`<input>`), formul�rios (`<form>`) entre outros.

Ao trabalhar com tags do html podemos configur�-las, o que confere a formata��o uma flexibilidade muito maior por permitir que uma determinada tag assuma um comportamento ou apar�ncia espec�fica, por exemplo:

```
<img src="imagens/alura/logo.jpg" alt="Imagem de uma logo Alura" width="300" height="150">
```

Na codifica��o acima, temos a tag img configurada para apresentar uma imagem presente em �imagens/alura/logo.jpg�. Caso a imagem n�o seja encontrada, ser� mostrado o texto alternativo �Imagem de uma logo Alura� e dever� ser apresentada nas dimens�es de largura 300 e altura 150. O Src � um atributo espec�fico da imagem, contudo existem alguns atributos globais que podem ser inseridos em qualquer tag html como o Id (identificador), Name (nome) ou Class (configura��o css) e s�o bem �teis para que possamos identificar e configurar um determinado elemento (tag) no html. Veja um exemplo:

```
<input type="submit" value="Logar" id="btn-logar" class="btn btn-primary btn-lg" />
```

Para se aprofundar ainda mais sobre HTML e suas tags:
[ O que � o HTML e suas tags? Parte 1: estrutura b�sica](https://www.alura.com.br/artigos/o-que-e-html-suas-tags-parte-1-estrutura-basica).