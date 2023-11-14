using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionCalculatrice
{
    public static class MyConsole
    {
        public static decimal GetNumberFromUser(string messageToUser)
        {
            decimal numberToReturn = 0;
            bool done = false;
            while (!done)
            {
                try
                {
                    Console.WriteLine(messageToUser);
                    string reponseUtilisateur = Console.ReadLine();
                    numberToReturn = Convert.ToDecimal(reponseUtilisateur);
                    done = true;
                }
                catch
                {
                    Console.WriteLine("Saisie incorect");
                }
            }
            return numberToReturn;
        }
    }
}
