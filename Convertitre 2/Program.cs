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
            Console.ReadLine();
            Console.WriteLine("Inserisci un divisore:");
            divisore = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            while (numerodecimale > 0)
            {
                resto = numerodecimale % divisore;
                numerodecimale = numerodecimale / divisore;

                if (resto == 10)
                {
                    numeroconvertito = "A" + numeroconvertito;
                }
                else if (resto == 11)
                {
                    numeroconvertito = "B" + numeroconvertito;
                }
                else if (resto == 12)
                {
                    numeroconvertito = "C" + numeroconvertito;
                }
                else if (resto == 13)
                {
                    numeroconvertito = "D" + numeroconvertito;
                }
                else if (resto == 14)
                {
                    numeroconvertito = "E" + numeroconvertito;
                }
                else if (resto == 15)
                {
                    numeroconvertito = "F" + numeroconvertito;
                }
                else
                {
                    numeroconvertito = Convert.ToString(resto) + numeroconvertito;
                }
            }
            Console.WriteLine($"{numeroconvertito}");
            Console.ReadLine();
        }
    }
}
