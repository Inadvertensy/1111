//принимает на вход два числа и выводить, является ли второе число кратно первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления
Console.WriteLine("number1");
//int number1=Convert.ToInt32(Console.ReadLine());
int number1=int.Parse(Console.ReadLine());
Console.WriteLine("number2");
int number2=Convert.ToInt32(Console.ReadLine());

if(number1%number2==0){
    Console.WriteLine($"Число {number2} кратно {number1}");
}
else
{
    Console.WriteLine($"Число {number2} не кратно {number1}");
     Console.WriteLine($"Остаток от деления {number1%number2}");
}


