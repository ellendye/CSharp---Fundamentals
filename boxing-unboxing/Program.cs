using System;
using System.Collections.Generic;


namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> boxing = new List<object>();
            boxing.Add(7);
            boxing.Add(28);
            boxing.Add(-1);
            boxing.Add(true);
            boxing.Add("chair");
            int sum = 0;
            for (int i=0; i<boxing.Count; i++){
                if(boxing[i] is int){
                    int iterator = (int)boxing[i];
                    sum += iterator;
                }
                Console.WriteLine(boxing[i]);
            }
            Console.WriteLine($"The sum of all integers is {sum}");
        }
    }
}
