using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;

namespace RandomHits
{
    public class Program
    {
        // private static readonly object GetHits;

        public static void Main()
        {
            List<Hits> hit = new();
            string userInput = "";

            do
            {
                AddHits(hit);
                Console.WriteLine("To EXIT PROGRAM, Type \"exit\" or hit enter go again.");
                userInput = Console.ReadLine();
            } while (userInput != "exit");

           // hit.ForEach((Hits) => { Console.WriteLine(Hits.GetHits); });
        }


        static void AddHits(List<Hits> damage)
        {

            Random rd = new();
            int rand_num = rd.Next(1, 36);

            Hits hit = new()
            {
                GetHits = rand_num
            };


            damage.Add(hit);

            Console.WriteLine($"----------- Hit enter to continue -----------");
            Console.WriteLine(rand_num);
            Console.ReadLine();

        }


    }


    public class Hits
    {
        public int GetHits { get; set; }


    }

}

