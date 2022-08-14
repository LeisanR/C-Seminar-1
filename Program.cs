// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int numbera = new Random().Next(0,100);
Console.WriteLine (numbera);
int numberb = new Random().Next(0,100);
Console.WriteLine (numberb);
if (numbera>numberb)
{
Console.WriteLine (numbera);
}
else 
{
Console.WriteLine (numberb);
}