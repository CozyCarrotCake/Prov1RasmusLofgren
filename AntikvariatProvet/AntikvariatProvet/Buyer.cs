using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntikvariatProvet
{
    class Buyer
    {
        Random generator = new Random();
        int money;

        string name;
        string[] names = { "Kevin", "Dylan", "Barb", "DOnnie", "Coolio" };
        int nameRand;

        string[] categories = { "Super Sweet", "Allright", "Crap" };
        string category;
        int catRand;


        public void Buyers() // Slumpar värden efter att den instansierats
        {
            money = generator.Next(10, 501);


            nameRand = generator.Next(1,6);
            name = names[nameRand];


            catRand = generator.Next(1, 4);
            category = categories[catRand];
        }

        //Alla dessa returnerar värdena så att de kan användas i main utan att vara public i klassen.

        public string GetName()

        {
            return name;
        }

        public string GetCat()
        {
            return category;
        }

        public int GetMoney()
        {
            return money;
        }



    }
}
