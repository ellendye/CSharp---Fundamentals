using System;
using System.Collections.Generic;


namespace puzzles
{
    class Program
    {
        public static int[] RandomArray(){
            int[] randomArr = new int[10];
            Random rand = new Random();
            int min = 0;
            int max = 0; 
            int sum = 0;
            for(int i = 0; i<randomArr.Length; i++){
                randomArr[i] = rand.Next(5,randomArr.Length);
                if (i == 0){
                    min = randomArr[i];
                    max = randomArr[i];
                }
                else if (randomArr[i] < min){
                    min = randomArr[i];
                }
                else if (randomArr[i] > max){
                    max = randomArr[i];
                }
                sum += randomArr[i];
            }
            Console.WriteLine($"The min is {min} the max is {max} and the sum of all nums is {sum}");
            return randomArr;
        }

        public static string CoinToss() {
            string coinResult = "";
            Console.WriteLine("Tossing a coin!");
            Random rand = new Random();
            int coin = rand.Next(0,2);
            Console.WriteLine(coin);
            if (coin == 0){
                coinResult = "heads";
            }
            else{
                coinResult = "tails";
            }
            return coinResult;
        }

        public static double TossMutipleCoins(int num){
            Random rand = new Random();
            Console.WriteLine("Tossing a coin!");
            double heads = 0;
            double tails = 0;
            for ( int i = 0; i<num; i++){
                int coin = rand.Next(0,2);
                if(coin == 0){
                    heads += 1;
                    Console.WriteLine("Heads");
                }
                else{
                    tails += 1;
                    Console.WriteLine("Tails");
                }
            }
            double ratio = heads/num;
            return ratio;
        }
        public static List<string> nameList(){
            List<string> names = new List<string>() {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};

            Random rand = new Random();
            int shuffleTimes = (names.Count * 2);
            for (int i = 0; i<shuffleTimes; i++){
                int tempNum = rand.Next(0,names.Count);
                string temp = names[tempNum];
                int tempNum2 = rand.Next(0,names.Count);
                string temp2 = names[tempNum2];
                names[tempNum] = temp2;
                names[tempNum2] = temp;
            }

            List<string> newList = new List<string>();
            for (int i = 0; i<names.Count; i++){
                Console.WriteLine(names[i]);
                if(names[i].Length > 5){
                    newList.Add(names[i]);
                }
            }
            return newList;
        }


        static void Main(string[] args)
        {
            RandomArray();
            Console.WriteLine(CoinToss());
            Console.WriteLine(TossMutipleCoins(3));
            Console.WriteLine(nameList());
        }
    }
}
