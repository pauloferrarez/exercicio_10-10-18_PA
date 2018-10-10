
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Exercício 5");
                Console.WriteLine("***********");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("OBS: Caso queira encerrar o programa digite o salario negativo!!");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Gray;

                double fam = 1;
                double salario = 0;
                int filhos = 0;
                double soma = 0;
                double divisao = 0;
                int i = 0;
                int somaf = 0;
                int div = 0;
                double maior = 0;
                int m = 0;
                double x = 0;

                do
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(fam + "º Família");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Digite o Salário: ");
                    salario = Convert.ToDouble(Console.ReadLine());
              
                    if(salario > 0)
                    {
                        Console.Write("Digite a quantidade de filhos: ");
                        filhos = Convert.ToInt32(Console.ReadLine());
                        fam++;
                        i++;

                        if (salario > 0)
                        {
                            soma = soma + salario;
                            divisao = soma / i;
                        }
                        if (filhos > 0)
                        {
                            somaf = somaf + filhos;
                            div = somaf / i;
                        }
                        if (salario > maior)
                        {
                            maior = salario;
                        }
                        if (salario <= 1000)
                        {
                            m++;
                        
                        }
                }


                } while (salario > 0);

                //m = m * 100;
                x =  ( (double) m / i)*100;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("A média do salário da população é de: " + "R$" + divisao);
                Console.WriteLine("A média de filhos da população é de: " + div + " filhos");
                Console.WriteLine("O salário maior é: " + "R$" + maior);
                Console.WriteLine("A percentagem de pessoas com salários até R$1000,00: " + x + "%");
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Dados inválidos!!");
            }
            Console.ReadKey();

        }
    }
}
