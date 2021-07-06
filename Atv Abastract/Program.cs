using System;
using System.Collections.Generic;
using Atv_Abastract.Entidades;
using System.Globalization;

namespace Atv_Abastract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPlayer> lista = new List<TaxPlayer>();

            Console.Write("Enter the number of tax payers: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (op == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double expenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Individual(name, income, expenditures));

                }
                else
                {
                    Console.WriteLine("Number of employees: ");
                    int employeesnumber = int.Parse(Console.ReadLine());
                    lista.Add(new Company(name, income, employeesnumber));

                }
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPlayer player in lista)
            {
                double tax = player.tax();
                Console.WriteLine(player.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
