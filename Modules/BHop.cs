using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Modules
{
    public class BHop
    {
        public static string Name = "BHop";
        public static Keys key = Keys.X;
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
            if(SDK.Entity.LocalPlayer.onGround)
            {
                SDK.Entity.LocalPlayer.Jump();
            }
            else
            {
                SDK.Entity.LocalPlayer.speed = 0.2f;
            }
        }
    }
}
