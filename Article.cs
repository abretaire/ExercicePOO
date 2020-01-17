using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicePOO
{
    public class Article
    {
        private string reference;
        public string Reference
        {
            get
            {
                return reference;
            }
            set
            {
                reference = value;
            }
        }


        private string Designation { get; set; }

        private double prixHT;
        public double PrixHT { get => prixHT; set => prixHT = value; }
        
        
        private double tauxTVA;
        public double TauxTVA { get => tauxTVA; set => tauxTVA = value; }


        public Article()
        {

        }
        public Article(string reference, string designation, double prixHT, double tauxTVA)
        {
            this.reference = reference;
            this.Designation = designation;
            this.prixHT = prixHT;
            this.tauxTVA = tauxTVA;
        }

        public double CalculerPrixTTC()
        {
            double prixTTC =  0;

            prixTTC = prixHT + (prixHT * tauxTVA / 100);

            return prixTTC;
        }

        public void Afficher()
        {

            Console.WriteLine(string.Format("Reference: {0}", this.reference));
            Console.WriteLine(string.Format("Designation: {0}", this.Designation));
            Console.WriteLine(string.Format("PrixHT: {0}", this.prixHT));
            Console.WriteLine(string.Format("tauxTVA: {0}", this.tauxTVA));
            Console.WriteLine(string.Format("PrixTTC: {0}", CalculerPrixTTC()));
        }

        


    }
}
