using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace Client.SDK
{ 
     public class TimeUtil
     {
        public static int currentTick = 0;
        public static void Reset()
        {
            currentTick = 0;
        }

        public static void Tick()
        {
            currentTick++;
        }
        public static bool timerHasReached(int value, bool reset)
        {
            if (currentTick >= value)
            {
                if (reset)
                {
                    Reset();
                }
                return true;
            }
            else
            {
                Tick();
                return false;
            }
        }
    }   
}
