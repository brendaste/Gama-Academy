using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.Aula2.Console
{
    public static class Calculadora
    {
        public static void Calcular()
        {
            while (true)
            {

                // mensagens no console
                System.Console.WriteLine("Escola a operação:");
                System.Console.WriteLine("1 - DIVISÃO");
                System.Console.WriteLine("2 - MULTIPLICAÇÃO");
                System.Console.WriteLine("3 - SOMA");
                System.Console.WriteLine("4 - SUBTRAÇÃO");
                System.Console.WriteLine("Digite o numero:");

                // declarações
                var op = System.Console.ReadLine();
                var a = 2;
                var b = 3;

                switch (op)
                {
                    case "1":
                        System.Console.WriteLine(Div(a, b));
                        break;

                    case "2":
                        System.Console.WriteLine(Multi(a, b));
                        break;

                    case "3":
                        System.Console.WriteLine(Soma(a, b));
                        break;

                    case "4":
                        System.Console.WriteLine(Sub(a, b));
                        break;

                    default:
                        System.Console.WriteLine("Opção inválida");
                        break;
                }

                System.Console.ReadKey();
                System.Console.Clear();
            }

            static int Soma(int a, int b)
            {
                return a + b;
            }

            static int Sub(int a, int b)
            {
                return a - b;
            }

            static int Multi(int a, int b)
            {
                return a * b;
            }

            static double Div(int a, int b)
            {
                return (double)a / b;
            }
        }
    }
}
