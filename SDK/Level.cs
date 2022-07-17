using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.SDK
{
    public class Level
    {
        private static string MultiPlayerLvl = SDK.Entity.Player + "358";

        private static string LookingActor = MultiPlayerLvl + "964";

        public struct MultiPlayer
        {
            public static int lookingActor
            {
                get
                {
                    return Form1.m.ReadByte(LookingActor);
                }
                set
                {
                    Form1.m.WriteMemory(LookingActor, "byte", value.ToString());
                }
            }
        }
    }
}
