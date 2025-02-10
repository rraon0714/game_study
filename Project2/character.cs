using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{

    public class character : Actor
    {
        public string character_name;
        public int character_hp;
        public int character_atk;
        public int character_def;
        public Attribute Character_Attribute;

        public static string game_character_Attribute { get; internal set; }

        public character(string name, int hp, int def, int atk, Attribute attribute)
        {
            Console.WriteLine($"{name}, {hp}, {def}, {atk}");
            character_name = name;
            character_hp = hp;
            character_def = def;
            character_atk = atk;
            Character_Attribute = attribute;
        }        

        public void TakeDamage(int damage)
        {
            character_hp -= damage;
            if (character_hp < 0) character_hp = 0;
        }


        //public void Attack(character attacker monster defender)
        //{
        //    int damage = Calculate_Damage(target, Attack_Power);
        //}

        // 등록된 몬스터들을 순서대로 공격
        // 인덱스 넘버링에 의해 자동적으로 순서에 맞게 적용 
        // 



        public void registerMonsterAttack(character attacker , monster defender)
        {
            for (int i = 0; i < defender.hpData[i]; i++)
            {

            }
        }
    }
}

