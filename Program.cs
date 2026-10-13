// int age = 22;

// if (age >= 21)
// {
//     Console.WriteLine("Доступ разрешён.");
// }

// Console.WriteLine($"Программа продолжает работу");

// Console.WriteLine();
// Console.WriteLine("Введите ваш возраст: ");
// int age2 = int.Parse(Console.ReadLine());

// if (age2 >= 18)
// {
//     Console.WriteLine("Вы совершеннолетний.");
// }
// else
// {
//     Console.WriteLine("Вы несовершеннолетний.");

//     int yearsLeft = 18 - age2;
//     Console.WriteLine($"До совершеннолетия осталось лет: {yearsLeft}");
// }

// Console.WriteLine();
// Console.Write("Введите возраст: ");
// int age3 = int.Parse(Console.ReadLine()!);

// if (age3 < 18)
// {
//     Console.WriteLine("Категория: Несовершеннолетний");
// }
// else if (age3 < 60)
// {
//     Console.WriteLine("Категория: Взрослый");
// }
// else
// {
//     Console.WriteLine("Категория: Пенсионер");
// }

Console.WriteLine();
int age = 16;
double height = 1.44;
bool hasAdult = false;

if ((age >= 14 && height >= 1.5) || (height < 1.5 && hasAdult))
{
    Console.WriteLine("Можно кататься");
}
else
{
    Console.WriteLine("Пока нельзя");
}
