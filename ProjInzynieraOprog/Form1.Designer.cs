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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox_coordinates = new System.Windows.Forms.RichTextBox();
            this.label_Coordinates = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.richTextBox_PointGain = new System.Windows.Forms.RichTextBox();
            this.label_PointGain = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.newTurnButton = new System.Windows.Forms.PictureBox();
            this.soldierTrackBar = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.recrutingTrackBar = new System.Windows.Forms.TrackBar();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.newTurnButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.soldierTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.recrutingTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(35, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(707, 577);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // richTextBox_coordinates
            // 
            this.richTextBox_coordinates.Enabled = false;
            this.richTextBox_coordinates.Location = new System.Drawing.Point(936, 50);
            this.richTextBox_coordinates.Name = "richTextBox_coordinates";
            this.richTextBox_coordinates.Size = new System.Drawing.Size(111, 21);
            this.richTextBox_coordinates.TabIndex = 2;
            this.richTextBox_coordinates.Text = "";
            // 
            // label_Coordinates
            // 
            this.label_Coordinates.Location = new System.Drawing.Point(830, 53);
            this.label_Coordinates.Name = "label_Coordinates";
            this.label_Coordinates.Size = new System.Drawing.Size(100, 23);
            this.label_Coordinates.TabIndex = 3;
            this.label_Coordinates.Text = "Coordinates";
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(1012, 590);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 26);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // richTextBox_PointGain
            // 
            this.richTextBox_PointGain.Enabled = false;
            this.richTextBox_PointGain.Location = new System.Drawing.Point(936, 93);
            this.richTextBox_PointGain.Name = "richTextBox_PointGain";
            this.richTextBox_PointGain.Size = new System.Drawing.Size(111, 21);
            this.richTextBox_PointGain.TabIndex = 6;
            this.richTextBox_PointGain.Text = "";
            // 
            // label_PointGain
            // 
            this.label_PointGain.Location = new System.Drawing.Point(830, 96);
            this.label_PointGain.Name = "label_PointGain";
            this.label_PointGain.Size = new System.Drawing.Size(100, 23);
            this.label_PointGain.TabIndex = 7;
            this.label_PointGain.Text = "Point gain";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(889, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generate new map";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(910, 512);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 22);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Big Map";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(910, 540);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 19);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "Medium Map";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(910, 565);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(86, 21);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.Text = "Small Map";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // newTurnButton
            // 
            this.newTurnButton.Image = ((System.Drawing.Image) (resources.GetObject("newTurnButton.Image")));
            this.newTurnButton.InitialImage = ((System.Drawing.Image) (resources.GetObject("newTurnButton.InitialImage")));
            this.newTurnButton.Location = new System.Drawing.Point(853, 398);
            this.newTurnButton.Margin = new System.Windows.Forms.Padding(2);
            this.newTurnButton.Name = "newTurnButton";
            this.newTurnButton.Size = new System.Drawing.Size(205, 68);
            this.newTurnButton.TabIndex = 12;
            this.newTurnButton.TabStop = false;
            this.newTurnButton.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // soldierTrackBar
            // 
            this.soldierTrackBar.Location = new System.Drawing.Point(880, 317);
            this.soldierTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.soldierTrackBar.Name = "soldierTrackBar";
            this.soldierTrackBar.Size = new System.Drawing.Size(116, 45);
            this.soldierTrackBar.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(899, 248);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 20);
            this.textBox1.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonN
            // 
            this.buttonN.Location = new System.Drawing.Point(899, 281);
            this.buttonN.Margin = new System.Windows.Forms.Padding(2);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(79, 23);
            this.buttonN.TabIndex = 16;
            this.buttonN.Text = "Attack N";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // buttonE
            // 
            this.buttonE.Location = new System.Drawing.Point(998, 317);
            this.buttonE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(89, 25);
            this.buttonE.TabIndex = 17;
            this.buttonE.Text = "Attack E";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // buttonW
            // 
            this.buttonW.Location = new System.Drawing.Point(797, 317);
            this.buttonW.Margin = new System.Windows.Forms.Padding(2);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(79, 25);
            this.buttonW.TabIndex = 18;
            this.buttonW.Text = "Attack W";
            this.buttonW.UseVisualStyleBackColor = true;
            this.buttonW.Click += new System.EventHandler(this.buttonW_Click);
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(899, 346);
            this.buttonS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(76, 24);
            this.buttonS.TabIndex = 19;
            this.buttonS.Text = "Attack S";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(936, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(108, 28);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // recrutingTrackBar
            // 
            this.recrutingTrackBar.Location = new System.Drawing.Point(797, 640);
            this.recrutingTrackBar.Name = "recrutingTrackBar";
            this.recrutingTrackBar.Size = new System.Drawing.Size(92, 45);
            this.recrutingTrackBar.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(797, 607);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 27);
            this.button2.TabIndex = 22;
            this.button2.Text = "Recruit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(937, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 20);
            this.textBox2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(825, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 40);
            this.label1.TabIndex = 25;
            this.label1.Text = "Overall player points";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(825, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 26;
            this.label2.Text = "Soldiers on tile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (158)))), ((int) (((byte) (103)))), ((int) (((byte) (12)))));
            this.ClientSize = new System.Drawing.Size(1188, 716);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.recrutingTrackBar);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonW);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.soldierTrackBar);
            this.Controls.Add(this.newTurnButton);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_PointGain);
            this.Controls.Add(this.richTextBox_PointGain);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label_Coordinates);
            this.Controls.Add(this.richTextBox_coordinates);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.newTurnButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.soldierTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.recrutingTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.TrackBar recrutingTrackBar;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.RichTextBox richTextBox1;

        private System.Windows.Forms.HelpProvider helpProvider1;

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonS;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.TrackBar soldierTrackBar;

        private System.Windows.Forms.PictureBox newTurnButton;

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.RichTextBox richTextBox_PointGain;
        private System.Windows.Forms.Label label_PointGain;

        private System.Windows.Forms.Button button_exit;

        private System.Windows.Forms.Label label_Coordinates;
        private System.Windows.Forms.RichTextBox richTextBox_coordinates;

        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

