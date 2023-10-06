Console.WriteLine("Bienvenue dans votre application de calculatrice !");
bool continueOperation = false;

do
{
    Console.WriteLine("Donnez moi votre calcul");

    string reponse = Console.ReadLine();

    string currentNumberOne = "";
    string currentNumberTwo = "";
    string currentOperator = "";
    bool currentNumberOneFinded = false;
    decimal currentResult = 0;
    foreach (char carac in reponse)
    {
        if (Char.IsDigit(carac))
        {
            if (currentNumberOneFinded)
            {
                currentNumberTwo += carac;
            }
            else
            {
                currentNumberOne += carac;
            }
        }
        else
        {
            if (!currentNumberOneFinded)
                currentNumberOneFinded = true;
            if (currentNumberOneFinded && currentNumberTwo != "" && currentOperator != "")
            {
                currentResult = doCalculs(currentNumberOne, currentNumberTwo, currentOperator);

                currentNumberOne = currentResult.ToString();
                currentNumberTwo = "";
            }
            currentOperator = carac.ToString();
        }
    }
    currentResult = doCalculs(currentNumberOne, currentNumberTwo, currentOperator);

    Console.WriteLine(currentResult);

    Console.WriteLine("Voulez-vous refaire un calcul ? O/N");
    continueOperation = Console.ReadLine() == "O";
} while(continueOperation);


decimal doCalculs(string numberOneStr, string numberTwoStr, string operateur)
{
    decimal resultat = 0;
    decimal numberOne = Convert.ToDecimal(numberOneStr);
    decimal numberTwo = Convert.ToDecimal(numberTwoStr);
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