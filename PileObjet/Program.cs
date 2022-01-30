using MesOutils;
using System;
using PileObjet.Tests;
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
                TestPile.TestePileVide();
                TestPile.TesteEmpiler();
                TestPile.TesteEmpilerDepiler();
                // Appels des méthodes de tests conversion
                TestPile.TesteConversion();
                TestPile.TesteConversion(154, 2);
                TestPile.TesteConversion(11, 16);
                TestPile.TesteConversion(2986, 16);
                TestPile.TesteConversion(9999, 16);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Fin du programme");
            Console.ReadKey();
        }
    }
}
