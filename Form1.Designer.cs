
namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AirWalk = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AirJump = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HiveGlide = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Gamemode = new System.Windows.Forms.Button();
            this.BounceFly = new System.Windows.Forms.Button();
            this.Flight = new System.Windows.Forms.Button();
            this.Glide = new System.Windows.Forms.Button();
            this.Movement = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PlayerCat = new System.Windows.Forms.Label();
            this.Step = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TriggerBot = new System.Windows.Forms.Button();
            this.StepLabel = new System.Windows.Forms.Label();
            this.FlightLabel = new System.Windows.Forms.Label();
            this.AirWalkLabel = new System.Windows.Forms.Label();
            this.TriggerBotLabel = new System.Windows.Forms.Label();
            this.GamemodeLabel = new System.Windows.Forms.Label();
            this.AirJumpLabel = new System.Windows.Forms.Label();
            this.BounceFlyLabel = new System.Windows.Forms.Label();
            this.GlideLabel = new System.Windows.Forms.Label();
            this.BHopLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HiveGlideLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AirWalk
            // 
            this.AirWalk.BackColor = System.Drawing.Color.Orange;
            this.AirWalk.Location = new System.Drawing.Point(17, 47);
            this.AirWalk.Name = "AirWalk";
            this.AirWalk.Size = new System.Drawing.Size(115, 51);
            this.AirWalk.TabIndex = 0;
            this.AirWalk.Text = "TEST";
            this.AirWalk.UseVisualStyleBackColor = false;
            this.AirWalk.Click += new System.EventHandler(this.AirWalk_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AirJump
            // 
            this.AirJump.BackColor = System.Drawing.Color.Orange;
            this.AirJump.Location = new System.Drawing.Point(17, 104);
            this.AirJump.Name = "AirJump";
            this.AirJump.Size = new System.Drawing.Size(115, 51);
            this.AirJump.TabIndex = 1;
            this.AirJump.Text = "AirJump";
            this.AirJump.UseVisualStyleBackColor = false;
            this.AirJump.Click += new System.EventHandler(this.AirJump_Click);
            // 
            // panel1
            // 
            //this.panel1.Controls.Add(this.HiveGlide);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Gamemode);
            //this.panel1.Controls.Add(this.BounceFly);
            this.panel1.Controls.Add(this.Flight);
            //this.panel1.Controls.Add(this.Glide);
            this.panel1.Controls.Add(this.Movement);
            this.panel1.Controls.Add(this.AirWalk);
            this.panel1.Controls.Add(this.AirJump);
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 509);
            this.panel1.TabIndex = 2;
            // 
            // HiveGlide
            // 
            this.HiveGlide.BackColor = System.Drawing.Color.Orange;
            this.HiveGlide.Location = new System.Drawing.Point(17, 446);
            this.HiveGlide.Name = "HiveGlide";
            this.HiveGlide.Size = new System.Drawing.Size(115, 51);
            this.HiveGlide.TabIndex = 8;
            this.HiveGlide.Text = "?7";
            this.HiveGlide.UseVisualStyleBackColor = false;
            this.HiveGlide.Click += new System.EventHandler(this.HiveGlide_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(17, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "?2";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BHop_Click);
            // 
            // Gamemode
            // 
            this.Gamemode.BackColor = System.Drawing.Color.Orange;
            this.Gamemode.Location = new System.Drawing.Point(17, 332);
            this.Gamemode.Name = "GM(1/0)";
            this.Gamemode.Size = new System.Drawing.Size(115, 51);
            this.Gamemode.TabIndex = 6;
            this.Gamemode.Text = "GM(1/0)";
            this.Gamemode.UseVisualStyleBackColor = false;
            this.Gamemode.Click += new System.EventHandler(this.Gamemode_Click);
            // 
            // BounceFly
            // 
            this.BounceFly.BackColor = System.Drawing.Color.Orange;
            this.BounceFly.Location = new System.Drawing.Point(17, 275);
            this.BounceFly.Name = "BounceFly";
            this.BounceFly.Size = new System.Drawing.Size(115, 51);
            this.BounceFly.TabIndex = 5;
            this.BounceFly.Text = "?3";
            this.BounceFly.UseVisualStyleBackColor = false;
            this.BounceFly.Click += new System.EventHandler(this.BounceFly_Click);
            // 
            // Flight
            // 
            this.Flight.BackColor = System.Drawing.Color.Orange;
            this.Flight.Location = new System.Drawing.Point(17, 218);
            this.Flight.Name = "Flight";
            this.Flight.Size = new System.Drawing.Size(115, 51);
            this.Flight.TabIndex = 4;
            this.Flight.Text = "SFly";
            this.Flight.UseVisualStyleBackColor = false;
            this.Flight.Click += new System.EventHandler(this.Flight_Click);
            // 
            // Glide
            // 
            this.Glide.BackColor = System.Drawing.Color.Orange;
            this.Glide.Location = new System.Drawing.Point(17, 161);
            this.Glide.Name = "Glide";
            this.Glide.Size = new System.Drawing.Size(115, 51);
            this.Glide.TabIndex = 3;
            this.Glide.Text = "?4";
            this.Glide.UseVisualStyleBackColor = false;
            this.Glide.Click += new System.EventHandler(this.Glide_Click);
            // 
            // Movement
            // 
            this.Movement.AutoSize = true;
			this.Movement.BackColor = System.Drawing.Color.Orange;
            this.Movement.Location = new System.Drawing.Point(35, 16);
            this.Movement.Name = "Movement";
            this.Movement.Size = new System.Drawing.Size(73, 17);
            this.Movement.TabIndex = 2;
            this.Movement.Text = "Movement";
            // 
            // panel2
            // 
            //this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.PlayerCat);
            this.panel2.Controls.Add(this.Step);
            this.panel2.Location = new System.Drawing.Point(195, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 106);
            this.panel2.TabIndex = 5;
            // 
            // PlayerCat
            // 
            this.PlayerCat.AutoSize = true;
			this.PlayerCat.BackColor = System.Drawing.Color.Orange;
            this.PlayerCat.Location = new System.Drawing.Point(50, 16);
            this.PlayerCat.Name = "PlayerCat";
            this.PlayerCat.Size = new System.Drawing.Size(48, 17);
            this.PlayerCat.TabIndex = 2;
            this.PlayerCat.Text = "Player";
            // 
            // Step
            // 
            this.Step.BackColor = System.Drawing.Color.Orange;
            this.Step.Location = new System.Drawing.Point(17, 47);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(115, 51);
            this.Step.TabIndex = 0;
            this.Step.Text = "?1";
            this.Step.UseVisualStyleBackColor = false;
            this.Step.Click += new System.EventHandler(this.Step_Click);
            // 
            // panel3
            // 
            //this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.TriggerBot);
            this.panel3.Location = new System.Drawing.Point(381, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(147, 111);
            this.panel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(50, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Combat";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TriggerBot
            // 
            this.TriggerBot.BackColor = System.Drawing.Color.Orange;
            this.TriggerBot.Location = new System.Drawing.Point(17, 47);
            this.TriggerBot.Name = "Reach";
            this.TriggerBot.Size = new System.Drawing.Size(115, 51);
            this.TriggerBot.TabIndex = 0;
            this.TriggerBot.Text = "Reach";
            this.TriggerBot.UseVisualStyleBackColor = false;
            this.TriggerBot.Click += new System.EventHandler(this.TriggerBot_Click);
            // 
            // StepLabel
            // 
            this.StepLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StepLabel.AutoSize = true;
            this.StepLabel.BackColor = System.Drawing.Color.Orange;
            this.StepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepLabel.Location = new System.Drawing.Point(1056, 224);
            this.StepLabel.Name = "StepLabel";
            this.StepLabel.Size = new System.Drawing.Size(53, 25);
            this.StepLabel.TabIndex = 7;
            this.StepLabel.Text = "?5";
            this.StepLabel.Visible = false;
            // 
            // FlightLabel
            // 
            this.FlightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FlightLabel.AutoSize = true;
            this.FlightLabel.BackColor = System.Drawing.Color.Orange;
            this.FlightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightLabel.Location = new System.Drawing.Point(1047, 149);
            this.FlightLabel.Name = "FlightLabel";
            this.FlightLabel.Size = new System.Drawing.Size(59, 25);
            this.FlightLabel.TabIndex = 8;
            this.FlightLabel.Text = "SFly";
            this.FlightLabel.Visible = false;
            // 
            // AirWalkLabel
            // 
            this.AirWalkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AirWalkLabel.AutoSize = true;
            this.AirWalkLabel.BackColor = System.Drawing.Color.Orange;
            this.AirWalkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AirWalkLabel.Location = new System.Drawing.Point(1025, 99);
            this.AirWalkLabel.Name = "AirWalkLabel";
            this.AirWalkLabel.Size = new System.Drawing.Size(81, 25);
            this.AirWalkLabel.TabIndex = 9;
            this.AirWalkLabel.Text = "Test";
            this.AirWalkLabel.Visible = false;
            // 
            // TriggerBotLabel
            // 
            this.TriggerBotLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TriggerBotLabel.AutoSize = true;
            this.TriggerBotLabel.BackColor = System.Drawing.Color.Orange;
            this.TriggerBotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TriggerBotLabel.Location = new System.Drawing.Point(1003, -1);
            this.TriggerBotLabel.Name = "TriggerBotLabel";
            this.TriggerBotLabel.Size = new System.Drawing.Size(103, 25);
            this.TriggerBotLabel.TabIndex = 10;
            this.TriggerBotLabel.Text = "Reach";
            this.TriggerBotLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.TriggerBotLabel.Visible = false;
            // 
            // GamemodeLabel
            // 
            this.GamemodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GamemodeLabel.AutoSize = true;
            this.GamemodeLabel.BackColor = System.Drawing.Color.Orange;
            this.GamemodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamemodeLabel.Location = new System.Drawing.Point(1041, 124);
            this.GamemodeLabel.Name = "GamemodeLabel";
            this.GamemodeLabel.Size = new System.Drawing.Size(68, 25);
            this.GamemodeLabel.TabIndex = 11;
            this.GamemodeLabel.Text = "Gamemode";
            this.GamemodeLabel.Visible = false;
            // 
            // AirJumpLabel
            // 
            this.AirJumpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AirJumpLabel.AutoSize = true;
            this.AirJumpLabel.BackColor = System.Drawing.Color.Orange;
            this.AirJumpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AirJumpLabel.Location = new System.Drawing.Point(1021, 74);
            this.AirJumpLabel.Name = "AirJumpLabel";
            this.AirJumpLabel.Size = new System.Drawing.Size(85, 25);
            this.AirJumpLabel.TabIndex = 12;
            this.AirJumpLabel.Text = "AirJump";
            this.AirJumpLabel.Visible = false;
            // 
            // BounceFlyLabel
            // 
            this.BounceFlyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BounceFlyLabel.AutoSize = true;
            this.BounceFlyLabel.BackColor = System.Drawing.Color.Orange;
            this.BounceFlyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BounceFlyLabel.Location = new System.Drawing.Point(1004, 24);
            this.BounceFlyLabel.Name = "BounceFlyLabel";
            this.BounceFlyLabel.Size = new System.Drawing.Size(105, 25);
            this.BounceFlyLabel.TabIndex = 13;
            this.BounceFlyLabel.Text = "?6";
            this.BounceFlyLabel.Visible = false;
            // 
            // GlideLabel
            // 
            this.GlideLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GlideLabel.AutoSize = true;
            this.GlideLabel.BackColor = System.Drawing.Color.Orange;
            this.GlideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GlideLabel.Location = new System.Drawing.Point(1052, 199);
            this.GlideLabel.Name = "GlideLabel";
            this.GlideLabel.Size = new System.Drawing.Size(57, 25);
            this.GlideLabel.TabIndex = 14;
            this.GlideLabel.Text = "Glide";
            this.GlideLabel.Visible = false;
            // 
            // BHopLabel
            // 
            this.BHopLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BHopLabel.AutoSize = true;
            this.BHopLabel.BackColor = System.Drawing.Color.Orange;
            this.BHopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BHopLabel.Location = new System.Drawing.Point(1047, 174);
            this.BHopLabel.Name = "BHopLabel";
            this.BHopLabel.Size = new System.Drawing.Size(61, 25);
            this.BHopLabel.TabIndex = 15;
            this.BHopLabel.Text = "BHop";
            this.BHopLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::Client.Properties.Resources.Darkforces_client_name;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 71);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // HiveGlideLabel
            // 
            this.HiveGlideLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HiveGlideLabel.AutoSize = true;
            this.HiveGlideLabel.BackColor = System.Drawing.Color.Orange;
            this.HiveGlideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HiveGlideLabel.Location = new System.Drawing.Point(1010, 49);
            this.HiveGlideLabel.Name = "HiveGlideLabel";
            this.HiveGlideLabel.Size = new System.Drawing.Size(96, 25);
            this.HiveGlideLabel.TabIndex = 17;
            this.HiveGlideLabel.Text = "HiveGlide";
            this.HiveGlideLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1106, 709);
            this.ControlBox = false;
            this.Controls.Add(this.HiveGlideLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BHopLabel);
            this.Controls.Add(this.GlideLabel);
            this.Controls.Add(this.BounceFlyLabel);
            this.Controls.Add(this.AirJumpLabel);
            this.Controls.Add(this.GamemodeLabel);
            this.Controls.Add(this.TriggerBotLabel);
            this.Controls.Add(this.AirWalkLabel);
            this.Controls.Add(this.FlightLabel);
            this.Controls.Add(this.StepLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Esko Client";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AirWalk;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button AirJump;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Movement;
        private System.Windows.Forms.Button Glide;
        private System.Windows.Forms.Button Flight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label PlayerCat;
        private System.Windows.Forms.Button Step;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TriggerBot;
        private System.Windows.Forms.Button BounceFly;
        private System.Windows.Forms.Button Gamemode;
        private System.Windows.Forms.Label StepLabel;
        private System.Windows.Forms.Label FlightLabel;
        private System.Windows.Forms.Label AirWalkLabel;
        private System.Windows.Forms.Label TriggerBotLabel;
        private System.Windows.Forms.Label GamemodeLabel;
        private System.Windows.Forms.Label AirJumpLabel;
        private System.Windows.Forms.Label BounceFlyLabel;
        private System.Windows.Forms.Label GlideLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label BHopLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button HiveGlide;
        private System.Windows.Forms.Label HiveGlideLabel;
    }
}

