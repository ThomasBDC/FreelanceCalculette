const float _plafondTTC = 36800;


//Début du programme
float nbFacture = getNumberFromUser();

float sommeFacture = 0;

for (int i = 0; i < nbFacture; i++)
{
    sommeFacture += getNumberFromUser();
}

//Affichage des statistiques
float net = getNet(sommeFacture);

Console.WriteLine("Somme des factures en brut annuel " + getNumberWithEuro(sommeFacture));
Console.WriteLine("Somme des factures en net annuel " + getNumberWithEuro(net));

//version 1 
float mensuelNet = getMensuel(net);
Console.WriteLine("Facture par mois net " + getNumberWithEuro(mensuelNet));

if (sommeFacture > _plafondTTC)
{
    Console.WriteLine("Le plafond brut est dépassé de " + getNumberWithEuro((sommeFacture - _plafondTTC)));
}

#region Fonctions
float getNet(float brut)
{
    return brut * 0.75f;
}

float getMensuel(float annuel)
{
    return annuel / 12f;
}

string getNumberWithEuro(float price)
{
    return price + " €";
}

float getNumberFromUser()
{
    int numberToReturn = 0;
    bool done = false;
    while (!done)
    {
        try
        {
            Console.WriteLine("Entrez votre proposition");
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

#endregion