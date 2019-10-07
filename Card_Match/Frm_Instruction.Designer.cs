namespace Card_Match
{
    partial class Frm_Instruction
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Scoring_Method = new System.Windows.Forms.Button();
            this.btn_Tips = new System.Windows.Forms.Button();
            this.btn_Rule = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.btn_Scoring_Method);
            this.panel1.Controls.Add(this.btn_Tips);
            this.panel1.Controls.Add(this.btn_Rule);
            this.panel1.Location = new System.Drawing.Point(28, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 391);
            this.panel1.TabIndex = 0;
            // 
            // btn_Back
            // 
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(39, 249);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(163, 43);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Scoring_Method
            // 
            this.btn_Scoring_Method.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Scoring_Method.FlatAppearance.BorderSize = 0;
            this.btn_Scoring_Method.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Scoring_Method.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Scoring_Method.Location = new System.Drawing.Point(39, 96);
            this.btn_Scoring_Method.Name = "btn_Scoring_Method";
            this.btn_Scoring_Method.Size = new System.Drawing.Size(163, 69);
            this.btn_Scoring_Method.TabIndex = 2;
            this.btn_Scoring_Method.Text = "Scoring Method";
            this.btn_Scoring_Method.UseVisualStyleBackColor = true;
            this.btn_Scoring_Method.Click += new System.EventHandler(this.btn_Scoring_Method_Click);
            // 
            // btn_Tips
            // 
            this.btn_Tips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Tips.FlatAppearance.BorderSize = 0;
            this.btn_Tips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tips.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tips.Location = new System.Drawing.Point(39, 186);
            this.btn_Tips.Name = "btn_Tips";
            this.btn_Tips.Size = new System.Drawing.Size(163, 43);
            this.btn_Tips.TabIndex = 1;
            this.btn_Tips.Text = "Tips";
            this.btn_Tips.UseVisualStyleBackColor = true;
            this.btn_Tips.Click += new System.EventHandler(this.btn_Tips_Click);
            // 
            // btn_Rule
            // 
            this.btn_Rule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Rule.FlatAppearance.BorderSize = 0;
            this.btn_Rule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rule.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rule.Location = new System.Drawing.Point(39, 35);
            this.btn_Rule.Name = "btn_Rule";
            this.btn_Rule.Size = new System.Drawing.Size(163, 43);
            this.btn_Rule.TabIndex = 0;
            this.btn_Rule.Text = "Rule";
            this.btn_Rule.UseVisualStyleBackColor = true;
            this.btn_Rule.Click += new System.EventHandler(this.btn_Rule_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tbox);
            this.panel2.Location = new System.Drawing.Point(314, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 391);
            this.panel2.TabIndex = 1;
            // 
            // tbox
            // 
            this.tbox.BackColor = System.Drawing.Color.SandyBrown;
            this.tbox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox.Location = new System.Drawing.Point(3, 3);
            this.tbox.Multiline = true;
            this.tbox.Name = "tbox";
            this.tbox.ReadOnly = true;
            this.tbox.Size = new System.Drawing.Size(232, 381);
            this.tbox.TabIndex = 0;
            // 
            // Frm_Instruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Frm_Instruction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instruction";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Scoring_Method;
        private System.Windows.Forms.Button btn_Tips;
        private System.Windows.Forms.Button btn_Rule;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbox;
        private System.Windows.Forms.Button btn_Back;
    }
}