using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionCalculatrice
{
    public class CalculFromString
    {
        public string ChaineDeCalcul { get; }
        public decimal Resultat { get; }

        public CalculFromString(string chaineDeCalcul)
        {
            ChaineDeCalcul = chaineDeCalcul;
            Resultat = DoCalcul();
        }

        private decimal DoCalcul()
        {
            string nombre1str = "";
            string nombre2str = "";
            string operateur = "";
            bool nombre1Finded = false;

            foreach (char caractere in ChaineDeCalcul)
            {
                if (char.IsDigit(caractere))
                {
                    //Le caractère est un nombre
                    if (nombre1Finded == false)
                    {
                        nombre1str += caractere;
                    }
                    else
                    {
                        nombre2str += caractere;
                    }
                }
                else
                {
                    //le caractère n'est pas un nombre, donc c'est l'opérateur
                    if (nombre1Finded)
                    {
                        //Faire le calcul, ce n'est pas le premier opérateur
                        var myCalcul = new Calcul(nombre1str, nombre2str, operateur);

                        decimal currentResult = myCalcul.Resultat;
                        nombre1str = currentResult.ToString();
                        operateur = caractere.ToString();
                        nombre2str = "";
                    }
                    else
                    {

                        operateur = caractere.ToString();
                        nombre1Finded = true;
                    }
                }
            }

            var calculFinal = new Calcul(nombre1str, nombre2str, operateur);
            return calculFinal.Resultat;
        }
    }
}
