/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("a = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("c = ");
int numberC = Convert.ToInt32(Console.ReadLine());

string result;
if(numberA >= numberB)
{
    result = "max = numberA";
}
else 
{
    result = "max = numberB";
}
if(numberA >= numberC)
{
    result = "max = numberA";
}
else
{
    result = "max = numberC";
}
Console.WriteLine(result);