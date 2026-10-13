int age = 22;

if (age >= 21)
{
    Console.WriteLine("Доступ разрешён.");
}

Console.WriteLine($"Программа продолжает работу");

Console.WriteLine();
Console.WriteLine("Введите ваш возраст: ");
int age2 = int.Parse(Console.ReadLine());

if (age2 >= 18)
{
    Console.WriteLine("Вы совершеннолетний.");
}
else
{
    Console.WriteLine("Вы несовершеннолетний.");

    int yearsLeft = 18 - age2;
    Console.WriteLine($"До совершеннолетия осталось лет: {yearsLeft}");
}
