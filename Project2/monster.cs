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
        

        public monster(string name, int hp, int atk, int def, Attribute attribute)
        {
            Console.WriteLine($"{name}, {hp}, {atk} , {def} {Attribute}");
            Name = name;
            Hp = hp;
            Atk = atk;
            Def = def;
            Attribute = attribute;
        }
        
        // Arena class에 들어갈 몬스터 수 설정
       

        public static monster[] monstersTimes = new monster[10];
        
        public int[] hpData = { 10, 20, 30, 40, 50, 100, 150, 200, 120, 180 };

        public int[] atkData = { 5, 15, 30, 40, 30, 10, 25, 45, 120, 150 };

        public int[] defData = { 10, 15, 20, 25, 30, 35, 40, 45, 50, 55};

        public string[] nameData = { "고블린", "오크", "슬라임", "monster4", "monster5", "monster6", "monster7", "monster8", "monster9", "monster10" };


        //몬스터가 받는 피해
        //game_operation calculate 데미지 게산을 적용
        public void TakeDamage(int damage)
        {
            for (int i = 0; i < hpData.Length; i++)
            {
                hpData[i] -= damage;
            }
        }

    }
}
