// // Напишите цифру, которая выводит случайное число из отрезка [10:99] и показывает наибольшую цифру числа
// //78-->8
// //12-->2
// //85-->8
// using System;

// namespace Seminar2
// {
// class Program
// {
// static void Main (string[] args)
// {
//     Console.WriteLine("Hello world!");
//     MaxNumber();
// }
//         static  int MaxNumber()
//         {
//             int number1 = new Random().Next(10,1000);

//             int max = 0;

//             int iterator = number1;
// //iterator=798
//             while(iterator !=0)
//             {
//                 int number2=iterator%10;
// //number2=8
//                 if(number2>max) max=number2;

//                 iterator/=10;
//                 //iterator=iterator/10
// //iterator=79
                
//             }
//             System.Console.WriteLine($"Number{number1} Max {max}");
//         }

// }
// }

///////////////////////////////////


using System;

namespace Seminar2
{
    class Program
    {
        static void Main (string[] args)
        {
        System.Console.WriteLine("Hello world!");
       
        MaxNumber();
        }
        static void MaxNumber()
{
            int number1 = new Random().Next(10,1000);

            int max = 0;

            int iterator = number1;
//iterator=798
            while(iterator !=0)
            {
                int number2=iterator%10;
//number2=8
                if(number2>max) max=number2;

                iterator/=10;
                //iterator=iterator/10
//iterator=79
                
            }
            System.Console.WriteLine($"Number{number1} Max {max}");
        }
        }

    }
