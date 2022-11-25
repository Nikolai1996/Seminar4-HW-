// Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.

// 3, 5 -> 243
// 2, 4 -> 16


Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int ExpNum(int numA, int numB)
{
    {
        int exp = 1;
        for (int i = 1; i <= numB; i++)
        {
            exp = exp * numA;

        }
        return exp;
    }
}

int expNum = ExpNum(numberA, numberB);
Console.WriteLine($"Ответ: {expNum}");
