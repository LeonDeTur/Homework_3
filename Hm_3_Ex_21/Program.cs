// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Ввод данных с проверкой
Console.WriteLine("Введите координаты первой точки:");

Console.WriteLine("Введите X");
string? x = Console.ReadLine();
ValidateInput (x);
int x1 = Convert.ToInt32(x);

Console.WriteLine("Введите Y");
x = Console.ReadLine();
ValidateInput (x);
int y1 = Convert.ToInt32(x);

Console.WriteLine("Введите Z");
x = Console.ReadLine();
ValidateInput (x);
int z1 = Convert.ToInt32(x);


Console.WriteLine("Введите координаты второй точки:");
Console.WriteLine("Введите X");
x = Console.ReadLine();
ValidateInput (x);
int x2 = Convert.ToInt32(x);

Console.WriteLine("Введите Y");
x = Console.ReadLine();
ValidateInput (x);
int y2 = Convert.ToInt32(x);

Console.WriteLine("Введите Z");
x = Console.ReadLine();
ValidateInput (x);
int z2 = Convert.ToInt32(x);

// Выполнение методов программы
int[] Pos1 = Position(x1, y1, z1);
int[] Pos2 = Position(x2, y2, z2);
Console.WriteLine("Расстояние между точками:");
Console.WriteLine(GetDistanse(Pos1, Pos2));

// Методы
void ValidateInput (string input)
{
    bool IsNumber = int.TryParse(input, out int number);
    if (!IsNumber) 
    {
        Console.WriteLine("Error: Пожалуйста, введите целое число для каждой из координат.");
        Environment.Exit(0);
    }
}

int[] Position (int axisX,int axisY,int axisZ)
{
    int[] pos = new int[3];
    pos [0] = axisX;
    pos [1] = axisY;
    pos [2] = axisZ;
    return pos;
}

double GetDistanse(int[] Position1, int[] Position2)
{
    double result = Math.Sqrt((Position2[0] - Position1[0])*(Position2[0] - Position1[0]) + ((Position2[1] - Position1[1]))*(Position2[1] - Position1[1]) + ((Position2[2] - Position1[2])*(Position2[2] - Position1[2])));
    return result;
}
