using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public class Calcul
    {
        //Constructeur from string numbers
        public Calcul(string nombre1, string nombre2, string operateur) 
        {
            Nombre1 = Convert.ToDecimal(nombre1);
            Nombre2 = Convert.ToDecimal(nombre2);
            Operateur = operateur;
        }

        //Constructeur from decimal numbers
        public Calcul(decimal nombre1, decimal nombre2, string operateur)
        {
            Nombre1 = nombre1;
            Nombre2 = nombre2;
            Operateur = operateur;  
        }

        public decimal Nombre1 { get; set; }
        public decimal Nombre2 { get; set; }
        public string Operateur{ get; set; }

        public decimal DoCalculs()
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
            }

            return resultat;
        }
    }
}
