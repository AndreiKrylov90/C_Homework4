Console.WriteLine("Ищем сумму чисел в числе");
Console.WriteLine("Введите число");
if(!int.TryParse(Console.ReadLine(), out int A))
{
    Console.WriteLine("Введено нецелое число");
    return;
}
A = Math.Abs(A);
int SumNumbers (int A)
{
    int result = 0;
    int currentNumber = 0;
    while (A > 0)
    {
        currentNumber = A % 10;
        A = A /10;
        result = result + currentNumber;
    }
    return result; 
}
int result = SumNumbers(A);
Console.WriteLine($"Сумма цифр в числе {A} равна {result}");

