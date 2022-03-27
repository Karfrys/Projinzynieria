namespace ProjInzynieraOprog
{
    public class battle
    {
        private int attackerProvinceId;
        private int defenderProvinceId;
        private int soldierNum;

        public battle(int attacker, int defender, int soldiers)
        {
            attackerProvinceId = attacker;
            defenderProvinceId = defender;
            soldierNum = soldiers;
        }
        
        public int AttackerProvinceId
        {
            get => attackerProvinceId;
            set => attackerProvinceId = value;
        }

        public int DefenderProvinceId
        {
            get => defenderProvinceId;
            set => defenderProvinceId = value;
        }

        public int SoldierNum
        {
            get => soldierNum;
            set => soldierNum = value;
        }

        
    }
}