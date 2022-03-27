using System.Drawing;


namespace ProjInzynieraOprog
{
    internal class tile
    {
        int id;


        string point_gain ;
        private int playerControllerId;
        private int soldiersOnTile;

        public int SoldiersOnTile
        {
            get => soldiersOnTile;
            set => soldiersOnTile = value;
        }

        public int PlayerControllerId
        {
            get => playerControllerId;
            set => playerControllerId = value;
        }


        public int Id
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

        
    }
}
