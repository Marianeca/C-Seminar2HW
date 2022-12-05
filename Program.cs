//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число   ");
string number = Console.ReadLine()!;


if (number.Length > 2)
{
    Console.Write($"Третья цифра = {number[2]} \n");
}
else
{
    Console.Write($"Третьей цифры нет \n ");
}


