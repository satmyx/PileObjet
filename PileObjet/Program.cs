using MesOutils;
using System;
using Utilitaires;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PileObjet
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //TestePileVidePleine(5);
                //TestePileVidePleine(0);
                //TesteEmpiler(5);
                //TesteEmpiler(2);
                //TesteEmpilerDepiler(5);
                //int nbSaisi = Utilitaire.SaisirNb();
                //Console.WriteLine("Nombre saisi : " + nbSaisi);
                //nbSaisi = Utilitaire.SaisirNb(0);
                //Console.WriteLine("Nombre saisi : " + nbSaisi);
                //nbSaisi = Utilitaire.SaisirNb(2, 16);
                //Console.WriteLine("Nombre saisi : " + nbSaisi);
                TesteConversion();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Fin du programme");
            Console.ReadKey();
        }
        static void TestePileVidePleine(int elements)
        {
            Pile unePile = new Pile(elements);
            if (unePile.PileVide())
            {
                Console.WriteLine("La pile est vide");
            }
            else
            {
                Console.WriteLine("La pile n'est pas vide");
            }
            if (unePile.PilePleine())
            {
                Console.WriteLine("La pile est pleine");
            }
            else
            {
                Console.WriteLine("La pile n'est pas pleine");
            }
        }
        static void TesteEmpiler(int nbElements)
        {
            Pile unePile = new Pile(nbElements);
            unePile.Empiler(2);
            unePile.Empiler(6);
            unePile.Empiler(14);
        }
        static void TesteEmpilerDepiler(int nbElements)
        {
            try
            {
                Pile unePile = new Pile(nbElements);
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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static string Convertir(int pNbElements, int pNbAConvertir, Int32 pNewbase)
        {
            int resultat = pNbAConvertir;
            int reste;
            Pile unePile = new Pile(pNbElements);

            while (resultat != 0 && !unePile.PilePleine())
            {
                reste = resultat % pNewbase;
                resultat = resultat / pNewbase;
                unePile.Empiler(reste);
            }
            if (resultat == 0)
            {
                string message = "La valeur de " + pNbAConvertir + " (base 10) vaut ";
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
                message += " en base " + pNewbase;
                return message;
            }
            else
            {
                return "Impossible de convertir, la pile est trop petite";
            }
        }
        static void TesteConversion()
        {
            Console.Write("Entrez le nombre d'éléments du tableau : ");
            int nbMaxElt = Utilitaire.SaisirNb();
            Console.Write("Entrez le nombre à convertir : ");
            int nbAConvertir = Utilitaire.SaisirNb(0);
            int newBase = Utilitaire.SaisirNb(2, 16);
            while (newBase < 2 || newBase > 16)
            {
                Console.Write("Entrez la nouvelle base entre 2 et 16 : ");
                newBase = Int16.Parse(Console.ReadLine());
            }
            String message = Convertir(nbMaxElt, nbAConvertir, newBase);
            Console.WriteLine(message);

        }
    }
}
