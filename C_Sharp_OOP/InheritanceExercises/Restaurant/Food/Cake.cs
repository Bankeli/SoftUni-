﻿
namespace Restaurant.Food
{
    namespace Restaurant
    {
        public class Cake : Dessert
        {
            private const double CakeGrams = 250;
            private const double CakeCalories = 1000;
            private const decimal CakePrice = 5.00m;

            public Cake(string name)
                : base(name, CakePrice, CakeGrams, CakeCalories)
            {
            }
        }
    }

}
