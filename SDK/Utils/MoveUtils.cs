using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Client.SDK.Imports;
using System.Windows.Forms;

namespace Client.SDK
{
    public class MoveUtils
    {
        public static bool returnValue;
        public static bool CanMove(string x, string y, string z)
        {
            if (GetAsyncKeyState(Keys.W) < 0 || GetAsyncKeyState(Keys.A) < 0 || GetAsyncKeyState(Keys.S) < 0 || GetAsyncKeyState(Keys.D) < 0)
            {
                float xValue = Form1.m.ReadFloat(x);
                float yValue = Form1.m.ReadFloat(y);
                float zValue = Form1.m.ReadFloat(z);
                if(xValue > 0 && zValue > 0)
                {
                    returnValue = true;
                }
                else
                {
                    returnValue = false;
                }
            }
            return returnValue;
        }

        public static void TPY(float yValue)
        {
            float y = SDK.Entity.LocalPlayer.posY + yValue;
            SDK.Entity.LocalPlayer.posY = y;
        }
    }
}
