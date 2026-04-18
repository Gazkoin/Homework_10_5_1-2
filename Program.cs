using System;

namespace Homework_10_5_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILoger logger = new Logger();
            ICalculate calculate = new Calculate(logger);

            while (true)
            {
                try
                {
                    logger.Log(true);

                    Console.WriteLine("\nВведите х (0 для выхода):");
                    double x = double.Parse(Console.ReadLine().Trim());

                    if (x == 0) break;

                    Console.WriteLine("Введите y (0 для выхода):");
                    double y = double.Parse(Console.ReadLine().Trim());

                    calculate.Plus(x, y);
                }
                catch (Exception ex) { logger.Log(false); Console.WriteLine($"[LOG] {DateTime.Now}: {ex.Message}"); }
                finally { Console.ResetColor(); }
            }
        }
    }
}