using ClassLibrary1;
using System.Text;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Bike[] arrBike;
        Console.Write("Введiть кiлькiсть велосипедів: ");
        int cntBike = int.Parse(Console.ReadLine());
        arrBike = new Bike[cntBike];

        for (int i = 0; i < cntBike; i++)
        {
            Console.Write("Введiть назву велосипеда: ");
            string name = Console.ReadLine();
            Console.Write("Введiть вартість велосипеда: ");
            double cost = double.Parse(Console.ReadLine());
            Console.Write("Введiть вартість розстрочки: ");
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

            Bike bike = new Bike();
            bike._name = name;
            bike._cost = cost;
            bike._installment = installment;
            bike._diameterWheels = diameterWheels;
            bike._sleeveStyle = sleeveStyle;
            bike._plugType = plugType;
            bike._materialFrame = materialFrame;
            bike._typeBrakes = typeBrakes;

            arrBike[i] = bike;
        }

        foreach (Bike bike in arrBike)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Данi про об'єкт: ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Назва: " + bike._name);
            Console.WriteLine("Цінa: " + bike._cost.ToString("000.00 грн"));
            Console.WriteLine("Розстрочка: " + bike._installment.ToString("000.00 грн"));
            Console.WriteLine("Діаметр коліс: " +
            bike._diameterWheels.ToString("00") + "\"");
            Console.WriteLine("Тип втулки: " + bike._sleeveStyle);
            Console.WriteLine("Тип вилки: " + bike._plugType.ToString());
            Console.WriteLine("Матеріал рами:" + bike._materialFrame);
            Console.WriteLine("Тип гальмів:" + bike._typeBrakes);
            Console.WriteLine();
            Console.WriteLine("Кількість платежів: " + bike.numberPayments.ToString("0.00"));
        }

        Console.ReadLine();
    }
}