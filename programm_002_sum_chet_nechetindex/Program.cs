// Программа, которая считает сумму четных элементов, стоящих на нечётных позициях (позиция - индекс элемента в массиве).

Console.Write("Введите длину массива N ");
int N = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[N];
Random rnd_number = new Random();
int summa_chet_num = 0;

//заполняем массив случайными числами
for (int index = 0; index < N; index++)
{
    numbers[index] = rnd_number.Next(1,1000);
    Console.Write($"{numbers[index]} ");
    // проверяем элемент на четность а индекс на нечетность и добавляем элемент массива, если оба условия выполняется
    if ((index % 2 == 1) & (numbers[index] % 2 == 0)) 
    {
        summa_chet_num += numbers[index];
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма четных элементов в на нечетных позициях - {summa_chet_num}");