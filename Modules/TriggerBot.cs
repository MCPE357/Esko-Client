
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Memory;

namespace Client.Modules
{
    public class TriggerBot
    {
		
		public static string Name = "TriggerBot";
        public static Keys key = Keys.V;
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
                mem.WriteMemory("Minecraft.Windows.exe+3A224B0", "float", "7");
            }

        }
        public static void onDisable()
        {
			Mem mem = new Mem();
            int PID = mem.GetProcIdFromName("Minecraft.Windows.exe");
			{
                mem.OpenProcess(PID);
                mem.WriteMemory("Minecraft.Windows.exe+3A224B0", "float", "3");
            }

        }
        public static void onTick()
        {
        }
    }
}
