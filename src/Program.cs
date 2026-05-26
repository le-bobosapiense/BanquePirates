using System;

class Program
{
    static void Main()
    {
        int number = GetPositiveInteger("Veuillez entrer un entier strictement positif: ");
        Console.WriteLine($"Vous avez saisi: {number}");
    }

    /// <summary>
    /// Enregistre un entier saisi par l'utilisateur.
    /// Redemande jusqu'à ce que le format soit un entier strictement positif.
    /// </summary>
    /// <param name="prompt">Le message à afficher à l'utilisateur</param>
    /// <returns>Un entier strictement positif</returns>
    static int GetPositiveInteger(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number > 0)
            {
                return number;
            }

            Console.WriteLine("Erreur: Veuillez entrer un entier strictement positif.");
        }
    }
}
