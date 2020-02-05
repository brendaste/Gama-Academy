using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Gama.Aula2.Console
{
    public static class Colecoes
    {

        /// <summary>
        /// Arrays são coleções não dinâmicas,ou seja, não se adiciona em tempo de execução
        /// </summary>


        public static void trabalhandoComArray()
        {
            var nomes = new string[5];

            nomes[0] = "joão";
            nomes[1] = "ana";
            nomes[2] = "anderson";
            nomes[3] = "joyce";
            nomes[4] = "mariana";

            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine(nomes[i]);
            }

        }

        public static void trabalhandoComListas()
        {
            var nomes = new List<string>()
            {
                "Wilson",
                "Claudia"
            };

            while (true)
            {
                foreach (var n in nomes)
                {
                    System.Console.WriteLine(n);
                }

                System.Console.WriteLine("Informe o nome:");

                var novo = System.Console.ReadLine();

                nomes.Add(novo);

                System.Console.Clear();
            }
        }

        public static void trabalhandoComFila()
        {
            var nomes = new Queue<string>();

            while (true)
            {
                foreach (var n in nomes)
                {
                    System.Console.WriteLine(n);
                }

                System.Console.WriteLine("Informe o nome:");

                var novo = System.Console.ReadLine();

                nomes.Enqueue(novo);

                System.Console.Clear();
            }

            //Para retirar da fila
            //while (true)
            //{
            //    foreach (var n in nomes)
            //    {
            //        System.Console.WriteLine(n);
            //    }

            //    System.Console.WriteLine("Pressione qualquer tecla para retirar da fila");

            //    System.Console.WriteLine("Informe o nome:");

            //    System.Console.ReadKey();

            //    nomes.Dequeue();

            //    System.Console.Clear();
            //}
        }

        public static void trabalhandoComPilha()

        {
            var nomes = new Stack<string>();

            nomes.Push("Joana");
            nomes.Push("Maria");
            nomes.Push("Clarice");


            while (true)
            {
                foreach (var n in nomes)
                {
                    System.Console.WriteLine(n);
                }

                System.Console.WriteLine('\n');
                System.Console.WriteLine("Pressione qualquer tecla para retirar um nome da pilha:");

                System.Console.ReadKey();

                nomes.Pop();

                System.Console.Clear();
            }

        }

        public static void trabalhandoComDicionario()
        {
            var nomes = new Dictionary<string, int>();

            nomes.Add("joana", 22);
            nomes.Add("amanda", 32);
            nomes.Add("bruna", 13);

            var resultado = nomes.First(item => item.Key == "amanda");

            System.Console.WriteLine(resultado);

        }

        public static void filtrandoListas()
        {
            var nomes = new List<string>()
            {
                "Wilson",
                "Claudia"
            };

            var resultado = nomes.Single(item => item == "Claudia");

            System.Console.WriteLine(resultado);

        }

    }
}
