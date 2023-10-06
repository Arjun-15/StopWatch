using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class StopWatchState
    {
        public System.Diagnostics.Stopwatch stopwatch { get; set; }
        public Timer StopWatchTimer { get; set; } // states of stop watch start and stop working of watch.
        public List<string> LapList { get; set; }
        public string Lap { get; set; } // states of lap of stop watch and restart as well.
    }
}
