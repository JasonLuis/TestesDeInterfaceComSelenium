Para execução dos testes de interface, estamos trabalhando usando um navegador específico, o Google Chrome. Ele é um recurso gerenciado pelo sistema operacional, ou seja, a criação e execução de uma instância do Google Chrome entra na fila de processos que vão consumir processador e memória.

É importante prestar atenção na utilização desse recurso, porque a máquina na qual os testes serão executados pode ter pouco poder de processamento ou memória, portanto a execução de qualquer programa pelo sistema operacional em paralelo pode afetar a performance de execução dos testes.

Como vimos nesta aula, existe uma estratégia interessante que podemos adotar para controlar a criação de vários navegadores durante a execução de múltiplos testes pelo gerenciador do Visual Studio Community, que é a utilização de uma Fixture, um recurso presente no próprio xUnit.

Pois bem, agora é com você! Utilizando este conceito, crie uma classe responsável por cuidar da criação de instâncias do navegador.




--------------------------------------------------------

O navegador é um recurso externo à aplicação sob teste e é uma boa prática usarmos este recurso de forma controlada. No caso dos testes de interface usando o xUnit e Selenium, podemos usar a estratégia da Fixture, onde começamos criando uma classe que gerenciará o driver:


```
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Alura.ByteBank.WebApp.Testes.Utilitarios
{
    public class Gerenciador : IDisposable
    {
        public IWebDriver Driver { get; private set; }
        public Gerenciador()
        {
            Driver = new ChromeDriver(“Caminho Driver Navegador “);
        }
        public void Dispose()
        {
            Driver.Quit();
        }
    }

}
```

A classe Gerenciador conhece o Drive do navegador que estamos usando no teste e implementa a interface ` IDisposable`, para que no método `Dispose()`, encerremos o navegador através do método `.Quit()`.

Na classe de teste, `AposRealizarLogin` que usamos na aula, vamos criar um campo para guardar a referência do Driver do navegador e vamos “decorar” a classe com IClassFixture, parametrizado com a nossa classe Gerenciador. Veja como exemplo o código abaixo:

```
  public class AposRealizarLogin:IClassFixture<Gerenciador>
    {
        private IWebDriver driver;
       // código omitido
```

Agora, injetando uma referência do Gerenciador pelo construtor da classe de teste, vamos obter nosso driver. Ele sempre será invocado antes da execução do método de teste e, por meio da Fixture, sempre será instanciado o mesmo gerenciador. Observe o código do construtor:

```
        public AposRealizarLogin(Gerenciador gerenciador)
        {
           driver = gerenciador.Driver;           
        }
```


Essa refatoração possibilita que, na execução de todos os testes da classe `AposRealizarLogin`, seja utilizado somente uma instância do navegador. 

Muito bacana! Sua tarefa agora é fazer esta implementação para praticar e fixar ainda mais o conteúdo desta aula.