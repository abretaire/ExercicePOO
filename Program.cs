using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Article article1 = new Article();
            article1.Afficher();

            Article article2 = new Article("Article 1", "Désignation de l'article 1", 100, 20);
            article2.Afficher();

            Console.ReadLine();
        }
    }
}
