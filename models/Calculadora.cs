using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFundamentos.models
{
    public class Calculadora
    {
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
                        Console.WriteLine($"Raiz quadrada de {x} = {Math
                        .Sqrt(x)}");
                        }
                        public void PotenciaRaiz(int x, int y)
                        {
                            Console.WriteLine($"{x} ^ {y} = {Math.Pow(x, y)}");
                            Console.WriteLine($"Raiz quadrada de {x} = {Math
                            .Sqrt(x)}");
                            }

    }
}