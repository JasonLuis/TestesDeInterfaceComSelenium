![alt text: A imagem mostra o texto CSS de forma estilizada.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/04/aula4-img1.png)


O Cascading Style Sheets ou simplesmente CSS é uma linguagem de estilização usada para definir a apresentação de páginas HTML. No CSS vamos definir cores, tamanhos, posicionamento, entre outros. O Css é um padrão internacional também mantido pelo [W3C](https://www.w3.org/standards/).


O CSS é executado no lado cliente (client-side), ou seja, a interpretação do documento é feita pelo browser do usuário, não sendo necessário nenhum tipo de servidor web para visualização.

![alt text: A imagem mostra arquivos com extensão .html e .css para estilização de um site.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/04/aula4-img2.png)


O objetivo do Css é informar ao navegador como ele apresentará o HTML da página. A sua sintaxe básica é:

![alt text: A imagem mostra a sintaxe básica de um css. seletor abre chaves propriedade dois pontos valor ponto e vírgula e fecha chaves.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/04/aula4-img3.png)

No Css, o seletor "seleciona" o elemento HTML usando o atributo Class=“...” ou ID=“...”, mas também podemos identificar o nome da tag como `<H1>`, `<Title>` ou `<p>`. A propriedade é o elemento que vamos estilizar, já o valor é o que atribuímos à propriedade. Como podemos ver no exemplo da imagem abaixo:

![alt text: A imagem mostra a estilização do elemento HTML h1.](https://cdn3.gnarususercontent.com.br/2377-donet-testes-curso3/04/aula4-img4.png)

Para a estilização de uma página usando o css, podemos aplicar inline, interno e arquivo externo.

No css inline, aplicamos o estilo diretamente ao elemento HTML, como no exemplo abaixo estamos estilizando a tag `h1`:


```
<!DOCTYPE html>
<head>
    <meta charset="UTF-8">
    <title>O que é Css?</title>
</head>
<body>
    <!-- css inline -->
    <h1 style="font-size: 30px;color: blue; margin: 0;">Mas o que é Css?</h1>
</body>
</html>
```

Na estilização usando o css interno, definimos uma tag style no head do documento html, como no exemplo abaixo:


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
    <title>O que é Css?</title>
</head>
<body>
    <h1>Mas o que é Css?</h1>
</body>
</html>
```

Na utilização de um arquivo externo, podemos centralizar a manutenção do css de uma aplicação em um só local, o que facilita bastante. Observe o exemplo abaixo:


```
h1{
    font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
    font-size: 30px;
    color: aqua;
}
```

No arquivo HTML usando a tag `Link` para indicar o local do arquivo com extensão `.css`.

```
<!DOCTYPE html>
<head>
     <meta charset="UTF-8">
     <link rel="stylesheet" href="/css/estilo.css">
    <title>O que é Css?</title>
</head>
<body>
    <h1>Mas o que é Css?</h1>
</body>
</html>
```

Para maior aprofundamento do tema Css, acesse os links abaixo:

* [ HTML, CSS e Javascript, quais as diferenças?](https://www.alura.com.br/artigos/html-css-e-js-definicoes)
* [ Reset CSS: O que é, Exemplos, Como Criar e Utilizar](https://www.alura.com.br/artigos/o-que-e-reset-css)