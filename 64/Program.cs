//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.WriteLine("Введите любое целое значение переменной N, которе будет больше, либо равно 1");
int N = Convert.ToInt32(Console.ReadLine());
    if (N > 0)
    {
string ShowNaturalNumbers(int number)
{
    if (number == 0) return string.Empty;
    return $"{number} " + ShowNaturalNumbers(number - 1);
}
Console.WriteLine($"Натуральные числа от {N} до 1 включительно: {ShowNaturalNumbers(N)}");
    }
    else
    {
        Console.WriteLine("Ошибка! Введите любое целое положительное значение переменной N");        
    }

