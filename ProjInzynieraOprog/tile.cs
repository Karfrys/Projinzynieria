using System.Drawing;


namespace ProjInzynieraOprog
{
    internal class tile
    {
        Point id;
        private int point_gain = 0;


        public Point Id
        {
            get => id; 
            set => id = value;
        }

        public int PointGain
        {
            get => point_gain;
            set => point_gain = value;
        }
    }
}
