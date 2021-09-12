using System;

namespace FundamentalsI
{
    class Program
    {
        public static void print1To255(){
            for(int i=1; i<=255; i++){
                Console.WriteLine(i);
            }
        }
        public static void divisible3Or5(){
            for(int i=1; i<=100; i++){
                if(i % 3 == 0 && i % 5 != 0){
                    Console.WriteLine(i);
                }
                if(i % 5 == 0 && i % 3 != 0){
                    Console.WriteLine(i);
                }
            }
        }
        public static void fizzBuzz(){
            for(int i=1; i<=100; i++){
                if(i % 3 == 0 && i % 5 != 0){
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0 && i % 3 != 0){
                    Console.WriteLine("Buzz");
                }
                else if(i % 5 == 0 && i % 5 == 0){
                    Console.WriteLine("FizzBuzz");
                }
            }
        }
        public static void whilePrint1To255(){
            int i = 1;
            while (i <= 255){
                Console.WriteLine(i);
                i++;
            }
        }
        public static void whileDivisible3Or5(){
            int i = 1;
            while(i <= 100){
                if(i % 3 == 0 && i % 5 != 0){
                    Console.WriteLine(i);
                }
                if(i % 5 == 0 && i % 3 != 0){
                    Console.WriteLine(i);
                }
                i++;
            }
        }
        public static void whileFizzBuzz(){
            int i = 1;
            while(i<=100){
                if(i % 3 == 0 && i % 5 != 0){
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0 && i % 3 != 0){
                    Console.WriteLine("Buzz");
                }
                else if(i % 5 == 0 && i % 5 == 0){
                    Console.WriteLine("FizzBuzz");
                }
                i++;
            }
        }
        static void Main(string[] args)
        {
            whileFizzBuzz();
            whileDivisible3Or5();
            whilePrint1To255();
            print1To255();
            divisible3Or5();
            fizzBuzz();
        }
    }
}
