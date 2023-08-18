// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите пожалуйста три числа для сравнения");

int a = TakeUserNum();
int b = TakeUserNum();
int c = TakeUserNum();
int max = NumComparison(a, b, c);

Console.WriteLine($"{a}, {b}, {c} -> {max}");

int TakeUserNum()
{
    int userNum;

    while(!int.TryParse(Console.ReadLine(), out userNum))
    {
        Console.WriteLine("Пожалуйста введите число!");
    }

    return userNum;
}

int NumComparison(int a, int b, int c)
{
    int max = a;

    if(max < b) max = b;
    if(max < c) max = c;

    return max;
}
