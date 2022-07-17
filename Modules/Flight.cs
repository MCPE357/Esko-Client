using System;
using Memory;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.SDK;

namespace Client.Modules
{
    public class Flight
    {
        public static string Name = "Flight";
        public static int key;
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
            isPressed = true;
            Mem mem = new Mem();
            int PID = mem.GetProcIdFromName("Minecraft.Windows.exe");
            {
                mem.OpenProcess(PID);
                mem.WriteMemory("Minecraft.Windows.exe+043BEB98,10,18,B8,498,98,B8,B18", "int", "1");
            }
        }
        public static void onDisable()
        {
            isPressed = false;
            Mem mem = new Mem();
            int PID = mem.GetProcIdFromName("Minecraft.Windows.exe");
            {
                mem.OpenProcess(PID);
                mem.WriteMemory("Minecraft.Windows.exe+043BEB98,10,18,B8,498,98,B8,B18", "int", "0");
            }
        }
        public static void onTick()
        {
            if (isPressed == true)
            {

                Mem mem = new Mem();
                int PID = mem.GetProcIdFromName("Minecraft.Windows.exe");
                {
                    mem.OpenProcess(PID);
                    mem.WriteMemory("Minecraft.Windows.exe+043BEB98,10,18,B8,498,98,B8,B18", "int", "1");
                }
            }
        }
    }
}
