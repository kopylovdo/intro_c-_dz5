// Программа, которая покажет количество чётных чисел в массиве

Console.Write("Введите длину массива N ");
int N = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[N];
Random rnd_number = new Random();
int count_chet_num = 0;

//заполняем массив случайными числами
for (int index = 0; index < N; index++)
{
    numbers[index] = rnd_number.Next(1,1000);
    Console.Write($"{numbers[index]} ");
    // проверяем элемент на четность и увеличиваем счетчик четных чисел на единицу, если условие четности выполняется
    if (numbers[index] % 2 == 0) 
    {
        count_chet_num++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в заданном массиве - {count_chet_num}");