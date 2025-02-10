using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class game_operation
    {
        public Boolean game_over = false; // true로 변경되면 게임 종료
        public double damage = 1;
        Attribute Attribute;
        character character;
        monster monster;
        Boolean gameProgress = false;



        public int CalculateDamage(Actor attacker, Actor defender)
        {
            // 데미지 계산
            // attacker, defender
            // (때린애 공격력 - 맞은애 방어력) * 속성 상성
            int atk = attacker.Atk;
            int def = defender.Def;

            int basicDamage = atk - def;

            double additionalAttributeDamage = GetAdditionalAttributeDamage(attacker.attribute, defender.attribute);

            double damage = basicDamage * additionalAttributeDamage;

            int totalDamage = (int)Math.Truncate(damage);

            if (totalDamage < 0)
            {
                totalDamage = 1;
            }

            return totalDamage;
        }

        public double GetAdditionalAttributeDamage(Attribute attackAttribute, Attribute defenderAttribute)
        {
            if (attackAttribute == Attribute.Fire && defenderAttribute == Attribute.Wind)
                return 1.5;
            else if (attackAttribute == Attribute.Fire && defenderAttribute == Attribute.Water)
                return 0.5;
            else if (attackAttribute == Attribute.Fire && defenderAttribute == Attribute.Earth)
                return 0.5;
            else if (attackAttribute == Attribute.Water && defenderAttribute == Attribute.Fire)
                return 1.5;
            else if (attackAttribute == Attribute.Water && defenderAttribute == Attribute.Earth)
                return 1.5;
            else if (attackAttribute == Attribute.Water && defenderAttribute == Attribute.Wind)
                return 0.5;
            else if (attackAttribute == Attribute.Wind && defenderAttribute == Attribute.Water)
                return 1.5;
            else if (attackAttribute == Attribute.Wind && defenderAttribute == Attribute.Earth)
                return 1.5;
            else if (attackAttribute == Attribute.Wind && defenderAttribute == Attribute.Fire)
                return 0.5;
            else if (attackAttribute == Attribute.Earth && defenderAttribute == Attribute.Fire)
                return 1.5;
            else if (attackAttribute == Attribute.Earth && defenderAttribute == Attribute.Wind)
                return 0.5;
            else if (attackAttribute == Attribute.Earth && defenderAttribute == Attribute.Water)
                return 0.5;
            else
                return 1;
        }



        //public void npc_Attack(monster target, int attack_power)
        //{
        //    int damage = calculate_damage(target, attack_power);
        //}

        //public String 캐릭터이름(String 이름)
        //{
        //    return 이름;
        //}
        // 생성자로부터 받기 위해서는 매개 변수가 필요
        // 생성자에게 받는 정보 
        // 캐릭터로부터 이름, 생명력, 방어력 console.readline()  -> game 클래스에서 이름만 입력받아서 사용
        // 속성 관계 조건문으로 상성 역상성 무상성 등을 공격력 등을 설정 -> 조건문 활용
        // 속성에 따른 공격 및 피해량이 설정됨
        //  1. 불 > 바람 && 물, 땅 > 불
        //  2. 물 > 불 && 바람 > 물
        //  3. 땅 > 불 && 바람 > 땅
        //  4. 바람 > 물 && 불 > 바람



        //  함수
        //- 자기 자신에게 Damage를 주는 함수
        //-> 생명력이 50일 때, 자기 자신에게 damage를 주는 함수(5) 생명력 45   

        //  damage 연산
        //- damage 최소 값 = 1
        //- 때리는 애 -> 공격력
        //- 맞는 애 -> 방어력 
        //- 속성이 상성이라면 damage 1.5배 
        //- 역상성 0.5배
        //- 무상성 1배


        //  매개변수 이름 방어력 생명력
        //  이름은 자율적으로 입력에 따라 저장 -> ReadLine() 사용
        //  상대방 공격하는 함수 생성
        //  npc와 자신의 속성에 따라 공격과 방어력 수치가 달라져야함
        //  자신의 생명력이 줄어드는 함수 생성
        //  생명력이 상대방 공격 시 계속 변화해야됨 -> while문 사용
        //  몬스터를 선택하는 함수 만들어서 인자로는 공격할 몬스터를 선택                                                                                                                                                                             
        //  피해량을 속성 관계(상성, 역상성, 무상성)에 따른 피해량을 적용
        //  생명력이 낮을 경우 게임 종료

    }
}

