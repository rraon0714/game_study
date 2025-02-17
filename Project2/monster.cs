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
        public string monster_nameData;
        public int monster_hpData;
        public int monster_atkData;
        public int monster_defData;
        public Attribute monster_Attribute;

        public monster(string name, int hp, int atk, int def, Attribute Attribute)
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

        // 현재 등록된 몬스터들 중 생명력이 가장 높은 몬스터 이름 출력
        // hpdata 0~9까지 비교 -> 변수 생성
        // hpdata끼리 비교했을 때 해당하는 name data 인덱스의 이름 출력?
        // hpdata 비교를 끝내고 인덱스 넘버를 출력 
        // index number와 nameData 같은 인덱스와 일치

        public void MonsterMaximumHpPrint()
        {
            int maxHp = 0;
            int maxIndex = 0;



            for (int i = 0; i < hpData.Length; i++)
            {
                for (int j = 1; j < hpData.Length; j++)
                {
                    if (hpData[i] > hpData[j])
                    {
                        maxHp = hpData[i];
                        maxIndex = i;
                        
                    }
                }
                
            }

        }
    }
}
