namespace Card_Match
{
    partial class Frm_Loading
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
            this.ProgressBar = new System.Windows.Forms.StatusStrip();
            this.Progress_Bar = new System.Windows.Forms.ToolStripProgressBar();
            this.lbl_Loading = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_progress_bar = new System.Windows.Forms.Timer(this.components);
            this.lbl_Click_To_Continue = new System.Windows.Forms.Label();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.ProgressBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.AutoSize = false;
            this.ProgressBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Progress_Bar,
            this.lbl_Loading});
            this.ProgressBar.Location = new System.Drawing.Point(0, 441);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(584, 20);
            this.ProgressBar.Stretch = false;
            this.ProgressBar.TabIndex = 0;
            this.ProgressBar.Text = "Loading";
            // 
            // Progress_Bar
            // 
            this.Progress_Bar.AutoSize = false;
            this.Progress_Bar.MarqueeAnimationSpeed = 10;
            this.Progress_Bar.Name = "Progress_Bar";
            this.Progress_Bar.Size = new System.Drawing.Size(400, 14);
            this.Progress_Bar.Step = 1;
            this.Progress_Bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // lbl_Loading
            // 
            this.lbl_Loading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Loading.Name = "lbl_Loading";
            this.lbl_Loading.Size = new System.Drawing.Size(50, 15);
            this.lbl_Loading.Text = "Loading";
            // 
            // timer_progress_bar
            // 
            this.timer_progress_bar.Interval = 50;
            this.timer_progress_bar.Tick += new System.EventHandler(this.timer_progress_bar_Tick);
            // 
            // lbl_Click_To_Continue
            // 
            this.lbl_Click_To_Continue.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Click_To_Continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Click_To_Continue.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Click_To_Continue.Location = new System.Drawing.Point(201, 391);
            this.lbl_Click_To_Continue.Name = "lbl_Click_To_Continue";
            this.lbl_Click_To_Continue.Size = new System.Drawing.Size(175, 25);
            this.lbl_Click_To_Continue.TabIndex = 1;
            this.lbl_Click_To_Continue.Text = "Click to continue";
            this.lbl_Click_To_Continue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Click_To_Continue.Click += new System.EventHandler(this.lbl_Click_To_Continue_Click);
            // 
            // lbl_Version
            // 
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Version.ForeColor = System.Drawing.Color.Red;
            this.lbl_Version.Location = new System.Drawing.Point(12, 428);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(70, 13);
            this.lbl_Version.TabIndex = 2;
            this.lbl_Version.Text = "version 2.2";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Name.Location = new System.Drawing.Point(183, 9);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(205, 27);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "Pokemon Card Match";
            // 
            // Frm_Loading
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.lbl_Click_To_Continue);
            this.Controls.Add(this.ProgressBar);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "Frm_Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card Match";
            this.Load += new System.EventHandler(this.Frm_Loading_Load);
            this.ProgressBar.ResumeLayout(false);
            this.ProgressBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ProgressBar;
        private System.Windows.Forms.ToolStripProgressBar Progress_Bar;
        private System.Windows.Forms.Timer timer_progress_bar;
        private System.Windows.Forms.Label lbl_Click_To_Continue;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Loading;
        private System.Windows.Forms.Label lbl_Version;
        private System.Windows.Forms.Label lbl_Name;
    }
}