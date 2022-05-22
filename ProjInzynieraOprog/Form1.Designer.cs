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
            this.button_options = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_SaveGame = new System.Windows.Forms.Button();
            this.textBox_SaveFileName = new System.Windows.Forms.TextBox();
            this.button_NewSave = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.upgradecosttextbox = new System.Windows.Forms.TextBox();
            this.upgradeButton = new System.Windows.Forms.Button();
            this.upgradecostlabel = new System.Windows.Forms.Label();
            this.soldierTrackBar = new System.Windows.Forms.TrackBar();
            this.ListBox_SaveNew = new System.Windows.Forms.ListBox();
            this.LogBook = new System.Windows.Forms.RichTextBox();
            this.TotalPointsLabel = new System.Windows.Forms.Label();
            this.AllPointsTextBox = new System.Windows.Forms.TextBox();
            this.TotalPointsTextBox = new System.Windows.Forms.TextBox();
            this.TotalPointGain = new System.Windows.Forms.Label();
            this.buttonRecruit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newTurnButton = new System.Windows.Forms.PictureBox();
            this.tileIDlabel = new System.Windows.Forms.Label();
            this.tileIDtextbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soldierTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTurnButton)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // button_exit
            // 
            this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.ForeColor = System.Drawing.Color.Yellow;
            this.button_exit.Location = new System.Drawing.Point(788, 1602);
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
            this.button1.Location = new System.Drawing.Point(320, 1260);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 94);
            this.button1.TabIndex = 8;
            this.button1.Text = "Load Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_options
            // 
            this.button_options.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_options.ForeColor = System.Drawing.Color.Yellow;
            this.button_options.Location = new System.Drawing.Point(592, 1602);
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
            this.button_back.Location = new System.Drawing.Point(372, 1602);
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
            this.button_SaveGame.Location = new System.Drawing.Point(320, 1365);
            this.button_SaveGame.Margin = new System.Windows.Forms.Padding(6);
            this.button_SaveGame.Name = "button_SaveGame";
            this.button_SaveGame.Size = new System.Drawing.Size(202, 73);
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
            this.textBox_SaveFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_SaveFileName.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_SaveFileName.Location = new System.Drawing.Point(542, 1488);
            this.textBox_SaveFileName.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_SaveFileName.Name = "textBox_SaveFileName";
            this.textBox_SaveFileName.Size = new System.Drawing.Size(230, 37);
            this.textBox_SaveFileName.TabIndex = 32;
            this.textBox_SaveFileName.Visible = false;
            // 
            // button_NewSave
            // 
            this.button_NewSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_NewSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_NewSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NewSave.ForeColor = System.Drawing.Color.Yellow;
            this.button_NewSave.Location = new System.Drawing.Point(320, 1452);
            this.button_NewSave.Margin = new System.Windows.Forms.Padding(6);
            this.button_NewSave.Name = "button_NewSave";
            this.button_NewSave.Size = new System.Drawing.Size(202, 73);
            this.button_NewSave.TabIndex = 33;
            this.button_NewSave.Text = "New Save file";
            this.button_NewSave.UseVisualStyleBackColor = false;
            this.button_NewSave.Visible = false;
            this.button_NewSave.Click += new System.EventHandler(this.button_NewSave_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox3.ForeColor = System.Drawing.Color.Yellow;
            this.textBox3.Location = new System.Drawing.Point(428, 474);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(220, 34);
            this.textBox3.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.upgradecosttextbox);
            this.panel1.Controls.Add(this.upgradeButton);
            this.panel1.Controls.Add(this.upgradecostlabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.soldierTrackBar);
            this.panel1.Controls.Add(this.ListBox_SaveNew);
            this.panel1.Controls.Add(this.button_NewSave);
            this.panel1.Controls.Add(this.textBox_SaveFileName);
            this.panel1.Controls.Add(this.button_SaveGame);
            this.panel1.Controls.Add(this.button_back);
            this.panel1.Controls.Add(this.button_options);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Location = new System.Drawing.Point(1468, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1444, 1679);
            this.panel1.TabIndex = 40;
            // 
            // upgradecosttextbox
            // 
            this.upgradecosttextbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.upgradecosttextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.upgradecosttextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.upgradecosttextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.upgradecosttextbox.ForeColor = System.Drawing.Color.Yellow;
            this.upgradecosttextbox.Location = new System.Drawing.Point(641, 125);
            this.upgradecosttextbox.Margin = new System.Windows.Forms.Padding(4);
            this.upgradecosttextbox.Name = "upgradecosttextbox";
            this.upgradecosttextbox.Size = new System.Drawing.Size(220, 34);
            this.upgradecosttextbox.TabIndex = 44;
            this.upgradecosttextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // upgradeButton
            // 
            this.upgradeButton.AutoSize = true;
            this.upgradeButton.BackColor = System.Drawing.Color.Transparent;
            this.upgradeButton.Location = new System.Drawing.Point(4, 39);
            this.upgradeButton.Margin = new System.Windows.Forms.Padding(0);
            this.upgradeButton.Name = "upgradeButton";
            this.upgradeButton.Size = new System.Drawing.Size(410, 131);
            this.upgradeButton.TabIndex = 43;
            this.upgradeButton.UseVisualStyleBackColor = false;
            this.upgradeButton.Click += new System.EventHandler(this.upgradeButton_Click);
            // 
            // upgradecostlabel
            // 
            this.upgradecostlabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.upgradecostlabel.AutoSize = true;
            this.upgradecostlabel.Font = new System.Drawing.Font("Javanese Text", 11F);
            this.upgradecostlabel.ForeColor = System.Drawing.Color.Yellow;
            this.upgradecostlabel.Location = new System.Drawing.Point(418, 116);
            this.upgradecostlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.upgradecostlabel.Name = "upgradecostlabel";
            this.upgradecostlabel.Size = new System.Drawing.Size(215, 69);
            this.upgradecostlabel.TabIndex = 43;
            this.upgradecostlabel.Text = "Upgrade Cost:";
            // 
            // soldierTrackBar
            // 
            this.soldierTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.soldierTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.soldierTrackBar.Location = new System.Drawing.Point(98, 1129);
            this.soldierTrackBar.Margin = new System.Windows.Forms.Padding(6);
            this.soldierTrackBar.Name = "soldierTrackBar";
            this.soldierTrackBar.Size = new System.Drawing.Size(204, 90);
            this.soldierTrackBar.TabIndex = 40;
            // 
            // ListBox_SaveNew
            // 
            this.ListBox_SaveNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ListBox_SaveNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ListBox_SaveNew.FormattingEnabled = true;
            this.ListBox_SaveNew.ItemHeight = 37;
            this.ListBox_SaveNew.Location = new System.Drawing.Point(542, 1260);
            this.ListBox_SaveNew.Margin = new System.Windows.Forms.Padding(4);
            this.ListBox_SaveNew.Name = "ListBox_SaveNew";
            this.ListBox_SaveNew.Size = new System.Drawing.Size(562, 189);
            this.ListBox_SaveNew.TabIndex = 41;
            this.ListBox_SaveNew.Visible = false;
            // 
            // LogBook
            // 
            this.LogBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LogBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LogBook.ForeColor = System.Drawing.Color.Yellow;
            this.LogBook.Location = new System.Drawing.Point(46, 1381);
            this.LogBook.Margin = new System.Windows.Forms.Padding(4);
            this.LogBook.Name = "LogBook";
            this.LogBook.ReadOnly = true;
            this.LogBook.Size = new System.Drawing.Size(796, 312);
            this.LogBook.TabIndex = 41;
            this.LogBook.Text = "";
            // 
            // TotalPointsLabel
            // 
            this.TotalPointsLabel.AutoSize = true;
            this.TotalPointsLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TotalPointsLabel.ForeColor = System.Drawing.Color.Yellow;
            this.TotalPointsLabel.Location = new System.Drawing.Point(914, 1381);
            this.TotalPointsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalPointsLabel.Name = "TotalPointsLabel";
            this.TotalPointsLabel.Size = new System.Drawing.Size(181, 36);
            this.TotalPointsLabel.TabIndex = 42;
            this.TotalPointsLabel.Text = "Total Points:";
            // 
            // AllPointsTextBox
            // 
            this.AllPointsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AllPointsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllPointsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AllPointsTextBox.ForeColor = System.Drawing.Color.Yellow;
            this.AllPointsTextBox.Location = new System.Drawing.Point(1168, 1379);
            this.AllPointsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AllPointsTextBox.Name = "AllPointsTextBox";
            this.AllPointsTextBox.ReadOnly = true;
            this.AllPointsTextBox.Size = new System.Drawing.Size(240, 34);
            this.AllPointsTextBox.TabIndex = 43;
            this.AllPointsTextBox.Text = "100";
            this.AllPointsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalPointsTextBox
            // 
            this.TotalPointsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TotalPointsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalPointsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TotalPointsTextBox.ForeColor = System.Drawing.Color.Yellow;
            this.TotalPointsTextBox.Location = new System.Drawing.Point(1168, 1447);
            this.TotalPointsTextBox.Name = "TotalPointsTextBox";
            this.TotalPointsTextBox.Size = new System.Drawing.Size(240, 34);
            this.TotalPointsTextBox.TabIndex = 43;
            this.TotalPointsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalPointGain
            // 
            this.TotalPointGain.AutoSize = true;
            this.TotalPointGain.BackColor = System.Drawing.Color.Transparent;
            this.TotalPointGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TotalPointGain.ForeColor = System.Drawing.Color.Yellow;
            this.TotalPointGain.Location = new System.Drawing.Point(914, 1442);
            this.TotalPointGain.Name = "TotalPointGain";
            this.TotalPointGain.Size = new System.Drawing.Size(237, 36);
            this.TotalPointGain.TabIndex = 44;
            this.TotalPointGain.Text = "Total Point Gain:";
            // 
            // buttonRecruit
            // 
            this.buttonRecruit.AutoSize = true;
            this.buttonRecruit.BackColor = System.Drawing.Color.Transparent;
            this.buttonRecruit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRecruit.Location = new System.Drawing.Point(6, 377);
            this.buttonRecruit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRecruit.Name = "buttonRecruit";
            this.buttonRecruit.Size = new System.Drawing.Size(410, 131);
            this.buttonRecruit.TabIndex = 22;
            this.buttonRecruit.UseVisualStyleBackColor = false;
            this.buttonRecruit.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 11F);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(38, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 46);
            this.label2.TabIndex = 26;
            this.label2.Text = "Soldiers on tile:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox2.ForeColor = System.Drawing.Color.Yellow;
            this.textBox2.Location = new System.Drawing.Point(428, 86);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(220, 34);
            this.textBox2.TabIndex = 23;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(426, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(220, 34);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 11F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(38, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 54);
            this.label1.TabIndex = 25;
            this.label1.Text = "Point gain:";
            // 
            // newTurnButton
            // 
            this.newTurnButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.newTurnButton.BackColor = System.Drawing.Color.Black;
            this.newTurnButton.InitialImage = null;
            this.newTurnButton.Location = new System.Drawing.Point(4, 199);
            this.newTurnButton.Margin = new System.Windows.Forms.Padding(4);
            this.newTurnButton.Name = "newTurnButton";
            this.newTurnButton.Size = new System.Drawing.Size(410, 131);
            this.newTurnButton.TabIndex = 12;
            this.newTurnButton.TabStop = false;
            this.newTurnButton.Click += new System.EventHandler(this.newTurnButton_Click);
            // 
            // tileIDlabel
            // 
            this.tileIDlabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tileIDlabel.AutoSize = true;
            this.tileIDlabel.Font = new System.Drawing.Font("Javanese Text", 11F);
            this.tileIDlabel.ForeColor = System.Drawing.Color.Yellow;
            this.tileIDlabel.Location = new System.Drawing.Point(38, 126);
            this.tileIDlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tileIDlabel.Name = "tileIDlabel";
            this.tileIDlabel.Size = new System.Drawing.Size(132, 69);
            this.tileIDlabel.TabIndex = 41;
            this.tileIDlabel.Text = "Tile ID:";
            // 
            // tileIDtextbox
            // 
            this.tileIDtextbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tileIDtextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tileIDtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tileIDtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tileIDtextbox.ForeColor = System.Drawing.Color.Yellow;
            this.tileIDtextbox.Location = new System.Drawing.Point(428, 135);
            this.tileIDtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.tileIDtextbox.Name = "tileIDtextbox";
            this.tileIDtextbox.Size = new System.Drawing.Size(220, 34);
            this.tileIDtextbox.TabIndex = 42;
            this.tileIDtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tileIDtextbox);
            this.panel2.Controls.Add(this.tileIDlabel);
            this.panel2.Controls.Add(this.newTurnButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.buttonRecruit);
            this.panel2.Location = new System.Drawing.Point(4, 189);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 585);
            this.panel2.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(103)))), ((int)(((byte)(12)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2884, 1759);
            this.Controls.Add(this.TotalPointsTextBox);
            this.Controls.Add(this.TotalPointGain);
            this.Controls.Add(this.AllPointsTextBox);
            this.Controls.Add(this.TotalPointsLabel);
            this.Controls.Add(this.LogBook);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soldierTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTurnButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TrackBar soldierTrackBar;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.Button button_NewSave;

        private System.Windows.Forms.TextBox textBox_SaveFileName;

        internal static System.Windows.Forms.ListBox listBox_Save;

        private System.Windows.Forms.Button button_SaveGame;

        private System.Windows.Forms.Button button_back;

        private System.Windows.Forms.Button button_options;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button button_exit;

        #endregion

        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox ListBox_SaveNew;
        private System.Windows.Forms.RichTextBox LogBook;
        private System.Windows.Forms.Label TotalPointsLabel;
        private System.Windows.Forms.TextBox AllPointsTextBox;
        private System.Windows.Forms.Label TotalPointGain;
        private System.Windows.Forms.TextBox TotalPointsTextBox;
        private System.Windows.Forms.Button upgradeButton;
        private System.Windows.Forms.TextBox upgradecosttextbox;
        private System.Windows.Forms.Label upgradecostlabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tileIDtextbox;
        private System.Windows.Forms.Label tileIDlabel;
        private System.Windows.Forms.PictureBox newTurnButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRecruit;
    }
}

