using Core;

namespace Service
{
    public class State : IState
    {
        public State() { }
        public string TimerTick(StopWatchState stopWatch)
        {
            TimeSpan elapsed = stopWatch.stopwatch.Elapsed;
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}:{3:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds);
            stopWatch.Lap = elapsedTime;
            AddLapTimer(stopWatch);
            return elapsedTime;
        }
        public void ResetTimer(StopWatchState stopWatch)
        {
            stopWatch.stopwatch.Reset();
            stopWatch.Lap = "00:00:00:000";
            stopWatch.LapList.Clear();
        }
        public void StartTimer(StopWatchState stopWatch)
        {
            stopWatch.stopwatch.Start();
            //stopWatch.StopWatchTimer.Start();
        }
        public void StopTimer(StopWatchState stopWatch)
        {            
            stopWatch.stopwatch.Stop();
            TimerTick(stopWatch);
        }
        public void AddLapTimer(StopWatchState stopWatch)
        {
            stopWatch.LapList.Add(stopWatch.Lap);
        }
    }
}