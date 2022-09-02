Console.WriteLine("Input number");
string? x = Console.ReadLine();

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


WriteResult(CheckPolindrom(x));
    
    