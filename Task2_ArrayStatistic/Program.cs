# region Задание 2
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Требуется: 
//Создать массив размерностью N элементов, заполнить его произвольными целыми значениями. 
//Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов,
//среднее арифметическое всех элементов, вывести все нечетные значения.
#endregion

/// <summary>
/// Creates array of random values
/// </summary>
/// <return> int[] array of random values</return>
static int[] GetArray()
{
    int sizeArray;

    {
        Console.Write("Please, insert size of the array:");
        sizeArray = Convert.ToInt32(Console.ReadLine());
    }

    int[] array = new int[sizeArray];

    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 100);
    }

    return array;
}

/// <summary>
/// Shows elements of the array
/// </summary>
static void ShowArray(int[] array)
{
    Console.Write("Array = {");

    foreach (int item in array)
    {
        Console.Write("{0}, ", item);
    }

    Console.Write("}\n");
}

/// <summary>
/// Shows odd elements of the array
/// </summary>
static void ShowOddNumbers(int[] array)
{
    Console.Write("\nOdd Numbers = {");

    foreach (int item in array)
    {
        if (item % 2 != 0)
        {
            Console.Write("{0}, ", item);
        }
    }

    Console.Write("}\n");
}

/// <summary>
/// Shows the array statistic: Max, Min, Average, Sum, Odd Numbers.
/// </summary>
static void ShowArrayStatistic(int[] array)
{
    // Using a class method public static class Enumerable
    // interface IEnumerable.
    int maxValue = array.Max();

    int maxIndex = array.ToList().IndexOf(maxValue);

    Console.WriteLine("Max = {0}  Position = {1}", maxValue, maxIndex);

    // Using a class method public static class Enumerable
    // interface IEnumerable.
    int minValue = array.Min();

    int minIndex = array.ToList().IndexOf(minValue);

    Console.WriteLine("Min = {0}  Position = {1}", minValue, minIndex);

    // Using a class method public static class Enumerable
    // interface IEnumerable.
    double avgValue = array.Average();

    Console.WriteLine("Avg = {0:F2}", avgValue);

    // Using a class method public static class Enumerable
    // interface IEnumerable.
    int sumValue = array.Sum();

    Console.Write("Sum = {0}", sumValue);

    ShowOddNumbers(array);
}


int[] array = GetArray();

ShowArray(array);

ShowArrayStatistic(array);


// Delay.
Console.ReadLine();