using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10_5_1_2
{
    
    public interface CalcFunc
    {
        void Plus (double x, double y);
        void Log (bool k);
    }

    internal class Calculate
    {
        public void Plus (double x, double y)
        {
            Console.WriteLine($"{x}+{y}={x+y}");
        }
        public void Log(bool k)
        {
            if (k) Console.ForegroundColor = ConsoleColor.Blue;
            else Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
