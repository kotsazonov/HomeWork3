// Напишите программу, которая принимает на вход пятизначное число и
//  проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPalindrome(number))
        {
            Console.WriteLine("Да, число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Нет, число не является палиндромом.");
        }
    

    static bool IsPalindrome(int number)
    {
        string numberString = number.ToString();

        int left = 0;
        int right = numberString.Length - 1;

        while (left < right)
        {
            if (numberString[left] != numberString[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
