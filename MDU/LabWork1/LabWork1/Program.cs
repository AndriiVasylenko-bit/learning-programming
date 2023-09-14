#region Integral
//double Function(double x)
//{
//    return x * x;
//}

//Integral();

//void Integral()
//{
//    Console.Write("Введiть початок вiдрiзку iнтегрування a: ");
//    string sa = Console.ReadLine();
//    double a = double.Parse(sa);
//    Console.Write("Введiть кiнець вiдрiзку iнтегрування b: ");
//    string sb = Console.ReadLine();
//    double b = double.Parse(sb);
//    Console.Write("Введiть кiлькiсть дiлянок n: ");
//    string sn = Console.ReadLine();
//    double n = double.Parse(sn);
//    double dx = (b - a) / n;
//    double y1, y2;
//    double x1, x2;
//    double Intgrl = 0;
//    for (int i = 0; i < n; i++)
//    {
//        x1 = a + i * dx;
//        x2 = x1 + dx;
//        y1 = Function(x1);
//        y2 = Function(x2);
//        // Обчислення інтегралу методом центральних прямокутників
//        Intgrl += (y1 + y2) / 2 * dx;
//    }
//    Console.WriteLine(
//"Iнтеграл функцiї на вiдрiзку [{0}, {1}] становить {2:0.0000}", a, b,
//Intgrl);
//    Console.Write("Повторити розрахунок (y - так) ? ");
//    ConsoleKeyInfo pressedKey = Console.ReadKey();
//    Console.WriteLine();
//    if (pressedKey.Key == ConsoleKey.Y)
//    {
//        Console.WriteLine();
//        Integral();
//    }
//}
#endregion 



const double START_X = 10.3;
const double D_X = 0.7;


double founction(double x)
{
    double x1 = 2.76 * x;
    double x2 = 0.5 * x;
    return Math.Log10(x1)/Math.Pow((0.6 * x1) * Math.Sin(x2) * Math.PowMath.Cos(x1),1/5);
}

double[] _arr = new double[10];
double _x = START_X;

for (int i = _arr.GetLowerBound(0); i <= _arr.GetUpperBound(0); i++)
{


    _x += D_X;
}

Array.Sort(_arr);
Array.Reverse(_arr);
Console.WriteLine("Вiдсортованi за спаданням значення масиву: ");

for (int i = _arr.GetLowerBound(0); i <= _arr.GetUpperBound(0); i++)
    Console.WriteLine("arr[{0:00}] = {1:0.0000}", i, _arr[i]);


double aMin = _arr[_arr.GetUpperBound(0)];
double aMax = _arr[_arr.GetLowerBound(0)];
double aAvg = _arr.Length / _arr.GetUpperBound(0);

Console.WriteLine("Мiнiмальне значення масиву: {0:0.0000}", aMin);
Console.WriteLine("Максимальне значення масиву: {0:0.0000}", aMax);
Console.WriteLine("Середнє значення масиву: {0:0.0000}", aAvg);
Console.ReadKey(true);
