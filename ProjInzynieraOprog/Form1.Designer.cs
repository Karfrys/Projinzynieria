namespace ProjInzynieraOprog
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox_coordinates = new System.Windows.Forms.RichTextBox();
            this.label_Coordinates = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_attack = new System.Windows.Forms.Button();
            this.richTextBox_PointGain = new System.Windows.Forms.RichTextBox();
            this.label_PointGain = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(72, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1414, 1110);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // richTextBox_coordinates
            // 
            this.richTextBox_coordinates.Enabled = false;
            this.richTextBox_coordinates.Location = new System.Drawing.Point(1872, 96);
            this.richTextBox_coordinates.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.richTextBox_coordinates.Name = "richTextBox_coordinates";
            this.richTextBox_coordinates.Size = new System.Drawing.Size(218, 37);
            this.richTextBox_coordinates.TabIndex = 2;
            this.richTextBox_coordinates.Text = "";
            // 
            // label_Coordinates
            // 
            this.label_Coordinates.Location = new System.Drawing.Point(1660, 102);
            this.label_Coordinates.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Coordinates.Name = "label_Coordinates";
            this.label_Coordinates.Size = new System.Drawing.Size(200, 44);
            this.label_Coordinates.TabIndex = 3;
            this.label_Coordinates.Text = "Coordinates";
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(2024, 1135);
            this.button_exit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(150, 50);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_attack
            // 
            this.button_attack.Location = new System.Drawing.Point(1800, 392);
            this.button_attack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_attack.Name = "button_attack";
            this.button_attack.Size = new System.Drawing.Size(150, 44);
            this.button_attack.TabIndex = 5;
            this.button_attack.Text = "Attack";
            this.button_attack.UseVisualStyleBackColor = true;
            this.button_attack.Click += new System.EventHandler(this.button_attack_Click);
            // 
            // richTextBox_PointGain
            // 
            this.richTextBox_PointGain.Enabled = false;
            this.richTextBox_PointGain.Location = new System.Drawing.Point(1872, 179);
            this.richTextBox_PointGain.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.richTextBox_PointGain.Name = "richTextBox_PointGain";
            this.richTextBox_PointGain.Size = new System.Drawing.Size(218, 37);
            this.richTextBox_PointGain.TabIndex = 6;
            this.richTextBox_PointGain.Text = "";
            // 
            // label_PointGain
            // 
            this.label_PointGain.Location = new System.Drawing.Point(1660, 185);
            this.label_PointGain.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_PointGain.Name = "label_PointGain";
            this.label_PointGain.Size = new System.Drawing.Size(200, 44);
            this.label_PointGain.TabIndex = 7;
            this.label_PointGain.Text = "Point gain";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1778, 906);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 67);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(1820, 985);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(160, 42);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Big Map";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(1820, 1038);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(220, 37);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "Medium Map";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(1820, 1087);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(172, 40);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.Text = "Small Map";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2198, 1202);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_PointGain);
            this.Controls.Add(this.richTextBox_PointGain);
            this.Controls.Add(this.button_attack);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label_Coordinates);
            this.Controls.Add(this.richTextBox_coordinates);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.RichTextBox richTextBox_PointGain;
        private System.Windows.Forms.Label label_PointGain;

        private System.Windows.Forms.Button button_attack;

        private System.Windows.Forms.Button button_exit;

        private System.Windows.Forms.Label label_Coordinates;
        private System.Windows.Forms.RichTextBox richTextBox_coordinates;

        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

