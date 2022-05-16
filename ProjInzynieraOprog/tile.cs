using System.Drawing;


namespace ProjInzynieraOprog
{
    internal class Tile
    {
        int id;


        int pointGain ;
        private int playerControllerId;
        private int soldiersOnTile=0;
        private int type;
        int foresttype;
        bool isUpgraded;
        
        

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

        public bool isUpgraded1
        {
            get => isUpgraded;
            set => isUpgraded = value;
        }
        public int Foresttype { get => foresttype; set => foresttype = value; }
    }
}
