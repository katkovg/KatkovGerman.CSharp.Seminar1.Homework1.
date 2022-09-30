/*
// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Input first number:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("A larger number is " + number1);
    Console.WriteLine("A smaller number is " + number2);
}
else
{
    Console.WriteLine("A larger number is " + number2);
    Console.WriteLine("A smaller number is " + number1);
}
*/

/*
// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Input first number:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number:");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2 && number1 > number3)
{
    Console.WriteLine("A larger number is " + number1);
}
else if (number2 > number1 && number2 > number3)
{
   Console.WriteLine("A larger number is " + number2);
}
else if (number3 > number1 && number3 > number2)
{
    Console.WriteLine("A larger number is " + number3);
}
*/

/*
// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Input a number:");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Your number is even");
} 
else
{
    Console.WriteLine("Your number is not even");
}
*/

/*
//Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Input a number:");
int number = Convert.ToInt32(Console.ReadLine());
int current = 1;

if (number <= 1)
{
    Console.Write("Uncorrect number. Input a number that is greater than zero and greater than one.");
}
else
{
    while (current <= number)
        {
            if (current == number) 
                { 
                    if (current % 2 == 0)
                        {
                            Console.Write(current); 
                            break;
                        }
                    else
                    {
                        break;
                    }
                }
            else
                {
                    if (current % 2 == 0)
                    {
                        Console.Write(current + " ");
                        current++;
                    }
                    else
                    {
                        current++;
                    }
                }
        }
}
*/
