using System;
using System.Collections.Generic;
using TP2_PDF;
namespace TP2_PDF
{
    /// <summary>
    /// Modélise un poulailler
    /// </summary>
    public class Poulailler
    {
        /// <summary>
        /// Nom du poulailler
        /// </summary>
        /// <example>Nuggets,Cluck Norris,Cloaque,Cot cot,</example>
        string nom_poulailler;
        /// <summary>
        /// Le nombre de poule maximale stockable dans le poulailler
        /// </summary>
        /// <example>20,30,50,100</example>
        int capacite_max_poulailler;
        /// <summary>
        /// La liste des poules présente dans le poulailler
        /// </summary>
        /// <example>Nuggets,Cluck Norris,Cloaque,Cot cot,</example>
        List<Poule> poule_presente = new List<Poule>();
        /// <summary>
        /// Le nombre de poule  présente dans le poulailler
        /// </summary>
        /// <example>20,25,32,50</example>
        int nb_poule_presente;
        public Poulailler(string nomP, int max_P)
        {
            nom_poulailler = nomP;
            capacite_max_poulailler = max_P;
            nb_poule_presente = 0;
        }
        public void Ajout_de_poule(string nomP, string raceP, double intensiteP, Taille tailleP)
        {
            if (nb_poule_presente + 1 < capacite_max_poulailler)
            {

                nb_poule_presente += 1;
                poule_presente.Add(new Poule(nomP, raceP, intensiteP, tailleP));
            }
        }
        public void Affichage_poule_du_poulailler()
        {
            foreach(Poule p in poule_presente)
            {
                p.Afficher();
            }
            Console.WriteLine(nb_poule_presente);
        }
        public void Supprimer_poule_poulailler(int num_affichage)
        {
            if (num_affichage - 1 >= 0)
            {
                if (num_affichage - 1 < capacite_max_poulailler)
                {
                    poule_presente.RemoveAt(num_affichage-1);
                    nb_poule_presente -= 1;
                }
                else
                {
                    Console.WriteLine("\n Numéro d'affichage invalide,il n'y a pas de poule qui lui est assigné");
                }
            }
        }
        public double pourcentage_taille_poule_du_poulailler(Taille T)
        {
            int compteur = 0;
            double moyenne_taille_poule_de_T;
            foreach (Poule p in poule_presente)
            {
                if (p.taille == T)
                {   
                    compteur += 1;
                }

            }
            moyenne_taille_poule_de_T = compteur / (nb_poule_presente*1.0);
            return moyenne_taille_poule_de_T;
        }
    }
}