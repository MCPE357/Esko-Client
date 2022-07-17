using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Modules
{
    public class BounceGlide
    {
        public static string Name = "BounceGlide";
        public static System.Windows.Forms.Keys key = System.Windows.Forms.Keys.V;
        public static bool toggeld;

        public static bool isPressed;

        public static void Toggle()
        {
            toggeld = !toggeld;

            if (toggeld)
            {
                onEnable();
            }
            else
            {
                onDisable();
            }
        }

        public static void onEnable()
        {

        }
        public static void onDisable()
        {

        }
        public static void onTick()
        {
            if(SDK.TimeUtil.timerHasReached(40, true))
            {
                SDK.Entity.LocalPlayer.Jump();
            }
        }
    }
}
