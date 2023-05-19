using System;
using TP2_PDF;

namespace TP2_PDF
{
    class Program
    {
        static void Main(string[] args)
        {
            double test;
            
            /*
            // Instanciation d'un poule Ginger
            Poule ginger = new Poule("Ginger", "gauloise", 0.8, Taille.L);

            // Affichage de cette poule
            ginger.Afficher();
            */

            Poulailler P1 = new Poulailler("Nuggets", 250);
            P1.Ajout_de_poule("Ginger", "gauloise", 0.8, Taille.L);
            P1.Ajout_de_poule("Paul", "Marans", 0.5, Taille.S);
            P1.Ajout_de_poule("Mira", "Marans", 1.0, Taille.S);
            P1.Affichage_poule_du_poulailler();
            test=P1.pourcentage_taille_poule_du_poulailler(Taille.S);
            Console.WriteLine(String.Format("{0:0.00}",test));
            P1.Supprimer_poule_poulailler(1);
            P1.Affichage_poule_du_poulailler();
        }
    }
}
