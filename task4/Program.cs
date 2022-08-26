//Console.WriteLine(new Random().Next(1,999));
//убирает среднюю цифру из трехзначного числа
int number=new Random().Next(100,999);
Console.WriteLine(number);
int number1=number/100;
int number2=number%10;
int number3=number1*10+number2;
Console.WriteLine(number3);