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
            this.button_exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.newTurnButton = new System.Windows.Forms.PictureBox();
            this.soldierTrackBar = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_options = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_SaveGame = new System.Windows.Forms.Button();
            this.listBox_Save = new System.Windows.Forms.ListBox();
            this.textBox_SaveFileName = new System.Windows.Forms.TextBox();
            this.button_NewSave = new System.Windows.Forms.Button();
            this.buttonx1 = new System.Windows.Forms.Button();
            this.buttonx10 = new System.Windows.Forms.Button();
            this.buttonx100 = new System.Windows.Forms.Button();
            this.buttonx1000 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.newTurnButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.soldierTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(23, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(707, 577);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // button_exit
            // 
            this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exit.Location = new System.Drawing.Point(553, 979);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 27);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(345, 769);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Load Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newTurnButton
            // 
            this.newTurnButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.newTurnButton.BackColor = System.Drawing.Color.Black;
            this.newTurnButton.InitialImage = null;
            this.newTurnButton.Location = new System.Drawing.Point(345, 673);
            this.newTurnButton.Margin = new System.Windows.Forms.Padding(2);
            this.newTurnButton.Name = "newTurnButton";
            this.newTurnButton.Size = new System.Drawing.Size(205, 68);
            this.newTurnButton.TabIndex = 12;
            this.newTurnButton.TabStop = false;
            this.newTurnButton.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // soldierTrackBar
            // 
            this.soldierTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.soldierTrackBar.Location = new System.Drawing.Point(421, 526);
            this.soldierTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.soldierTrackBar.Name = "soldierTrackBar";
            this.soldierTrackBar.Size = new System.Drawing.Size(116, 45);
            this.soldierTrackBar.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.Location = new System.Drawing.Point(440, 426);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 14;
            // 
            // buttonN
            // 
            this.buttonN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonN.Location = new System.Drawing.Point(440, 490);
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
            this.buttonE.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonE.Location = new System.Drawing.Point(539, 526);
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
            this.buttonW.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonW.Location = new System.Drawing.Point(338, 526);
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
            this.buttonS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonS.Location = new System.Drawing.Point(443, 575);
            this.buttonS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(76, 25);
            this.buttonS.TabIndex = 19;
            this.buttonS.Text = "Attack S";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Location = new System.Drawing.Point(533, 618);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 20);
            this.button2.TabIndex = 22;
            this.button2.Text = "Recruit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(440, 456);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 20);
            this.textBox2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.Location = new System.Drawing.Point(330, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "point gain";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.Location = new System.Drawing.Point(330, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Soldiers on tile";
            // 
            // button_options
            // 
            this.button_options.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_options.Location = new System.Drawing.Point(454, 979);
            this.button_options.Name = "button_options";
            this.button_options.Size = new System.Drawing.Size(75, 27);
            this.button_options.TabIndex = 27;
            this.button_options.Text = "options";
            this.button_options.UseVisualStyleBackColor = true;
            this.button_options.Click += new System.EventHandler(this.button_options_Click);
            // 
            // button_back
            // 
            this.button_back.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_back.Location = new System.Drawing.Point(345, 979);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(86, 27);
            this.button_back.TabIndex = 28;
            this.button_back.Text = "back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Visible = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_SaveGame
            // 
            this.button_SaveGame.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SaveGame.Location = new System.Drawing.Point(458, 769);
            this.button_SaveGame.Name = "button_SaveGame";
            this.button_SaveGame.Size = new System.Drawing.Size(93, 35);
            this.button_SaveGame.TabIndex = 30;
            this.button_SaveGame.Text = "Save Game";
            this.button_SaveGame.UseVisualStyleBackColor = true;
            this.button_SaveGame.Visible = false;
            this.button_SaveGame.Click += new System.EventHandler(this.button_SaveGame_Click);
            // 
            // listBox_Save
            // 
            this.listBox_Save.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_Save.FormattingEnabled = true;
            this.listBox_Save.Location = new System.Drawing.Point(345, 825);
            this.listBox_Save.Name = "listBox_Save";
            this.listBox_Save.Size = new System.Drawing.Size(120, 69);
            this.listBox_Save.TabIndex = 31;
            this.listBox_Save.Visible = false;
            // 
            // textBox_SaveFileName
            // 
            this.textBox_SaveFileName.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SaveFileName.Location = new System.Drawing.Point(435, 903);
            this.textBox_SaveFileName.Name = "textBox_SaveFileName";
            this.textBox_SaveFileName.Size = new System.Drawing.Size(100, 20);
            this.textBox_SaveFileName.TabIndex = 32;
            this.textBox_SaveFileName.Visible = false;
            // 
            // button_NewSave
            // 
            this.button_NewSave.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_NewSave.Location = new System.Drawing.Point(345, 901);
            this.button_NewSave.Name = "button_NewSave";
            this.button_NewSave.Size = new System.Drawing.Size(75, 23);
            this.button_NewSave.TabIndex = 33;
            this.button_NewSave.Text = "New Save file";
            this.button_NewSave.UseVisualStyleBackColor = true;
            this.button_NewSave.Visible = false;
            this.button_NewSave.Click += new System.EventHandler(this.button_NewSave_Click);
            // 
            // buttonx1
            // 
            this.buttonx1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonx1.Location = new System.Drawing.Point(306, 645);
            this.buttonx1.Name = "buttonx1";
            this.buttonx1.Size = new System.Drawing.Size(75, 23);
            this.buttonx1.TabIndex = 34;
            this.buttonx1.Text = "x1";
            this.buttonx1.UseVisualStyleBackColor = true;
            this.buttonx1.Click += new System.EventHandler(this.buttonx1_Click);
            // 
            // buttonx10
            // 
            this.buttonx10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonx10.Location = new System.Drawing.Point(387, 645);
            this.buttonx10.Name = "buttonx10";
            this.buttonx10.Size = new System.Drawing.Size(75, 23);
            this.buttonx10.TabIndex = 35;
            this.buttonx10.Text = "x10";
            this.buttonx10.UseVisualStyleBackColor = true;
            this.buttonx10.Click += new System.EventHandler(this.buttonx10_Click);
            // 
            // buttonx100
            // 
            this.buttonx100.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonx100.Location = new System.Drawing.Point(466, 645);
            this.buttonx100.Name = "buttonx100";
            this.buttonx100.Size = new System.Drawing.Size(75, 23);
            this.buttonx100.TabIndex = 36;
            this.buttonx100.Text = "x100";
            this.buttonx100.UseVisualStyleBackColor = true;
            this.buttonx100.Click += new System.EventHandler(this.buttonx100_Click);
            // 
            // buttonx1000
            // 
            this.buttonx1000.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonx1000.Location = new System.Drawing.Point(547, 645);
            this.buttonx1000.Name = "buttonx1000";
            this.buttonx1000.Size = new System.Drawing.Size(75, 23);
            this.buttonx1000.TabIndex = 37;
            this.buttonx1000.Text = "x1000";
            this.buttonx1000.UseMnemonic = false;
            this.buttonx1000.UseVisualStyleBackColor = true;
            this.buttonx1000.Click += new System.EventHandler(this.buttonx1000_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(50, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 400);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(308, 619);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(154, 20);
            this.textBox3.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_NewSave);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox_SaveFileName);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.listBox_Save);
            this.panel1.Controls.Add(this.buttonx1000);
            this.panel1.Controls.Add(this.button_SaveGame);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button_back);
            this.panel1.Controls.Add(this.buttonx100);
            this.panel1.Controls.Add(this.button_options);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Controls.Add(this.buttonx10);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.buttonx1);
            this.panel1.Controls.Add(this.buttonN);
            this.panel1.Controls.Add(this.soldierTrackBar);
            this.panel1.Controls.Add(this.buttonE);
            this.panel1.Controls.Add(this.buttonW);
            this.panel1.Controls.Add(this.buttonS);
            this.panel1.Controls.Add(this.newTurnButton);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(735, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 1019);
            this.panel1.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (158)))), ((int) (((byte) (103)))), ((int) (((byte) (12)))));
            this.ClientSize = new System.Drawing.Size(1298, 1061);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.newTurnButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.soldierTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.Button buttonx1;
        private System.Windows.Forms.Button buttonx10;
        private System.Windows.Forms.Button buttonx100;
        private System.Windows.Forms.Button buttonx1000;

        private System.Windows.Forms.Button button_NewSave;

        private System.Windows.Forms.TextBox textBox_SaveFileName;

        private System.Windows.Forms.ListBox listBox_Save;

        private System.Windows.Forms.Button button_SaveGame;

        private System.Windows.Forms.Button button_back;

        private System.Windows.Forms.Button button_options;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonS;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.TrackBar soldierTrackBar;

        private System.Windows.Forms.PictureBox newTurnButton;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button button_exit;

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
       
    }
}

