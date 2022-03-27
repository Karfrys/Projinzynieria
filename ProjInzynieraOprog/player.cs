using System.Drawing;

namespace ProjInzynieraOprog
{
    public class player
    {
        private SolidBrush PlayerColor;
        private int pointsBalance;
        private int PlayerId;

        public player(int playerId)
        {
            PlayerId = playerId;
        }
        
        public int PlayerId1
        {
            get => PlayerId;
            set => PlayerId = value;
        }

        public int PointsBalance
        {
            get => pointsBalance;
            set => pointsBalance = value;
        }

        

        public SolidBrush PlayerColor1
        {
            get => PlayerColor;
            set => PlayerColor = value;
        }
    }
}