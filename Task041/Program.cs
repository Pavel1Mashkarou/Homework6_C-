int Print(string arg)
{
    System.Console.WriteLine($"Введите {arg}");
    int Arg = int.Parse(Console.ReadLine());
    return Arg;
}


int [] CreateArray(int Length)
{
    int [] Array = new int [Length];
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.WriteLine($"Введите элемент массива с индексом {i}: ");
        Array[i] = int.Parse(Console.ReadLine());
    }
    return Array;
}

void PrintArray(int [] Array)
{
    System.Console.Write("Полученный массив: [");
    for (int i = 0; i < Array.Length-1; i++)
    {
        System.Console.Write(Array[i]+";");
    }
    System.Console.WriteLine(Array[Array.Length-1]+"]");
}

void MoreThenNull (int[] Array)
{
    int Kol = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i]>0) Kol++;
    }
    System.Console.WriteLine($"Количество чисел больше 0 в массиве: {Kol}");;
}

int Len = Print("длину массива: ");
int [] Mas = CreateArray(Len);
PrintArray(Mas);
MoreThenNull(Mas);