using System;

namespace Convertitre_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerodecimale;
            int resto;
            string numeroconvertito = "";
            int divisore;

            Console.WriteLine("Inserisci un numero:");
            numerodecimale = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci un divisore");
            divisore = Convert.ToInt32(Console.ReadLine());

            while (numerodecimale > 0)
            {
                resto = numerodecimale % divisore;
                numerodecimale = numerodecimale / 2;
                numeroconvertito = Convert.ToString(resto) + numeroconvertito;
            }
            Console.WriteLine($"{numeroconvertito}");
            Console.ReadLine();
        }
    }
}
