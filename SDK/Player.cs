using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Client.SDK.Vecters;

namespace Client.SDK
{
    public class Entity
    {
        public static string Player = "Minecraft.Windows.exe+03CDD138,0,18,B8,";

        //looking vec
        private static string yaw = Player + "124";
        private static string pitch = Player + "128";

        //can be modified
        private static string OnGround = Player + "1C0";
        private static string StepHeight = Player + "220";

        private static string Speed = "Minecraft.Windows.exe+03961810,108,250,18,1F0,9C";

        private static string IsFlying = Player + "928";
        private static string CanFly = Player + "934";
        private static string FlySpeed = Player + "958";

        private static string VelocityX = Player + "4DC";
        private static string VelocityY = Player + "4E0";
        private static string VelocityZ = Player + "4E4";

        //position values
        private static string PosX = Player + "4A0";
        private static string PosY = Player + "4A4";
        private static string PosZ = Player + "4A8";

        private static string PosX2 = Player + "4AC";
        private static string PosY2 = Player + "4B0";
        private static string PosZ2 = Player + "4B4";


        public struct LocalPlayer
        {
            public static float Yaw
            {
                get
                {
                    return Form1.m.ReadFloat(yaw);
                }
            }
            public static float Pitch
            {
                get
                {
                    return Form1.m.ReadFloat(pitch);
                }
            }
            public static void Jump()
            {
                Form1.m.WriteMemory(VelocityY, "float", "0.5");
            }

            public static float posX
            {
                get
                {
                    return Form1.m.ReadFloat(PosX);
                }
                set
                {
                    Form1.m.WriteMemory(PosX, "float", value.ToString());
                }
            }
            public static float posY
            {
                get
                {
                    return Form1.m.ReadFloat(PosY);
                }
                set
                {
                    Form1.m.WriteMemory(PosY, "float", value.ToString());
                }
            }
            public static float posZ
            {
                get
                {
                    return Form1.m.ReadFloat(PosZ);
                }
                set
                {
                    Form1.m.WriteMemory(PosZ, "float", value.ToString());
                }
            }

            public static float posX2
            {
                get
                {
                    return Form1.m.ReadFloat(PosX2);
                }
                set
                {
                    Form1.m.WriteMemory(PosX2, "float", value.ToString());
                }
            }
            public static float posY2
            {
                get
                {
                    return Form1.m.ReadFloat(PosY2);
                }
                set
                {
                    Form1.m.WriteMemory(PosY2, "float", value.ToString());
                }
            }
            public static float posZ2
            {
                get
                {
                    return Form1.m.ReadFloat(PosZ2);
                }
                set
                {
                    Form1.m.WriteMemory(PosZ2, "float", value.ToString());
                }
            }

            public static float MotionX
            {
                get
                {
                    return Form1.m.ReadFloat(VelocityX);
                }
                set
                {
                    Form1.m.WriteMemory(VelocityX, "float", value.ToString());
                }
            }
            public static float MotionY
            {
                get
                {
                    return Form1.m.ReadFloat(VelocityY);
                }
                set
                {
                    Form1.m.WriteMemory(VelocityY, "float", value.ToString());
                }
            }
            public static float MotionZ
            {
                get
                {
                    return Form1.m.ReadFloat(VelocityZ);
                }
                set
                {
                    Form1.m.WriteMemory(VelocityZ, "float", value.ToString());
                }
            }

            public static bool onGround
            {
                get
                {
                    if(Form1.m.ReadByte(OnGround) >= 1)
                    {
                        return true;
                    }
                    return false;
                }
                set
                {
                    if(value == true)
                    {
                        Form1.m.WriteMemory(OnGround, "byte", "1");
                    }
                    else
                    {
                        Form1.m.WriteMemory(OnGround, "byte", "0");
                    }
                    
                }
            }

            public static bool canFly
            {
                get
                {
                    if(Form1.m.ReadByte(CanFly) >= 1)
                    {
                        return true;
                    }
                    return false;
                }
                set
                {
                    if (value == true)
                    {
                        Form1.m.WriteMemory(CanFly, "byte", "1");
                    }
                    else
                    {
                        Form1.m.WriteMemory(CanFly, "byte", "0");
                    }
                }
            }

            public static bool isFlying
            {
                get
                {
                    if(Form1.m.ReadByte(IsFlying) >= 1)
                    {
                        return true;
                    }
                    return false;
                }
                set
                {
                    if (value == true)
                    {
                        Form1.m.WriteMemory(IsFlying, "byte", "1");
                    }
                    else
                    {
                        Form1.m.WriteMemory(IsFlying, "byte", "0");
                    }
                }
            }

            public static float flySpeed
            {
                get
                {
                    return Form1.m.ReadFloat(FlySpeed);
                }
                set
                {
                    Form1.m.WriteMemory(FlySpeed, "float", value.ToString());
                }
            }
            public static float speed
            {
                get
                {
                    return Form1.m.ReadFloat(Speed);
                }
                set
                {
                    Form1.m.WriteMemory(Speed, "float", value.ToString());
                }
            }
            public static float stepHeight
            {
                get
                {
                    return Form1.m.ReadFloat(StepHeight);
                }
                set
                {
                    Form1.m.WriteMemory(StepHeight, "float", value.ToString());
                }
            }

            public static void Telport(float x, float y, float z)
            {
                posX = x;
                posY = y;
                posZ = z;
                posX2 = x + 0.6f;
                posY2 = y + 1.8f;
                posZ2 = z + 0.6f;
            }
        }
    }
}
