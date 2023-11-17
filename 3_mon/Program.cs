using _3_mon.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Мурзик", 50, 50);

            cat1.EatSomething(Food.Fish);
            cat1.EatSomething(Food.Mouse);
            cat1.EatSomething(Food.Milk);
            cat1.EatSomething(Food.Chicken);
            cat1.EatSomething(Food.Beef);
            cat1.EatSomething(Food.Turkey);
            cat1.EatSomething(Food.Tuna);
            cat1.EatSomething(Food.Salmon);
            cat1.EatSomething(Food.Shrimp);
            cat1.EatSomething(Food.Liver);
            cat1.EatSomething(Food.Cheese);
            cat1.EatSomething(Food.Yogurt);
            cat1.EatSomething(Food.Catnip);
            cat1.EatSomething(Food.Eggs);
            cat1.EatSomething(Food.Duck);
            cat1.EatSomething(Food.Rabbit);
            cat1.EatSomething(Food.Venison);
            cat1.EatSomething(Food.Kibble);
        }
    }
}
