using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProjInzynieraOprog
{
    public partial class Form1 : Form
    {
        Map M = new Map();

        //internal player _playerHuman = new player(1);
        //readonly player _playerAi = new player(2);
        private int clickedX;
        private int clickedY;


        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.None;
                Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.Sizable;
            }
        }


        public Form1()
        {

            M.CreateMaps(15, 1);
            M.CreateMaps(10, 2);
            M.CreateMaps(5, 3);
            InitializeComponent();

            GoFullscreen(true);
            DrawMap_OnPictrurebox();
            this.BackgroundImage = M.load_resource_image("bg_texture.jpg");
            panel1.BackColor = Color.Transparent;

            string new_turn = "NEW_TURN.png";
            string path_new_turn = Path.Combine(Environment.CurrentDirectory, @"Resources", new_turn);
            Image new_turn_img = Image.FromFile(path_new_turn);
            newTurnButton.Image = new_turn_img;



        





            pictureBarracks.Image = M.load_resource_image("BARRACKS.png");
            pictureCastle.Image = M.load_resource_image("CASTLE.png");
            pictureGarrison.Image = M.load_resource_image("GARRISON.png");
            pictureTax.Image = M.load_resource_image("TAX_OFFICE.png");

            TotalPointsTextBox.Text = M.totalPointGain_changed().ToString();







        }

        public void
            DrawMap_OnPictrurebox() //tu trzeba użyć lokalnej funkcji do rysowania, w której zawarta jest ta z klasy map XDDD
        {
            pictureBox1.Image = null;
            pictureBox1.Size = new Size(Map.Mapsize * Map.TileSize, Map.Mapsize * Map.TileSize);
            pictureBox1.Image = M.DrawMap(this);
            pictureBox1.Refresh();
        }

        internal void Refresh_Picturebox()
        {
            pictureBox1.Refresh();
        }

        Button menuUpgradeButton;
        Button menuRecruitButton;
        Button OK;
        Button Cancel;
        TextBox soldierText;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) //najcięższa robota
        {
            if (menuRecruitButton != null || menuRecruitButton != null)
            {
                menuRecruitButton.Dispose();
                menuUpgradeButton.Dispose();
            }

            check_if_soldiers_sufficient();
            int TS = Map.tileSize;
            int MS = Map.Mapsize;

            int x = e.X / TS;
            int y = e.Y / TS;




            if (M.attackMode == true && ((x == clickedX && (y >= clickedY - 1 || y <= clickedY + 1)) ||
                                         (y == clickedY && (y >= clickedX - 1 || y <= clickedX + 1))))
            {

                M.TempAttackerId = M.List_of_tiles[clickedX, clickedY].Id;
                M.TempDefenderId = M.List_of_tiles[x, y].Id;
                //M.battle_simulation_rt(soldierTrackBar.Value,M.List_of_tiles[clickedX, clickedY].Id, M.List_of_tiles[x, y].Id);
                add_Battle_To_List();
                M.List_of_tiles[clickedX, clickedY].SoldiersOnTile -= soldierTrackBar.Value;
                soldierTrackBar.Maximum -= soldierTrackBar.Value;
                DrawMap_OnPictrurebox();


            }

            clickedX = x;
            clickedY = y;
            int clickX = e.X;
            int clickY = e.Y;


            tileIDtextbox.Text = M.List_of_tiles[x, y].Id.ToString();
            textBox1.Text = M.List_of_tiles[x, y].SoldiersOnTile.ToString();
            textBox2.Text = M.List_of_tiles[x, y].PointGain.ToString();
            M.temppointsbalance = M._playerHuman.PointsBalance;


            DrawMap_OnPictrurebox();
            M.Draw_Frame(x, y);
            pictureBox1.Refresh();

            if (M.List_of_tiles[x, y].PlayerControllerId == 1)
            {
                Enable_if_Friendly();
                soldierTrackBar.Maximum = M.List_of_tiles[x, y].SoldiersOnTile;
            }
            else
            {
                soldierTrackBar.Maximum = 0;
                Disable_if_enemy();
            }

            M.selectedProvince.X = x;
            M.selectedProvince.Y = y;

            M.tempAttackerId = M.List_of_tiles[x, y].Id;

            CheckForUpgradeButtons();




            //disabling attack control buttons if player dont clink on tile he owns or neigbouring tiles are non existent



            //jesli tile jest nasz
            if (M.List_of_tiles[clickedX, clickedY].PlayerControllerId == M._playerHuman.PlayerId1)
            {
                //jesli tile nie jest woda
                if (M.List_of_tiles[clickedX, clickedY].Type != 2 && M.List_of_tiles[clickedX, clickedY].Type != 4)
                {
                    if ((M.List_of_tiles[clickedX, clickedY].PointGain * 3) < int.Parse(AllPointsTextBox.Text))
                    {
                        //upgradeButton.Visible = true;
                        upgradecosttextbox.Visible = true;
                        upgradecostlabel.Visible = true;
                        upgradecosttextbox.Text = (M.List_of_tiles[clickedX, clickedY].PointGain * 3).ToString();
                    }
                    else
                    {
                        //upgradeButton.Visible = false;
                        upgradecosttextbox.Visible = false;
                        upgradecostlabel.Visible = false;
                    }

                }
                else
                {
                    //upgradeButton.Visible = false;
                    upgradecosttextbox.Visible = false;
                    upgradecostlabel.Visible = false;
                }
            }
            //jesli tile nie jest nasz
            else
            {
                //upgradeButton.Visible = false;
                upgradecosttextbox.Visible = false;
                upgradecostlabel.Visible = false;

            }


            if (((e.Button & MouseButtons.Right) != 0))
            {



                string fileName = "MENU.UPGRADE.png";
                string path = Path.Combine(Environment.CurrentDirectory, @"Resources", fileName);
                Image menuUpgrade = Image.FromFile(path);

                string fileName2 = "MENU.RECRUIT.png";
                string path2 = Path.Combine(Environment.CurrentDirectory, @"Resources", fileName2);
                Image menuRecruit = Image.FromFile(path2);


                menuUpgradeButton = new Button();
                menuUpgradeButton.Size = new Size(menuUpgrade.Width, menuUpgrade.Height);
                menuUpgradeButton.Location = new Point(e.X, e.Y);
                menuUpgradeButton.Image = menuUpgrade;
                menuUpgradeButton.FlatStyle = FlatStyle.Flat;
                pictureBox1.Controls.Add(menuUpgradeButton);
                menuUpgradeButton.Click += new EventHandler(menuUpgrade_Click);





                menuRecruitButton = new Button();
                menuRecruitButton.Size = new Size(menuRecruit.Width, menuRecruit.Height);
                menuRecruitButton.Location = new Point(e.X, e.Y + menuRecruitButton.Height);
                menuRecruitButton.Image = menuRecruit;
                pictureBox1.Controls.Add(menuRecruitButton);
                menuRecruitButton.FlatStyle = FlatStyle.Flat;
                menuRecruitButton.Click += new EventHandler(menuRecruit_Click);

                if (M.List_of_tiles[clickedX, clickedY].PointGain * 3 > M._playerHuman.PointsBalance ||
                    M.List_of_tiles[clickedX, clickedY].Type == 2)
                {
                    menuUpgradeButton.Enabled = false;
                }
                else
                {
                    menuUpgradeButton.Enabled = true;
                }


                pictureBox1.Refresh();
                pictureBox1.Refresh();


            }
            else
            {
                if (menuUpgradeButton != null && menuRecruitButton != null)
                {
                    menuUpgradeButton.Dispose();
                    menuRecruitButton.Dispose();
                    pictureBox1.Controls.Remove(menuUpgradeButton);
                    pictureBox1.Controls.Remove(menuRecruitButton);
                }

                if (OK != null && Cancel != null)
                {
                    OK.Dispose();
                    Cancel.Dispose();
                    soldierText.Dispose();
                    pictureBox1.Controls.Remove(OK);
                    pictureBox1.Controls.Remove(Cancel);
                    pictureBox1.Controls.Remove(soldierText);
                }


            }





        }

        private void CheckForUpgradeButtons()
        {
            LabelBarracks.Text = "Level " + M._playerHuman.City.BarracksLevel.ToString();
            LabelCastle.Text = "Level " + M._playerHuman.City.CastleLevel.ToString();
            LabelGarrison.Text = "Level " + M._playerHuman.City.GarrisonLevel.ToString();
            LabelTax.Text = "Level " + M._playerHuman.City.TaxOfficeLevel.ToString();


            if (M._playerHuman.PointsBalance < 600)
            {
                ButtonBarracks.Enabled = false;
                ButtonCastle.Enabled = false;
                ButtonGarrison.Enabled = false;
                ButtonTax.Enabled = false;

            }
            else
            {
                ButtonBarracks.Enabled = true;
                ButtonCastle.Enabled = true;
                ButtonGarrison.Enabled = true;
                ButtonTax.Enabled = true;

            }
        }


        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Closing the game", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e) // LOAD GAME
        {
            M.First_Run();
            pictureBox1.Refresh();
            DrawMap_OnPictrurebox();
            pictureBox1.Refresh();
            DrawMap_OnPictrurebox();
        }

        private void newTurnButton_Click(object sender, EventArgs e)
        {
            if (M.List_of_tiles[1, 1].PlayerControllerId != M._playerHuman.PlayerId1)
            {
                MessageBox.Show("Loser and noob");
            }
            
            
            LogBook.Text = "";
            M.playerAiController();
            M.battle_simulation();


            DrawMap_OnPictrurebox();
            foreach (var flash in M.flashes)
            {
                M.DrawFrameTileTaken(flash.x, flash.y);
                pictureBox1.Refresh();

            }

            M.flashes.Clear();
            AllPointsTextBox.Text = M._playerHuman.PointsBalance.ToString();
            int tmp = M.TurnNumber + 1;
            string temp = "Turn: " + tmp.ToString() + "\n";
            M.LogString1.Add(temp);

            foreach (string s in M.LogString1)
            {

                LogBook.Text += s + "\n";
            }

            M.TurnNumber += 1;

            TotalPointsTextBox.Text = M.totalPointGain_changed().ToString();
            LogBook.SelectionStart = LogBook.Text.Length;
            LogBook.ScrollToCaret();
            CheckForUpgradeButtons();


        }
        //event handler for trackbar value change


        private void add_Battle_To_List()
        {
            battle bat = new battle(M.TempAttackerId, M.TempDefenderId, soldierTrackBar.Value);
            M.battlesToDetermine.Add(bat);
        }

        void populate_listboxSave()
        {
            ListBox_SaveNew.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, @"Data\"));
            FileInfo[] Files = dir.GetFiles();
            foreach (FileInfo file in Files)
            {
                ListBox_SaveNew.Items.Add(file.Name);
            }
        }

        private void button_options_Click(object sender, EventArgs e)
        {
            populate_listboxSave();
            
            tileIDlabel.Visible = false;
            tileIDtextbox.Visible = false;
            newTurnButton.Visible = false;
          
            soldierTrackBar.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button_SaveGame.Visible = true;
            button_back.Visible = true;
            button1.Visible = true;
            ListBox_SaveNew.Visible = true;
            textBox_SaveFileName.Visible = true;
            button_NewSave.Visible = true;
        
            label1.Visible = false;
            label2.Visible = false;


            //populate_listboxSave();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            
            tileIDlabel.Visible = true;
            tileIDtextbox.Visible = true;
            newTurnButton.Visible = true;
          
            soldierTrackBar.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            button_back.Visible = false;
            button1.Visible = false;
            button_SaveGame.Visible = false;
            ListBox_SaveNew.Visible = false;
            textBox_SaveFileName.Visible = false;
            button_NewSave.Visible = false;
           
        }

        private void button_SaveGame_Click(object sender, EventArgs e)
        {
            if (ListBox_SaveNew.SelectedItem != null)
            {
                string path = Path.Combine(Environment.CurrentDirectory, @"Data",
                    ListBox_SaveNew.SelectedItem.ToString());
                M.write_save_file(path);
                ListBox_SaveNew.SelectedItem = null;
            }
        }

        private void button_NewSave_Click(object sender, EventArgs e)
        {
            ListBox_SaveNew.Items.Clear();
            string fileName = textBox_SaveFileName.Text + ".txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            M.write_save_file(path);
            populate_listboxSave();
        }

        void check_if_soldiers_sufficient()
        {

        }
        
        public string Get_SaveFile()
        {
            if (ListBox_SaveNew.SelectedItem != null)
            {
                return Path.Combine(Environment.CurrentDirectory, @"Data\", ListBox_SaveNew.SelectedItem.ToString());
            }
            else
            {
                string default_path = Path.Combine(Environment.CurrentDirectory, @"Data\", "map1.txt");
                return default_path;
            }
        }

        int Get_SoldierTrackBar()
        {
            return soldierTrackBar.Value;
        }

        private void Disable_if_enemy()
        {
          
            soldierTrackBar.Visible = false;
        }


        void Enable_if_Friendly()
        {
            soldierTrackBar.Visible = true;
        }





        //funkcja do ulepszania pól, na click jakiegos buttona;
        private void upgradeButton_Click(object sender, EventArgs e)
        {
            M._playerHuman.PointsBalance -= M.List_of_tiles[clickedX, clickedY].PointGain * 3;
            AllPointsTextBox.Text =
                (int.Parse(AllPointsTextBox.Text) - M.List_of_tiles[clickedX, clickedY].PointGain * 3).ToString();
            M.List_of_tiles[clickedX, clickedY].UpgradeTile();
           
            DrawMap_OnPictrurebox();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (M.List_of_tiles[clickedX, clickedY].PlayerControllerId == 1)
            {
                DrawMap_OnPictrurebox();

                M.Draw_Frame(clickedX, clickedY + 1);
                M.Draw_Frame(clickedX, clickedY - 1);
                M.Draw_Frame(clickedX - 1, clickedY);
                M.Draw_Frame(clickedX + 1, clickedY);

                pictureBox1.Refresh();

                M.attackMode = true;
            }
        }


        private void ButtonTax_Click(object sender, EventArgs e)
        {
            M._playerHuman.City.TaxOfficeLevel++;
            M._playerHuman.PointsBalance -= 600;
            M.List_of_tiles[1, 1].PointGain += 100;
            AllPointsTextBox.Text = (int.Parse(AllPointsTextBox.Text) - 600).ToString();
            textBox2.Text = (int.Parse(textBox2.Text) + 100).ToString();
            CheckForUpgradeButtons();
        }

        private void ButtonCastle_Click(object sender, EventArgs e)
        {
            M._playerHuman.City.CastleLevel++;
            M._playerHuman.PointsBalance -= 600;
            M.List_of_tiles[1, 1].PointGain += 100;
            AllPointsTextBox.Text = (int.Parse(AllPointsTextBox.Text) - 600).ToString();
            CheckForUpgradeButtons();
        }

        private void ButtonGarrison_Click(object sender, EventArgs e)
        {
            M._playerHuman.City.GarrisonLevel++;
            M._playerHuman.PointsBalance -= 600;
            AllPointsTextBox.Text = (int.Parse(AllPointsTextBox.Text) - 600).ToString();
            CheckForUpgradeButtons();
        }

        private void ButtonBarracks_Click(object sender, EventArgs e)
        {
            M._playerHuman.City.BarracksLevel++;
            M._playerHuman.PointsBalance -= 600;
            AllPointsTextBox.Text = (int.Parse(AllPointsTextBox.Text) - 600).ToString();
            CheckForUpgradeButtons();
        }



        public void menuUpgrade_Click(object sender, EventArgs e)
        {


            upgradeButton_Click(sender, e);
            menuUpgradeButton.Dispose();
            menuRecruitButton.Dispose();


        }

        public void menuRecruit_Click(object sender, EventArgs e)
        {


            soldierText = new TextBox();
            soldierText.Location = new Point(menuRecruitButton.Location.X + 25, menuRecruitButton.Location.Y + 25);
            soldierText.Size = new Size(80, 20);
            soldierText.BackColor = Color.FromArgb(158, 103, 12);
            soldierText.ForeColor = Color.Yellow;
            soldierText.Font = new Font("Javanese Text", 12);
            
            pictureBox1.Controls.Add(soldierText);

            OK = new Button();
            OK.Location = new Point(soldierText.Location.X + 100, soldierText.Location.Y);
            OK.Size = new Size(50, 35);
            OK.BackColor = Color.FromArgb(158, 103, 12);
            OK.ForeColor = Color.Yellow;
            OK.Font = new Font("Javanese Text", 12);
            OK.Text = "OK";
            OK.FlatStyle = FlatStyle.Flat;
            pictureBox1.Controls.Add(OK);


            Cancel = new Button();
            Cancel.Location = new Point(OK.Location.X, soldierText.Location.Y + 40);
            Cancel.Size = new Size(100, 35);
            Cancel.BackColor = Color.FromArgb(158, 103, 12);
            Cancel.ForeColor = Color.Yellow;
            Cancel.Font = new Font("Javanese Text", 12);
            Cancel.Text = "Cancel";
            Cancel.FlatStyle = FlatStyle.Flat;
            pictureBox1.Controls.Add(Cancel);

            OK.Click += new EventHandler(OK_Click);
            Cancel.Click += new EventHandler(Cancel_Click);







            menuRecruitButton.Dispose();
            menuUpgradeButton.Dispose();


        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            OK.Dispose();
            Cancel.Dispose();
            menuUpgradeButton.Dispose();
            menuRecruitButton.Dispose();
            soldierText.Dispose();
            pictureBox1.Controls.Remove(menuUpgradeButton);
            pictureBox1.Controls.Remove(menuRecruitButton);
            pictureBox1.Controls.Remove(soldierText);
            pictureBox1.Controls.Remove(OK);
            pictureBox1.Controls.Remove(Cancel);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            int soldiers = int.Parse(soldierText.Text);
            if (soldiers < M._playerHuman.PointsBalance)
            {

                M.List_of_tiles[clickedX, clickedY].SoldiersOnTile += soldiers;
                M._playerHuman.PointsBalance -= soldiers;
                AllPointsTextBox.Text = (int.Parse(AllPointsTextBox.Text) - soldiers).ToString();
            }

            else
            {
                MessageBox.Show("You don't have enough points to recruit this many soldiers!");
            }


            OK.Dispose();
            Cancel.Dispose();
            menuUpgradeButton.Dispose();
            menuRecruitButton.Dispose();
            soldierText.Dispose();
            pictureBox1.Controls.Remove(menuUpgradeButton);
            pictureBox1.Controls.Remove(menuRecruitButton);
            pictureBox1.Controls.Remove(soldierText);
            pictureBox1.Controls.Remove(OK);
            pictureBox1.Controls.Remove(Cancel);
            pictureBox1.Refresh();
            DrawMap_OnPictrurebox();


        }

    }


}
