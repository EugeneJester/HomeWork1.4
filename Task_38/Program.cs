//Задача 38: Задайте массив вещественных(дробных) чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.1 7.23, 22.57, 2.45, 78.78] -> 76.33

void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100*100, 100*100)/100.0;
}

Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
double min = 0;
double max = 0;
foreach (double i in array)  // Поиск максимального и минимального значения
{
    if (min > i) min = i;
    if (max < i) max = i;
}
double result = max - min;
Console.WriteLine($"Разница между максимальной и минимальным элементом массива: [{string.Join("; ", array)}] -> {Math.Round(result, 2)} ");
