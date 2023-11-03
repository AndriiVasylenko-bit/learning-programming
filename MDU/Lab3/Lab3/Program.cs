using ClassLibrary1;
using System.Text;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Tablet[] arrTablet;
        Console.Write("Введiть кiлькiсть палншетів: ");
        int cntTablet = int.Parse(Console.ReadLine());
        Console.WriteLine();
        arrTablet = new Tablet[cntTablet];

        for (int i = 0; i < cntTablet; i++)
        {
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

            Tablet tablet = new Tablet();
            tablet._name = name;
            tablet._cost = cost;
            tablet._installment = installment;
            tablet._size = size;
            tablet._processor = processor;
            tablet._faceID = faceID.Key == ConsoleKey.Y ? true : false;
            tablet._сamera = camera;
            tablet._connecteur = connecteur;

            arrTablet[i] = tablet;
        }

        foreach (Tablet tablet in arrTablet)
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Данi про об`ект: ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Назва: " + tablet._name);
            Console.WriteLine("Цінa: " + tablet._cost.ToString("000.00 грн"));
            Console.WriteLine("Розстрочка: " + tablet._installment.ToString("000.00 грн"));
            Console.WriteLine("Діагональ: " + tablet._size.ToString("00.0") + "\"");
            Console.WriteLine("Процессор: " + tablet._processor);
            Console.WriteLine("Камера: " + tablet._сamera);
            Console.WriteLine("FaceID: " + (tablet._faceID ? "Присутнє" : "Відсутне"));
            Console.WriteLine("Тип порту: " + tablet._connecteur);
            Console.WriteLine();
            Console.WriteLine("Кількість платжеів: " + tablet.numberPayments.ToString("0.00 міс."));
        }

        Console.ReadLine();
    }
}