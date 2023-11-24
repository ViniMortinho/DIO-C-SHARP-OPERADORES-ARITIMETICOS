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
                    double pot = Math.Pow(x,y);
                    Console.WriteLine($"{x} ^ {y} = {Math.Pow(x, y)}");
                    }
                            public void Seno (double angulo)
                            {   double radioano = angulo * Math.PI / 180;
                                double seno = Math.Sin(radioano);
                                Console.WriteLine($"Seno de {angulo}º = {Math.Round(seno, 4)}");
                            }
                                public void Coseno (double angulo)
                            {   double radioano = angulo * Math.PI / 180;
                                double coseno = Math.Cos(radioano);
                                Console.WriteLine($"Coseno de {angulo}º = {Math.Round(coseno, 4)}");
                            }
                            public void Tangente (double angulo)
                            {   double radioano = angulo * Math. PI / 180;
                                double tangente = Math.Tan(radioano);
                                Console.WriteLine($"Tangente de {angulo}º = {Math.Round(tangente, 4)}");
                            }
                            public void RaizQuadrada(double x)
                            {
                                double raiz = Math.Sqrt(x);
                                Console.WriteLine($"A raiz quadrada de {x} é: {raiz}");
                            }
                            
                            
    }
}