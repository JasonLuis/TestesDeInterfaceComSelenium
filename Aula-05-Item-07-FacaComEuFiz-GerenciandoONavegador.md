Para execu��o dos testes de interface, estamos trabalhando usando um navegador espec�fico, o Google Chrome. Ele � um recurso gerenciado pelo sistema operacional, ou seja, a cria��o e execu��o de uma inst�ncia do Google Chrome entra na fila de processos que v�o consumir processador e mem�ria.

� importante prestar aten��o na utiliza��o desse recurso, porque a m�quina na qual os testes ser�o executados pode ter pouco poder de processamento ou mem�ria, portanto a execu��o de qualquer programa pelo sistema operacional em paralelo pode afetar a performance de execu��o dos testes.

Como vimos nesta aula, existe uma estrat�gia interessante que podemos adotar para controlar a cria��o de v�rios navegadores durante a execu��o de m�ltiplos testes pelo gerenciador do Visual Studio Community, que � a utiliza��o de uma Fixture, um recurso presente no pr�prio xUnit.

Pois bem, agora � com voc�! Utilizando este conceito, crie uma classe respons�vel por cuidar da cria��o de inst�ncias do navegador.




--------------------------------------------------------

O navegador � um recurso externo � aplica��o sob teste e � uma boa pr�tica usarmos este recurso de forma controlada. No caso dos testes de interface usando o xUnit e Selenium, podemos usar a estrat�gia da Fixture, onde come�amos criando uma classe que gerenciar� o driver:


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
            Driver = new ChromeDriver(�Caminho Driver Navegador �);
        }
        public void Dispose()
        {
            Driver.Quit();
        }
    }

}
```

A classe Gerenciador conhece o Drive do navegador que estamos usando no teste e implementa a interface ` IDisposable`, para que no m�todo `Dispose()`, encerremos o navegador atrav�s do m�todo `.Quit()`.

Na classe de teste, `AposRealizarLogin` que usamos na aula, vamos criar um campo para guardar a refer�ncia do Driver do navegador e vamos �decorar� a classe com IClassFixture, parametrizado com a nossa classe Gerenciador. Veja como exemplo o c�digo abaixo:

```
  public class AposRealizarLogin:IClassFixture<Gerenciador>
    {
        private IWebDriver driver;
       // c�digo omitido
```

Agora, injetando uma refer�ncia do Gerenciador pelo construtor da classe de teste, vamos obter nosso driver. Ele sempre ser� invocado antes da execu��o do m�todo de teste e, por meio da Fixture, sempre ser� instanciado o mesmo gerenciador. Observe o c�digo do construtor:

```
        public AposRealizarLogin(Gerenciador gerenciador)
        {
           driver = gerenciador.Driver;           
        }
```


Essa refatora��o possibilita que, na execu��o de todos os testes da classe `AposRealizarLogin`, seja utilizado somente uma inst�ncia do navegador. 

Muito bacana! Sua tarefa agora � fazer esta implementa��o para praticar e fixar ainda mais o conte�do desta aula.