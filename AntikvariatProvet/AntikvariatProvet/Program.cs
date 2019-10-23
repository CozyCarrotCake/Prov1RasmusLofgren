using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntikvariatProvet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapar listor för klassernas instanser 
            List<Books> books = new List<Books>();
            List<Buyer> buyers = new List<Buyer>();
            //För att kunna spara böckernas pris och cursed-ness då man jämför med kunden
            List<int> sellingPrices = new List<int>();
            List<bool> cursedBooks = new List<bool>();

            string answer;
            int sellingPrice;
            bool convert;
            string cursedQ;
            bool cursedq;
            bool cursed;

            for (int i = 0; i < 3; i++) // Först värdesätter man alla böcker, därefter i nästa for-loop kommer kunderna och köper eller inte böckerna.
            {
                books.Add(new Books());// Instantsierar boken i listan med for-loopens index

                books[i].Book(); //Kör Book-metoden från klassen

                books[i].PrintInfo();

                Console.WriteLine("What would you evaluate this book to be?");
                answer = Console.ReadLine();
                
                convert = int.TryParse(answer, out sellingPrice);

                while (convert == false)
                {
                    Console.WriteLine("Please write the amount!");
                    answer = Console.ReadLine();
                    convert = int.TryParse(answer, out sellingPrice);
                }

                Console.WriteLine("Okay! It's worth " + sellingPrice + "!");
                //Lägger till priset i listan med böckernas priser till då kunderna köper de.
                sellingPrices[i] = sellingPrice;

                //Cursed?

                Console.WriteLine("Is it cursed? Write YES or NO");
                cursedQ = Console.ReadLine();
                while (cursedQ != "YES" || cursedQ != "NO")
                {
                    Console.WriteLine("YES or NO?");
                    cursedQ = Console.ReadLine();
                }

                if (cursedQ == "YES")
                {
                    cursedq = true;
                }
                else
                {
                    cursedq = false;
                }

                //För att kunna använda i nästa for-loop för all böckera
                cursed = books[i].IsCursed();

                
                if (cursedq != cursed)
                {
                    Console.WriteLine("You were wrong!");
                    cursedBooks[i] = true;
                }

                //Han inte använda dessa
                books[i].GetName();

                Console.ReadLine();
            }


            for (int i = 0; i<5; i++)
            {
                buyers.Add(new Buyer());

                string name = buyers[i].GetName();
                string category = buyers[i].GetCat();
                int money = buyers[i].GetMoney();

                Console.WriteLine(name + " walks into the place!");

                for (int o = 0; o < 3; o++)
                {
                    if (category == books[o].GetCategory() && money > sellingPrices[o] && cursedBooks[o] == false)
                    {
                        Console.WriteLine("SOLD");
                        //Add money 

                    }
                    else
                    {
                        Console.WriteLine("Didn't buy nothing!");
                    }
                }
                

            }





            Console.ReadLine();
        }
    }
}
