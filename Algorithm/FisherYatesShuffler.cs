using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Algorithm
{
    public static class FisherYatesShuffler
    {
        //field to generate random number
        private static Random randomNumber = new Random();

        public static void DoFisherYatesShuffle(this object[] objects)
        {
            for (int i = objects.Length-1; i > 0; i--)
            {
                int j = randomNumber.Next(i + 1);
                object temp = objects[i];
                objects[i] = objects[j];
                objects[j] = temp;
            }
        }

        public static void TestFisherYatesShuffler()
        {
            string[] letters = { "A", "B", "C", "D", "E" };

            letters.DoFisherYatesShuffle();

            foreach (string letter in letters)
                Console.Write(letter + " ");
        }
    }
}
