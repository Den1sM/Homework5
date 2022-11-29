// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
 
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
int min = Int32.MaxValue;
int max = Int32.MinValue;

for (int x = 0; x < numbers.Length; x++)
{
    if (numbers[x] > max)
        {
            max = numbers[x];
        }
    if (numbers[x] < min)
        {
            min = numbers[x];
        }
}

Console.WriteLine("Всего " + numbers.Length + " чисел. Максимальное значение = " + max + " , минимальное значение = " + min);
Console.WriteLine("Разница между максимальным и минимальным значением = "+ (max - min));

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(new Random().Next(1,100));
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
    
