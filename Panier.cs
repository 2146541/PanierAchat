using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanierAchat
{
    public class Panier
    {
        // nom de la Personne
        private string noItem;
        private string nomItem;
        private string tailleItem;
        private decimal prixItem;

        //Propriété Auto-implémentée
        public string CodeItem { get; set; }
        public string NameItem { get; set; }
        public string SizeItem 
        { 
            get 
            { 
                return tailleItem; 
            } 
            set 
            {   
                if (value == "0")
                    tailleItem = "Taille inconnue";
                else
                    tailleItem = value;
            } 
        }
        public decimal PriceItem { 
            get 
            { 
                return Convert.ToDecimal(prixItem); 
            } 
            set 
            {   
                if (value < 0)                  
                    prixItem = 0.0m; 
                else
                    prixItem = Convert.ToDecimal(value);
            }
        }

        public Panier()
        {
            //CodeItem = null;
            //NameItem = null;
            //SizeItem = null;
            //PriceItem = 0.0m;
            noItem = null;
            nomItem = null;
            tailleItem = null;
            prixItem = 0.0m;
        }

        // Constructeur initialise Personne
        public Panier(string noItem, string nomItem, string tailleItem, decimal prixItem)
        {
            //CodeItem = noItem;
            //NameItem = nomItem;
            //SizeItem = tailleItem;
            //PriceItem = Convert.ToDecimal(prixItem);
            this.noItem = noItem;
            this.nomItem = nomItem;
            this.tailleItem = tailleItem;
            this.prixItem = Convert.ToDecimal(prixItem);
        }


        public override string ToString()
        {
            return this.noItem + " " + this.nomItem + " " + this.tailleItem + " " + this.prixItem;
        }

        // Affiche un message à l'utilisateur
        public void AfficheMessage()
        {
            Console.WriteLine("Item #: {0}\nDescription: {1}\nTaille: {2}\nPrix unitaire: {3}\n", this.noItem, this.nomItem, this.tailleItem, this.prixItem);
        }

    }
}
