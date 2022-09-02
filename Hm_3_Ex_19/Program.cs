// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Ввод данных
Console.WriteLine("Input number");
string? x = Console.ReadLine();

// Выполнение методов
WriteResult(CheckPolindrom(x));

//Методы
void WriteResult (bool Result)
{
    if (Result != true)
    {
        Console.WriteLine("Не является полендромом");
    }
    else
    {
        Console.WriteLine("Является полендромом");
    } 
}

bool CheckPolindrom (string input)
{
    int index = input.Length - 1;
    for (int i = 0; i < input.Length; i++)
    {
        bool check = input[i] == input[index];
        index--;
        if (check == false)
        {
            return check;
        }
    }
    return true;  
}

    
    