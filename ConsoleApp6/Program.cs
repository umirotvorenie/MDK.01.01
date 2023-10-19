namespace ConsoleApp6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Запуск программы...");
            double x, y, z, a, b;
            while (true)
            {
                try
                {
                    Console.Write("Введите x: ");
                    x = double.Parse(Console.ReadLine());
                    Console.Write("Введите y: ");
                    y = double.Parse(Console.ReadLine());
                    Console.Write("Введите z: ");
                    z = double.Parse(Console.ReadLine());
                    a = x * z;
                    b = y * (z - 0.5);
                    if (a < b)
                    {
                        Console.WriteLine("Второй автомобиль обгонит первый");
                    }
                    else
                    {
                        Console.WriteLine("Второй автомобиль не обногит первый");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}