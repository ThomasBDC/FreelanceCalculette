//Instancier un calcul en dur dans le code
using Calculatrice;


string nombre1 = Console.ReadLine();
string nombre2 = Console.ReadLine();
string operateur = Console.ReadLine();
Calcul monCalculFromString = new Calcul(nombre1, nombre2, operateur);

Console.WriteLine(monCalculFromString.DoCalculs());


Console.WriteLine("Bienvenue dans votre application de calculatrice !");
bool continueOperation = false;

do
{
    Console.WriteLine("Donnez moi votre calcul");

    string reponse = Console.ReadLine();
    try
    {
        string currentNumberOne = "";
        string currentNumberTwo = "";
        string currentOperator = "";
        bool currentNumberOneFinded = false;
        decimal currentResult = 0;
        foreach (char carac in reponse)
        {
            //Le caractère est il un nombre ? 
            if (char.IsDigit(carac))
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
                {
                    currentNumberOneFinded = true;
                }
                else if (currentNumberOneFinded && currentNumberTwo != "" && currentOperator != "")
                {
                    //J'ai mon nombre 1, mon nombre 2, et mon opérateur, je fait donc le calcul
                    currentResult = doCalculs(currentNumberOne, currentNumberTwo, currentOperator);
                    
                    //Le calcul est fait, donc mon nombre 1 devient le résultat final, et je supprime le 2
                    currentNumberOne = currentResult.ToString();
                    currentNumberTwo = "";
                }
                currentOperator = carac.ToString();
            }
        }
        currentResult = doCalculs(currentNumberOne, currentNumberTwo, currentOperator);

        Console.WriteLine(currentResult);
    }
    catch(Exception ex)
    {
        if (ex.GetType() == typeof(DivideByZeroException))
        {
            Console.WriteLine("Impossible de diviser par zero");
        }
        else
        {
            Console.WriteLine("Impossible d'interpréter votre demande.");
        }
    }
    

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
    }

    return resultat;
}