using System;
using System.Collections.Generic;

namespace curs4
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat1 = new Cat()
            {
                Name = "Tomas"
            };
            //cat1.Name = "Tomas";
            var cat2 = new Cat()
            {
                Name = "Viorel"
            };
            var cat3 = new Cat()
            {
                Name = "Garfield"
            };
            var dog1 = new Dog()
            {
                Name = "Totto"
            };

            var catsList = new List<Cat>();
            catsList.Add(cat1);
            catsList.Add(cat2);
            catsList.Add(cat3);

            foreach(var cat in catsList)
            {
                cat.MakeNoise();
            }
        }
    }
}
