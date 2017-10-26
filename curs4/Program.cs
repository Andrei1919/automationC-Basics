using System;
using System.Collections.Generic;

namespace curs4
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat1 = new Kitty()
            {
                Name = "Tomas"
            };
            //cat1.Name = "Tomas";
            var cat2 = new Kitty()
            {
                Name = "Viorel"
            };
            var cat3 = new Kitty()
            {
                Name = "Garfield"
            };

            var catsList = new List<Kitty>();
            catsList.Add(cat1);
            catsList.Add(cat2);
            catsList.Add(cat3);

            for(var i=0;i<catsList.Count;i++)
            {
                catsList[i].MakeNoise();
            }

            foreach(var cat in catsList)
                cat.MakeNoise();
        }
    }

    public class Kitty
    {
        public string Name{get;set;}

        public void MakeNoise(){
            Console.WriteLine(Name + " says Miawww");
        }


    }
}
