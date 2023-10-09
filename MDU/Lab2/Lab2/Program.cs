using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;


#region variant 9
//Console.Write("Введiть назву велосипеда: ");
//string name = Console.ReadLine();
//Console.Write("Введiть вартість велосипеда: ");
//double cost = double.Parse(Console.ReadLine());
//Console.Write("Введiть вартість розстрочк: ");
//double installment = double.Parse(Console.ReadLine());
//Console.Write("Введiть діаметр коліс: ");
//double diameterWheels = double.Parse(Console.ReadLine());
//Console.Write("Введiть тип втулки: ");
//string sleeveStyle = Console.ReadLine();
//Console.Write("Введiть тип вилки: ");
//string plugType = Console.ReadLine();
//Console.Write("Введiть матеріал рами: ");
//string materialFrame = Console.ReadLine();
//Console.Write("Введiть тип гальмів: ");
//string typeBrakes = Console.ReadLine();
//Console.WriteLine();

//Bike Kinetic29Crystal2023 = new Bike();
//Kinetic29Crystal2023._name = name;
//Kinetic29Crystal2023._cost = cost;
//Kinetic29Crystal2023._installment = installment;
//Kinetic29Crystal2023._diameterWheels = diameterWheels;
//Kinetic29Crystal2023._sleeveStyle = sleeveStyle;
//Kinetic29Crystal2023._plugType = plugType;
//Kinetic29Crystal2023._materialFrame = materialFrame;
//Kinetic29Crystal2023._typeBrakes = typeBrakes;
//int numberMonths = Kinetic29Crystal2023.NumberPayments();
//Console.WriteLine();
//Console.WriteLine("------------------------------------------------");
//Console.WriteLine("Данi про об`ект: ");
//Console.WriteLine("------------------------------------------------");
//Console.WriteLine("Назва: " + Kinetic29Crystal2023._name);
//Console.WriteLine("Цінa: " + Kinetic29Crystal2023._cost.ToString("000.00 грн"));
//Console.WriteLine("Розстрочка: " + Kinetic29Crystal2023._installment.ToString("000.00 грн"));
//Console.WriteLine("Діаметр коліс: " +
//Kinetic29Crystal2023._diameterWheels.ToString("00") + "\"");
//Console.WriteLine("Тип втулки: " + Kinetic29Crystal2023._sleeveStyle);
//Console.WriteLine("Тип вилки: " + Kinetic29Crystal2023._plugType.ToString());
//Console.WriteLine("Матеріал рами:" + Kinetic29Crystal2023._materialFrame);
//Console.WriteLine("Тип гальмів:" + Kinetic29Crystal2023._typeBrakes);
//Console.WriteLine();
//Console.WriteLine("Кількість платжеів: " + numberMonths.ToString("0.00"));
//Console.ReadKey();

//class Bike
//{
//    public string _name { get; set; }
//    public double _cost { get; set; }
//    public double _installment { get; set; }
//    public double _diameterWheels { get; set; }
//    public string _sleeveStyle { get; set; }
//    public string _plugType { get; set; }
//    public string _materialFrame { get; set; }
//    public string _typeBrakes { get; set; }

//    public int NumberPayments()
//    {
//        return Convert.ToInt32(Math.Round(_cost / _installment));
//    }
//}
#endregion

Console.Write("Введiть назву планшету: ");
string name = Console.ReadLine();
Console.Write("Введiть вартість планшету: ");
double cost = double.Parse(Console.ReadLine());
Console.Write("Введiть вартість розстрочк: ");
double installment = double.Parse(Console.ReadLine());
Console.Write("Введiть розмір екрану: ");
double size = double.Parse(Console.ReadLine());
Console.Write("Введiть назву процесору: ");
string processor = Console.ReadLine();
Console.Write("Чи наявний FaceID (y-так, n-нi): ");
ConsoleKeyInfo faceID = Console.ReadKey();
Console.Write("\nВведiть параметри камери: ");
string camera = Console.ReadLine();
Console.Write("Введiть тип порту: ");
string connecteur = Console.ReadLine();
Console.WriteLine();

Tablet IPadPro = new Tablet();
IPadPro._name = name;
IPadPro._cost = cost;
IPadPro._installment = installment;
IPadPro._size = size;
IPadPro._processor = processor;
IPadPro._faceID = faceID.Key == ConsoleKey.Y ? true : false;
IPadPro._сamera = camera;
IPadPro._connecteur = connecteur;
int numberMonths = IPadPro.NumberPayments();
Console.WriteLine();
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Данi про об`ект: ");
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Назва: " + IPadPro._name);
Console.WriteLine("Цінa: " + IPadPro._cost.ToString("000.00 грн"));
Console.WriteLine("Розстрочка: " + IPadPro._installment.ToString("000.00 грн"));
Console.WriteLine("Діагональ: " +
IPadPro._size.ToString("00.0") + "\"");
Console.WriteLine("Процессор: " + IPadPro._processor);
Console.WriteLine("Камера: " + IPadPro._сamera);
Console.WriteLine("FaceID: " + (IPadPro._faceID ? "Присутнє":"Відсутне"));
Console.WriteLine("Тип порту: " + IPadPro._connecteur);
Console.WriteLine();
Console.WriteLine("Кількість платжеів: " + numberMonths.ToString("0.00 міс."));
Console.ReadKey();

class Tablet
{
    public string _name { get; set; }
    public double _cost { get; set; }
    public double _installment { get; set; }
    public double _size { get; set; }
    public string _processor { get; set; }
    public bool _faceID { get; set; }
    public string _сamera { get; set; }
    public string _connecteur { get; set; }

    public int NumberPayments()
    {
        if (_cost > 0 && _installment > 0 && _cost <= _installment)
            return Convert.ToInt32(Math.Round(_cost / _installment));
        else 
            return 0;
    }
}