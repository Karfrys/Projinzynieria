using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProjInzynieraOprog
{
    public partial class Form1 : Form
    {
        private static int tileSize = 45;

        private static int mapsize = 15;
       //static int coef = mapsize * tileSize;
        private int tileXposition;
        private int tileYposition;

        Bitmap bm = new Bitmap(675, 675);
        //List<tile> listoftiles = new List<tile>();
         tile [,] List_of_tiles = new tile [mapsize,mapsize];
        

        private void DrawMap()
        {
            string[] lines=GetMapSize();
            pictureBox1.Refresh();
            pictureBox1.Size = new Size(mapsize*tileSize, mapsize*tileSize);
            using (Graphics g = Graphics.FromImage(bm))
            using (SolidBrush kolorPola = new SolidBrush(Color.Gray))
            //using (SolidBrush whiteBrush = new SolidBrush(Color.Green))
            {
                int xWidth = 0;
                int yHeight = 0;
                var shape = new PointF[4];
                for (int i = 0; i < mapsize; i++)
                {
                    for (int j = 0; j < mapsize; j++)
                    {
                        tile b = new tile();
                        b.Id = new Point(i * tileSize, j * tileSize);
                        //listoftiles.Add(b);
                        List_of_tiles[i, j] = b;
                        //List_of_tiles[i, j].PointGain = 15;
                        g.FillRectangle(kolorPola, i * tileSize+1, j * tileSize+1, tileSize-1, tileSize-1);
                        shape[0] = new PointF(xWidth, yHeight);
                        xWidth = xWidth + tileSize;
                        shape[1] = new PointF(xWidth, yHeight);
                        yHeight = yHeight + tileSize;
                        shape[2] = new PointF(xWidth, yHeight);
                        xWidth = xWidth - tileSize;
                        shape[3] = new PointF(xWidth, yHeight);
                        g.DrawPolygon(Pens.Black, shape);
                        yHeight = yHeight - tileSize;
                        xWidth = xWidth + tileSize;
                    }
                    xWidth = 0;
                    yHeight = yHeight + tileSize;
                }
                int iterator=0;
                
                for (int i = 0; i < mapsize; i++)
                {
                    for (int j = 0; j < mapsize; j++)
                    {
                        List_of_tiles[i, j].PointGain  = lines[iterator];
                        iterator++;
                    }
                }
                pictureBox1.Image = bm;
            }
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
            InitializeComponent();
            GoFullscreen(true);
            DrawMap();
        }



        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            {
                int x = e.X / tileSize;
                int y = e.Y / tileSize;

                tileXposition = x * tileSize;
                tileYposition = y * tileSize;

                richTextBox_coordinates.Text = List_of_tiles[x,y].Id.ToString();
                richTextBox_PointGain.Text = List_of_tiles[x,y].PointGain.ToString();
                
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

        private void button_attack_Click(object sender, EventArgs e)
        {
            SolidBrush EnemyColor = new SolidBrush(Color.Red);
            using (var g = Graphics.FromImage(pictureBox1.Image))
            {
                g.FillRectangle(EnemyColor, tileXposition + 1, tileYposition + 1, tileSize - 1, tileSize - 1);
                pictureBox1.Refresh();
            }
        }

          string[] GetMapSize()
          {
             
              string[] elo = new string[] { };

             if (radioButton1.Checked)
            {
                string fileName = "map1.txt";
                string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
                mapsize = 15;
                string[] lines = File.ReadAllLines(path, Encoding.UTF8);
                return lines;

            }
            else if (radioButton2.Checked)
            {
                string fileName = "map2.txt";
                string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
                mapsize = 10;
                string[] lines = File.ReadAllLines(path, Encoding.UTF8);
                return lines;
            }
            else if (radioButton3.Checked)
            {
                string fileName = "map3.txt";
                string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
                mapsize = 5;
                string[] lines = File.ReadAllLines(path, Encoding.UTF8);
                return lines;
            }
             return elo;

          }


        private void button1_Click(object sender, EventArgs e)
        {
            DrawMap();
        }
    }
}
