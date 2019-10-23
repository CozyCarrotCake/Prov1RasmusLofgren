using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntikvariatProvet
{
    class Books
    {


        public int price;
        string name;
        int rarity;
        string category;
        int actualValue;
        bool cursed;
        
        Random generator = new Random();

        string[] names = { "UNO", "ZWEI", "TREEE" };
        string[] categories = { "Super Sweet", "Allright", "Crap" };
        int correctPrice;
        int twoSidedCoin;
        int threeSidedCoin;
        int tenSidedCoin;

        public void Book() // Slumpar alla värden efter att den insansierat med hjälp av generator, instansen från Random-klassen
        {
            actualValue = generator.Next(10, 501);
            rarity = generator.Next(1, 11);

            twoSidedCoin = generator.Next(0, 1);

            //Slumpa cursed
            if (twoSidedCoin == 0)
            {
                cursed = true;
            }
            else
            {
                cursed = false;
            }

            //Slumpa namn, får namnet i arrayen med samma index som det slumpade talet
            threeSidedCoin = generator.Next(0, 3);
            if (threeSidedCoin == 0)
            {
                name = names[0];
            }
            else if (threeSidedCoin == 1)
            {
                name=names[1];
            }
            else
            {
                name=names[2];
            }
                       



            //slumpa kategori

            threeSidedCoin = generator.Next(0, 3);
            if (threeSidedCoin == 0)
            {
                category = categories[0];
            }
            else if (threeSidedCoin == 1)
            {
                category = categories[1];
            }
            else
            {
                category = categories[2];
            }



        } 


        public void PrintInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Category: " + category);
            Console.WriteLine("Rarity: " + rarity);
            Console.WriteLine("Price: " + price);
        }

        public int Evaluate()
        {
            correctPrice  = rarity * actualValue;

            twoSidedCoin = generator.Next(0,1);

            if (twoSidedCoin == 0)
            {
                correctPrice = correctPrice/2;
            }
            else
            {
                correctPrice = correctPrice * 3 / 2;
            }

            return correctPrice;
        }
        // Båda returnerar så att man kan 

        public string GetCategory() 
        {
            return category;
        }

        public string GetName()
        {
            return name;
        }

        public bool IsCursed() // Slumpar om den är cursed. När den returnerar true så har man gissat rätt i Main, false inte
        {
            tenSidedCoin = generator.Next(1, 11);

            if (tenSidedCoin < 9)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
