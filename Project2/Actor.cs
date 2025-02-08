using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Actor
    {
        public string Name;
        public int Hp;
        public int Atk;
        public int Def;
        public Attribute attribute;


        public static int attribute_selection(string attributeString)
        {
            Console.WriteLine("캐릭터 속성을 선택하세요.");
            Console.WriteLine("1.불 2.물 3.바람 4.땅");
            Console.ReadLine();

            if (Attribute.Fire.ToString() == attributeString)
            {
                return (int)Attribute.Fire;
            }
            else if (Attribute.Water.ToString() == attributeString)
            {
                return (int)Attribute.Water;
            }
            else if (Attribute.Wind.ToString() == attributeString)
            {
                return (int)Attribute.Wind;
            }
            else if (Attribute.Earth.ToString() == attributeString)
            {
                return (int)Attribute.Earth;
            }
            else
            {
                return (int)Attribute.None;
            }
        }

        public static Attribute ConvertAttributeFromNumber(string attributeString)
        {
            int number = Convert.ToInt32(attributeString);
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


        public void PrintInfo()
        {
            Console.WriteLine($"이름은 {Name}");
            Console.WriteLine($"생명력은 {Hp}");
            Console.WriteLine($"방어력은 {Def}");
            Console.WriteLine($"공격력은 {Atk}");
            Console.WriteLine($"속성은 {attribute}");
        }

        
    }
}
