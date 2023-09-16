using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;



Console.Write("Введiть назву велосипеда: ");
string name = Console.ReadLine();
Console.Write("Введiть вартість велосипеда: ");
double cost = double.Parse(Console.ReadLine());
Console.Write("Введiть вартість розстрочк: ");
double installment = double.Parse(Console.ReadLine());
Console.Write("Введiть діаметр коліс: ");
double diameterWheels = double.Parse(Console.ReadLine());
Console.Write("Введiть тип втулки: ");
string sleeveStyle = Console.ReadLine();
Console.Write("Введiть тип вилки: ");
string plugType = Console.ReadLine();
Console.Write("Введiть матеріал рами: ");
string materialFrame = Console.ReadLine();
Console.Write("Введiть тип гальмів: ");
string typeBrakes = Console.ReadLine();
Console.WriteLine();

Bike Kinetic29Crystal2023 = new Bike();
Kinetic29Crystal2023._name = name;
Kinetic29Crystal2023._cost = cost;
Kinetic29Crystal2023._installment = installment;
Kinetic29Crystal2023._diameterWheels = diameterWheels;
Kinetic29Crystal2023._sleeveStyle = sleeveStyle;
Kinetic29Crystal2023._plugType = plugType;
Kinetic29Crystal2023._materialFrame = materialFrame;
Kinetic29Crystal2023._typeBrakes = typeBrakes;
int numberMonths = Kinetic29Crystal2023.NumberPayments();
Console.WriteLine();
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Данi про об`ект: ");
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Назва: " + Kinetic29Crystal2023._name);
Console.WriteLine("Цінa: " + Kinetic29Crystal2023._cost.ToString("000.00 грн"));
Console.WriteLine("Розстрочка: " + Kinetic29Crystal2023._installment.ToString("000.00 грн"));
Console.WriteLine("Діаметр коліс: " +
Kinetic29Crystal2023._diameterWheels.ToString("00") + "\"");
Console.WriteLine("Тип втулки: " + Kinetic29Crystal2023._sleeveStyle);
Console.WriteLine("Тип вилки: " + Kinetic29Crystal2023._plugType.ToString());
Console.WriteLine("Матеріал рами:" + Kinetic29Crystal2023._materialFrame);
Console.WriteLine("Тип гальмів:" + Kinetic29Crystal2023._typeBrakes);
Console.WriteLine();
Console.WriteLine("Кількість платжеів: " + numberMonths.ToString("0.00"));
Console.ReadKey();

class Bike
{
    public string _name { get; set; }
    public double _cost { get; set; }
    public double _installment { get; set; }
    public double _diameterWheels { get; set; }
    public string _sleeveStyle { get; set; }
    public string _plugType { get; set; }
    public string _materialFrame { get; set; }
    public string _typeBrakes { get; set; }

    public int NumberPayments()
    {
        return Convert.ToInt32(Math.Round(_cost / _installment));
    }
}