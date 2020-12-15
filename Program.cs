using System;

namespace cs_1._5_CalculaVariacaoPercentual
{
    class Program
    {
        static void Main(string[] args)
        {
            double DifVal, ValIni, ValFin, Perc;

            Console.Clear();

            do
            {
                Console.Write("Digite o valor inicial: ");
                ValIni = double.Parse(Console.ReadLine());
            } while (ValIni < 0);

            Console.WriteLine();

            do
            {
                Console.Write("Digite o valor final: ");
                ValFin = double.Parse(Console.ReadLine());
            } while (ValFin < 0);

            Console.WriteLine();

            DifVal = ValFin - ValIni;
            Perc = (DifVal / ValIni) * 100;
            
            if (DifVal < 0)
            {
                Console.WriteLine($"A Variação percentual foi de {Perc}%");
            }
            else if (DifVal > 0)
            {
                Console.WriteLine($"A Variação percentual foi de +{Perc}%");
            }
            else
            {
                Console.WriteLine("A Variação percentual foi de 0%");      
            }
        }
    }
}
