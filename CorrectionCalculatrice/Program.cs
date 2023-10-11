Console.WriteLine("Bienvenue dans votre calculatrice");

bool continueCalcul = false;

do
{
    Console.WriteLine("Entrez votre calcul");
    string calculUtilisateur = Console.ReadLine();

    string nombre1str = "";
    string nombre2str = "";
    string operateur = "";
    bool nombre1Finded = false;

    foreach (char caractere in calculUtilisateur)
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
                decimal currentResult = doCalculStr(nombre1str, nombre2str, operateur);
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

    decimal Resultat = doCalculStr(nombre1str, nombre2str, operateur);

    string phraseAAfficher = $"Résultat : {Resultat}";

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

decimal doCalculStr(string nombre1str, string nombre2str, string operateur)
{
    decimal nombre1 = Convert.ToDecimal(nombre1str);
    decimal nombre2 = Convert.ToDecimal(nombre2str);

    decimal resultat = doCalcul(nombre1, nombre2, operateur);
    return resultat;
}
#endregion