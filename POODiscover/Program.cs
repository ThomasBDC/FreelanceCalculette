// See https://aka.ms/new-console-template for more information
using POODiscover;

Console.WriteLine("Hello, World!");


User monUtilisateur = new User();
monUtilisateur.Prenom = "Thomas";

Console.WriteLine(monUtilisateur.Prenom);

//Affichera          padawan Thomas
string nomDisplay = User.UserPrefixe + monUtilisateur.Prenom;