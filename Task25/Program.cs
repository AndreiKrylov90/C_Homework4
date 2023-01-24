Console.WriteLine("Возводим число А в степень числа B");
Console.WriteLine("Введите число A");
if(!int.TryParse(Console.ReadLine(), out int A))
{
    Console.WriteLine("Введено нецелое число");
}
Console.WriteLine("Введите число B");
if(!int.TryParse(Console.ReadLine(), out int B ) || B < 1)
{
    Console.WriteLine("Введено нецелое или неположительное число");
    return; 
}
int HandMadePow (int A, int B)
{
int Pow = 1;
for (int i = 1; i <= B; i++)
{
Pow = Pow * A;
}
return Pow;
}
int result = HandMadePow(A, B);
Console.WriteLine($"{A} в степени {B} равно {result}");
