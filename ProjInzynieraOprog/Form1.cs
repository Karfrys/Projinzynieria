using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProjInzynieraOprog
{
    public partial class Form1 : Form
    {
        private static int tileSize = 55;
        private  player _playerHuman = new player(1);
        readonly player _playerAi = new player(2);
        private static int mapsize = 15;
        SolidBrush allyColor = new SolidBrush(Color.LightSeaGreen);
        SolidBrush enemyColor = new SolidBrush(Color.LightCoral);
        SolidBrush neutralColor = new SolidBrush(Color.Gray);
        private int tempDefenderId;
        private int tempAttackerId;
        static Bitmap bm = new Bitmap(tileSize * mapsize, tileSize * mapsize);
        tile [,] List_of_tiles = new tile [mapsize,mapsize];
        List <battle> battlesToDetermine = new List<battle>();
        private bool firstRun = true;
        Point selectedProvince;
        private OpenFileDialog ofd;
        Graphics g = Graphics.FromImage(bm);
        private int temppointsbalance;

        private void DrawMap()
        {
            int iter = 0;
            string[,] tiles = GetMapSize();
            pictureBox1.Refresh();
            pictureBox1.Size = new Size(mapsize * tileSize, mapsize * tileSize);
            for (int i = 0; i < mapsize; i++)
            {
                for (int j = 0; j < mapsize; j++)
                {
                    if (firstRun == true)
                    {
                        tile b = new tile();
                        b.Id = iter;
                        iter++;
                        List_of_tiles[i, j] = b;
                        List_of_tiles[i, j].PointGain = int.Parse(tiles[i, j].Substring(0, 2));
                        List_of_tiles[i, j].Type = int.Parse(tiles[i, j].Substring(3, 1));
                        List_of_tiles[i, j].PlayerControllerId = int.Parse(tiles[i, j].Substring(5, 1));
                    }

                    if (List_of_tiles[i, j].PlayerControllerId == 1)
                    {
                        g.FillRectangle(allyColor, i * tileSize + 1, j * tileSize + 1, tileSize - 1, tileSize - 1);
                        
                    }
                    else if (List_of_tiles[i, j].PlayerControllerId == 2)
                    {
                        g.FillRectangle(enemyColor, i * tileSize + 1, j * tileSize + 1, tileSize - 1, tileSize - 1);
                    }
                    else
                    {
                        g.FillRectangle(neutralColor, i * tileSize + 1, j * tileSize + 1, tileSize - 1, tileSize - 1);
                    }

                    if (List_of_tiles[i, j].Type == 2)
                    {
                        Draw_Lake(i, j);
                    }

                    if (List_of_tiles[i, j].Type == 1)
                    {
                        Draw_Forest(i, j);
                    }

                    if (List_of_tiles[i, j].Type == 0)
                    {
                        Draw_Wheat(i, j);
                    }
                    soldiers_on_tile(i,j);
                    g.DrawRectangle(Pens.Black, tileSize * i, tileSize * j, tileSize, tileSize);
                }
            }
            firstRun = false;
            pictureBox1.Image = bm;
        }

        
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
            CreateMaps(15,1);
            CreateMaps(10,2);
            CreateMaps(5,3);
            InitializeComponent();
            GoFullscreen(true);
            DrawMap();
            this.BackgroundImage = load_resource_image("bg_texture.jpg");
            panel1.BackColor = Color.Transparent;
        }



        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            check_if_soldiers_sufficient();

            int x = e.X / tileSize;
            int y = e.Y / tileSize;
            int clickX = e.X;
            int clickY = e.Y;
            //tileXposition = x * tileSize;
           // tileYposition = y * tileSize;
            
            SolidBrush lol = new SolidBrush(Color.DarkSlateBlue);
            textBox1.Text = List_of_tiles[x,y].SoldiersOnTile.ToString();
            textBox2.Text = List_of_tiles[x, y].PointGain.ToString();
            temppointsbalance=_playerHuman.PointsBalance;
            DrawMap();
            Draw_Frame(x, y);

            if (List_of_tiles[x, y].PlayerControllerId == 1)
            {
                Enable_if_Friendly();
                soldierTrackBar.Maximum=List_of_tiles[x, y].SoldiersOnTile;
            }
            else
            {
                soldierTrackBar.Maximum = 0;
                Disable_if_enemy();
            }

            selectedProvince.X = x;
            selectedProvince.Y = y;
           // richTextBox_coordinates.Text = List_of_tiles[x, y].Id.ToString();
           // richTextBox_PointGain.Text = List_of_tiles[x, y].PointGain.ToString();
           
            tempAttackerId = List_of_tiles[x, y].Id;
            //textBox2.Text = List_of_tiles[x, y].SoldiersOnTile.ToString();
          
            if(pictureBox2.Image != null)
            {
                pictureBox2.Image.Dispose();
            }
            switch (List_of_tiles[x,y].Type)
            {
                case 0:
                    pictureBox2.Image=load_resource_image("plains-background.png");
                    break;
                case 1:
                    pictureBox2.Image=load_resource_image("forest-background.png");
                    break;
                case 2:
                    pictureBox2.Image=load_resource_image("lake-background.png");
                    break;
            }
            
            

            //disabling attack control buttons if player dont clink on tile he owns or neigbouring tiles are non existent

            if (List_of_tiles[x, y].PlayerControllerId != 1)
            {
                buttonS.Enabled = false;
                buttonE.Enabled = false;
                buttonW.Enabled = false;
                buttonN.Enabled = false;
            }
            else
            {
                if (clickX < tileSize)
                {
                    buttonW.Enabled = false;
                }
                else
                {
                    /*
                    Point one = new Point(tileXposition+1,tileYposition);
                    Point two = new Point(tileXposition+1,tileYposition+tileSize);
                    Point three = new Point(tileXposition-(tileSize/3),tileYposition+(tileSize/2));
                    Point[] Triangle = {one,two,three};
                    g.FillPolygon(lol,Triangle);*/
                    buttonW.Enabled = true;
                }

                if (clickY < tileSize)
                {
                    buttonN.Enabled = false;
                }
                else
                {
                    /* Point one = new Point(tileXposition,tileYposition-1);
                     Point two = new Point(tileXposition+tileSize,tileYposition-1);
                     Point three = new Point(tileXposition+(tileSize/2),tileYposition-(tileSize/3));
                     Point[] Triangle = {one,two,three};
                     g.FillPolygon(lol,Triangle);*/
                    buttonN.Enabled = true;
                }

                if (clickX + tileSize > tileSize * mapsize)
                {
                    buttonE.Enabled = false;
                }
                else
                {
                    /* Point one = new Point(tileXposition+1+tileSize,tileYposition);
                     Point two = new Point(tileXposition+1+tileSize,tileYposition+tileSize);
                     Point three = new Point(tileXposition+(tileSize/3)+tileSize,tileYposition+(tileSize/2));
                     Point[] Triangle = {one,two,three};
                     g.FillPolygon(lol,Triangle);*/
                    buttonE.Enabled = true;
                }

                if (clickY + tileSize > tileSize * mapsize)
                {
                    buttonS.Enabled = false;
                }
                else
                {
                    /* Point one = new Point(tileXposition,tileYposition+2+tileSize);
                     Point two = new Point(tileXposition+tileSize,tileYposition+2+tileSize);
                     Point three = new Point(tileXposition+(tileSize/2),tileYposition+(tileSize/3)+tileSize);
                     Point[] Triangle = {one,two,three};
                     g.FillPolygon(lol,Triangle);*/
                    buttonS.Enabled = true;
                }
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

        void CreateMaps(int size,int map)
        {
            string name = "map" + map.ToString() + ".txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", name);
            StreamWriter sw;
            sw = new StreamWriter(path, false);
            Random r = new Random();
            string line;
            int pg; //assigning random pointgain for each tile// 
            int type; //0-clearing , 1-forest, 2-water //
            int own; //ownership //
            for (int i = 0; i < size; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < size; j++)
                {
                    pg = r.Next(10, 30);
                    type = r.Next(0, 3);
                    if (i < 2 && j < 2)
                    {
                        own = 1;
                    }
                    else if (i > size - 3 && j > size - 3)
                    {
                        own = 2;
                    }
                    else
                    {
                        own = 0;
                    }
                    sb.Append(pg.ToString()+"|"+type.ToString()+"|"+own.ToString()+"#");
                }
                line = sb.ToString();
                sw.WriteLine(line);
            }
            sw.Close();
        }

        string [,] GetMapSize()
          {
              int iterator = 0;
              string fileName = "map1.txt";
              mapsize = 15;
              if (listBox_Save.SelectedItem != null)
              {
                  fileName = listBox_Save.SelectedItem.ToString();
              }
              string[,] Tiles = new string[mapsize, mapsize];

              string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
              string[] lines = File.ReadAllLines(path, Encoding.UTF8);
              mapsize = lines.Length;

              for (int i = 0; i < mapsize; i++) 
              {
                  iterator = 0;
                  for (int j = 0; j < mapsize; j++)
                  {
                      Tiles[i, j] = lines[i].Substring(iterator, 6);
                      iterator += 7;
                       
                  }
              } 
              return Tiles;
          }

        private void button1_Click(object sender, EventArgs e)
        {
            firstRun = true;
            DrawMap();
        }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mapsize; i++)
            {
                for (int j = 0; j < mapsize; j++)
                {
                    if (List_of_tiles[i, j].PlayerControllerId == 1)
                    {
                        _playerHuman.PointsBalance += Convert.ToInt32(List_of_tiles[i, j].PointGain);
                    }
                    else if (List_of_tiles[i, j].PlayerControllerId == 2)
                    {
                        _playerAi.PointsBalance += Convert.ToInt32(List_of_tiles[i, j].PointGain);
                    }
                }
            }
            //basic battle simulation

            int defenders;  
            
            for (int k = 0; k < battlesToDetermine.Count;k++)
            {
                defenders = get_soldier_num_by_id(battlesToDetermine[k].DefenderProvinceId);
                if (checkIfFriendly(tempDefenderId) == true)
                {
                    for (int i = 0; i < 0; i++)
                    {
                        for (int j = 0; j < 0; j++)
                        {
                            if (battlesToDetermine[k].AttackerProvinceId == List_of_tiles[i, j].Id)
                            {
                                for (int x = 0; x < 0; x++)
                                {
                                    for (int z = 0; z < 0; z++)
                                    {
                                        if (battlesToDetermine[k].DefenderProvinceId == List_of_tiles[x, z].Id)
                                        {
                                            List_of_tiles[x, z].SoldiersOnTile += battlesToDetermine[k].SoldierNum;
                                        }
                                    }
                                }

                                List_of_tiles[i, j].SoldiersOnTile -= battlesToDetermine[k].SoldierNum;
                            }
                        }
                    }
                }
                else
                {
                    if (defenders<battlesToDetermine[k].SoldierNum)
                    {
                        battlesToDetermine[k].SoldierNum -= defenders;
                        for (int i = 0; i < mapsize; i++)
                        {
                            for (int j = 0; j < mapsize; j++)
                            {
                                if (List_of_tiles[i, j].Id == battlesToDetermine[k].DefenderProvinceId)
                                {
                                    List_of_tiles[i, j].SoldiersOnTile = battlesToDetermine[k].SoldierNum;
                                    List_of_tiles[i, j].PlayerControllerId = 1;
                                }
                                if(List_of_tiles[i,j].Id == battlesToDetermine[k].AttackerProvinceId)
                                {
                                    List_of_tiles[i, j].SoldiersOnTile -= battlesToDetermine[k].SoldierNum;
                                }
                            }
                        }
                    }
                    else
                    {
                    
                        for (int i = 0; i < mapsize; i++)
                        {
                            for (int j = 0; j < mapsize; j++)
                            {
                                if (List_of_tiles[i, j].Id == battlesToDetermine[k].AttackerProvinceId)
                                {
                                    List_of_tiles[i, j].SoldiersOnTile -= defenders;
                                }
                                if(List_of_tiles[i,j].Id == battlesToDetermine[k].DefenderProvinceId)
                                {
                                    List_of_tiles[i, j].SoldiersOnTile -= battlesToDetermine[k].SoldierNum;
                                }
                            }
                        }
                    }
                }
                }
            
            battlesToDetermine.Clear();
            DrawMap();

        }
        //event handler for trackbar value change
        
        private void soldierTrackBar_ValueChanged(object sender, System.EventArgs e)
        {
            textBox1.Text = soldierTrackBar.Value.ToString();
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            tempDefenderId = tempAttackerId - 1;
            add_Battle_To_List();
            soldierTrackBar.Maximum -= soldierTrackBar.Value;
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            tempDefenderId = tempAttackerId - mapsize;
            add_Battle_To_List();
            soldierTrackBar.Maximum -= soldierTrackBar.Value;
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            tempDefenderId = tempAttackerId + 1;
            add_Battle_To_List();
            soldierTrackBar.Maximum -= soldierTrackBar.Value;
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            tempDefenderId = tempAttackerId +mapsize;
            add_Battle_To_List();
            soldierTrackBar.Maximum -= soldierTrackBar.Value;
        }

        private void add_Battle_To_List()
        {
            battle bat = new battle(tempAttackerId,tempDefenderId,soldierTrackBar.Value);
            battlesToDetermine.Add(bat);
        }
        
        int get_soldier_num_by_id(int defid)
        {
            int solCount;
            for (int i = 0; i < mapsize; i++)
            {
                for (int j = 0; j < mapsize; j++)
                {
                    if (List_of_tiles[i, j].Id == defid)
                    {
                        solCount = List_of_tiles[i, j].SoldiersOnTile;
                        return solCount;
                    }
                }
            }
            return 0;
        }
        //check if attacked tile is friendly
        bool checkIfFriendly(int id)
        {
            for (int i = 0; i < mapsize; i++)
            {
                for (int j = 0; j < mapsize; j++)
                {
                    if (id == List_of_tiles[i, j].Id)
                    {
                        if (List_of_tiles[i, j].PlayerControllerId == 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            return false;
        }

        void populate_listboxSave()
        {
            listBox_Save.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, @"Data\"));
            FileInfo[] Files = dir.GetFiles();
            foreach (FileInfo file in Files)
            {
                listBox_Save.Items.Add(file.Name);
            }
        }

        private void button_options_Click(object sender, EventArgs e)
        {
            buttonE.Visible = false;
            buttonN.Visible = false;
            buttonW.Visible = false;
            buttonS.Visible = false;
            newTurnButton.Visible = false;
            button2.Visible = false;
            soldierTrackBar.Visible = false;
            textBox1.Visible = false;
            button_SaveGame.Visible = true;
            button_back.Visible = true;
            button1.Visible = true;
            listBox_Save.Visible = true;
            textBox_SaveFileName.Visible = true;
            button_NewSave.Visible = true;
            buttonx1.Visible = false;
            buttonx10.Visible = false;
            buttonx100.Visible = false;
            buttonx1000.Visible = false;
            textBox3.Visible = false;

            populate_listboxSave(); 
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            buttonE.Visible = true;
            buttonN.Visible = true;
            buttonW.Visible = true;
            buttonS.Visible = true;
            newTurnButton.Visible = true;
            button2.Visible = true;
            soldierTrackBar.Visible = true;
            textBox1.Visible = true;
            button_back.Visible = false;
            button1.Visible = false;
            button_SaveGame.Visible = false;
            listBox_Save.Visible = false;
            textBox_SaveFileName.Visible = false;
            button_NewSave.Visible = false;
            buttonx1.Visible = true;
            buttonx10.Visible = true;
            buttonx100.Visible = true;
            buttonx1000.Visible = true;
            textBox3.Visible = true;
        }

        void write_save_file(string path)
        {
            StreamWriter sw;
            string line;
            
            sw = new StreamWriter(path, false);
            for (int x = 0; x < mapsize; x++)
            {
                StringBuilder sb = new StringBuilder();
                for (int y = 0; y < mapsize; y++)
                {
                    if (List_of_tiles[x, y].PointGain == 0)
                    {
                        List_of_tiles[x, y].PointGain = 99;
                    }
                    sb.Append(List_of_tiles[x,y].PointGain.ToString()+"|"+List_of_tiles[x,y].Type.ToString()+"|"+List_of_tiles[x,y].PlayerControllerId.ToString()+"#");
                }
                line = sb.ToString();
                sw.WriteLine(line);
            }
            sw.Close();
        }

        private void button_SaveGame_Click(object sender, EventArgs e)
        {
            if (listBox_Save.SelectedItem != null)
            {
                string path = Path.Combine(Environment.CurrentDirectory, @"Data\", listBox_Save.SelectedItem.ToString());
                write_save_file(path);
                listBox_Save.SelectedItem = null;
            }
        }

        private void button_NewSave_Click(object sender, EventArgs e)
        {
            listBox_Save.Items.Clear();
            string fileName = textBox_SaveFileName.Text+".txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\",fileName);
            write_save_file(path);
            populate_listboxSave();
        }
        void check_if_soldiers_sufficient()
        {
            if (temppointsbalance > 999)
            {
                buttonx1000.Enabled = true;
                buttonx100.Enabled = true;
                buttonx10.Enabled = true;
                buttonx1.Enabled = true;          }
            else if(temppointsbalance>99)
            {
                buttonx1000.Enabled = false;
                buttonx100.Enabled = true;
                buttonx10.Enabled = true;
                buttonx1.Enabled = true;
            }
            else if (temppointsbalance > 9)
            {
                buttonx1000.Enabled = false;
                buttonx100.Enabled = false;
                buttonx10.Enabled = true;
                buttonx1.Enabled = true;
            }
            else if (temppointsbalance > 0)
            {
                buttonx1000.Enabled = false;
                buttonx100.Enabled = false;
                buttonx10.Enabled = false;
                buttonx1.Enabled = true;
            }
            else
            {
                buttonx1000.Enabled = false;
                buttonx100.Enabled = false;
                buttonx10.Enabled = false;
                buttonx1.Enabled = false;
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            int selectedRecruiting = Convert.ToInt32(textBox3.Text);
            List_of_tiles[selectedProvince.X,selectedProvince.Y].SoldiersOnTile+=selectedRecruiting;
            _playerHuman.PointsBalance -= selectedRecruiting;
            textBox3.Text = "0";
            soldierTrackBar.Maximum = List_of_tiles[selectedProvince.X, selectedProvince.Y].SoldiersOnTile;
            textBox1.Refresh();
        }
        private void buttonx1_Click(object sender, EventArgs e)
        {
            if(textBox3.Text!="")
            {
                int textToInt = Convert.ToInt32(textBox3.Text);
                temppointsbalance -= textToInt;
                textToInt += 1;
                textBox3.Text = textToInt.ToString();
            }
            else
            {
                int textToInt = 0;
                temppointsbalance -= textToInt;
                textToInt += 1;
                textBox3.Text = textToInt.ToString();
            }
            check_if_soldiers_sufficient();
        }
        private void buttonx10_Click(object sender, EventArgs e)
        {
            if(textBox3.Text!="")
            {
                int textToInt = Convert.ToInt32(textBox3.Text);
                temppointsbalance -= textToInt;
                textToInt += 10;
                textBox3.Text = textToInt.ToString();
            }
            else
            {
                int textToInt = 0;
                temppointsbalance -= textToInt;
                textToInt += 10;
                textBox3.Text = textToInt.ToString();
            }
            check_if_soldiers_sufficient();
        }
        private void buttonx100_Click(object sender, EventArgs e)
        {
            if(textBox3.Text!="")
            {
                int textToInt = Convert.ToInt32(textBox3.Text);
                temppointsbalance -= textToInt;
                textToInt += 10;
                textBox3.Text = textToInt.ToString();
            }
            else
            {
                int textToInt = 0;
                temppointsbalance -= textToInt;
                textToInt += 100;
                textBox3.Text = textToInt.ToString();
            }

            check_if_soldiers_sufficient();
        }
        private void buttonx1000_Click(object sender, EventArgs e)
        {
            if(textBox3.Text!="")
            {
                int textToInt = Convert.ToInt32(textBox3.Text);
                temppointsbalance -= textToInt;
                textToInt += 10;
                textBox3.Text = textToInt.ToString();
            }
            else
            {
                int textToInt = 0;
                temppointsbalance -= textToInt;
                textToInt += 1000;
                textBox3.Text = textToInt.ToString();
            }
            check_if_soldiers_sufficient();
        }
        void Draw_Frame(int x, int y)
        {
            g.DrawRectangle(Pens.MediumVioletRed, tileSize * x, tileSize * y, tileSize, tileSize);
            g.DrawRectangle(Pens.MediumVioletRed, tileSize * x + 1, tileSize * y + 1, tileSize - 2, tileSize - 2);
            g.DrawRectangle(Pens.MediumVioletRed, tileSize * x + 2, tileSize * y + 2, tileSize - 4, tileSize - 4);
        }

        Image load_resource_image(string filename)
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"Resources", filename);
            return  Image.FromFile(path);
        }
        
        private void Disable_if_enemy()
        {
            buttonE.Visible = false;
            buttonN.Visible = false;
            buttonS.Visible = false;
            buttonW.Visible = false;
            button2.Visible = false;
            soldierTrackBar.Visible = false;
        }

        void Enable_if_Friendly()
        {
            buttonE.Visible = true;
            buttonN.Visible = true;
            buttonS.Visible = true;
            buttonW.Visible = true;
            button2.Visible = true;
            soldierTrackBar.Visible = true;
        }
        
        private void Draw_Wheat(int x, int y)
        {
            string fileName = "BUMP.png";
            string path = Path.Combine(Environment.CurrentDirectory, @"Resources", fileName);
            Image wheatimg = Image.FromFile(path);

            g.DrawImage(wheatimg, x * tileSize + 1, y * tileSize + 1, tileSize - 1, tileSize - 1);
        }

        void Draw_Forest(int x, int y)
        {
            string fileName = "FOREST.png";
            string path = Path.Combine(Environment.CurrentDirectory, @"Resources", fileName);
            Image villageimg = Image.FromFile(path);
            g.DrawImage(villageimg, x * tileSize + 1, y * tileSize + 1, tileSize - 1, tileSize - 1);
        }

        void Draw_Lake(int x, int y)
        {
            List_of_tiles[x, y].PointGain = 0;
            string fileName = "WATER.png";
            string path = Path.Combine(Environment.CurrentDirectory, @"Resources", fileName);
            Image waterimg = new Bitmap(path);
            g.DrawImage(waterimg, x * tileSize + 1, y * tileSize + 1, tileSize - 1, tileSize - 1);
        }

        void soldiers_on_tile(int x, int y)
        {
            if (List_of_tiles[x, y].SoldiersOnTile > 0)
            {
                g.DrawString(List_of_tiles[x, y].SoldiersOnTile.ToString(), new Font("Arial", 8), Brushes.Black, x * tileSize + 5, y * tileSize + 5);
            }
        }
    
    }
}
