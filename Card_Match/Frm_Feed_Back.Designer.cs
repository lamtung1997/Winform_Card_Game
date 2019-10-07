namespace Card_Match
{
    partial class Frm_Feed_Back
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
            this.lbl_Satisfaction_Level = new System.Windows.Forms.Label();
            this.tbox_Problem = new System.Windows.Forms.TextBox();
            this.tbox_Comment = new System.Windows.Forms.TextBox();
            this.lbl_Problem = new System.Windows.Forms.Label();
            this.lbl_Comment = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Emoji = new System.Windows.Forms.Label();
            this.lbl_Star_1 = new System.Windows.Forms.Label();
            this.lbl_Star_5 = new System.Windows.Forms.Label();
            this.lbl_Star_3 = new System.Windows.Forms.Label();
            this.lbl_Star_4 = new System.Windows.Forms.Label();
            this.lbl_Star_2 = new System.Windows.Forms.Label();
            this.lbl_Thank_You = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Satisfaction_Level
            // 
            this.lbl_Satisfaction_Level.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Satisfaction_Level.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Satisfaction_Level.Location = new System.Drawing.Point(223, 39);
            this.lbl_Satisfaction_Level.Name = "lbl_Satisfaction_Level";
            this.lbl_Satisfaction_Level.Size = new System.Drawing.Size(143, 34);
            this.lbl_Satisfaction_Level.TabIndex = 2;
            this.lbl_Satisfaction_Level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbox_Problem
            // 
            this.tbox_Problem.Location = new System.Drawing.Point(69, 228);
            this.tbox_Problem.Multiline = true;
            this.tbox_Problem.Name = "tbox_Problem";
            this.tbox_Problem.Size = new System.Drawing.Size(442, 46);
            this.tbox_Problem.TabIndex = 3;
            this.tbox_Problem.Visible = false;
            // 
            // tbox_Comment
            // 
            this.tbox_Comment.Location = new System.Drawing.Point(69, 318);
            this.tbox_Comment.Multiline = true;
            this.tbox_Comment.Name = "tbox_Comment";
            this.tbox_Comment.Size = new System.Drawing.Size(442, 46);
            this.tbox_Comment.TabIndex = 4;
            this.tbox_Comment.Visible = false;
            // 
            // lbl_Problem
            // 
            this.lbl_Problem.AutoSize = true;
            this.lbl_Problem.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Problem.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Problem.Location = new System.Drawing.Point(66, 209);
            this.lbl_Problem.Name = "lbl_Problem";
            this.lbl_Problem.Size = new System.Drawing.Size(121, 16);
            this.lbl_Problem.TabIndex = 5;
            this.lbl_Problem.Text = "What\'s your problem";
            this.lbl_Problem.Visible = false;
            // 
            // lbl_Comment
            // 
            this.lbl_Comment.AutoSize = true;
            this.lbl_Comment.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Comment.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Comment.Location = new System.Drawing.Point(66, 299);
            this.lbl_Comment.Name = "lbl_Comment";
            this.lbl_Comment.Size = new System.Drawing.Size(84, 16);
            this.lbl_Comment.TabIndex = 6;
            this.lbl_Comment.Text = "Your comment";
            this.lbl_Comment.Visible = false;
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.Color.Transparent;
            this.btn_Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Send.FlatAppearance.BorderSize = 0;
            this.btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Send.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.Location = new System.Drawing.Point(413, 404);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(97, 33);
            this.btn_Send.TabIndex = 7;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Visible = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(69, 404);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(97, 33);
            this.btn_Back.TabIndex = 8;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_Emoji
            // 
            this.lbl_Emoji.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Emoji.Location = new System.Drawing.Point(272, 141);
            this.lbl_Emoji.Name = "lbl_Emoji";
            this.lbl_Emoji.Size = new System.Drawing.Size(50, 50);
            this.lbl_Emoji.TabIndex = 0;
            this.lbl_Emoji.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Star_1
            // 
            this.lbl_Star_1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Star_1.Location = new System.Drawing.Point(174, 89);
            this.lbl_Star_1.Name = "lbl_Star_1";
            this.lbl_Star_1.Size = new System.Drawing.Size(45, 43);
            this.lbl_Star_1.TabIndex = 9;
            this.lbl_Star_1.Click += new System.EventHandler(this.lbl_Star_1_Click);
            this.lbl_Star_1.MouseLeave += new System.EventHandler(this.lbl_Star_1_MouseLeave);
            this.lbl_Star_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_Star_1_MouseMove);
            // 
            // lbl_Star_5
            // 
            this.lbl_Star_5.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Star_5.Location = new System.Drawing.Point(371, 89);
            this.lbl_Star_5.Name = "lbl_Star_5";
            this.lbl_Star_5.Size = new System.Drawing.Size(45, 43);
            this.lbl_Star_5.TabIndex = 14;
            this.lbl_Star_5.Click += new System.EventHandler(this.lbl_Star_5_Click);
            this.lbl_Star_5.MouseLeave += new System.EventHandler(this.lbl_Star_5_MouseLeave);
            this.lbl_Star_5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_Star_5_MouseMove);
            // 
            // lbl_Star_3
            // 
            this.lbl_Star_3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Star_3.Location = new System.Drawing.Point(272, 89);
            this.lbl_Star_3.Name = "lbl_Star_3";
            this.lbl_Star_3.Size = new System.Drawing.Size(45, 43);
            this.lbl_Star_3.TabIndex = 12;
            this.lbl_Star_3.Click += new System.EventHandler(this.lbl_Star_3_Click);
            this.lbl_Star_3.MouseLeave += new System.EventHandler(this.lbl_Star_3_MouseLeave);
            this.lbl_Star_3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_Star_3_MouseMove);
            // 
            // lbl_Star_4
            // 
            this.lbl_Star_4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Star_4.Location = new System.Drawing.Point(322, 89);
            this.lbl_Star_4.Name = "lbl_Star_4";
            this.lbl_Star_4.Size = new System.Drawing.Size(45, 43);
            this.lbl_Star_4.TabIndex = 13;
            this.lbl_Star_4.Click += new System.EventHandler(this.lbl_Star_4_Click);
            this.lbl_Star_4.MouseLeave += new System.EventHandler(this.lbl_Star_4_MouseLeave);
            this.lbl_Star_4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_Star_4_MouseMove);
            // 
            // lbl_Star_2
            // 
            this.lbl_Star_2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Star_2.Location = new System.Drawing.Point(223, 89);
            this.lbl_Star_2.Name = "lbl_Star_2";
            this.lbl_Star_2.Size = new System.Drawing.Size(45, 43);
            this.lbl_Star_2.TabIndex = 11;
            this.lbl_Star_2.Click += new System.EventHandler(this.lbl_Star_2_Click);
            this.lbl_Star_2.MouseLeave += new System.EventHandler(this.lbl_Star_2_MouseLeave);
            this.lbl_Star_2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_Star_2_MouseMove);
            // 
            // lbl_Thank_You
            // 
            this.lbl_Thank_You.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Thank_You.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Thank_You.Location = new System.Drawing.Point(225, 89);
            this.lbl_Thank_You.Name = "lbl_Thank_You";
            this.lbl_Thank_You.Size = new System.Drawing.Size(143, 34);
            this.lbl_Thank_You.TabIndex = 15;
            this.lbl_Thank_You.Text = "Thank You !!!";
            this.lbl_Thank_You.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Thank_You.Visible = false;
            // 
            // Frm_Feed_Back
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Thank_You);
            this.Controls.Add(this.lbl_Star_5);
            this.Controls.Add(this.lbl_Star_4);
            this.Controls.Add(this.lbl_Star_3);
            this.Controls.Add(this.lbl_Star_2);
            this.Controls.Add(this.lbl_Star_1);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.lbl_Comment);
            this.Controls.Add(this.lbl_Problem);
            this.Controls.Add(this.tbox_Comment);
            this.Controls.Add(this.tbox_Problem);
            this.Controls.Add(this.lbl_Satisfaction_Level);
            this.Controls.Add(this.lbl_Emoji);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Frm_Feed_Back";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feed Back";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Satisfaction_Level;
        private System.Windows.Forms.TextBox tbox_Problem;
        private System.Windows.Forms.TextBox tbox_Comment;
        private System.Windows.Forms.Label lbl_Problem;
        private System.Windows.Forms.Label lbl_Comment;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_Emoji;
        private System.Windows.Forms.Label lbl_Star_1;
        private System.Windows.Forms.Label lbl_Star_5;
        private System.Windows.Forms.Label lbl_Star_3;
        private System.Windows.Forms.Label lbl_Star_4;
        private System.Windows.Forms.Label lbl_Star_2;
        private System.Windows.Forms.Label lbl_Thank_You;
    }
}