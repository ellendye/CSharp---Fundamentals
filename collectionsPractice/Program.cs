using System;
using System.Collections.Generic;

namespace collectionsPractice
{
    class Program
    {

        static void Main(string[] args)
        {
            //three basic arrays
            int[] arr1 = {0,1,2,3,4,5,6,7,8,9};
            string[] arr2 = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] arr3 = {true, false, true, false, true, false, true, false, true, false};
            //list of flavors
            List<string> flavors = new List<string>();
            flavors.Add("vanilla");
            flavors.Add("chocolate");
            flavors.Add("rasberry");
            flavors.Add("chocolate chip");
            flavors.Add("banana");
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);

            //user info dictionary
            Dictionary<string, string> users = new Dictionary<string, string>();
            Random rand = new Random();
            for (int i = 0; i<arr2.Length; i++){
                users.Add(arr2[i], flavors[rand.Next(flavors.Count)]);
            }

            foreach(var user in users){
                Console.WriteLine($"{user.Key} will have {user.Value} ice cream");
            }
        }
    }
}
