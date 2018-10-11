using System;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int P = 20;
            int[] list = { 1, 5, 5, 2 };
            int size = list.Length;
            for (int i = 0; i < size; i++){
                sum += list[i];
            }
                if (sum >= P){
                    Console.WriteLine("True");
                }
                else{
                    Console.WriteLine("False");
                }
                

               
            

           }
     }
}

