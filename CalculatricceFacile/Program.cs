// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenue dans mon application de calculatrice ! ");

Console.WriteLine("Merci d'entrer votre premier nombre");
decimal numberOne = getNumberFromUser();

Console.WriteLine("Merci d'entrer votre deuxième nombre");
decimal numberTwo = getNumberFromUser();

Console.WriteLine("Merci d'entrer l'opérateur");
string operateur = Console.ReadLine();

Console.WriteLine("Voici le résultat : ");
Console.WriteLine(doCalculs(numberOne, numberTwo, operateur));

decimal doCalculs(decimal numberOne, decimal numberTwo, string operateur)
{
    decimal resultat = 0;
    switch (operateur)
    {
        case "+":
            resultat = numberOne + numberTwo;
            break;
        case "-":
            resultat = numberOne - numberTwo;
            break;
        case "*":
            resultat = numberOne * numberTwo;
            break;
        case "/":
            resultat = numberOne / numberTwo;
            break;
        default:
            throw new ArgumentException("Opérateur non pris en charge : " + operateur);
    }

    return resultat;
}



decimal getNumberFromUser()
{
    int numberToReturn = 0;
    bool done = false;
    while (!done)
    {
        try
        {
            numberToReturn = Convert.ToInt32(Console.ReadLine());
            done = true;
        }
        catch
        {
            Console.WriteLine("Saisie incorect");

        }
    }
    return numberToReturn;
}