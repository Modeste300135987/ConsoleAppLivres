using ConsoleAppLivres;

internal class Program
{
    private static void Main(string[] args)
    {
        Revue revue1 = new Revue("La belle et la bete", "Paule Isabelle", 99, 12, 2015);
        Revue revue2 = new Revue("The Magazine", "Camilla Bones", 100, 05, 2013);
        Revue revue3 = new Revue("Union", "John Hugh", 150, 40, 2010);


        Roman roman1 = new Roman("Et Pourtant elle pleurait", "Isaie Biton Coulibaly", 156, "Roman");
        Roman roman2 = new Roman("SAS ", "Gérard de Villiers", 218, "romans d'espionnage");
        Roman roman3 = new Roman("Harry Potter", "J. K. Rowling", 300, "Science Fiction");


        //Créer une liste Livre
        List<Livre> livres = new List<Livre> { revue1, revue2, revue3, roman1, roman2, roman3 };

        // Parcourir la liste et afficher 
        Console.WriteLine("Les livres de la liste sont:");
        foreach (Livre livre in livres)
        {
            livre.AfficherDetails();
        }
    }
}