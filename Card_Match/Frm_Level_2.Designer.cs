namespace Card_Match
{
    partial class Frm_Level_2
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
            this.btn_Done = new System.Windows.Forms.Button();
            this.Card_0 = new System.Windows.Forms.Label();
            this.Card_1 = new System.Windows.Forms.Label();
            this.Card_2 = new System.Windows.Forms.Label();
            this.Card_3 = new System.Windows.Forms.Label();
            this.lbl_End = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_Notification = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.lbl_Turns = new System.Windows.Forms.Label();
            this.lbl_Remain = new System.Windows.Forms.Label();
            this.panel_Play = new System.Windows.Forms.Panel();
            this.Card_7 = new System.Windows.Forms.Label();
            this.Card_6 = new System.Windows.Forms.Label();
            this.Card_5 = new System.Windows.Forms.Label();
            this.Card_4 = new System.Windows.Forms.Label();
            this.btn_Help = new System.Windows.Forms.Button();
            this.btn_Give_Up = new System.Windows.Forms.Button();
            this.lbl_Record = new System.Windows.Forms.Label();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.btn_Slow_Time = new System.Windows.Forms.Button();
            this.btn_Add_10 = new System.Windows.Forms.Button();
            this.btn_Add_20 = new System.Windows.Forms.Button();
            this.btn_Add_25 = new System.Windows.Forms.Button();
            this.lbl_Gold = new System.Windows.Forms.Label();
            this.panel_Play.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Done
            // 
            this.btn_Done.BackColor = System.Drawing.Color.Transparent;
            this.btn_Done.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Done.Enabled = false;
            this.btn_Done.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Done.FlatAppearance.BorderSize = 0;
            this.btn_Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Done.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Done.Location = new System.Drawing.Point(583, 508);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(85, 42);
            this.btn_Done.TabIndex = 4;
            this.btn_Done.Text = "Done";
            this.btn_Done.UseVisualStyleBackColor = false;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // Card_0
            // 
            this.Card_0.BackColor = System.Drawing.Color.Transparent;
            this.Card_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Card_0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Card_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Card_0.Location = new System.Drawing.Point(101, 142);
            this.Card_0.Name = "Card_0";
            this.Card_0.Size = new System.Drawing.Size(75, 75);
            this.Card_0.TabIndex = 0;
            this.Card_0.Click += new System.EventHandler(this.Card_0_Click);
            // 
            // Card_1
            // 
            this.Card_1.BackColor = System.Drawing.Color.Transparent;
            this.Card_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Card_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Card_1.Location = new System.Drawing.Point(191, 142);
            this.Card_1.Name = "Card_1";
            this.Card_1.Size = new System.Drawing.Size(75, 75);
            this.Card_1.TabIndex = 1;
            this.Card_1.Click += new System.EventHandler(this.Card_1_Click);
            // 
            // Card_2
            // 
            this.Card_2.BackColor = System.Drawing.Color.Transparent;
            this.Card_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Card_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Card_2.Location = new System.Drawing.Point(283, 142);
            this.Card_2.Name = "Card_2";
            this.Card_2.Size = new System.Drawing.Size(75, 75);
            this.Card_2.TabIndex = 2;
            this.Card_2.Click += new System.EventHandler(this.Card_2_Click);
            // 
            // Card_3
            // 
            this.Card_3.BackColor = System.Drawing.Color.Transparent;
            this.Card_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Card_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Card_3.Location = new System.Drawing.Point(373, 142);
            this.Card_3.Name = "Card_3";
            this.Card_3.Size = new System.Drawing.Size(75, 75);
            this.Card_3.TabIndex = 3;
            this.Card_3.Click += new System.EventHandler(this.Card_3_Click);
            // 
            // lbl_End
            // 
            this.lbl_End.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_End.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_End.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_End.Location = new System.Drawing.Point(-2, -2);
            this.lbl_End.Name = "lbl_End";
            this.lbl_End.Size = new System.Drawing.Size(550, 450);
            this.lbl_End.TabIndex = 5;
            this.lbl_End.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_End.Visible = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lbl_Time
            // 
            this.lbl_Time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Time.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.Location = new System.Drawing.Point(330, 21);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(123, 28);
            this.lbl_Time.TabIndex = 6;
            this.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Notification
            // 
            this.lbl_Notification.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Notification.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Notification.Location = new System.Drawing.Point(306, 505);
            this.lbl_Notification.Name = "lbl_Notification";
            this.lbl_Notification.Size = new System.Drawing.Size(161, 35);
            this.lbl_Notification.TabIndex = 7;
            this.lbl_Notification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.Transparent;
            this.btn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Next.Enabled = false;
            this.btn_Next.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Next.FlatAppearance.BorderSize = 0;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Location = new System.Drawing.Point(687, 507);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(85, 42);
            this.btn_Next.TabIndex = 8;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // lbl_Turns
            // 
            this.lbl_Turns.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Turns.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Turns.Location = new System.Drawing.Point(3, 53);
            this.lbl_Turns.Name = "lbl_Turns";
            this.lbl_Turns.Size = new System.Drawing.Size(109, 66);
            this.lbl_Turns.TabIndex = 9;
            this.lbl_Turns.Text = "Your Turns: ";
            this.lbl_Turns.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Remain
            // 
            this.lbl_Remain.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Remain.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Remain.Location = new System.Drawing.Point(3, 135);
            this.lbl_Remain.Name = "lbl_Remain";
            this.lbl_Remain.Size = new System.Drawing.Size(109, 66);
            this.lbl_Remain.TabIndex = 10;
            this.lbl_Remain.Text = "Remains:";
            this.lbl_Remain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_Play
            // 
            this.panel_Play.BackColor = System.Drawing.Color.Transparent;
            this.panel_Play.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Play.Controls.Add(this.lbl_End);
            this.panel_Play.Controls.Add(this.Card_7);
            this.panel_Play.Controls.Add(this.Card_6);
            this.panel_Play.Controls.Add(this.Card_5);
            this.panel_Play.Controls.Add(this.Card_4);
            this.panel_Play.Controls.Add(this.Card_3);
            this.panel_Play.Controls.Add(this.Card_2);
            this.panel_Play.Controls.Add(this.Card_1);
            this.panel_Play.Controls.Add(this.Card_0);
            this.panel_Play.Location = new System.Drawing.Point(118, 52);
            this.panel_Play.Name = "panel_Play";
            this.panel_Play.Size = new System.Drawing.Size(550, 450);
            this.panel_Play.TabIndex = 11;
            // 
            // Card_7
            // 
            this.Card_7.BackColor = System.Drawing.Color.Transparent;
            this.Card_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Card_7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Card_7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Card_7.Location = new System.Drawing.Point(373, 233);
            this.Card_7.Name = "Card_7";
            this.Card_7.Size = new System.Drawing.Size(75, 75);
            this.Card_7.TabIndex = 7;
            this.Card_7.Click += new System.EventHandler(this.Card_7_Click);
            // 
            // Card_6
            // 
            this.Card_6.BackColor = System.Drawing.Color.Transparent;
            this.Card_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Card_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Card_6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Card_6.Location = new System.Drawing.Point(283, 233);
            this.Card_6.Name = "Card_6";
            this.Card_6.Size = new System.Drawing.Size(75, 75);
            this.Card_6.TabIndex = 6;
            this.Card_6.Click += new System.EventHandler(this.Card_6_Click);
            // 
            // Card_5
            // 
            this.Card_5.BackColor = System.Drawing.Color.Transparent;
            this.Card_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Card_5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Card_5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Card_5.Location = new System.Drawing.Point(191, 233);
            this.Card_5.Name = "Card_5";
            this.Card_5.Size = new System.Drawing.Size(75, 75);
            this.Card_5.TabIndex = 5;
            this.Card_5.Click += new System.EventHandler(this.Card_5_Click);
            // 
            // Card_4
            // 
            this.Card_4.BackColor = System.Drawing.Color.Transparent;
            this.Card_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Card_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Card_4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Card_4.Location = new System.Drawing.Point(101, 233);
            this.Card_4.Name = "Card_4";
            this.Card_4.Size = new System.Drawing.Size(75, 75);
            this.Card_4.TabIndex = 4;
            this.Card_4.Click += new System.EventHandler(this.Card_4_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.BackColor = System.Drawing.Color.Transparent;
            this.btn_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Help.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Help.FlatAppearance.BorderSize = 0;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Help.Location = new System.Drawing.Point(687, 52);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(85, 42);
            this.btn_Help.TabIndex = 12;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = false;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // btn_Give_Up
            // 
            this.btn_Give_Up.BackColor = System.Drawing.Color.Transparent;
            this.btn_Give_Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Give_Up.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Give_Up.FlatAppearance.BorderSize = 0;
            this.btn_Give_Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Give_Up.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Give_Up.Location = new System.Drawing.Point(687, 112);
            this.btn_Give_Up.Name = "btn_Give_Up";
            this.btn_Give_Up.Size = new System.Drawing.Size(85, 42);
            this.btn_Give_Up.TabIndex = 13;
            this.btn_Give_Up.Text = "Give Up";
            this.btn_Give_Up.UseVisualStyleBackColor = false;
            this.btn_Give_Up.Click += new System.EventHandler(this.btn_Give_Up_Click);
            // 
            // lbl_Record
            // 
            this.lbl_Record.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Record.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Record.Location = new System.Drawing.Point(3, 218);
            this.lbl_Record.Name = "lbl_Record";
            this.lbl_Record.Size = new System.Drawing.Size(109, 66);
            this.lbl_Record.TabIndex = 14;
            this.lbl_Record.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Restart
            // 
            this.btn_Restart.BackColor = System.Drawing.Color.Transparent;
            this.btn_Restart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Restart.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Restart.FlatAppearance.BorderSize = 0;
            this.btn_Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Restart.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Restart.Location = new System.Drawing.Point(12, 507);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(85, 42);
            this.btn_Restart.TabIndex = 15;
            this.btn_Restart.Text = "Restart";
            this.btn_Restart.UseVisualStyleBackColor = false;
            this.btn_Restart.Click += new System.EventHandler(this.Btn_Restart_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.BackColor = System.Drawing.Color.Transparent;
            this.btn_Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Pause.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Pause.FlatAppearance.BorderSize = 0;
            this.btn_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pause.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pause.Location = new System.Drawing.Point(687, 170);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(85, 42);
            this.btn_Pause.TabIndex = 16;
            this.btn_Pause.Text = "Pause";
            this.btn_Pause.UseVisualStyleBackColor = false;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Continue
            // 
            this.btn_Continue.BackColor = System.Drawing.Color.Transparent;
            this.btn_Continue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Continue.Enabled = false;
            this.btn_Continue.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Continue.FlatAppearance.BorderSize = 0;
            this.btn_Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Continue.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Continue.Location = new System.Drawing.Point(687, 228);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(85, 42);
            this.btn_Continue.TabIndex = 17;
            this.btn_Continue.Text = "Continue";
            this.btn_Continue.UseVisualStyleBackColor = false;
            this.btn_Continue.Click += new System.EventHandler(this.btn_Continue_Click);
            // 
            // btn_Slow_Time
            // 
            this.btn_Slow_Time.BackColor = System.Drawing.Color.Transparent;
            this.btn_Slow_Time.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Slow_Time.Enabled = false;
            this.btn_Slow_Time.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Slow_Time.FlatAppearance.BorderSize = 0;
            this.btn_Slow_Time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Slow_Time.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Slow_Time.Location = new System.Drawing.Point(12, 287);
            this.btn_Slow_Time.Name = "btn_Slow_Time";
            this.btn_Slow_Time.Size = new System.Drawing.Size(85, 42);
            this.btn_Slow_Time.TabIndex = 18;
            this.btn_Slow_Time.Text = "Slow Time";
            this.btn_Slow_Time.UseVisualStyleBackColor = false;
            this.btn_Slow_Time.Click += new System.EventHandler(this.btn_Slow_Time_Click);
            // 
            // btn_Add_10
            // 
            this.btn_Add_10.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Add_10.Enabled = false;
            this.btn_Add_10.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Add_10.FlatAppearance.BorderSize = 0;
            this.btn_Add_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_10.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_10.Location = new System.Drawing.Point(12, 335);
            this.btn_Add_10.Name = "btn_Add_10";
            this.btn_Add_10.Size = new System.Drawing.Size(85, 42);
            this.btn_Add_10.TabIndex = 19;
            this.btn_Add_10.Text = "10";
            this.btn_Add_10.UseVisualStyleBackColor = false;
            this.btn_Add_10.Click += new System.EventHandler(this.btn_Add_10_Click);
            // 
            // btn_Add_20
            // 
            this.btn_Add_20.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add_20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Add_20.Enabled = false;
            this.btn_Add_20.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Add_20.FlatAppearance.BorderSize = 0;
            this.btn_Add_20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_20.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_20.Location = new System.Drawing.Point(12, 383);
            this.btn_Add_20.Name = "btn_Add_20";
            this.btn_Add_20.Size = new System.Drawing.Size(85, 42);
            this.btn_Add_20.TabIndex = 20;
            this.btn_Add_20.Text = "20";
            this.btn_Add_20.UseVisualStyleBackColor = false;
            this.btn_Add_20.Click += new System.EventHandler(this.btn_Add_20_Click);
            // 
            // btn_Add_25
            // 
            this.btn_Add_25.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add_25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Add_25.Enabled = false;
            this.btn_Add_25.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Add_25.FlatAppearance.BorderSize = 0;
            this.btn_Add_25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_25.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_25.Location = new System.Drawing.Point(12, 431);
            this.btn_Add_25.Name = "btn_Add_25";
            this.btn_Add_25.Size = new System.Drawing.Size(85, 42);
            this.btn_Add_25.TabIndex = 21;
            this.btn_Add_25.Text = "25";
            this.btn_Add_25.UseVisualStyleBackColor = false;
            this.btn_Add_25.Click += new System.EventHandler(this.btn_Add_25_Click);
            // 
            // lbl_Gold
            // 
            this.lbl_Gold.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Gold.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gold.Location = new System.Drawing.Point(674, 297);
            this.lbl_Gold.Name = "lbl_Gold";
            this.lbl_Gold.Size = new System.Drawing.Size(109, 66);
            this.lbl_Gold.TabIndex = 22;
            this.lbl_Gold.Text = "Your Gold:";
            this.lbl_Gold.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Frm_Level_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Gold);
            this.Controls.Add(this.btn_Add_25);
            this.Controls.Add(this.btn_Add_20);
            this.Controls.Add(this.btn_Add_10);
            this.Controls.Add(this.btn_Slow_Time);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.lbl_Record);
            this.Controls.Add(this.btn_Give_Up);
            this.Controls.Add(this.lbl_Notification);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.panel_Play);
            this.Controls.Add(this.lbl_Remain);
            this.Controls.Add(this.lbl_Turns);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.btn_Done);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Frm_Level_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level 2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_Level_1_Load);
            this.panel_Play.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Done;
        private System.Windows.Forms.Label Card_0;
        private System.Windows.Forms.Label Card_1;
        private System.Windows.Forms.Label Card_2;
        private System.Windows.Forms.Label Card_3;
        private System.Windows.Forms.Label lbl_End;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_Notification;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label lbl_Turns;
        private System.Windows.Forms.Label lbl_Remain;
        private System.Windows.Forms.Panel panel_Play;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Button btn_Give_Up;
        private System.Windows.Forms.Label lbl_Record;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button btn_Continue;
        private System.Windows.Forms.Button btn_Slow_Time;
        private System.Windows.Forms.Button btn_Add_10;
        private System.Windows.Forms.Button btn_Add_20;
        private System.Windows.Forms.Button btn_Add_25;
        private System.Windows.Forms.Label lbl_Gold;
        private System.Windows.Forms.Label Card_7;
        private System.Windows.Forms.Label Card_6;
        private System.Windows.Forms.Label Card_5;
        private System.Windows.Forms.Label Card_4;
    }
}