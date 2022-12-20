/*Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую 
цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 3-х знаков */

Console.WriteLine("Введите трёхзначное число: ");
int dex = int.Parse(Console.ReadLine()!);
if (dex>99 && dex<1000) {
    int n2 = (dex/10)%10;
    Console.WriteLine($"Вторая цифра числа {dex} - {n2}");}
else 
{Console.WriteLine($"Число {dex} не соответствует условию");}

/*Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей 
цифры нет. Берем числа до 100000
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите число от 0 до 10000: ");
int indexber = int.Parse(Console.ReadLine()!);

if (indexber >= 0 && indexber < 10000)
{

    if (indexber < 100)
        Console.WriteLine($"В числе {indexber} нет третьей цифры");
    else
    {
        if (indexber < 1000)
        {
            int n3 = indexber % 10;
            Console.WriteLine($"Третья цифра числа {indexber} - {n3}");
        }
        else
        {
            int n3 = (indexber % 100) / 10;
            Console.WriteLine($"Третья цифра числа {indexber} - {n3}");

        }
    }

}


else
{ Console.WriteLine($"Число {indexber} не соответствует условию"); }

/*Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите число от 1 до 7: ");
int index = int.Parse(Console.ReadLine()!);

if (index > 0 && index < 8)
{



    if (index == 1)
        Console.WriteLine($"Для числа {index} соотвествует день недели Понедельник");
    if (index == 2)
        Console.WriteLine($"Для числа {index} соотвествует день недели Вторник");
    if (index == 3)
        Console.WriteLine($"Для числа {index} соотвествует день недели Среда");
    if (index == 4)
        Console.WriteLine($"Для числа {index} соотвествует день недели Четверг");
    if (index == 5)
        Console.WriteLine($"Для числа {index} соотвествует день недели Пятница");
    if (index == 6)
        Console.WriteLine($"Для числа {index} соотвествует день недели Суббота");
    if (index == 7)
        Console.WriteLine($"Для числа {index} соотвествует день недели Воскресенье");


    if (index < 6) { Console.WriteLine($"Это рабочий день"); }
    else { Console.WriteLine($"Это выходной день"); }
}
else
{ Console.WriteLine($"Число {index} не соответствует условию"); }