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

        //캐릭터가 받는 피해량 설정
        public void TakeDamage(int damage)
        {
            character_hp -= damage;
            if (character_hp < 0) character_hp = 0;
        }
    }
}

