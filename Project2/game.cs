using Project2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

class game
{


    public static void Main()
    {
        //monster monster;
        //Arena arena;
        //game_operation game_play = new game_operation();

        //Console.WriteLine("캐릭터 이름을 입력해주세요");
        //string character_name = Console.ReadLine();

        //Console.WriteLine("캐릭터의 속성을 입력해주세요 (1. Fire, 2. Water, 3. Wind, 4. Earth)");
        //string Character_Attribute = Console.ReadLine();

        //Project2.Attribute attribute = character.ConvertAttributeFromNumber(Character_Attribute);

        //character character2 = new character(character_name, 100, 10, 20, attribute);
        //character2.PrintInfo();


        //Console.WriteLine("몬스터의 속성을 입력해주세요 (1. Fire, 2. Water, 3. Wind, 4. Earth)");
        //string monster_Attribute = Console.ReadLine();
        //Project2.Attribute mon_attribute = monster.ConvertAttributeFromNumber(monster_Attribute);

        //monster game_monster = new monster("tt", 50, 15, 5, mon_attribute);
        //game_monster.PrintInfo();

        //int damage = game_play.CalculateDamage(character2, game_monster);
        //Console.WriteLine($"{character2.character_name}이 {game_monster.monster_name}에게 {damage}의 데미지를 입혔습니다.");

        //game_monster.monster_hp -= damage;
        //Console.WriteLine($"{game_monster.monster_name}의 남은 체력: {game_monster.monster_hp}");


        monster ork = new monster("오크", 100, 20, 10, Project2.Attribute.Earth);
        monster goblin = new monster("고블린", 20, 10, 5, Project2.Attribute.Wind);
        monster slime = new monster("슬라임", 20, 10, 5, Project2.Attribute.Wind);
        monster dragon = new monster("드래곤", 20, 10, 5, Project2.Attribute.Wind);
        monster troll = new monster("트롤", 20, 10, 5, Project2.Attribute.Wind);
        monster skeleton = new monster("스켈레톤", 20, 10, 5, Project2.Attribute.Wind);

        //Arena arena = new Arena(5);
        //bool isSuccess = false;

        //isSuccess = arena.AddMonster(ork);
        //if (isSuccess)
        //{
        //    Console.WriteLine("몬스터 추가 성공");
        //}

        //isSuccess = arena.AddMonster(goblin);
        //if (isSuccess)
        //{
        //    Console.WriteLine("몬스터 추가 성공");
        //}

        //isSuccess = arena.AddMonster(slime);
        //if (isSuccess)
        //{
        //    Console.WriteLine("몬스터 추가 성공");
        //}

        //isSuccess = arena.AddMonster(dragon);
        //if (isSuccess)
        //{
        //    Console.WriteLine("몬스터 추가 성공");
        //}

        //isSuccess = arena.AddMonster(troll);
        //if (isSuccess)
        //{
        //    Console.WriteLine("몬스터 추가 성공");
        //}

        //isSuccess = arena.AddMonster(skeleton);
        //if (isSuccess)
        //{
        //    Console.WriteLine("몬스터 추가 성공");
        //}
        //else
        //{
        //    Console.WriteLine("몬스터 추가 실패");
        //}


        int[] hpData = { 10, 20, 30, 40, 50, 100, 150, 200, 120, 180 };
        int[] atkData = { 5, 15, 30, 40, 30, 10, 25, 45, 120, 150 };
        int[] defData = { 10, 15, 20, 25, 30, 35, 40, 45, 50, 55 };
        string[] nameData = { "고블린", "오크", "슬라임", "트롤", "드래곤", "스켈리톤", "오우거", "monster8", "monster9", "monster10" };

        Arena arena2 = new Arena(10);

        for (int i = 0; i < nameData.Length; ++i)
        {
            Random random = new Random();
            Project2.Attribute monsterAttribute = (Project2.Attribute)random.Next(Enum.GetValues(typeof(Project2.Attribute)).Length);
            monster monster = new monster(nameData[i], hpData[i], atkData[i], defData[i], monsterAttribute);

            bool isSuccess2 = arena2.AddMonster(monster);
            if (isSuccess2)
            {
                Console.WriteLine($"{monster.monster_nameData} 몬스터 추가 성공");
            }
            else
            {
                Console.WriteLine($"{monster.monster_nameData} 몬스터 추가 실패");
            }


            monster.MonsterMaximumHpPrint();
        }
    }
}