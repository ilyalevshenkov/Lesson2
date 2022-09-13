// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введи номер: ");
int number = int.Parse(Console.ReadLine());
switch (number)
{
case 1:
Console.WriteLine("Понедельник -нет");
break;
case 2:
Console.WriteLine("Вторник - нет");
break;
case 3:
Console.WriteLine("Среда - нет");
break;
case 4:
Console.WriteLine("Четверг - нет");
break;
case 5:
Console.WriteLine("Пятница - почти");
break;
case 6:
Console.WriteLine("Суббота - да");
break;
case 7:
Console.WriteLine("Воскресенье - да");
break;
default:
Console.WriteLine("Нет такого дня недели");
break;
} 