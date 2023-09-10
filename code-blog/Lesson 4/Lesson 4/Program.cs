using System;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Int = 5;
            byte Byte = 255;
            double Double = 250;
            double DoubleFraction = 654.845;
            decimal Decimal = 249M;
            decimal DecimalFraction = 466.6363M;
            string StringFraction = "90,77";
            string StringNumber = "8";
            string StringSymbol = "f";
            string StringLogic = "true";
            char СharNumbers = '9';
            char СharLetter = 'a';
            bool Bool = false;
            


            //не явное приведение

            //int
            int a = Byte;
            //double
            double b = Int;
            double с0 = Byte;
            //decimal
            decimal c = Int;
            decimal d = Byte;


            //явное приведение

            //int
            int e = (int)Double; //можно но нежылатильно (не будет окркугление, но часть после точки исчезнет)
            int f = (int)Decimal; //можно но нежылатильно (не будет окркугление, но часть после точки исчезнет)
            //byte
            byte g = (byte)Int;
            byte h = (byte)Double;  //неможно использовать больше 255, и не целые числа (не будет округление, но чясть после точки исчезнет и цикл от 0 до 255 если чичло больше 255)
            byte i = (byte)Decimal;  //неможно использовать больше 255, и не целые числа (не будет округление, но чясть после точки исчезнет и цикл от 0 до 255 если чичло больше 255)
            //double
            double j = (double)DecimalFraction;
            //decimal
            decimal k = (decimal)DoubleFraction;
            //char
            char l = (char)Int;  //почему не выводит значение на консоль (выводит: пустату)?



            //не явное приобразование
            
            //int
            int m = Int + Byte;
            //double
            double n = DoubleFraction + Int;
            double o = DoubleFraction + Byte;
            //decimal
            decimal p = DecimalFraction + Int;
            decimal q = DecimalFraction + Byte;
            //string
            string r = StringSymbol + Int;
            string s = StringSymbol + Byte;
            string t = StringSymbol + DoubleFraction;
            string u = StringSymbol + DecimalFraction;
            string v = StringSymbol + СharNumbers;
            string w = StringSymbol + Bool;


            //явное приобраование

            //int
            int x = Convert.ToInt32(Double);  //можно но нежылатильно (будет окркугление)
            int v0 = Convert.ToInt32(Decimal);  //можно но нежылатильно (будет окркугление)
            int y = Convert.ToInt32(StringNumber);
            int z = Convert.ToInt32(СharNumbers);
            //dyte
            byte a1 = Convert.ToByte(Double);  //неможно использовать больше 255, и не целые числа(будет округление и цикл от 0 до 255 если чичло больше 255)
            byte b1 = Convert.ToByte(Decimal);
            byte c1 = Convert.ToByte(StringNumber);
            byte d1 = Convert.ToByte(СharNumbers);
            //double
            double e1 = Convert.ToDouble(StringFraction);
            //decimal
            decimal f1 = Convert.ToDecimal(StringFraction);
            decimal g1 = Convert.ToDecimal(StringNumber);
            //string
            string h1 = Convert.ToString(Int);
            string i1 = Convert.ToString(Byte);
            string j1 = Convert.ToString(DoubleFraction);
            string k1 = Convert.ToString(DoubleFraction);
            string l1 = Convert.ToString(СharLetter);
            string m1 = Convert.ToString(Bool);
            //char
            char n1 = Convert.ToChar(StringNumber);
            char o1 = Convert.ToChar(StringSymbol);
            //bool
            bool p1 = Convert.ToBoolean(StringLogic);

            //проверка ввода данных

            Console.WriteLine("Ведите true или false:");

            if (bool.TryParse(Console.ReadLine(), out bool result))
            {
                Console.WriteLine($"Вы ввели: {result}");
            }
            else
            {
                Console.WriteLine("Не коректно вели значение.");
            }
            Console.ReadKey();
        }
    }
}