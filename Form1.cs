using Client.SDK;
using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    
    public partial class Form1 : Form
    {
        public static Mem m = new Mem();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            m.OpenProcess("Minecraft.Windows.exe");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Modules.AirWalk.toggeld)
            {
                Modules.AirWalk.onTick();
            }
            if (Modules.AirJump.toggeld)
            {
                Modules.AirJump.onTick();
            }
            if (Modules.Glide.toggeld)
            {
                Modules.Glide.onTick();
            }
            if (Modules.Flight.toggeld)
            {
                Modules.Flight.onTick();
            }
            if (Modules.Step.toggeld)
            {
                Modules.Step.onTick();
            }
            if (Modules.TriggerBot.toggeld)
            {
                Modules.TriggerBot.onTick();
            }
            if (Modules.BounceGlide.toggeld)
            {
                Modules.BounceGlide.onTick();
            }
            if (Modules.Gamemode.toggeld)
            {
                Modules.Gamemode.onTick();
            }
            if (Modules.BHop.toggeld)
            {
                Modules.BHop.onTick();
            }
            if (Modules.HiveGlide.toggeld)
            { 
                Modules.HiveGlide.onTick();
            }

            onLoop();
        }
        private void AirWalk_Click(object sender, EventArgs e)
        {
            Modules.AirWalk.Toggle();
            AirWalkLabel.Visible = !AirWalkLabel.Visible;
        }
        private void AirJump_Click(object sender, EventArgs e)
        {
            Modules.AirJump.Toggle();
            AirJumpLabel.Visible = !AirJumpLabel.Visible;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Glide_Click(object sender, EventArgs e)
        {
            Modules.Glide.Toggle();
            GlideLabel.Visible = !GlideLabel.Visible;
        }

        private void Flight_Click(object sender, EventArgs e)
        {
            Modules.Flight.Toggle();
            FlightLabel.Visible = !FlightLabel.Visible;
        }

        public void onLoop()
        {
            if (SDK.Imports.GetAsyncKeyState(Modules.HiveGlide.key) < 0)
            {
                if (!Modules.HiveGlide.isPressed)
                {
                    Modules.HiveGlide.Toggle();
                    HiveGlideLabel.Visible = !HiveGlideLabel.Visible;
                    Modules.HiveGlide.isPressed = true;
                }
            }
            else
            {
                Modules.HiveGlide.isPressed = false;
            }
            if (Imports.GetAsyncKeyState(Modules.Glide.key) < 0)
            {
                if (!Modules.Glide.isPressed)
                {
                    Modules.Glide.Toggle();
                    GlideLabel.Visible = !GlideLabel.Visible;
                    Modules.Glide.isPressed = true;
                }
            }
            else
            {
                Modules.Glide.isPressed = false;
            }

            if (Imports.GetAsyncKeyState(Modules.BounceGlide.key) < 0)
            {
                if (!Modules.BounceGlide.isPressed)
                {
                    Modules.BounceGlide.Toggle();
                    BounceFlyLabel.Visible = !BounceFlyLabel.Visible;
                    Modules.BounceGlide.isPressed = true;
                }
            }
            else
            {
                Modules.BounceGlide.isPressed = false;
            }

            if (Imports.GetAsyncKeyState(Modules.Gamemode.key) < 0)
            {
                if (!Modules.Gamemode.isPressed)
                {
                    Modules.Gamemode.Toggle();
                    GamemodeLabel.Visible = !GamemodeLabel.Visible;
                    Modules.Gamemode.isPressed = true;
                }
            }
            else
            {
                Modules.Gamemode.isPressed = false;
            }

            if (Imports.GetAsyncKeyState(Modules.BHop.key) < 0)
            {
                if (!Modules.BHop.isPressed)
                {
                    Modules.BHop.Toggle();
                    BHopLabel.Visible = !BHopLabel.Visible;
                    Modules.BHop.isPressed = true;
                }
            }
            else
            {
                Modules.BHop.isPressed = false;
            }

            if (Imports.GetAsyncKeyState(Keys.F12) < 0)
            {
                Close();
            }
        }

        private void Step_Click(object sender, EventArgs e)
        {
            Modules.Step.Toggle();
            StepLabel.Visible = !StepLabel.Visible;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TriggerBot_Click(object sender, EventArgs e)
        {
            Modules.TriggerBot.Toggle();
            TriggerBotLabel.Visible = !TriggerBotLabel.Visible;
        }

        private void BounceFly_Click(object sender, EventArgs e)
        {
            Modules.BounceGlide.Toggle();
            BounceFlyLabel.Visible = !BounceFlyLabel.Visible;
        }

        private void Gamemode_Click(object sender, EventArgs e)
        {
            Modules.Gamemode.Toggle();
            GamemodeLabel.Visible = !GamemodeLabel.Visible;
        }

        private void BHop_Click(object sender, EventArgs e)
        {
            Modules.BHop.Toggle();
            BHopLabel.Visible = !BHopLabel.Visible;
        }
        private void HiveGlide_Click(object sender, EventArgs e)
        {
            Modules.HiveGlide.Toggle();
            HiveGlideLabel.Visible = !HiveGlideLabel.Visible;
        }
    }
}
