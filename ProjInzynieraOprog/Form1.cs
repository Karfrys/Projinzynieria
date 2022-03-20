using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjInzynieraOprog
{
    public partial class Form1 : Form
    {
        static int tileSize = 35;
        static int mapsize = 15;
        static int coef = tileSize * mapsize;

        private int tileXposition;
        private int tileYposition;

        Bitmap bm = new Bitmap(coef, coef);
        //List<tile> listoftiles = new List<tile>();
        tile [,] List_of_tiles = new tile [mapsize,mapsize];
        

        private void DrawMap()
        {

            pictureBox1.Size = new Size(coef, coef);
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
                pictureBox1.Image = bm;
            }
        }

        
        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.Sizable;
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
    }
}
