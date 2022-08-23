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
        System.Console.WriteLine("Hello world!");
       
        MaxNumber2();
        }
        static void MaxNumber2()
        {
            int number = new Random().Next(10,99);
            int number1=number%10;
            int number2=number/10;
            int max = number1;

            if(number1<number2){
                max=number2;
            }
                System.Console.WriteLine($"Number {number} Max {max}");
        }
        }

    }

