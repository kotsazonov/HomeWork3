// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int N = TakeUserNum();
PrintNumPowers(N);


void PrintNumPowers(int N)
{
    for(int i = 1; i <= N; i++)
    {
        if(i == 1)
            Console.Write(i);
        else
            Console.Write($", {Math.Pow(i, 3)}");
    }
}

int TakeUserNum()
{
    int userNum;

    while(!int.TryParse(Console.ReadLine(), out userNum))
    {
        Console.WriteLine("Пожалуйста введите число!");
    }

    return userNum;
}

