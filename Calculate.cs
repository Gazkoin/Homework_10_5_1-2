using System;

namespace Homework_10_5_1_2
{
    // ==================== ИНТЕРФЕЙСЫ ====================
    public interface ICalculate
    {
        void Plus (double x, double y);   
    }

    public interface ILoger
    {
        void Log (bool isEvent); // isEvent = true - событие (синий), false - ошибка (красный)
    }

    // ==================== РЕАЛИЗАЦИИ ====================
    internal class Calculate : ICalculate
    {
        private readonly ILoger _logger;   

        public Calculate(ILoger logger)
        {
            _logger = logger;
        }

        public void Plus (double x, double y)
        {
            _logger.Log(true);
            Console.WriteLine($"{x}+{y}={x+y}");
        }
        
    }

    internal class Logger : ILoger
    {
        public void Log(bool isEvent)
        {
            Console.ForegroundColor = isEvent ? ConsoleColor.Blue : ConsoleColor.Red;
        }

    }

}
