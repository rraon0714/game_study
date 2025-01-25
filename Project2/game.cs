using Project2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

class game
{


    public static void Main()
    {
        game_operation game_play = new game_operation();

        Console.WriteLine("캐릭터 이름을 입력해주세요");
        string character_name = Console.ReadLine();

        Console.WriteLine("캐릭터의 속성을 입력해주세요 (Fire, Water, Wind, Earth)");
        string Character_Attribute = Console.ReadLine();
        Project2.Attribute attribute = character.Character_ConvertAttributeFromNumber(Character_Attribute);

        character character2 = new character(character_name, 100, 10, 20, Character_Attribute);
        character2.CharacterPrintInfo();

        Console.WriteLine("몬스터의 속성을 입력해주세요 (Fire, Water, Wind, Earth)");
        string monster_Attribute = Console.ReadLine();
        Project2.Attribute mon_attribute = monster.Moster_ConvertAttributeFromNumber(monster_Attribute);

        monster game_monster = new monster("tt", 50, 15, 5, monster_Attribute);
        game_monster.MonsterPrintInfo();

        int damage = game_play.CalculateDamage(character2, game_monster);
        Console.WriteLine($"{character2.character_name}이 {game_monster.monster_name}에게 {damage}의 데미지를 입혔습니다.");

        game_monster.monster_hp -= damage;
        Console.WriteLine($"{game_monster.monster_name}의 남은 체력: {game_monster.monster_hp}");
        

 



    }
}