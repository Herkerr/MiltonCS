// Már elkészített modulok, amelyekből funkciókat tudunk bevinni
using System;
 
namespace ElsoProjekt_v2_0926
{
    internal class Program
    {
        const string sayHello = "Szia Uram!";
        const string firstName = "Szalai";
        const string secondName = "Patrik";
        const byte kettoOtvenOt = 255;
 
        static void Main(string[] args)
        {
            /* Console.WriteLine("Kérek egy számot");
            string szam1Input = Console.ReadLine();
            int szam1 = Convert.ToInt32(szam1Input);
            Console.WriteLine("Na acca mégegyet, öcsémnek is kell.");
            int szam2 = int.Parse(Console.ReadLine());
 
            int osszeg = szam1 + szam2;
            Console.WriteLine("Inputs: " + szam1 + " + " + szam2);
            Console.WriteLine(osszeg.ToString());
            */
 
            Console.WriteLine("Mi az r értéke?");
            string korSugaraInput = Console.ReadLine();
            int korSugara = Convert.ToInt32(korSugaraInput);
            Console.WriteLine("A kör kerülete = " + 2 * korSugara * Math.PI);
        }
    }
}
