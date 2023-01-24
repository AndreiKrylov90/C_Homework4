Console.WriteLine("Введите числа, мы их оформим в массив");
void FillArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine("Введите число");
        if(!int.TryParse(Console.ReadLine(), out int A))
        {
            Console.WriteLine("Введено нецелое число");
            return;
        }
        array[i] = A;
    }
}
int[] array = new int[8];
FillArray(array);
void PrintArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.WriteLine("Внимание, ваш массив:");
PrintArray(array);

