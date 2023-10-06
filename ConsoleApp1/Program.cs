using Core;
using Service;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start a stop watch project.");
            IState state = new State();
            StopWatchState stopWatch = new StopWatchState();
            Console.WriteLine("Enter a command: initial state, start, lap");
            stopWatch.stopwatch = new();
            stopWatch.LapList = new();
            bool isStart = false;
            while (true)
            {                
                string input = Console.ReadLine();
                if(input.Equals("start",StringComparison.OrdinalIgnoreCase) || input.Equals("started", StringComparison.OrdinalIgnoreCase))
                {
                    state.StartTimer(stopWatch);
                    isStart = true;
                    Console.WriteLine("Current state: running state, stop, lap");
                }
                else if(input.Equals("stop",StringComparison.OrdinalIgnoreCase) || input.Equals("stoped", StringComparison.OrdinalIgnoreCase))
                {                    
                    state.StopTimer(stopWatch);
                    string times = state.TimerTick(stopWatch);
                    isStart = false;
                    Console.WriteLine($"Current state: {times}, start, lap");
                }
                else if(input.Equals("lap",StringComparison.OrdinalIgnoreCase))
                {
                    string times = state.TimerTick(stopWatch);
                    string count = isStart ? "stop" : "start";
                    Console.WriteLine($"Current state: {times}, {count}, lap");
                }
                else if(input.Equals("reset",StringComparison.OrdinalIgnoreCase) || input.Equals("restart", StringComparison.OrdinalIgnoreCase))
                {
                    state.ResetTimer(stopWatch);
                    string times = state.TimerTick(stopWatch);
                    isStart = false;
                    Console.WriteLine($"Current state: {times}, start, lap");
                }
                else if(input.Equals("q",StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }
            Console.WriteLine("Thanks for using stop watch.");
        }
    }
}