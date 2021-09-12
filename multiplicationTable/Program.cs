using System;
using System.Collections.Generic;


namespace multiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10,10];
            for (int i = 0; i < array.GetLength(0); i++){
                for (int j = 0; j < array.GetLength(1); j++) {
                    if(j == 0){
                        Console.Write("[");
                    }
                    array[i,j] = (i+1) * (j+1);
                    Console.Write("{0}, ", array[i, j]);
                    if(j == array.GetLength(1)-1){
                        Console.Write("]");
                    }
                }
            Console.WriteLine();
            }
        }
    }
}
