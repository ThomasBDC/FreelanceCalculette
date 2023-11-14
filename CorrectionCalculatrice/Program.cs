using CorrectionCalculatrice;

Console.WriteLine("Bienvenue dans votre calculatrice");

bool continueCalcul = false;

do
{
    Console.WriteLine("Entrez votre calcul");
    string calculUtilisateur = Console.ReadLine();

    var myCalcul = new CalculFromString(calculUtilisateur);

    string phraseAAfficher = $"Résultat : {myCalcul.Resultat}";

    Console.WriteLine(phraseAAfficher);

    //Modifier ma condition de sortie

    Console.WriteLine("Voulez-vous faire une autre calcul ? O/N");
    string reponseContinue = Console.ReadLine();
    if(reponseContinue == "O" || reponseContinue == "o")
    {
        continueCalcul = true;
    }
    else
    {
        continueCalcul = false;
    }

} while (continueCalcul);

Console.WriteLine("Bye bye, please enter any key to escape");
Console.ReadLine();