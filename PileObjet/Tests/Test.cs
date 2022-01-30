using System;
using MesOutils;
using Utilitaires;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PileObjet.Tests
{
    internal abstract class TestPile
    {
        public static void TestePileVide()
        {
            Pile<int> unePile = new Pile<int>();
            if (unePile.PileVide())
            {
                Console.WriteLine("La pile est vide");
            }
            else
            {
                Console.WriteLine("La pile n'est pas vide");
            }
        }
        public static void TesteEmpiler()
        {
            Pile<int> unePile = new Pile<int>();
            unePile.Empiler(2);
            unePile.Empiler(6);
            unePile.Empiler(14);
        }
        public static void TesteEmpilerDepiler()
        {
            try
            {
                Pile<int> unePile = new Pile<int>();
                unePile.Empiler(2);
                unePile.Empiler(14);
                unePile.Empiler(6);
                unePile.Empiler(22);
                int valeurDepilee = unePile.Depiler();
                Console.WriteLine("Valeur dépilée : " + valeurDepilee);
                unePile.Empiler(17);
                unePile.Empiler(81);
                unePile.Empiler(34);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void TesteConversion()
        {
            Console.WriteLine("Saisie du nombre à convertir. ");
            int nbAConvertir = Utilitaire.SaisirNb(0);
            Console.WriteLine("Saisie de la nouvelle base. ");
            int newBase = Utilitaire.SaisirNb(2, 16);
            TesteConversion(nbAConvertir, newBase);
        }
        public static void TesteConversion(int nbAConvertir, int newBase)
        {
            try
            {
                String valeurConvertie = Utilitaire.Conversion(nbAConvertir, newBase);
                Console.WriteLine("valeurConvertie convertie : " + valeurConvertie);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        internal static string InversePhrase(String phrase)
        {
            Pile<string> maPile = new Pile<string>();
            var tab = phrase.Split(' ');
            foreach (string mot in tab)
            {
                maPile.Empiler(mot);
            }
            String message = "";
            while (maPile.PileVide())
            {
                message += " " + maPile.Depiler();
            }
            return message;
        }
        internal static void TesteInversePhrase()
        {
            try
            {
                String phrase = UtilitaireAPI.RecupereLoremIpsum(3);
                Console.WriteLine("---------------------------");
                Console.WriteLine("\n\nphrase: ");
                Console.WriteLine(phrase);
                String phraseInversee = Utilitaire.InversePhrase(phrase);
                Console.WriteLine("\nphraseInversee : ");
                Console.WriteLine(phraseInversee);
                Console.WriteLine("---------------------------");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
