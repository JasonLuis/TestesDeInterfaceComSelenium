![alt text: A imagem mostra o texto HTML.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/02/aula2-img3.png)


O HTML existe desde os primórdios da web e é a maneira padronizada de estruturarmos uma página Web. O HTML ou HyperText Markup Language, é uma linguagem de marcação que nos permite construir uma página Web, que poderá ser renderizada em um navegador de sua escolha e assim compor um website ou sistema web. 


Até o momento da publicação deste curso, o HTML encontra-se na versão 5 e é mantida pelo W3C (World Wide Web Consortium) - um consórcio internacional que tem por objetivo definir os padrões da internet.

A estrutura básica de um documento HTML é apresentada abaixo:

```
<!DOCTYPE html>
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Título da página</title>
</head>
<body>
    <!-- Corpo da página -->
</body>
</html>
```

Todo documento HTML é composto por uma série de tags, que representam elementos, e possuem um nome, identificação e são escritas entre os sinais de `<` e `>`. Conforme apresentado na codificação acima, temos algumas tags:  

- `<html></html>`: define o documento como página html;
- `<head></head>`: define o cabeçalho da página, e onde geralmente definimos metadados úteis para pesquisa de buscadores;
- `<title></title>`: define o título que irá aparecer na página html;
- `<body></body>`: é onde definimos o corpo da página, nela inserimos outros elementos do html como links( `<a>`), botões( `<button>`), imagens (`<img>`), campos de texto (`<input>`), formulários (`<form>`) entre outros.

Ao trabalhar com tags do html podemos configurá-las, o que confere a formatação uma flexibilidade muito maior por permitir que uma determinada tag assuma um comportamento ou aparência específica, por exemplo:

```
<img src="imagens/alura/logo.jpg" alt="Imagem de uma logo Alura" width="300" height="150">
```

Na codificação acima, temos a tag img configurada para apresentar uma imagem presente em “imagens/alura/logo.jpg”. Caso a imagem não seja encontrada, será mostrado o texto alternativo “Imagem de uma logo Alura” e deverá ser apresentada nas dimensões de largura 300 e altura 150. O Src é um atributo específico da imagem, contudo existem alguns atributos globais que podem ser inseridos em qualquer tag html como o Id (identificador), Name (nome) ou Class (configuração css) e são bem úteis para que possamos identificar e configurar um determinado elemento (tag) no html. Veja um exemplo:

```
<input type="submit" value="Logar" id="btn-logar" class="btn btn-primary btn-lg" />
```

Para se aprofundar ainda mais sobre HTML e suas tags:
[ O que é o HTML e suas tags? Parte 1: estrutura básica](https://www.alura.com.br/artigos/o-que-e-html-suas-tags-parte-1-estrutura-basica).