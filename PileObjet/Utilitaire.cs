using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitaires
{
    public abstract class Utilitaire
    {
        public static int SaisirNb()
        {
            int nb = 0;
                try
                {
                    Console.WriteLine("Veuillez saisr un nombre entier : ");
                    nb = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) { }
            return nb;
        }
        public static int SaisirNb(int pMin)
        {
            int nb = 0;
            do
            {
                try
                {
                    Console.WriteLine("Veuillez saisr un nombre entier supérieur à " + pMin + " : ");
                    nb = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) { }
            } while (nb < pMin);
            return nb;
        }
        public static int SaisirNb(int pMin, int pMax)
        {
            int nb = 0;
            do
            {
                try
                {
                    Console.WriteLine("Veuillez saisr un nombre entier supérieur à " + pMin + " et " + pMax + " : ");
                    nb = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) { }
            } while (nb < pMin || nb > pMax);
            return nb;
        }
    }
}
