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

    public class character
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

        

        public static int character_attribute_selection(string game_character_Attribute)
        {
            Console.WriteLine("게임 캐릭터 속성을 선택하세요.");
            Console.WriteLine("1.불 2.물 3.바람 4.땅");
            Console.ReadLine();
            
            if (Attribute.Fire.ToString() == game_character_Attribute)
            {
                return (int)Attribute.Fire;
            }
            else if (Attribute.Water.ToString() == game_character_Attribute)
            {
                return (int)Attribute.Water;
            }
            else if (Attribute.Wind.ToString() == game_character_Attribute)
            {
                return (int)Attribute.Wind;
            }
            else if (Attribute.Earth.ToString() == game_character_Attribute)
            {
                return (int)Attribute.Earth;
            }
            else
            {
                return (int)Attribute.None;
            }
        }
        

        public void TakeDamage(int damage)
        {
            character_hp -= damage;
            if (character_hp < 0) character_hp = 0;
        }

        public void CharacterPrintInfo()
        {
            Console.WriteLine($"이름은 {character_name}");
            Console.WriteLine($"생명력은 {character_hp}");
            Console.WriteLine($"방어력은 {character_def}");
            Console.WriteLine($"공격력은 {character_atk}");
            Console.WriteLine($"속성은 {Character_Attribute}");
        }
        
        public static Attribute Character_ConvertAttributeFromNumber(string character_Attribute)
        {
            int number = Convert.ToInt32(character_Attribute);
            //string game_character_Attribute = Console.ReadLine();
            number = number - 1;
            if (Attribute.Fire == (Attribute)number)
            {
                return Attribute.Fire;
            }
            else if (Attribute.Water == (Attribute)number)
            {
                return Attribute.Water;
            }
            else if (Attribute.Wind == (Attribute)number)
            {
                return Attribute.Wind;
            }
            else if (Attribute.Earth == (Attribute)number)
            {
                return Attribute.Earth;
            }
            else
            {
                return Attribute.None;
            }
        }

        public void Attack(monster target)
        {
            //int damage = Calculate_Damage(target, Attack_Power);
        }

        
    }
}

