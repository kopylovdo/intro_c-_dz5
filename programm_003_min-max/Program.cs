// Программа, которая считает сумму четных элементов, стоящих на нечётных позициях (позиция - индекс элемента в массиве).

Console.Write("Введите длину массива N ");
int N = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[N];
Random rnd_number = new Random();
//задаем нулевой элемент массива
numbers[0] = rnd_number.Next(1,1000);
Console.Write($"{numbers[0]} ");
//задаем минимум и максимум
int array_max = numbers[0];
int array_min = numbers[0];

//заполняем оставшиеся элементы массива случайными числами
for (int index = 1; index < N; index++)
{
    numbers[index] = rnd_number.Next(1,1000);
    Console.Write($"{numbers[index]} ");
    // сравниваем текущий элемент массива с максимальным, и, если его значение больше макимального, присваиеваем его значение максимуму
    if (numbers[index] > array_max) 
    {
        array_max= numbers[index];
    }
    // сравниваем текущий элемент массива с минимальным, и, если его значение меньше минимального, присваиеваем его значение максимуму
    if (numbers[index] < array_min) 
    {
        array_min= numbers[index];
    }
}

//определяем разницу между максимальным и минимальным элементами массива
int different = array_max - array_min;

Console.WriteLine();
Console.WriteLine($"Разница между максимальным {array_max} и минимальным {array_min} элементами - {different}");