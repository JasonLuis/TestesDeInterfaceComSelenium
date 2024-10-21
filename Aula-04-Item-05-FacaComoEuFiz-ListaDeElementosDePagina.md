Nesta aula vimos outras formas de capturar elementos do HTML para escrevermos nossos códigos de testes em C# que não estão restritos somente ao ID ou Name.

Agora é com você! Crie uma lista com todos os elementos web da página Web mostrada abaixo:

```
<!DOCTYPE html>
<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="/css/style.css">
    <link rel="stylesheet" href="/css/bootstrap.css">
    <title>Formulário de Contato</title>
</head>
<body>
    <div class="col-sm-6">
                       
        <form action="engine/contato.cshtml" method="POST">

            <div class="row">
           
                <div class="campo col-xs-12">
                   
                    <label for="">Nome</label>
                    <input type="text" name="nome_usuario" required>

                </div>

                <div class="campo col-xs-12">
                   
                    <label for="">E-mail</label>
                    <input type="email" name="email_usuario" required>

                </div>

                <div class="campo col-xs-12">
                   
                    <label for="">Telefone</label>
                    <input class="telefone" type="tel" name="telefone_usuario" required>

                </div>

                <div class="campo col-xs-12">
                   
                    <label for="">CEP</label>
                    <input class="cep" type="text" name="cep_usuario" required>

                </div>

                <div class="campo col-xs-10">
                   
                    <label for="">Cidade</label>
                    <input type="text" name="cidade_usuario" required>

                </div>

                <div class="campo col-xs-2">
                   
                    <label for="">UF</label>
                    <input type="text" name="uf_usuario" required>

                </div>

                <div class="campo col-xs-12">
                   
                    <label for="">Mensagem</label>
                    <textarea name="mensagem_usuario" required></textarea>

                </div>

                <div class="campo col-xs-12">
                   
                    <button type="submit">Enviar</button>

                </div>

            </div>

        </form>

    </div>

</div>

</div>

</div>

</body>
</html>
```


# Como resolver?

Para capturar mais de um elemento de uma página HTML usando a biblioteca do Selenium WebDriver, podemos usar o recurso de selecionar pela tag HTML, escrevendo como em:

```
 IReadOnlyCollection<IWebElement> divs    = driver.FindElements(By.TagName("div"));
 IReadOnlyCollection<IWebElement> inputs = driver.FindElements(By.TagName("input"));
 IReadOnlyCollection<IWebElement> labels = driver.FindElements(By.TagName("label"));
```

Com esta estrutura de código, temos a possibilidade de capturar todos os elementos do tipo div ( tag `div`) do HTML e trabalhar como uma lista de objetos do tipo IWebElement. 

Então, vamos praticar a captura de vários elementos usando o Selenium WebDriver?