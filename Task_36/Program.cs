// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
int sum = 0;

for (int i = 0; i < numbers.Length; i+=2)
sum = sum + numbers[i];

    Console.WriteLine("Количество чисел, " + numbers.Length + " сумма элементов, cтоящих на нечётных позициях = "+ sum);

void FillArrayRandomNumbers(int[] numbers)
{
    for(int x = 0; x < numbers.Length; x++)
        {
            numbers[x] = new Random().Next(1,100);
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