// Напишите цифру, которая выводит случайное число из отрезка [10:99] и показывает наибольшую цифру числа
//78-->8
//12-->2
//85-->8
using System;

namespace Seminar2
{
class Program
{
static void Main (string[] args)
{
    Console.WriteLine("Hello world!");
}
        static  int MaxNumber()
        {
            int number1 = new Random().Next(10,1000);

            int max = 0;

            int iterator = number1;

            while(iterator !=0)
            {
                int number2=iterator%10;

                if(number2>max) max=number2;

                iterator/=10;
                
                
            }
        }

}
}