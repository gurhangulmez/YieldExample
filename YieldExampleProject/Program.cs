using System;
using System.Collections.Generic;

namespace YieldExampleProject
{
    class Program
    {
        IList<int> ageList = new List<int> { 34,3,21,23,45,56,67,43,2,12,4,3,54,5,76,6,8,9,90,5,0,6,34,423,21,342,34,56,6,68,7,9,0,6,43,324,23,432,54,456,56,9,80,9,7,65,3,32,23,4,56,568,78,98};
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Lets Start to Yield!");

            foreach(int moreThanMinAge in p.GetAges(18))
            {
                Console.WriteLine("You can enter to Club : " + moreThanMinAge);
            }            
        }

        IEnumerable<int> GetAges(int minimum)
        {
            Console.WriteLine("Lets GetAges!"); 

            foreach (int num in ageList)
            {
                if (num == 68)
                {
                    Console.WriteLine("Lets Yield break!");
                    yield break;
                }

                Console.WriteLine("Lets Yield!");
                if (num >= minimum)
                {
                    yield return num;
                }
            }
        }
    }
}
