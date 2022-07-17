using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Modules
{
    public class Step
    {
        public static string Name = "Step";
        public static Keys Key;
        public static bool toggeld;

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
           SDK.Entity.LocalPlayer.stepHeight = 2f;
        }
        public static void onDisable()
        {
            SDK.Entity.LocalPlayer.stepHeight = 0.56f;
        }
        public static void onTick()
        {
            SDK.Entity.LocalPlayer.stepHeight = 2f;
        }
    }
}
