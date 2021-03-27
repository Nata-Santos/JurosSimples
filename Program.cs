using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal c, i , t;
            decimal juros, mont;
            
            Console.WriteLine("Juros Simples .");
            Console.WriteLine();
            
            Console.Write("Capital (R$).......:");
            c = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Taxa de Juros (%)..:");
            i = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Tempo (meses).....:");
            t = Convert.ToDecimal(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine("---------------------");

            juros = c * i * t *1 /100 ;
            mont = c + juros;
            Console.WriteLine($"\nJuros (R$)....: {juros:N2}");
            Console.WriteLine($"Montante(R$)..: {mont:N2}");
            }
    }
}
