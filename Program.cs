using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanierAchat
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Créer un objet Personne
            Panier objPanier1 = new Panier();

            Console.WriteLine("Entrer le code article: ");
            objPanier1.CodeItem = Console.ReadLine();
            Console.WriteLine("Entrer le nom de l'article: ");
            objPanier1.NameItem = Console.ReadLine();
            Console.WriteLine("Entrer la taille de l'article: ");
            objPanier1.SizeItem = Console.ReadLine();
            Console.WriteLine("Entrer le prix de l'article: ");
            objPanier1.PriceItem = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("==============================");
            Console.WriteLine("Détails Facturette\n");
            Console.WriteLine("============================");

            // Appel de la méthode de l'objet AfficheMessage()
            Console.WriteLine("Item #: {0}\nDescription: {1}\nTaille: {2}\nPrix unitaire: {3} $\n", objPanier1.CodeItem, objPanier1.NameItem, objPanier1.SizeItem, objPanier1.PriceItem);
            Console.WriteLine("==============================");
            Console.WriteLine("ce ci est un test pour github");

        } // Fin du Main
    } // Fin de la Classe Program
}

