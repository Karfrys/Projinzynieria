using System;
using System.Drawing;

namespace ProjInzynieraOprog
{
    public class player
    {
        private SolidBrush PlayerColor;
        private int pointsBalance=100;
        private int PlayerId;
        city city;

        public city City
        {
            get => city;
            set => city = value;
        }

        public player(int playerId)
        {
            PlayerId = playerId;
            city = new city();
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