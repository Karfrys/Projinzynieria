using System.Drawing;


namespace ProjInzynieraOprog
{
    internal class tile
    {
        Point id;
        int pointGain;
        private int type;
        private int ownership;

        public Point Id
        {
            get => id; 
            set => id = value;
        }

        public int PointGain
        {
            get => pointGain;
            set => pointGain = value;
        }

        public int Type
        {
            get => type;
            set => type = value;
        }

        public int Ownership
        {
            get => ownership;
            set => ownership = value;
        }
        
    }
}
