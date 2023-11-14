using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionCalculatrice
{
    public class Calcul
    {
        public Calcul(decimal nombre1, decimal nombre2, string operateur)
        {
            Nombre1 = nombre1;
            Nombre2 = nombre2;
            Operateur = operateur;
            Resultat = DoCalcul();
        }

        public Calcul(string nombre1, string nombre2, string operateur)
        {
            Nombre1 = Convert.ToDecimal(nombre1);
            Nombre2 = Convert.ToDecimal(nombre2);
            Operateur = operateur;
            Resultat = DoCalcul();
        }

        public decimal Nombre1 { get; }
        public decimal Nombre2 { get; }
        public string Operateur { get; }
        public decimal Resultat { get; }

        private decimal DoCalcul()
        {
            decimal resultat = 0;
            switch (Operateur)
            {
                case "+":
                    resultat = Nombre1 + Nombre2;
                    break;
                case "-":
                    resultat = Nombre1 - Nombre2;
                    break;
                case "*":
                    resultat = Nombre1 * Nombre2;
                    break;
                case "/":
                    resultat = Nombre1 / Nombre2;
                    break;
                default:
                    //Code à éxécuter si on ne rentre dans aucune des cases ci-dessus
                    Console.WriteLine("Opérateur inconnu");
                    break;
            }
            return resultat;
        }

    }

   
}
