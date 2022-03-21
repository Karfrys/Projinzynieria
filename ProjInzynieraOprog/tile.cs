using System.Drawing;


namespace ProjInzynieraOprog
{
    internal class tile
    {
        Point id;
        string point_gain ;


        public Point Id
        {
            get => id; 
            set => id = value;
        }

        public string PointGain
        {
            get => point_gain;
            set => point_gain = value;
        }
    }
}
