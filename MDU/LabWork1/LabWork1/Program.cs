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

double[] _arr = new double[10];
double _x = START_X;


double Function(double x)
{
    if (!double.IsNaN(x)) 
    {
        double x1 = 2.76 * x;
        double x2 = 0.5 * x;
        return Math.Log10(x1) / Math.Pow((0.6 * x1) * Math.Sin(x2) * Math.Pow(Math.Cos(x1), 4), 1 / 5);
    }
    return 0;
}

void R(double[] arr)
{
    double _min = arr[arr.GetUpperBound(0)];
    double _max = arr[arr.GetLowerBound(0)];
    double _avg = arr.Average();
    double _percentAvg = _avg * 10 / 100;
    double _sum = 0, _countAvg = 0, _countPercentAvg = 0;
    double _answer = 0;
    if (arr != null)
        for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
        {
            _sum += arr[i];
            _countAvg += _sum / (i + 1);
            _countPercentAvg = _countAvg * 10 / 100;
            _answer = _avg - _countPercentAvg + _percentAvg;
            Console.WriteLine("Середнє значення масиву: {0:0.0000}", _answer);
        }
    Console.WriteLine("Мiнiмальне значення масиву: {0:0.0000}", _min);
    Console.WriteLine("Максимальне значення масиву: {0:0.0000}", _max);
}

for (int i = _arr.GetLowerBound(0); i <= _arr.GetUpperBound(0); i++)
{
    _arr[i] = Function(_x);
    _x += D_X;
}

Array.Sort(_arr);
Array.Reverse(_arr);
Console.WriteLine("Вiдсортованi за спаданням значення масиву: ");

for (int i = _arr.GetLowerBound(0); i <= _arr.GetUpperBound(0); i++)
    Console.WriteLine("arr[{0:00}] = {1:0.0000}", i, _arr[i]);

R(_arr);

Console.ReadKey(true);
