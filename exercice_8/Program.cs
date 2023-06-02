// See https://aka.ms/new-console-template for more information
int[] tableau = new int[3];

Console.WriteLine("Veuillez écrire 3 chiffres");
for (int i = 0; i < 3; i++) {
    Console.WriteLine($"Chiffre {i + 1} :");
    tableau[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Merci, je vais maintenant afficher vos éléments :");

for (int i = 0; i < tableau.Length; i++) {
    Console.WriteLine($"L'élément {i + 1} est : {tableau[i]}");
}

Console.WriteLine("Tadaaa !");