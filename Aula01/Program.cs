using System;

namespace Gama.Calc.Console
{
    class Program
    {
        static void Main(string[] args)
        {

                System.Console.WriteLine("Escolha a operação:");
                System.Console.WriteLine("1 - Divisão");
                System.Console.WriteLine("2 - Multiplicação");
                System.Console.WriteLine("3 - Soma");
                System.Console.WriteLine("4 - Subtração");
                System.Console.WriteLine("Digite o número:");


                var op = System.Console.ReadLine();

                var a = 2;
                var b = 2;

                double resultado = 0;

                #region Condicional com if
                //if(op == "1")
                //{
                //    System.Console.WriteLine(Div(a, b));
                //}

                //else if(op == "2")
                //{
                //    System.Console.WriteLine(Mult(a, b));
                //}

                //else if (op == "3")
                //{
                //    System.Console.WriteLine(Soma(a, b));
                //}

                //else if (op == "4")
                //{
                //    System.Console.WriteLine(Sub(a, b));
                //}

                //else
                //{
                //    System.Console.WriteLine("Não existe essa opção");
                //} 
                #endregion

                #region Condicional com switch
                switch (op)
                {
                    case "1":
                        System.Console.WriteLine(Div(a, b));
                        break;

                    case "2":
                        System.Console.WriteLine(Mult(a, b));
                        break;

                    case "3":
                        System.Console.WriteLine(Soma(a, b));
                        break;

                    case "4":
                        System.Console.WriteLine(Sub(a, b));
                        break;

                    default:
                        System.Console.WriteLine("Não existe essa opção");
                        break;
                }
                #endregion

                System.Console.WriteLine(resultado != 0 ? resultado.ToString() : "Sem resultado!");
            }

        //COM CTRL+K CTRL+S CRIA-SE REGIÕES
        #region METODOS
        static int Soma(int a, int b)
        {
            return a + b;
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }

        static int Mult(int a, int b)
        {
            return a * b;
        }

        static double Div(int a, int b)
        {
            return (double)a / b;
        } 
        #endregion
    }
}