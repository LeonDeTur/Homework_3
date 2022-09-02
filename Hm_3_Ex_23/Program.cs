// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// Ввод данных и проверка
Console.WriteLine("Введите число");
string? check = Console.ReadLine();
ValidateInput (check);
int num = Convert.ToInt32(check);
Console.WriteLine();
//Выполнение метода
Output (num);

//Методы
void ValidateInput (string input)
{
    bool IsNumber = int.TryParse(input, out int number);
    if (!IsNumber) 
    {
        Console.WriteLine("Error: Пожалуйста, введите целое число .");
        Environment.Exit(0);
    }
}

void Output (int input)
{
    for(int i = 1; i <= input; i++)
    {
        int output = i * i * i;
        Console.WriteLine($"Куб: {i}");
        Console.WriteLine(output);
        Console.WriteLine();
    }
}