Console.WriteLine("Bienvenue dans votre calculatrice");

bool continueCalcul = false;

do
{
    decimal Nombre1 = getNumberFromUser("Votre nombre 1");
    decimal Nombre2 = getNumberFromUser("Votre nombre 2");

    Console.WriteLine("Quel est l'opérateur ? ");
    string operateur = Console.ReadLine();

    decimal Resultat = doCalcul(Nombre1, Nombre2, operateur);

    string phraseAAfficher = $"{Nombre1} {operateur} {Nombre2} = {Resultat}";

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
#region Functions
decimal getNumberFromUser(string messageToUser)
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

decimal doCalcul(decimal nombre1, decimal nombre2, string operateur)
{
    decimal resultat = 0;
    switch (operateur)
    {
        case "+":
            resultat = nombre1 + nombre2;
            break;
        case "-":
            resultat = nombre1 - nombre2;
            break;
        case "*":
            resultat = nombre1 * nombre2;
            break;
        case "/":
            resultat = nombre1 / nombre2;
            break;
        default:
            //Code à éxécuter si on ne rentre dans aucune des cases ci-dessus
            Console.WriteLine("Opérateur inconnu");
            break;
    }
    return resultat;
}
#endregion