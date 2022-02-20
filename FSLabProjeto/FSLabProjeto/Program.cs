using System;

namespace FSLabProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t -- Desafio Projeto FSLab -- \n");
            
            string continuar;

            do
            {   Console.Write("Digite o número do cálculo desejado: \t\n (1)SOMA SIMPLES  \t\n (2)MÉDIA ARITMÉTICA \t\n (3)MÉDIA PONDERADA\n");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        int n1, n2;

                        Console.WriteLine("\t -- Soma Simples --\n");
                        Console.Write("Digite um número: ");
                        n1 = int.Parse(Console.ReadLine());

                        Console.Write("Digite um número novamente: ");
                        n2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Resultado: " + soma(n1, n2));

                        break;

                    case 2:
                        double a1, a2;

                        Console.WriteLine("\t -- Média Aritmética --\n");
                        Console.Write("Digite um número: ");
                        a1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Digite um número novamente: ");
                        a2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Resultado: " + medA(a1, a2));

                        break;

                    case 3:
                        double nota1, nota2;
                        int p1, p2;

                        Console.WriteLine("\t -- Média Ponderada --\n");
                        Console.Write("Digite a nota do 1° Bimestre: ");
                        nota1 = double.Parse(Console.ReadLine());

                        Console.Write("Digite o peso para a nota do 1° Bimestre: ");
                        p1 = int.Parse(Console.ReadLine());

                        Console.Write("Digite a nota do 2° Bimestre: ");
                        nota2 = double.Parse(Console.ReadLine());

                        Console.Write("Digite o peso para a nota do 2° Bimestre: ");
                        p2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Resultado: " + medP(nota1, nota2, p1, p2));

                        break;
                    
                    default:
                        Console.WriteLine("\n Número inválido - Tente novamente\n");
                        break;
                }
                Console.WriteLine("\n -- Deseja realizar outro cálculo?-- \n(Sim) (Não)");
                continuar = Console.ReadLine();
                Console.Clear();

            } while ("sim" == continuar.ToLower());

            Console.ReadKey();

        }

        static int soma(int n1, int n2)
        {
            return (n1 + n2);
        }

        static double medA(double a1, double a2)
        {
            return (a1 + a2) / 2;
        }

        static double medP(double nota1, double nota2, double p1, double p2)
        {
            return (nota1 * p1 + nota2 * p2) / (p1 + p2);
        }
    }
}
