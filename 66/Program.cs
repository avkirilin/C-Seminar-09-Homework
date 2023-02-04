//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30
Console.Clear();
Console.WriteLine("Введите значение переменной M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение переменной N");
int N = Convert.ToInt32(Console.ReadLine());
int minValue = 0; int maxValue = 0;
if (M <= N) 
{
    minValue = M; maxValue = N;
}
else 
{
    minValue = N; maxValue = M;
}
int ShowNaturalNumbers(int start, int end)
{
    if (start == end + 1) return 0;
    return start + ShowNaturalNumbers(start + 1, end);
}
Console.WriteLine($"Сумма значений в промежутке от {minValue} до {maxValue}, включая эти значения, равна: {ShowNaturalNumbers(minValue, maxValue)}");
