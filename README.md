

# C SHARP - DIO |OPERADORES ARITIMÉTICOS E CLASSE MACTH|
## FORMAÇÃO .NET DA [DIO](^https://dio.me/curso-dot-net/AFY84PUWVGH8^).


## Repositório referente a formação .NET DIO
(DIO)[https://dio.me/curso-dot-net/AFY84PUWVGH8]

Vamos criar uma classe em C# para fazer algumas operações matemáticas. Segue o passo a passo:

1. Primeiro, vamos criar a classe. Vamos chamar ela de `Calculadora`. Fica assim :

```csharp
public class Calculadora
{
    // Os métodos vão aqui dentro
}
```

2. Agora, dentro da classe, vamos criar vários métodos para as operações que você quer fazer. Cada método começa com `public void`, seguido pelo nome do método e os parâmetros que ele vai receber. Olha só:

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

3. Pronto! Agora você já tem a sua classe `Calculadora` com vários métodos para fazer operações aritméticas. Para usar a classe, você cria uma instância dela e chama os métodos. Assim:

```csharp
Calculadora calc = new Calculadora();
calc.Somar(10,30);
calc.Subtrair(10,50);
calc.Multiplicar(15,45);
calc.Dividir(2,2);
```

Nesse exemplo, a gente criou um objeto `calc` da classe `Calculadora` e usou os métodos `Somar`, `Subtrair`, `Multiplicar` e `Dividir` para realizar algumas operações. O resultado de cada operação é mostrado no console. Você pode fazer o mesmo com os outros métodos.

Os operadores aritméticos em C# são usados para realizar operações matemáticas com operandos de tipos numéricos. Eles incluem:

## Operadores Unários

- **++ (incremento)**: incrementa o operando em 1.
- **-- (decremento)**: decrementa o operando em 1.
- **+ (mais)**: retorna o valor do operando.
- **- (menos)**: calcula a negação numérica do operando.

## Operadores Binários

- **\* (multiplicação)**: retorna o produto de dois números.
- **/ (divisão)**: retorna o quociente de dois números.
- **% (resto)**: retorna o resto de um número dividido por outro.
- **+ (adição)**: retorna a soma de dois números.
- **- (subtração)**: retorna a diferença entre dois números.

Esses operadores são suportados por todos os tipos numéricos integrais e de ponto flutuante. No caso de tipos integrais, esses operadores (exceto os operadores ++ e --) são definidos para os tipos int, uint, long e ulong.

Para mais informações, consulte a documentação oficial da Microsoft.