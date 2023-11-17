using _3_mon.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_mon
{
    class Cat
    {
        public string Name { get; set; } // Имя
        public int HungerLevel { get; set; } // Уровень сытости
        public int MoodLevel { get; set; } //уолвень настроения

        public Cat(string name, int hungerLevel, int moodLevel)
        {
            Name = name;
            HungerLevel = hungerLevel;
            MoodLevel = moodLevel;
        }


        public void EatSomething(Food food)
        {
            Console.WriteLine($"{Name} ест {food}.");
            switch (food)
            {
                case Food.Fish:
                    HungerLevel += 20;
                    break;
                case Food.Mouse:
                    HungerLevel += 10;
                    break;
                case Food.Milk:
                    HungerLevel += 5;
                    break;
                case Food.Chicken:
                    HungerLevel += 15;
                    break;
                case Food.Beef:
                    HungerLevel += 18;
                    break;
                case Food.Turkey:
                    HungerLevel += 12;
                    break;
                case Food.Tuna:
                    HungerLevel += 25;
                    break;
                case Food.Salmon:
                    HungerLevel += 22;
                    break;
                case Food.Shrimp:
                    HungerLevel += 8;
                    break;
                case Food.Liver:
                    HungerLevel += 15;
                    break;
                case Food.Cheese:
                    HungerLevel += 7;
                    break;
                case Food.Yogurt:
                    HungerLevel += 6;
                    break;
                case Food.Catnip:
                    MoodLevel += 200; // Котяра словила лютый кайф
                    Console.WriteLine("Котяра ваще вау от этой кошачьей мяты!");
                    break;
                case Food.Eggs:
                    HungerLevel += 10;
                    break;
                case Food.Duck:
                    HungerLevel += 16;
                    break;
                case Food.Rabbit:
                    HungerLevel += 14;
                    break;
                case Food.Venison:
                    HungerLevel += 20;
                    break;
                case Food.Kibble:
                    HungerLevel += 15;
                    break;
                default:
                    Console.WriteLine("Неизвестная еда");
                    break;
            }

            Console.WriteLine($"Уровень сытости {Name} стал {HungerLevel}.");
        }
    }
}
