// int[] points = { 10, 20, 5, 15, 30, 8 };

// int sum = 0;

// foreach (int point in points)
// {
//     sum += point;
// }

// Console.WriteLine($"Общая сумма баллов: {sum}");

// int[] points = { 60, 80, 90, 70, 100 };

// int sum = 0;

// foreach (int point in points)
// {
//     sum += point;
// }

// double average = (double)sum / points.Length;

// Console.WriteLine($"Сумма: {sum}");
// Console.WriteLine($"Количество: {points.Length}");
// Console.WriteLine($"Среднее значение: {average:F2}");

// int[] temperatures = { 18, 7, 23, 4, 15, 9 };

// int min = temperatures[0];
// int max = temperatures[0];

// for (int i = 1; i < temperatures.Length; i++)
// {
//     if (temperatures[i] < min)
//     {
//         min = temperatures[i];
//     }

//     if (temperatures[i] > max)
//     {
//         max = temperatures[i];
//     }
// }
// Console.WriteLine($"Минимум: {min}");
// Console.WriteLine($"Максимум: {max}");

Console.Write("Введите фамилию и имя: ");
string fullName = (Console.ReadLine() ?? "").Trim();

if (string.IsNullOrWhiteSpace(fullName))
{
    Console.WriteLine("ФИО не введено.");
    return;
}

int total = 0;

foreach (char symbol in fullName)
{
    total += symbol;
}

int variant = total % 8 + 1;

Console.WriteLine($"Ваш вариант: №{variant}");


int[] numbers = { 4, 9, 12, 7, 15, 8, 21, 5 };
int sum = numbers.Where(n => n % 3 == 0).Sum();
Console.WriteLine(sum);
