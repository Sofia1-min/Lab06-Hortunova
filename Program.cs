//Шаг 1 1.1
/*for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
}*/
// 1.2
/*for (int i = 2; i <= 50; i+=2)
{
    Console.WriteLine(i);
}*/
// Шаг 2
/*int sum = 0;
for (int i = 1; i <= 10; i++)
{
    sum += i;
}
Console.WriteLine($"Сумма: {sum}");
int count = 0;
for (int i = 1; i <= 20; i++)
{
    if (i % 5 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Чисел кратных 5: {count}");*/
// Задание 2
/*int sum = 0;
for (int i = 1; i <= 100; i++)
{if (i % 3 == 0)
    {
        sum += i;
    }
}
Console.WriteLine($"Сумма: {sum}");
int count = 0;
for (int i = 1; i <= 100; i++)
{
    if (i % 7 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Чисел кратных 7: {count}");*/
// Шаг 3
/*int number = Convert.ToInt32(Console.ReadLine());
int total = 0;
while (number != 0)
{
    total += number;
    number = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Сумма: {total}");*/
// Задание 3
/*int number = Convert.ToInt32(Console.ReadLine());
int total = 0;
int a = 0;
while (number != 0)
{if (number < 0)
    {
        total ++;
    }
 else if (number > 0)
    {
        a ++;
    }
    
    number = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Количество отрицательных: {total}.Количество положительных: {a}");*/
// Шаг 4
/*string password;
do
{
    Console.Write("Введите пароль: ");
    password = Console.ReadLine();
}
while (password != "qwerty");
Console.WriteLine("Доступ разрешен");*/
//Задание 4
/*string password;

for (int i = 1; i <=3; i++)
{
   Console.Write("Введите пароль: ");
    password = Console.ReadLine();
    if (password != "qwerty" && i == 3)
    {
        Console.Write("Доступ заблокирован");
    }
    else if (password == "qwerty")
    {
        Console.WriteLine("Пароль верный");
        Console.WriteLine("Доступ разрешён");
        break;
    }
    else if (password != "qwerty")
    {
        Console.WriteLine("Неверный пароль");
    }
}*/
// Задание 5

/*int b;
Console.Write("Введите число( от 1 до 9): ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <=10; i++)
{ b = number * i;
    Console.WriteLine($"{number} * {i} = {b}");
}*/
//Задание 6
/*for (int i = 1; i <=30; i++)
{
    if (i % 3 == 0) continue;
    if (i % 10 == 0 && i > 20) break;
    Console.WriteLine(i);
}*/
// Итоговая задача. «Угадай число»
/*int a = 42;

for (int i = 1; i <= 5; i++)
{
    Console.Write("Введите число: ");
    int b = int.Parse(Console.ReadLine());

    if (b == a)
    {
        Console.WriteLine($"Победа! Попыток: {i}");
        break;
    }
    else if (b < a)
    {
        Console.WriteLine("Больше");
    }
    else
    {
        Console.WriteLine("Меньше");
    }
}*/
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

int sum = 0;
int count = 0;

while (a > 0)
{
    int b = a % 10;
    sum = sum + b;
    count++;
    a = a / 10;
}

Console.WriteLine($"Сумма цифр: {sum}");
Console.WriteLine($"Количество цифр: {count}");