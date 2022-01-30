using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PileObjet.Tests;
using MesOutils;

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
        public static string Conversion(int nbAConvertir, int newBase)
        {
            if (nbAConvertir <= 0)
            {
                throw new Exception("Le nombre à convertir doit etre strictement positif");
            }
            if (newBase < 2 || newBase > 16)
            {
                throw new Exception("La nouvelle base doit etre comprise entre 2 et 16");
            }
            int reste;
            int resultat = nbAConvertir;

            Pile<int> unePile = new Pile<int>();

            while (resultat != 0)
            {
                reste = resultat % newBase;
                resultat = resultat / newBase;
                unePile.Empiler(reste);
            }
            if (resultat == 0)
            {
                string message = "La valeur de " + nbAConvertir + " (base 10) vaut ";
                while (!unePile.PileVide())
                {
                    int retour = (int)unePile.Depiler();
                    if (retour < 10)
                    {
                        message += Convert.ToChar(48 + retour);
                    }
                    else
                    {
                        message += Convert.ToChar(55 + retour);
                    }
                }
                message += " en base " + newBase;
                return message;
            }
            else
            {
                return "Impossible de convertir, la pile est trop petite";
            }
        }
    }
}
