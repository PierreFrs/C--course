// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bonjour, comment vous appelez-vous ?");
string prenom = Console.ReadLine();
Console.WriteLine($"Bonjour {prenom}, et quel age avez-vous ?");
string age = Console.ReadLine();
int ageInt = int.Parse(age);
int majorite = 18;
bool estMajeur = ageInt >= majorite;
if (!estMajeur) {
    Console.WriteLine($"Vous vous appelez {prenom} et vous avez {ageInt} ans. Vous êtes donc mineur");
} else {
    Console.WriteLine($"Vous vous appelez {prenom} et vous avez {ageInt} ans. Vous êtes donc majeur");
}

