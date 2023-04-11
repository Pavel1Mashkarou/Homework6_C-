double Print(string arg)
{
    System.Console.WriteLine($"Введите {arg}");
    double Arg = int.Parse(Console.ReadLine());
    return Arg;
}

void PrintEquation(double K1, double B1, double K2, double B2)
{
    System.Console.WriteLine($"Первое уравнение: y={K1}x + ({B1})");
    System.Console.WriteLine($"Второе уравнение: y={K2}x + ({B2})");
}

void FindTheDot (double K1, double B1, double K2, double B2)
{
    double X = ((B2-B1)/(K1-K2));
    System.Console.WriteLine(X);
    double Y = K1*X + B1;
    System.Console.WriteLine($"Точка пересечения прямых с координатами ({X};{Y}).");
}


double K1 = Print("коэффициент k1: ");
double B1 = Print("коэффициент b1: ");

double K2 = Print("коэффициент k2: ");
double B2 = Print("коэффициент b2: ");

PrintEquation(K1,B1,K2,B2);
FindTheDot(K1,B1,K2,B2);
