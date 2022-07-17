using Client.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Client.SDK.Vecters;

namespace Client.Modules
{
    public class HiveGlide
    {
        public static string Name = "HiveGlide";
        public static Keys key = Keys.F;
        public static bool toggeld;

        private static int timeInAir = 0;
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
            timeInAir = 0;
        }
        public static void onDisable()
        {
            timeInAir = 0;
        }
        public static void onTick()
        {
                if(timeInAir < 220)
                {
                    SDK.Entity.LocalPlayer.MotionY = -0.05f;
                    if (!(Imports.GetAsyncKeyState(Keys.Space) < 0))
                    {
                        SDK.Entity.LocalPlayer.onGround = true;
                    }
                }
                else
                {
                    Toggle();
                }
                timeInAir++;
        }
    }
}
