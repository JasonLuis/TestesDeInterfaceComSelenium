![alt text: A imagem mostra o texto CSS de forma estilizada.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/04/aula4-img1.png)


O Cascading Style Sheets ou simplesmente CSS � uma linguagem de estiliza��o usada para definir a apresenta��o de p�ginas HTML. No CSS vamos definir cores, tamanhos, posicionamento, entre outros. O Css � um padr�o internacional tamb�m mantido pelo [W3C](https://www.w3.org/standards/).


O CSS � executado no lado cliente (client-side), ou seja, a interpreta��o do documento � feita pelo browser do usu�rio, n�o sendo necess�rio nenhum tipo de servidor web para visualiza��o.

![alt text: A imagem mostra arquivos com extens�o .html e .css para estiliza��o de um site.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/04/aula4-img2.png)


O objetivo do Css � informar ao navegador como ele apresentar� o HTML da p�gina. A sua sintaxe b�sica �:

![alt text: A imagem mostra a sintaxe b�sica de um css. seletor abre chaves propriedade dois pontos valor ponto e v�rgula e fecha chaves.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/04/aula4-img3.png)

No Css, o seletor "seleciona" o elemento HTML usando o atributo Class=�...� ou ID=�...�, mas tamb�m podemos identificar o nome da tag como `<H1>`, `<Title>` ou `<p>`. A propriedade � o elemento que vamos estilizar, j� o valor � o que atribu�mos � propriedade. Como podemos ver no exemplo da imagem abaixo:

![alt text: A imagem mostra a estiliza��o do elemento HTML h1.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/04/aula4-img4.png)

Para a estiliza��o de uma p�gina usando o css, podemos aplicar inline, interno e arquivo externo.

No css inline, aplicamos o estilo diretamente ao elemento HTML, como no exemplo abaixo estamos estilizando a tag `h1`:


```
<!DOCTYPE html>
<head>
    <meta charset="UTF-8">
    <title>O que � Css?</title>
</head>
<body>
    <!-- css inline -->
    <h1 style="font-size: 30px;color: blue; margin: 0;">Mas o que � Css?</h1>
</body>
</html>
```

Na estiliza��o usando o css interno, definimos uma tag style no head do documento html, como no exemplo abaixo:


```
<!DOCTYPE html>
<head>
    <style>
        /* Css interno */
        h1{
            font-size: 30px;
            color: blue;
            margin: 0;
        }
    </style>
    <meta charset="UTF-8">
    <title>O que � Css?</title>
</head>
<body>
    <h1>Mas o que � Css?</h1>
</body>
</html>
```

Na utiliza��o de um arquivo externo, podemos centralizar a manuten��o do css de uma aplica��o em um s� local, o que facilita bastante. Observe o exemplo abaixo:


```
h1{
    font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
    font-size: 30px;
    color: aqua;
}
```

No arquivo HTML usando a tag `Link` para indicar o local do arquivo com extens�o `.css`.

```
<!DOCTYPE html>
<head>
     <meta charset="UTF-8">
     <link rel="stylesheet" href="/css/estilo.css">
    <title>O que � Css?</title>
</head>
<body>
    <h1>Mas o que � Css?</h1>
</body>
</html>
```

Para maior aprofundamento do tema Css, acesse os links abaixo:

* [ HTML, CSS e Javascript, quais as diferen�as?](https://www.alura.com.br/artigos/html-css-e-js-definicoes)
* [ Reset CSS: O que �, Exemplos, Como Criar e Utilizar](https://www.alura.com.br/artigos/o-que-e-reset-css)