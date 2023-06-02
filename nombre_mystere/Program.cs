// See https://aka.ms/new-console-template for more information
const int nombreMystere = 50;
const int nbMin = 1;
const int nbMax = 100;
Console.WriteLine("Bienvenue, comment vous appelez-vous ?");
string prenom = Console.ReadLine();
Console.WriteLine($"Bonjour {prenom}, nous allons jouer au jeu du nombre mystere, je vais choisir un nombre entre 1 et 100 et vous allez essayer de le deviner. Prêt ? Partez !");

bool gagne = false;

// Déclaration de la liste des différents nombres déjà choisis par l'utilisateur
List<int> nombres = new List<int>();

string indication = "";

// Boucle gérant le jeu
while (!gagne)
{
    // nettoyage de la console a chaque tour
    Console.Clear();

    Console.WriteLine(indication);

    // Affiche les nombres deja joués s'il y en a
    if (nombres.Count > 0)
    {
        Console.Write("Nombres deja joués : ");
        foreach (int entier in nombres)
        {
            Console.Write($"{entier} ");
        }
    }
    // Ligne vide
    Console.WriteLine();

    // tour de jeu
    int nbSaisi = 0;
    while (nbSaisi < nbMin || nbSaisi > nbMax)
    {
        Console.WriteLine($"Veuillez saisir un nombre entre {nbMin} et {nbMax} :");
        try
        {
            nbSaisi = int.Parse(Console.ReadLine());
        }
        catch
        {
            nbSaisi = 0;
        }
    }

    // Verifie que le nombre n'a pas deja été choisi
    if (nombres.Contains(nbSaisi))
    {
        Console.WriteLine("Vous avez déjà choisi ce nombre. Essayez encore !");
        continue;
    }
    else if (nombreMystere == nbSaisi)
    {
        gagne = true;
    }
    else if (nombreMystere > nbSaisi)
    {
        indication = "Le nombre est plus grand";
        nombres.Add(nbSaisi);
    }
    else if (nombreMystere < nbSaisi)
    {
        indication = "Le nombre est plus petit";
        nombres.Add(nbSaisi);
    }
}

// Fin du jeu
Console.WriteLine($"Félicitation {prenom}, le nombre mystère était bien {nombreMystere} !");