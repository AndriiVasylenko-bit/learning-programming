using System;
using System.IO;
using System.Text;


namespace Lesson_16
{
    class Program
    {
        string userName;
        string userPassword;
        string entrance;
        string saveName;
        string savePassword;
        bool flag;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Program program = new Program();
            program.LoginProcess();
        }


        void LoginProcess()
        {
            Console.WriteLine("Регистрация пользователя (введите: р)");
            Console.WriteLine("Вход в систему (введите: в)");
            do
            {
                Console.Write("ввод: ");
                entrance = Console.ReadLine();
                if (entrance == "р")
                {
                    SingUp(); 
                    flag = false;
                }
                else if (entrance == "в")
                {
                    SingIn();
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Ведено не правильное значение");
                    flag = true;
                }
            }
            while (flag);     
        }



        void SingUp()
        {
            using (var sw = new StreamWriter(@"C:\Users\livek\Desktop", true, Encoding.UTF8))
            {
                Console.Write("\nПридумайте свой никнейм: ");
                sw.WriteLine(Console.ReadLine());
                Console.Write("Придумайте свой пароль: ");
                sw.WriteLine(Console.ReadLine());
            }
            SingIn();
        }

        void SingIn()
        {
            using (var sw = new StreamWriter(@"C:\Users\livek\Desktop", true, Encoding.UTF8))
            {
                Console.Write("\nВведите свой никнейм: ");
                userName = Console.ReadLine();
                Console.Write("Введите свой пароль: ");
                userPassword = Console.ReadLine();
            }
            UserVerification();
        }

        void UserVerification()
        {

            using (var sr = new StreamReader(@"C:\Users\livek\Desktop", Encoding.UTF8))
            {
                sr.DiscardBufferedData();
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                while (!sr.EndOfStream)
                {
                    saveName = sr.ReadLine();
                    savePassword = sr.ReadLine();
                    if (userName == saveName && userPassword == savePassword)
                    {
                        Console.WriteLine("\nПоздравляю вход успешно выполнен!!!");
                    }
                }
            }
        }
    }
}
