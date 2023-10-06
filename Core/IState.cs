using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public partial interface IState
    {
        string TimerTick(StopWatchState stopWatch);
        void ResetTimer(StopWatchState stopWatch);
        void StartTimer(StopWatchState stopWatch);
        void StopTimer(StopWatchState stopWatch);
        void AddLapTimer(StopWatchState stopWatch);
    }
}
