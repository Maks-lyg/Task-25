Console.Clear();
Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine());
Console.WriteLine($"{A} в степени {B} = {PowMetd(B)}");

int PowMetd(int B)
{
    int power = 1;
    for (int i = 0; i < B; i++)
    {
        power *= A;
    }
    return power;
}