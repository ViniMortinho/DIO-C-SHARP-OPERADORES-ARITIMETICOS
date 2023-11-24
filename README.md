

# C SHARP > DIO - OPERADORES ARITIMÉTICOS E CLASSE MACTH

## FORMAÇÃO .NET DA [DIO](https://dio.me/curso-dot-net/AFY84PUWVGH8)


## REQUISITOS
- [.NET Core](https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://code.visualstudio.com/download)
- [C# Extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)

## OBJETIVOS

- [x] Entender os operadores aritméticos
- [x] Entender a utilização de classes e interfaces


crie uma classe em C# para fazer algumas operações matemáticas. Segue o passo a passo:
1. Crie um projeto em C# no Visual Studio Code.
Crie uma classe:
Vamos chamar ela de `Calculadora`. Fica assim :

```csharp
public class Calculadora
{
    // Os métodos vão aqui dentro
}
```

2. Agora, dentro da classe, crie vários métodos para as operações que você quer fazer. Cada método começa com `public void`, seguido pelo nome do método e os parâmetros que ele vai receber. Olha só:

```csharp
public void Somar(int x, int y)
{
    Console.WriteLine($"{x} + {y} = {x + y}");
}

public void Subtrair(int x, int y)
{
    Console.WriteLine($"{x} - {y} = {x - y}");
}

public void Multiplicar(int x, int y)
{
    Console.WriteLine($"{x} * {y} = {x * y}");
}

public void Dividir(int x, int y)
{
    Console.WriteLine($"{x} / {y} = {x / y}");
}

public void Potencia(int x, int y)
{
    Console.WriteLine($"{x} ^ {y} = {Math.Pow(x, y)}");
}

public void Raiz(int x)
{
    Console.WriteLine($"Raiz quadrada de {x} = {Math.Sqrt(x)}");
}

public void PotenciaRaiz(int x, int y)
{
    Console.WriteLine($"{x} ^ {y} = {Math.Pow(x, y)}");
    Console.WriteLine($"Raiz quadrada de {x} = {Math.Sqrt(x)}");
}
```

3. Agora você já tem a sua classe `Calculadora` com vários métodos para fazer operações aritméticas. Para usar a classe, você cria uma instância dela e chama os métodos. Assim:

```csharp
Calculadora calc = new Calculadora();
calc.Somar(10,30);
calc.Subtrair(10,50);
calc.Multiplicar(15,45);
calc.Dividir(2,2);

Execute no terminal `dotnet run`

apos a execução do codigo acima
, o resultado será:
10 + 30 = 40
10 - 50 = -40
15 * 45 = 675
2 / 2 = 1

```

Nesse exemplo, foi criado um objeto `calc` da classe `Calculadora` e usou os métodos `Somar`, `Subtrair`, `Multiplicar` e `Dividir` para realizar algumas operações. O resultado de cada operação é mostrado no console. Você pode fazer o mesmo com os outros métodos.

Os operadores aritméticos em C# são usados para realizar operações matemáticas com operandos de tipos numéricos. Eles incluem:

## Funções trigonométricas
As funções trigonométricas são funções que mostram como os ângulos se relacionam com os lados de um triângulo que tem um ângulo de 90 graus. Elas servem para resolver problemas de geometria, física, engenharia e outras Desgraças que envolvem medidas de ângulos e distâncias. As principais funções trigonométricas são: seno, cosseno e tangente. Elas podem ser mostradas pelo círculo trigonométrico, que é um círculo de tamanho 1. As funções trigonométricas também têm várias fórmulas e propriedades.

Usei o recurso Math!

A classe Math fornece métodos estáticos para realizar operações matemáticas mais avançadas, como potência, raiz quadrada, seno, cosseno, logaritmo, etc. Para usar esses métodos, basta usar a sintaxe `Math.NomeDoMetodo(argumentos)`. Por exemplo, `Math.Pow(x, y)` retorna o valor de x elevado à potência de y.

Para trabalhar com a operação em `Math` acrescente os seguinte metodos na calculadora:

```csharp
public void Seno (double angulo)                        
{double radioano = angulo * Math.PI / 180;
 double seno = Math.Sin(radioano);
 Console.WriteLine($"Seno de {angulo}º = {seno}");
}
public void Coseno (double angulo)
{double radioano = angulo * Math.PI / 180;
double coseno = Math.Cos(radioano);
Console.WriteLine($"Coseno de {angulo}º = {coseno}");
}
public void Tangente (double angulo)
{double radioano = angulo * Math. PI / 180;
double tangente = Math.Tan(radioano);
Console.WriteLine($"Tangente de {angulo}º = {tangente}");
}
```

Para executar os metodos acima, basta chamar eles na calculadora e
passar o angulo que deseja calcular o seno, coseno ou tangente
```csharp
Exemplo:
csharp
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
```

Execute no terminal `dotnet run`

Apos a execução do codigo acima
o resultado será:
```csharp
Seno de 30º = 0,49999999999999994
Coseno de 30º = 0,8660254037844387
Tangente de 30º = 0,5773502691896257
```

Pode-se usar uma variação para limitar o numero de digitos das respostas quando necessário
.
Para isso devemos alterar o output (saida do metodo).
no caso de C# o (Console.WriteLine) que printa no CMD ou powershel o que nele foi declarado pra escrever. 
É simples!

Na classe Calculadora identique Seno, Coceno e Tangente
e para isso vamos usar `Math.Roud`
Altere o Console.WriteLine para:

```csharp
Console.WriteLine($"Seno de {angulo}º = {Math.Round(seno, 4)}");
Console.WriteLine($"Coseno de {angulo}º = {Math.Round(coseno, 4)}");
Console.WriteLine($"Tangente de {angulo}º = {Math.Round(tangente, 4)});

Neste exemplo as repostas ficarão
com 4 casas decimais


o resultado será:
Seno de 30º = 0,5
Coseno de 30º = 0,866
Tangente de 30º = 0,5774
Pode-se usar uma variação para limitar o numero de digitos das
respostas quando necessário
.
```

Para mais informações, consulte a documentação oficial
https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/arithmetic-operators

## Operadores Unários

- **++ (incremento)**: incrementa o operando em 1.
  **-- (decremento)**: decrementa o operando em 1.
- **+ (mais)**: retorna o valor do operando.
- **- (menos)**: calcula a negação numérica do operando.

Incremento e decremento são operadores que aumentam ou diminuem o valor de uma variável em uma unidade. Eles são representados pelos símbolos `++` e `--`, respectivamente. Tipo, se você tem uma variável `x` com o valor 10, você pode fazer:

````csharp
using System.ComponentModel;
using ExemplosFundamentos.models;

//FUNÇÃO INCREMENTO
int numeroIncrenemento = 10 ;
Console.WriteLine(numeroIncreremento); // isso mostra o valor inicial de numeroIncreremento, que é 10
Console.WriteLine("incrementando o 10");
//numero = numero + 1;
numeroIncreremento++; // isso aumenta o valor de numeroIncreremento em 1, usando o operador ++
Console.WriteLine(numeroIncreremento); // isso mostra o valor final de numeroIncreremento, que é 11

//FUNÇÃO DECREMENTO
int numeroDedremento = 20;
Console.WriteLine(numeroDedremento); // isso mostra o valor inicial de numeroDedremento, que é 20
Console.WriteLine("decrementando o 20");
//numero = numero - 1;
numeroDedremento--; // isso diminui o valor de numeroDedremento em 1, usando o operador --
Console.WriteLine(numeroDedremento); // isso mostra o valor final de numeroDedremento, que é 19

Execute no terminal `dotnet run`

apos a execução do codigo acima
, o resultado será:

10
incrementando o 10
11
20
decrementando o 20
19


````
## Raiz Quadrada
Para calcular uma raiz quadrada usando a classe `MATH` pode-se fazer o seguinte:
1. Primeiro devemos adicionar o metodo na classe calculadora.

```csharp
public void CalcularRaizQuadrada(double x){
    return Math.Sqrt(x);
    }

2. Depois chamamos esse metodo da seguinte forma:

using ExemplosFundamentos.models;

//USANDO CLASSE MATH PARA CALCULAR RAIZ QUADRADA
Calculadora calc = new Calculadora();

calc.RaizQuadrada(9);

Execute no terminal `dotnet run`

apos a execução do codigo acima
o resultado será:
A raiz quadrada de 9 é: 3


## Operadores Binários

- **\* (multiplicação)**: retorna o produto de dois números.
- **/ (divisão)**: retorna o quociente de dois números.
- **% (resto)**: retorna o resto de um número dividido por outro.
- **+ (adição)**: retorna a soma de dois números.
- **- (subtração)**: retorna a diferença entre dois números.

Esses operadores são suportados por todos os tipos numéricos integrais e de ponto flutuante. No caso de tipos integrais, esses operadores (exceto os operadores ++ e --) são definidos para os tipos int, uint, long e ulong.

Espero poder ter ajudado. Se você tiver alguma dúvida ou sugestão, deixe um comentário. Obrigado por ler!

: https://dio.me/curso-dot-net/AFY84PUWVGH8
: https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/arithmetic-operators


Eu gostaria de agradecer ao professor do curso, Leonardo Buta, por compartilhar seus conhecimentos e experiências sobre o desenvolvimento .NET. Ele é um desenvolvedor .NET sênior e um tech expert da DIO, Eu aprendi muito com as suas aulas e espero continuar me aperfeiçoando nessa área. Muito obrigado, Buta!
[Leonardo Buta](https://github.com/leonardo-buta)
