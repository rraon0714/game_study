using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class monster
    {
        public string monster_name;
        public int monster_hp;
        public int monster_atk;
        public int monster_def;
        public Attribute monster_Attribute;

        public monster(string name, int hp, int atk, int def, Attribute Attribute) 
        {
            Console.WriteLine($"{name}, {hp}, {atk} , {def} {Attribute}");
            monster_name  = name;
            monster_hp = hp;
            monster_atk = atk;
            monster_def = def;
            Attribute = monster_Attribute;
        }



        public void MonsterPrintInfo()
        {
            Console.WriteLine($"이름은 {monster_name}");
            Console.WriteLine($"생명력은 {monster_hp}");
            Console.WriteLine($"방어력은 {monster_def}");
            Console.WriteLine($"공격력은 {monster_atk}");
            Console.WriteLine($"속성은 {monster_Attribute}");
        }

        public static Attribute Moster_ConvertAttributeFromNumber(string monster_Attribute)
        {
            int number = Convert.ToInt32(monster_Attribute);
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

      
    }
}
