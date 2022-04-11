using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProjInzynieraOprog
{
    internal class Map
    {
        internal static int tileSize = 55;
        internal player _playerHuman = new player(1);
        readonly player _playerAi = new player(2);
        private static int mapsize = 15;
        

        SolidBrush allyColor = new SolidBrush(Color.LightSeaGreen);
        SolidBrush enemyColor = new SolidBrush(Color.LightCoral);
        SolidBrush neutralColor = new SolidBrush(Color.Gray);
        internal int tempDefenderId;
        internal int tempAttackerId;
        static Bitmap bm = new Bitmap(tileSize * mapsize, tileSize * mapsize);
        internal Tile [,] List_of_tiles = new Tile [mapsize,mapsize];
        internal List <battle> battlesToDetermine = new List<battle>();
        private bool firstRun = true;
        internal Point selectedProvince;
        private OpenFileDialog ofd;
        Graphics g = Graphics.FromImage(bm);
        internal int temppointsbalance;

        public int Temppointsbalance
        {
            get => temppointsbalance;
            set => temppointsbalance = value;
        }

        public static int TileSize
        {
            get => tileSize;
            set => tileSize = value;
        }

        public static int Mapsize
        {
            get => mapsize;
            set => mapsize = value;
        }

        public int TempDefenderId
        {
            get => tempDefenderId;
            set => tempDefenderId = value;
        }

        public int TempAttackerId
        {
            get => tempAttackerId;
            set => tempAttackerId = value;
        }

     

        internal void Draw_Wheat(int x, int y)
        {
            string fileName = "BUMP.png";
            string path = Path.Combine(Environment.CurrentDirectory, @"Resources", fileName);
            Image wheatimg = Image.FromFile(path);

            g.DrawImage(wheatimg, x * tileSize + 1, y * tileSize + 1, tileSize - 1, tileSize - 1);
        }

        internal void Draw_Forest(int x, int y)
        {
            string fileName = "FOREST.png";
            string path = Path.Combine(Environment.CurrentDirectory, @"Resources", fileName);
            Image villageimg = Image.FromFile(path);
            g.DrawImage(villageimg, x * tileSize + 1, y * tileSize + 1, tileSize - 1, tileSize - 1);
        }

        internal void Draw_Lake(int x, int y)
        {
            List_of_tiles[x, y].PointGain = 0;
            string fileName = "WATER.png";
            string path = Path.Combine(Environment.CurrentDirectory, @"Resources", fileName);
            Image waterimg = new Bitmap(path);
            g.DrawImage(waterimg, x * tileSize + 1, y * tileSize + 1, tileSize - 1, tileSize - 1);
        }

        internal void soldiers_on_tile(int x, int y)
        {
            if (List_of_tiles[x, y].SoldiersOnTile > 0)
            {
                g.DrawString(List_of_tiles[x, y].SoldiersOnTile.ToString(), new Font("Arial", 8), Brushes.Black, x * tileSize + 5, y * tileSize + 5);
            }
        }
        
        bool checkIfFriendly(int iddef, int idatc)
        {
            for (int i = 0; i < mapsize; i++)
            {
                for (int j = 0; j < mapsize; j++)
                {
                    if (List_of_tiles[i, j].PlayerControllerId == iddef)
                    {
                        for(int k=0; k<mapsize; k++)
                        {
                            for(int l=0; l<mapsize; l++)
                            {
                                if(List_of_tiles[k, l].PlayerControllerId == idatc)
                                {
                                    if(List_of_tiles[k,l].PlayerControllerId==List_of_tiles[i,j].PlayerControllerId)
                                    {
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return false;

        }

        internal Image load_resource_image(string filename)
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"Resources", filename);
            return  Image.FromFile(path);
        }
        
        internal void Draw_Frame(int x, int y)
        {
            g.DrawRectangle(Pens.MediumVioletRed, tileSize * x, tileSize * y, tileSize, tileSize);
            g.DrawRectangle(Pens.MediumVioletRed, tileSize * x + 1, tileSize * y + 1, tileSize - 2, tileSize - 2);
            g.DrawRectangle(Pens.MediumVioletRed, tileSize * x + 2, tileSize * y + 2, tileSize - 4, tileSize - 4);
        }
        
        internal void CreateMaps(int size,int map)
        {
            string name = "map" + map.ToString() + ".txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", name);
            StreamWriter sw;
            sw = new StreamWriter(path, false);
            Random r = new Random();
            string line;
            int pg; //assigning random pointgain for each tile// 
            int type; //0-clearing , 1-forest, 2-water //
            int own; //ownership //
            for (int i = 0; i < size; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < size; j++)
                {
                    pg = r.Next(10, 30);
                    type = r.Next(0, 3);
                    if (i < 2 && j < 2)
                    {
                        own = 1;
                    }
                    else if (i > size - 3 && j > size - 3)
                    {
                        own = 2;
                    }
                    else
                    {
                        own = 0;
                    }
                    sb.Append(pg.ToString()+"|"+type.ToString()+"|"+own.ToString()+"#");
                }
                line = sb.ToString();
                sw.WriteLine(line);
            }
            sw.Close();
        }
        
        internal string [,] GetMapSize()
        {
            int iterator = 0;
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", "map1.txt");;
            mapsize = 15;
            if (Form1.Get_SaveFile() != null)
            {
                path = Form1.Get_SaveFile();
            }
            string[,] Tiles = new string[mapsize, mapsize];

            //string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            mapsize = lines.Length;

            for (int i = 0; i < mapsize; i++) 
            {
                iterator = 0;
                for (int j = 0; j < mapsize; j++)
                {
                    Tiles[i, j] = lines[i].Substring(iterator, 6);
                    iterator += 7;
                       
                }
            } 
            return Tiles;
        }

        internal Bitmap DrawMap()
        {
            int iter = 0;
            string[,] tiles = GetMapSize();
            for (int i = 0; i < mapsize; i++)
            {
                for (int j = 0; j < mapsize; j++)
                {
                    if (firstRun == true)
                    {
                        Tile b = new Tile();
                        b.Id = iter;
                        iter++;
                        List_of_tiles[i, j] = b;
                        List_of_tiles[i, j].PointGain = int.Parse(tiles[i, j].Substring(0, 2));
                        List_of_tiles[i, j].Type = int.Parse(tiles[i, j].Substring(3, 1));
                        List_of_tiles[i, j].PlayerControllerId = int.Parse(tiles[i, j].Substring(5, 1));
                    }

                    if (List_of_tiles[i, j].PlayerControllerId == 1)
                    {
                        g.FillRectangle(allyColor, i * tileSize + 1, j * tileSize + 1, tileSize - 1, tileSize - 1);
                        
                    }
                    else if (List_of_tiles[i, j].PlayerControllerId == 2)
                    {
                        g.FillRectangle(enemyColor, i * tileSize + 1, j * tileSize + 1, tileSize - 1, tileSize - 1);
                    }
                    else
                    {
                        g.FillRectangle(neutralColor, i * tileSize + 1, j * tileSize + 1, tileSize - 1, tileSize - 1);
                    }

                    if (List_of_tiles[i, j].Type == 2)
                    {
                        Draw_Lake(i, j);
                    }

                    if (List_of_tiles[i, j].Type == 1)
                    {
                        Draw_Forest(i, j);
                    }

                    if (List_of_tiles[i, j].Type == 0)
                    {
                        Draw_Wheat(i, j);
                    }
                    soldiers_on_tile(i,j);
                    g.DrawRectangle(Pens.Black, tileSize * i, tileSize * j, tileSize, tileSize);
                }
            }
            firstRun = false;
            return bm;
        }

        internal void write_save_file(string path)
        {
            StreamWriter sw;
            string line;
            
            sw = new StreamWriter(path, false);
            for (int x = 0; x < mapsize; x++)
            {
                StringBuilder sb = new StringBuilder();
                for (int y = 0; y < mapsize; y++)
                {
                    if (List_of_tiles[x, y].PointGain == 0)
                    {
                        List_of_tiles[x, y].PointGain = 99;
                    }
                    sb.Append(List_of_tiles[x,y].PointGain.ToString()+"|"+List_of_tiles[x,y].Type.ToString()+"|"+List_of_tiles[x,y].PlayerControllerId.ToString()+"#");
                }
                line = sb.ToString();
                sw.WriteLine(line);
            }
            sw.Close();
        }

        public void First_Run()
        {
            firstRun = true;
        }
        
        int get_soldier_num_by_id(int defid)
        {
            int solCount;
            for (int i = 0; i < mapsize; i++)
            {
                for (int j = 0; j < mapsize; j++)
                {
                    if (List_of_tiles[i, j].Id == defid)
                    {
                        solCount = List_of_tiles[i, j].SoldiersOnTile;
                        return solCount;
                    }
                }
            }
            return 0;
        }
        
       

        public void battle_simulation()
        {
            for (int i = 0; i < mapsize; i++)
            {
                for (int j = 0; j < mapsize; j++)
                {
                    if (List_of_tiles[i, j].PlayerControllerId == 1)
                    {
                        _playerHuman.PointsBalance += Convert.ToInt32(List_of_tiles[i, j].PointGain);
                    }
                    else if (List_of_tiles[i, j].PlayerControllerId == 2)
                    {
                        _playerAi.PointsBalance += Convert.ToInt32(List_of_tiles[i, j].PointGain);
                    }
                }
            }
            //basic battle simulation

          
            int attackerID=0;
            int defenderID = 0;


            for (int k = 0; k < battlesToDetermine.Count; k++)
            {
                for (int i = 0; i < mapsize; i++)
                {
                    for (int j = 0; j < mapsize; j++)
                    {
                        if (battlesToDetermine[k].AttackerProvinceId == List_of_tiles[i, j].Id)
                        {
                            attackerID = List_of_tiles[i, j].PlayerControllerId;
                            break;
                        }
                    }
                }

                for (int i = 0; i < mapsize; i++)
                {
                    for (int j = 0; j < mapsize; j++)
                    {
                        if (battlesToDetermine[k].DefenderProvinceId == List_of_tiles[i, j].Id)
                        {
                            defenderID = List_of_tiles[i, j].PlayerControllerId;
                            break;
                        }
                    }
                }

                if (defenderID == attackerID)
                {
                    for (int i = 0; i < mapsize; i++)
                    {
                        for (int j = 0; j < mapsize; j++)
                        {
                            if (List_of_tiles[i, j].Id == battlesToDetermine[k].AttackerProvinceId)
                            {
                                List_of_tiles[i, j].SoldiersOnTile -= battlesToDetermine[k].SoldierNum;
                                for (int y = 0; y < mapsize; y++)
                                {
                                    for (int z = 0; z < mapsize; z++)
                                    {
                                        if (List_of_tiles[y, z].Id == battlesToDetermine[k].DefenderProvinceId)
                                        {
                                            List_of_tiles[y, z].SoldiersOnTile += battlesToDetermine[k].SoldierNum;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < mapsize; i++)
                    {
                        for (int j = 0; j < mapsize; j++)
                        {
                            if (List_of_tiles[i, j].Id == battlesToDetermine[k].DefenderProvinceId)
                            {
                                if (List_of_tiles[i, j].SoldiersOnTile > battlesToDetermine[k].SoldierNum)
                                {
                                    for (int z = 0; z < mapsize; z++)
                                    {
                                        for (int y = 0; y < mapsize; y++)
                                        {
                                            if (List_of_tiles[z, y].Id == battlesToDetermine[k].AttackerProvinceId)
                                            {
                                                List_of_tiles[z, y].SoldiersOnTile -= battlesToDetermine[k].SoldierNum;
                                                break;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    for (int z = 0; z < mapsize; z++)
                                    {
                                        for (int y = 0; y < mapsize; y++)
                                        {
                                            if (List_of_tiles[z, y].Id == battlesToDetermine[k].AttackerProvinceId)
                                            {
                                                int temp;
                                                List_of_tiles[z,y].SoldiersOnTile-=battlesToDetermine[k].SoldierNum;
                                                temp = battlesToDetermine[k].SoldierNum-List_of_tiles[i,j].SoldiersOnTile;
                                                List_of_tiles[i, j].SoldiersOnTile = temp;
                                                List_of_tiles[i, j].PlayerControllerId = attackerID;
                                                break;
                                            }
                                        }
                                    }

                                }
                            }




                        }
                    }
                }
            }
            

            battlesToDetermine.Clear();
        }

        
        public void Uprgade(int clickedX, int clickedY)
        {
            List_of_tiles[clickedX,clickedY].isUpgraded1 = true;
        }
        
        struct Provinces
        {
          public int defender_id;       
          public int attacker_id;
          public int soldiers;
        }

       public void playerAiController()
        {
            
            List<Provinces> provinces = new List<Provinces>();

            int iterator = 0;
            //sprawdza ile prowincji graniczy z neutralnymi/wrogimi
            
            int counter = 0;
            
            for (int i = 0; i < mapsize; i++)
            {
                for (int j = 0; j < mapsize; j++)
                {
                    if (List_of_tiles[i, j].PlayerControllerId == 2)
                    {
                        if (i != 0)
                        {
                            if(List_of_tiles[i-1,j].PlayerControllerId !=2)
                            {
                                Provinces p= new Provinces();
                                p.attacker_id = List_of_tiles[i, j].Id;
                                p.defender_id = List_of_tiles[i - 1, j].Id;
                                provinces.Add(p);
                            }
                        }

                        if (i != mapsize-1)
                        {
                            if(List_of_tiles[i+1,j].PlayerControllerId !=2)
                            {
                                Provinces p= new Provinces();
                                p.attacker_id = List_of_tiles[i, j].Id;
                                p.defender_id = List_of_tiles[i + 1, j].Id;
                                provinces.Add(p);
                                counter++;
                            }
                        }
                            
                        
                        if (j != 0)
                        {
                            if(List_of_tiles[i,j-1].PlayerControllerId !=2)
                            {
                                Provinces p= new Provinces();
                                p.attacker_id = List_of_tiles[i, j].Id;
                                p.defender_id = List_of_tiles[i, j - 1].Id;
                                provinces.Add(p);
                                counter++;
                            }
                        }
                        if (j != mapsize-1)
                        {
                            if(List_of_tiles[i,j+1].PlayerControllerId !=2)
                            {
                                Provinces p= new Provinces();
                                p.attacker_id = List_of_tiles[i, j].Id;
                                p.defender_id = List_of_tiles[i, j + 1].Id;
                                provinces.Add(p);
                                counter++;
                            }
                        }
                    }
                }
            }
            
            Double pointsToSpend = _playerAi.PointsBalance/counter;
            pointsToSpend  = Math.Floor(pointsToSpend);
            int points = Convert.ToInt32(pointsToSpend);
            
            //rekrutuje wojska na prowincjach graniczacych z neutralnymi/wrogimi
            
            for (int i = 0; i < mapsize; i++)
            {
                for (int j = 0; j < mapsize; j++)
                {
                    if (List_of_tiles[i, j].PlayerControllerId == 2)
                    {
                        if (i != 0)
                        {
                            if(List_of_tiles[i-1,j].PlayerControllerId !=2)
                            {
                                _playerAi.PointsBalance -= points;
                                List_of_tiles[i,j].SoldiersOnTile += points;
                            }
                        }
                        
                        if(i!=mapsize-1)
                            if(List_of_tiles[i+1,j].PlayerControllerId !=2)
                            {
                                _playerAi.PointsBalance -= points;
                                List_of_tiles[i,j].SoldiersOnTile += points;                            
                            }
                        
                        if (j != 0)
                        {
                            if(List_of_tiles[i,j-1].PlayerControllerId !=2)
                            {
                                _playerAi.PointsBalance -= points;
                                List_of_tiles[i,j].SoldiersOnTile += points;
                            }
                        }
                        if (j != mapsize-1)
                        {
                            if(List_of_tiles[i,j+1].PlayerControllerId !=2)
                            {
                                _playerAi.PointsBalance -= points;
                                List_of_tiles[i,j].SoldiersOnTile += points;
                            }
                        }
                    }
                       
                }
            }

           for(int i=0; i<provinces.Count; i++)
            {
                battle b=new battle(provinces[i].attacker_id,provinces[i].defender_id,points);
                battlesToDetermine.Add(b);
            }



        }
        
    }
}