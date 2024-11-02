using System;
using System.Runtime.CompilerServices;

namespace NovoTeste
{
    class Program
    {
        struct Product
        {
            public int Id;
            public string Name;
            public double Price;

            public Product(int id, string name, double price)
            {
                Id = id;
                Name = name;
                Price = price;
            }

            public double PriceInDolar(double dolar)
            {
                return Price * dolar;
            }
        }

        enum Generos
        {
            Aventura,
            Romance,
            Suspense,
            Terror
        }

        static void Main(string[] args)
        {
            int pontuacao = 0;

            // pontuacao += FazerPergunta("Qual é a capital da França?", "Paris");

            // Console.WriteLine($"Pontuação total: {pontuacao}");
            arrays();

            Product mouse = new Product(1, "Mouse Gamer", 299.97);

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);

            trabalhando_enums();
            Calculadora();
        }

        static int FazerPergunta(string pergunta, string respostaCorreta)
        {
            Console.WriteLine(pergunta);
            string resposta = Console.ReadLine();

            if (resposta.Equals(respostaCorreta, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Correto!");
                return 1;
            }
            else
            {
                Console.WriteLine($"Errado! A resposta correta é: {respostaCorreta}");
                return 0;
            }
        }

        static void arrays()
        {
            int[] array = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            foreach (int data in array)
            {
                Console.WriteLine(data);
            }
        }

        static void trabalhando_enums()
        {
            Generos valor = Generos.Aventura;
            Console.WriteLine($"O gênero selecionado é: {valor}");
        }

        static double Calculadora()
        {

            int continua = 0;
            decimal valor_total = 0;
            int op;
            while (continua != 1)
            {

                Console.WriteLine("Deseja continuar a utilizar a calculadora? Digite 1 para sair ou 0 para continuar ");
                continua = Convert.ToInt32(Console.ReadLine());

                if (continua != 1)
                {
                    Console.WriteLine("***Escolha as opções da calculadora***");
                    Console.WriteLine("1 - SOMA");
                    Console.WriteLine("2 - SUBTRAÇÃO");
                    Console.WriteLine("3 - MULTIPLICAÇÃO");
                    Console.WriteLine("4 - DIVISÃO");
                    op = Convert.ToInt32(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            valor_total = Soma(valor_total);
                            break;
                        case 2:
                            valor_total = Subtracao(valor_total);
                            break;
                        case 3:
                            valor_total = Multiplicacao(valor_total);
                            break;
                        case 4:
                            valor_total = Divisao(valor_total);
                            break;
                        default:
                            Console.WriteLine("Opção invalida");
                            break;
                    }

                }
            }

            Console.WriteLine($"valor total: {valor_total}");

            return 0;

        }

        static decimal Soma(decimal valor_total)
        {
            decimal soma_total = valor_total;
            decimal Valor, Valor_A_Somar;
            int op;

            Console.WriteLine("Limpar campos: 1 - sim | 0 - não");
            op = Convert.ToInt32(Console.ReadLine());

            if (op == 1)
            {
                soma_total = 0;
                Console.Write("valor 1: ");
                Valor = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Valor 2: ");
                Valor_A_Somar = Convert.ToDecimal(Console.ReadLine());
                soma_total = Valor + Valor_A_Somar;
            }
            else if (op == 0)
            {
                Console.WriteLine($"Entre com o valor para somar com: {valor_total}");
                Valor_A_Somar = Convert.ToDecimal(Console.ReadLine());

                if (Valor_A_Somar < 0)
                {
                    Console.WriteLine("Por favor adicione um numero maior que 0");
                }
                else
                {
                    soma_total = valor_total + Valor_A_Somar;
                }
            }

            return soma_total;
        }

        static decimal Subtracao(decimal valor_total)
        {
            decimal subtracao_total = valor_total;
            decimal Valor, Valor_A_Subtrair;
            int op;

            Console.WriteLine("Limpar campos: 1 - sim | 0 - não");
            op = Convert.ToInt32(Console.ReadLine());

            if (op == 1)
            {
                subtracao_total = 0;
                Console.WriteLine("valor 1: ");
                Valor = decimal.Parse(Console.ReadLine());

                Console.WriteLine($"Tipo: {Valor.GetType()}");

                Console.WriteLine("Valor 2: ");
                Valor_A_Subtrair = decimal.Parse(Console.ReadLine());
                subtracao_total = Decimal.Round(Valor - Valor_A_Subtrair, 2);
                Console.WriteLine($"Valor1: {Valor} - Valor2: {Valor_A_Subtrair} = {subtracao_total}");
            }
            else if (op == 0)
            {
                Console.WriteLine($"Entre com o valor para subtrair com: {valor_total}");
                Valor_A_Subtrair = decimal.Parse(Console.ReadLine());

                if (Valor_A_Subtrair < 0)
                {
                    Console.WriteLine("Por favor adicione um numero maior que 0");
                }
                else
                {
                    subtracao_total = valor_total - Valor_A_Subtrair;
                }
            }

            Console.WriteLine($"Resultado da subtração: {subtracao_total}");
            return subtracao_total;

        }

        static decimal Multiplicacao(decimal valor_total)
        {
            decimal Multiplicacao_total = valor_total;
            decimal Valor, Valor_A_Multiplicar;
            int op;

            Console.WriteLine("Limpar campos: 1 - sim | 0 - não");
            op = Convert.ToInt32(Console.ReadLine());

            if (op == 1)
            {
                Multiplicacao_total = 0;
                Console.WriteLine("valor 1: ");
                Valor = decimal.Parse(Console.ReadLine());

                //Console.WriteLine($"Tipo: {Valor.GetType()}");

                Console.WriteLine("Valor 2: ");
                Valor_A_Multiplicar = decimal.Parse(Console.ReadLine());
                Multiplicacao_total = Decimal.Round(Valor * Valor_A_Multiplicar, 2);
                Console.WriteLine($"Valor1: {Valor} * Valor 2: {Valor_A_Multiplicar} = {Valor_A_Multiplicar}");
            }
            else if (op == 0)
            {
                Console.WriteLine($"Entre com o valor para multiplicar com: {valor_total}");
                Valor_A_Multiplicar = decimal.Parse(Console.ReadLine());

                if (Valor_A_Multiplicar < 0)
                {
                    Console.WriteLine("Por favor adicione um numero maior que 0");
                }
                else
                {
                    Multiplicacao_total = valor_total * Valor_A_Multiplicar;
                }
            }

            Console.WriteLine($"Resultado da Multiplicação: {Multiplicacao_total}");
            return Multiplicacao_total;
        }

        static decimal Divisao(decimal valor_total)
        {

            decimal Divisao_total = valor_total;
            decimal Valor, Valor_A_Dividir;
            int op;

            Console.WriteLine("Limpar campos: 1 - sim | 0 - não");
            op = Convert.ToInt32(Console.ReadLine());

            if (op == 1)
            {
                Divisao_total = 0;
                Console.WriteLine("valor 1: ");
                Valor = decimal.Parse(Console.ReadLine());

                //Console.WriteLine($"Tipo: {Valor.GetType()}");

                Console.WriteLine("Valor 2: ");
                Valor_A_Dividir = decimal.Parse(Console.ReadLine());
                Divisao_total = Decimal.Round(Valor / Valor_A_Dividir, 2);
                Console.WriteLine($"Valor 1: {Valor} / Valor 2: {Valor_A_Dividir} = {Divisao_total}");
            }
            else if (op == 0)
            {
                Console.WriteLine($"Entre com o valor para dividir com: {valor_total}");
                Valor_A_Dividir = decimal.Parse(Console.ReadLine());

                if (Valor_A_Dividir < 0)
                {
                    Console.WriteLine("Por favor adicione um numero maior que 0");
                }
                else
                {
                    Divisao_total = valor_total / Valor_A_Dividir;
                }
            }

            Console.WriteLine($"Resultado da Divisão: {Divisao_total}");
            return Divisao_total;

        }
    }
}
