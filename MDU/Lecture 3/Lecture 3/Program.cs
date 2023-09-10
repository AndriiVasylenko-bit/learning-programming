//Attempted to divide by zero
//int x = 3, y = 0;
//x = x / y;



int x = 3, y = 0;
try
{ // Start handling exceptions.
    x = x / y; // An exceptional situation arises here.
}
catch
{ // Code for handling exceptions.
    Console.WriteLine("Обробляємо виняток...");
}
Console.WriteLine("I продовжуємо роботу...\n");



try
{
    x /= y;
}
catch (DivideByZeroException)
{
    Console.WriteLine("Була спроба дiлення на нуль!");
}
Console.WriteLine("Але продовжуємо роботу...\n");



try
{
    x /= y;
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Стався виняток з описом:");
    Console.WriteLine("Message: {0}", e.Message);
    Console.WriteLine("StackTrace: {0}", e.StackTrace);
    Console.WriteLine("InnerException: ", e.InnerException);
    Console.WriteLine("HelpLink: ", e.HelpLink);
    Console.WriteLine("Source: {0}", e.Source);
}
Console.WriteLine();
Console.WriteLine("Але продовжуємо роботу...\n");



try
{
    try
    {
        x /= y; // An exceptional situation arises here.
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("Вихід за межі діапазону!");
    }
    finally
    {
        Console.WriteLine("Внутрiшнiй блок finally");
    }
}
catch (DivideByZeroException)
{
    Console.WriteLine("Дiлення на нуль!");
}
Console.WriteLine();
Console.WriteLine("I продовжуємо роботу...\n");



    int z = 0;
try
{
    if (y == 0) throw new DivideByZeroException("y == 0!");
    if (z == 0) throw new DivideByZeroException("z == 0!");
    x = (x / y + 100) / z;
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Помилка: {0}", e.Message);
}
Console.WriteLine("Але продовжуємо роботу...\n");

try
{
    string Name = "a";
    if ((Name == null) || (Name.Length < 2))
        throw new InvNameException("Неправильна назва!");
    Console.WriteLine("Назва: {0}", Name);
}
catch (InvNameException e)
{
    Console.WriteLine("Помилка: {0}", e.Message);
}
Console.WriteLine("Але продовжуємо роботу...");

class InvNameException : Exception
{
    public InvNameException(string message) : base(message)
    {
    }
}

