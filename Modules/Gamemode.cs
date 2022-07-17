using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace Client.Modules
{
    public class Gamemode
    {
        public static string Name = "Gamemode";
        public static Keys key = Keys.R;
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
			Mem mem = new Mem();
            int PID = mem.GetProcIdFromName("Minecraft.Windows.exe");
			{
                mem.OpenProcess(PID);
                mem.WriteMemory("Minecraft.Windows.exe+0x043BEB98,18,18,88,138,C8,C98,0,BE4", "int", "1");
            }
        }
        public static void onDisable()
        {
            Mem mem = new Mem();
            int PID = mem.GetProcIdFromName("Minecraft.Windows.exe");
			{
                mem.OpenProcess(PID);
                mem.WriteMemory("Minecraft.Windows.exe+0x043BEB98,18,18,88,138,C8,C98,0,BE4", "int", "0");
            }
        }
        public static void onTick()
        {
        }
    }
}
