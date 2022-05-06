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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.newTurnButton = new System.Windows.Forms.PictureBox();
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
            this.textBox_SaveFileName = new System.Windows.Forms.TextBox();
            this.button_NewSave = new System.Windows.Forms.Button();
            this.buttonx1 = new System.Windows.Forms.Button();
            this.buttonx10 = new System.Windows.Forms.Button();
            this.buttonx100 = new System.Windows.Forms.Button();
            this.buttonx1000 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListBox_SaveNew = new System.Windows.Forms.ListBox();
            this.soldierTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTurnButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soldierTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(46, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1414, 1110);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // button_exit
            // 
            this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.ForeColor = System.Drawing.Color.Yellow;
            this.button_exit.Location = new System.Drawing.Point(789, 1601);
            this.button_exit.Margin = new System.Windows.Forms.Padding(6);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(150, 52);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "exit";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(100, 931);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 67);
            this.button1.TabIndex = 8;
            this.button1.Text = "Load Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newTurnButton
            // 
            this.newTurnButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.newTurnButton.BackColor = System.Drawing.Color.Black;
            this.newTurnButton.InitialImage = null;
            this.newTurnButton.Location = new System.Drawing.Point(409, 1049);
            this.newTurnButton.Margin = new System.Windows.Forms.Padding(4);
            this.newTurnButton.Name = "newTurnButton";
            this.newTurnButton.Size = new System.Drawing.Size(410, 131);
            this.newTurnButton.TabIndex = 12;
            this.newTurnButton.TabStop = false;
            this.newTurnButton.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(563, 678);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 24);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonN
            // 
            this.buttonN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonN.ForeColor = System.Drawing.Color.Yellow;
            this.buttonN.Location = new System.Drawing.Point(563, 801);
            this.buttonN.Margin = new System.Windows.Forms.Padding(4);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(158, 44);
            this.buttonN.TabIndex = 16;
            this.buttonN.Text = "Attack N";
            this.buttonN.UseVisualStyleBackColor = false;
            this.buttonN.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // buttonE
            // 
            this.buttonE.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonE.ForeColor = System.Drawing.Color.Yellow;
            this.buttonE.Location = new System.Drawing.Point(761, 871);
            this.buttonE.Margin = new System.Windows.Forms.Padding(4);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(178, 48);
            this.buttonE.TabIndex = 17;
            this.buttonE.Text = "Attack E";
            this.buttonE.UseVisualStyleBackColor = false;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // buttonW
            // 
            this.buttonW.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonW.ForeColor = System.Drawing.Color.Yellow;
            this.buttonW.Location = new System.Drawing.Point(359, 871);
            this.buttonW.Margin = new System.Windows.Forms.Padding(4);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(158, 48);
            this.buttonW.TabIndex = 18;
            this.buttonW.Text = "Attack W";
            this.buttonW.UseVisualStyleBackColor = false;
            this.buttonW.Click += new System.EventHandler(this.buttonW_Click);
            // 
            // buttonS
            // 
            this.buttonS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonS.ForeColor = System.Drawing.Color.Yellow;
            this.buttonS.Location = new System.Drawing.Point(569, 965);
            this.buttonS.Margin = new System.Windows.Forms.Padding(4);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(152, 48);
            this.buttonS.TabIndex = 19;
            this.buttonS.Text = "Attack S";
            this.buttonS.UseVisualStyleBackColor = false;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(126, 1243);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 58);
            this.button2.TabIndex = 22;
            this.button2.Text = "Recruit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.ForeColor = System.Drawing.Color.Yellow;
            this.textBox2.Location = new System.Drawing.Point(563, 736);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 24);
            this.textBox2.TabIndex = 23;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(343, 742);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 38);
            this.label1.TabIndex = 25;
            this.label1.Text = "point gain";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(343, 684);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 46);
            this.label2.TabIndex = 26;
            this.label2.Text = "Soldiers on tile";
            // 
            // button_options
            // 
            this.button_options.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_options.ForeColor = System.Drawing.Color.Yellow;
            this.button_options.Location = new System.Drawing.Point(591, 1601);
            this.button_options.Margin = new System.Windows.Forms.Padding(6);
            this.button_options.Name = "button_options";
            this.button_options.Size = new System.Drawing.Size(150, 52);
            this.button_options.TabIndex = 27;
            this.button_options.Text = "options";
            this.button_options.UseVisualStyleBackColor = false;
            this.button_options.Click += new System.EventHandler(this.button_options_Click);
            // 
            // button_back
            // 
            this.button_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.ForeColor = System.Drawing.Color.Yellow;
            this.button_back.Location = new System.Drawing.Point(373, 1601);
            this.button_back.Margin = new System.Windows.Forms.Padding(6);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(172, 52);
            this.button_back.TabIndex = 28;
            this.button_back.Text = "back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Visible = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_SaveGame
            // 
            this.button_SaveGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_SaveGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SaveGame.ForeColor = System.Drawing.Color.Yellow;
            this.button_SaveGame.Location = new System.Drawing.Point(100, 1059);
            this.button_SaveGame.Margin = new System.Windows.Forms.Padding(6);
            this.button_SaveGame.Name = "button_SaveGame";
            this.button_SaveGame.Size = new System.Drawing.Size(186, 67);
            this.button_SaveGame.TabIndex = 30;
            this.button_SaveGame.Text = "Save Game";
            this.button_SaveGame.UseVisualStyleBackColor = false;
            this.button_SaveGame.Visible = false;
            this.button_SaveGame.Click += new System.EventHandler(this.button_SaveGame_Click);
            // 
            // textBox_SaveFileName
            // 
            this.textBox_SaveFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SaveFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox_SaveFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_SaveFileName.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_SaveFileName.Location = new System.Drawing.Point(553, 1455);
            this.textBox_SaveFileName.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_SaveFileName.Name = "textBox_SaveFileName";
            this.textBox_SaveFileName.Size = new System.Drawing.Size(200, 24);
            this.textBox_SaveFileName.TabIndex = 32;
            this.textBox_SaveFileName.Visible = false;
            // 
            // button_NewSave
            // 
            this.button_NewSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_NewSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_NewSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NewSave.ForeColor = System.Drawing.Color.Yellow;
            this.button_NewSave.Location = new System.Drawing.Point(373, 1451);
            this.button_NewSave.Margin = new System.Windows.Forms.Padding(6);
            this.button_NewSave.Name = "button_NewSave";
            this.button_NewSave.Size = new System.Drawing.Size(150, 44);
            this.button_NewSave.TabIndex = 33;
            this.button_NewSave.Text = "New Save file";
            this.button_NewSave.UseVisualStyleBackColor = false;
            this.button_NewSave.Visible = false;
            this.button_NewSave.Click += new System.EventHandler(this.button_NewSave_Click);
            // 
            // buttonx1
            // 
            this.buttonx1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonx1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonx1.ForeColor = System.Drawing.Color.Yellow;
            this.buttonx1.Location = new System.Drawing.Point(320, 1308);
            this.buttonx1.Margin = new System.Windows.Forms.Padding(6);
            this.buttonx1.Name = "buttonx1";
            this.buttonx1.Size = new System.Drawing.Size(150, 44);
            this.buttonx1.TabIndex = 34;
            this.buttonx1.Text = "x1";
            this.buttonx1.UseVisualStyleBackColor = false;
            this.buttonx1.Click += new System.EventHandler(this.buttonx1_Click);
            // 
            // buttonx10
            // 
            this.buttonx10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonx10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonx10.ForeColor = System.Drawing.Color.Yellow;
            this.buttonx10.Location = new System.Drawing.Point(492, 1308);
            this.buttonx10.Margin = new System.Windows.Forms.Padding(6);
            this.buttonx10.Name = "buttonx10";
            this.buttonx10.Size = new System.Drawing.Size(150, 44);
            this.buttonx10.TabIndex = 35;
            this.buttonx10.Text = "x10";
            this.buttonx10.UseVisualStyleBackColor = false;
            this.buttonx10.Click += new System.EventHandler(this.buttonx10_Click);
            // 
            // buttonx100
            // 
            this.buttonx100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonx100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonx100.ForeColor = System.Drawing.Color.Yellow;
            this.buttonx100.Location = new System.Drawing.Point(669, 1308);
            this.buttonx100.Margin = new System.Windows.Forms.Padding(6);
            this.buttonx100.Name = "buttonx100";
            this.buttonx100.Size = new System.Drawing.Size(150, 44);
            this.buttonx100.TabIndex = 36;
            this.buttonx100.Text = "x100";
            this.buttonx100.UseVisualStyleBackColor = false;
            this.buttonx100.Click += new System.EventHandler(this.buttonx100_Click);
            // 
            // buttonx1000
            // 
            this.buttonx1000.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonx1000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonx1000.ForeColor = System.Drawing.Color.Yellow;
            this.buttonx1000.Location = new System.Drawing.Point(844, 1308);
            this.buttonx1000.Margin = new System.Windows.Forms.Padding(6);
            this.buttonx1000.Name = "buttonx1000";
            this.buttonx1000.Size = new System.Drawing.Size(150, 44);
            this.buttonx1000.TabIndex = 37;
            this.buttonx1000.Text = "x1000";
            this.buttonx1000.UseMnemonic = false;
            this.buttonx1000.UseVisualStyleBackColor = false;
            this.buttonx1000.Click += new System.EventHandler(this.buttonx1000_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(79, 42);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1287, 570);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.ForeColor = System.Drawing.Color.Yellow;
            this.textBox3.Location = new System.Drawing.Point(314, 1260);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(308, 24);
            this.textBox3.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListBox_SaveNew);
            this.panel1.Controls.Add(this.soldierTrackBar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_NewSave);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox_SaveFileName);
            this.panel1.Controls.Add(this.textBox1);
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
            this.panel1.Controls.Add(this.buttonE);
            this.panel1.Controls.Add(this.buttonW);
            this.panel1.Controls.Add(this.buttonS);
            this.panel1.Controls.Add(this.newTurnButton);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(1468, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1445, 1678);
            this.panel1.TabIndex = 40;
            // 
            // ListBox_SaveNew
            // 
            this.ListBox_SaveNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ListBox_SaveNew.FormattingEnabled = true;
            this.ListBox_SaveNew.ItemHeight = 25;
            this.ListBox_SaveNew.Location = new System.Drawing.Point(553, 1367);
            this.ListBox_SaveNew.Name = "ListBox_SaveNew";
            this.ListBox_SaveNew.Size = new System.Drawing.Size(200, 79);
            this.ListBox_SaveNew.TabIndex = 41;
            this.ListBox_SaveNew.Visible = false;
            // 
            // soldierTrackBar
            // 
            this.soldierTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.soldierTrackBar.Location = new System.Drawing.Point(527, 865);
            this.soldierTrackBar.Margin = new System.Windows.Forms.Padding(6);
            this.soldierTrackBar.Name = "soldierTrackBar";
            this.soldierTrackBar.Size = new System.Drawing.Size(212, 90);
            this.soldierTrackBar.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(103)))), ((int)(((byte)(12)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2884, 1759);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTurnButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soldierTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TrackBar soldierTrackBar;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.Button buttonx1;
        private System.Windows.Forms.Button buttonx10;
        private System.Windows.Forms.Button buttonx100;
        private System.Windows.Forms.Button buttonx1000;

        private System.Windows.Forms.Button button_NewSave;

        private System.Windows.Forms.TextBox textBox_SaveFileName;

        internal static System.Windows.Forms.ListBox listBox_Save;

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

        private System.Windows.Forms.PictureBox newTurnButton;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button button_exit;

        #endregion

        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox ListBox_SaveNew;
    }
}

