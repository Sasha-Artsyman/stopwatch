using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("------ Stopwatch ------");
        Console.WriteLine("(Enter) to start/finish");

        Console.ReadLine();
        
        TimerCallback timeS = new TimerCallback(PrintTime);

        DateTime time0 = DateTime.Now;

        Timer t = new Timer(
        timeS, // объект делегата TimerCallback
        time0, // информация для передачи в вызванный метод
        0,     // период ожидания перед запуском (в миллисекундах)
        20); // интервал между вызовами (в миллисекундах)

        Console.ReadLine();
    }

    static void PrintTime(object state)
    {
        Console.WriteLine($"Time is: {DateTime.Now.Subtract(Convert.ToDateTime(state.ToString())):t}");
    }
}
