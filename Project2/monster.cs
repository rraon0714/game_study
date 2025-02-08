using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project2
{
    public class monster : Actor
    {
        public string[] monster_nameData = new string[10];
        public int[] monster_hpData = new int[10];
        public int[] monster_atkData = new int[10];
        public int[] monster_defData = new int[10];
        public Attribute monster_Attribute;

        public monster(string[] name, int[] hp, int[] atk, int[] def, Attribute Attribute)
        {
            Console.WriteLine($"{name}, {hp}, {atk} , {def} {Attribute}");
            monster_nameData = name;
            monster_hpData = hp;
            monster_atkData = atk;
            monster_defData = def;
            Attribute = monster_Attribute;
        }
        
        // Arena class에 들어갈 몬스터 수 설정
       

        public int[] monstersTimes = new int[10];
        
        public int[] hpData = { 10, 20, 30, 40, 50, 100, 150, 200, 120, 180 };

        public int[] atkData = { 5, 15, 30, 40, 30, 10, 25, 45, 120, 150 };

        public int[] defData = { 10, 15, 20, 25, 30, 35, 40, 45, 50, 55};

        public string[] nameData = { "고블린", "오크", "슬라임", "monster4", "monster5", "monster6", "monster7", "monster8", "monster9", "monster10" };
        

        public static implicit operator int(monster v)
        {
            throw new NotImplementedException();
        }

        public void highHP ()
        {
            for (int i = 0; i< monster_hpData.Length; i++)
            {
                for(int j = 0; j< hpData.Length; j++)
                {
                    if(monster_hpData[i] > hpData[j])
                    {
                        
                    }

                }
            }
        }
    }
}
