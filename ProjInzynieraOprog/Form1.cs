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

        Bitmap bm = new Bitmap(coef, coef);
        List<tile> listoftiles = new List<tile>();




        private void DrawMap()
        {

            pictureBox1.Size = new Size(coef, coef);
            using (Graphics g = Graphics.FromImage(bm))
            using (SolidBrush kolorPola = new SolidBrush(Color.Gray))
            //using (SolidBrush whiteBrush = new SolidBrush(Color.Green))
            {
                for (int i = 0; i < mapsize; i++)
                {
                    for (int j = 0; j < mapsize; j++)
                    {
                        tile b = new tile();
                        b.Id = new Point(i * tileSize, j * tileSize);
                        b.Color = false;
                        listoftiles.Add(b);
                        g.FillRectangle(kolorPola, i * tileSize, j * tileSize, tileSize, tileSize);

                    }
                }
                int xWidth = 0;
                int yHeight = 0;
                var shape = new PointF[4];
                for (int y = 0; y < mapsize; y++)
                {
                    for (int i = 0; i < mapsize; i++)
                    {
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



        public Form1()
        {
            InitializeComponent();
            DrawMap();
        }



        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            {

                double x;
                double y;
                x = e.X;
                y = e.Y;

                int counterx = e.X / tileSize;
                int countery = e.Y / tileSize;



                int tileXposition = counterx * tileSize;
                int tileYposition = countery * tileSize;

                SolidBrush EnemyColor = new SolidBrush(Color.Red);
                using (var g = Graphics.FromImage(pictureBox1.Image))
                {
                    g.FillRectangle(EnemyColor, tileXposition + 1, tileYposition + 1, tileSize - 1, tileSize - 1);
                    pictureBox1.Refresh();
                }



            }
        }



    }
}
