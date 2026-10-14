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

// Console.WriteLine();
// int age = 16;
// double height = 1.44;
// bool hasAdult = true;

// if ((age >= 14 && height >= 1.5) || (height < 1.5 && hasAdult))
// {
//     Console.WriteLine("Можно кататься");
// }
// else
// {
//     Console.WriteLine("Пока нельзя");
// }

// Console.Write("Введите номер дня недели (1-7): ");
// int day = int.Parse(Console.ReadLine());

// switch (day)
// {
//     case 1:
//         Console.WriteLine("Понедельник");
//         break;

//     case 2:
//         Console.WriteLine("Вторник");
//         break;

//     case 3:
//         Console.WriteLine("Среда");
//         break;

//     case 4:
//         Console.WriteLine("Четверг");
//         break;

//     case 5:
//         Console.WriteLine("Пятница");
//         break;

//     case 6:
//         Console.WriteLine("Суббота");
//         break;

//     case 7:
//         Console.WriteLine("Воскресенье");
//         break;

//     default:
//         Console.WriteLine("Неверный номер дня недели.");
//         break;
// }

// Console.WriteLine();
// Console.Write("Введите целое число: ");
// int numberA = int.Parse(Console.ReadLine());

// if (numberA % 2 == 0)
// {
//     Console.WriteLine("Число чётное.");
// }
// else
// {
//     Console.WriteLine("Число нечётное.");
// }

// Console.WriteLine();
// Console.Write("Введите оценку от 2 до 5: ");
// int grade = int.Parse(Console.ReadLine());

// switch (grade)
// {
//     case 5:
//         Console.WriteLine("Отлично");
//         break;

//     case 4:
//         Console.WriteLine("Хорошо");
//         break;

//     case 3:
//         Console.WriteLine("Удовлетворительно");
//         break;

//     case 2:
//         Console.WriteLine("Неудовлетворительно");
//         break;

//     default:
//         Console.WriteLine("Неверная оценка");
//         break;
// }

// Console.WriteLine();
// Console.Write("Введите возраст пользователя: ");
// int accessAge = int.Parse(Console.ReadLine()!);

// if (accessAge >= 18)
// {
//     Console.WriteLine("Доступ разрешён");
// }
// else
// {
//     Console.WriteLine("Доступ запрещён");
// }

// Console.Write("Введите первую сторону треугольника: ");
// double a = double.Parse(Console.ReadLine());

// Console.Write("Введите вторую сторону треугольника: ");
// double b = double.Parse(Console.ReadLine());

// Console.Write("Введите третью сторону треугольника: ");
// double c = double.Parse(Console.ReadLine());

// if (a + b > c && a + c > b && b + c > a)
// {
//     if (a == b && b == c)
//     {
//         Console.WriteLine("Треугольник равносторонний");
//     }
//     else if (a == b || a == c || b == c)
//     {
//         Console.WriteLine("Треугольник равнобедренный");
//     }
//     else
//     {
//         Console.WriteLine("Треугольник разносторонний");
//     }
// }
// else
// {
//     Console.WriteLine("Треугольник не существует");
// }
