using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace Project2
{
    public class Arena // 몬스터를 추가했을 때 정해진 배열 값에 따라 등록을 추가 하는 클래스
    {

        int mosterAddSelection;

        //Monster 등록: 상속을 통해 Monster 등록(예: 고블린, 오크, 슬라임) (check)
        //생명력 출력: 생명력이 0이 되면 맨 마지막에 등록된 몬스터 이름을 출력하는 함수 생성
        //몬스터의 생명력이 0 이하이면 몬스터는 아레나에서 사라짐 (check)
        //공격 함수: 몬스터 등록된 순서대로 각각 한 대씩 공격하는 함수 생성(예: 고블린 -> 오크 -> 슬라임 -> 고블린...)
        //현재 등록된 몬스터들 중 생명력이 가장 높은 몬스터 이름 출력 (check)
        //남은 몬스터 수: 현재 남아있는 몬스터 숫자를 가져오는 함수 (check)
        //등록 불가: 동적 배열을 활용해서 정해진 배열의 길이를 초과 시 "등록 불가" 출력 (check)

        // monsterAddQustionAnswer에 따라 몬스터 추가 결정
        // monster class에 저장된 int로 된 배열 10개 불러오기 
        // monster 생성 시 몬스터 숫자를 세는 기능 필요 -> monster Count
        // 배열 추가 시 정해진 배열의 길이를 초과 시 "등록 불가" 출력
        // 몬스터는 몬스터 class에서 관리하고 있다가 Arena class에서 추가한다고 했을 때 arena에 있는 몬스터 관리하는 배열에 추가하는 것으로 설정
        // 몬스터 클래스에 배열에 있는 것들이 추가 선택할 때마다 배열에 있던 것들이 Arena에 추가 그럴려면 만들 공간 즉 어떤 또 다른 배열이 필요
        // 속성은 랜덩으로 발생하도록 설정

        public monster[] monsters;
        public int index;
        public int monsterCount;

        public Arena(int monsterCount)
        {
            monsters = new monster[monsterCount];
            index = 0;
            monsterCount = 0;

            //Random random = new Random();
            //monsterAttribute monsterAttribute = (monsterAttribute)random.Next(Enum.GetValues(typeof(monsterAttribute)).Length);
        }

        public bool AddMonster(monster mon)
        {
            if (monsters.Length <= index)
            {
                return false;
            }

            // if (monsterCount >= monsters.Length)
            // {
            //     return false;
            // }

            // monsters[monsterCount] = mon;
            monsters[index] = mon;
            index = index + 1;
            // monsterCount = monsterCount + 1;

            // 첫번째 몬스터가 들어왔을 때
            // monsters[0] = mon;
            // 두번째 몬스터가 들어왔을 때
            // monsters[1] = mon;
            // 세번째 몬스터가 들어왔을 때
            // monsters[2] = mon;
            // 네번째 몬스터가 들어왔을 때
            // monsters[3] = mon;
            // 다섯번째 몬스터가 들어왔을 때
            // monsters[4] = mon;
            // 여섯번째 몬스터가 들어왔을 때
            // monsters[5] = mon;
            // 더이상 들어갈  자리가 없어서 return false를 해주자.


            return true;
        }

        string EnumtoString(Attribute monsterAttribute)
        {
            return monsterAttribute.ToString();
        }

        public void mosterAdd(monster monster, Attribute monsterAttribute)
        {
            Console.WriteLine("MOSTER를 추가하려면 1.YES 2. NO를 선택해주세요");
            String monsterAddQustionAnswer = Console.ReadLine();
            if (int.TryParse(monsterAddQustionAnswer, out mosterAddSelection))
            {
                if (mosterAddSelection == 1)
                {
                    Console.WriteLine("몬스터를 추가합니다.");
                    if (monsterCount < monster.monstersTimes.Length)
                    {
                        for (int i = 0; i < monster.monstersTimes.Length; i++)
                        {
                            for (int j = 0; j < monster.monstersTimes.Length; j++)
                            {
                                // 자료형의 대입
                                // 특정 자료형의 변수를 선언하고 해당 변수에 어떤 값을 할당하는 것
                                // int test = "aaaaa"; Error 같은 자료형만 대입을 할 수 있습니다.

                                // public string[] monster_nameData = new string[10];
                                // 위 데이터의 자료형은 string 배열
                                // 자료형 name = monster_nameData[0];

                                // 배열
                                // 동일한 데이터 타입의 데이터를 연속적인 메모리 공간에 저장
                                // string[] stringArray = new string[5] { }
                                // stringArray[0] = "aaa";
                                // stringArray[1] = "bbb";
                                // stringArray[2] = "ccc";
                                // stringArray[3] = "ddd";
                                // stringArray[4] = "eee";
                                // [aaa][bbb][ccc][ddd][eee]

                                // 배열에 특정 데이터에 접근한다고 하면
                                // stringArray[0] -> aaa
                                // 해당 배열에 들어있는 자료형 타입
                                // 스트링 배열 stringArray에서 특정 값을 하나 가져온다면 그 값은 string 자료형을 가지고 있습니다.

                                // string aaa = stringArray[0];

                                monster.monstersTimes[i] = new monster(monster.nameData[j], monster.hpData[j], monster.atkData[j], monster.defData[j], monsterAttribute);
                                monsterCount++;
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Arena class에 몬스터를 더 이상 추가할 수 없습니다.");
            }
        }

        // 몬스터의 체력이 0인 경우 mosterCount -1 제거 
        public int monsterRemove(monster monster)
        {
            for (int i = 0; i < monsters.Length; i++)
            {
                if (monsters[i].hpData[i] == 0)
                {
                    monsters[i] = null;
                    monsterCount -= 1;
                }
            }
            return monsterCount;
        }

        public void remainigMonsters(monster monster)
        {
            for(int i = 0; i < monsters.Length;i++)
            {
                Console.WriteLine("현재 남은 몬스터의 수는" + $"{monsters[i]}입니다.");
            }
        }


        // 생명력 출력: 생명력이 0이 되면 맨 마지막에 등록된 몬스터 이름을 출력하는 함수 생성
        // 마지막 인덱스의 이름 출력
        // 
        public void lastMonsterNamePrint(monster monster)
        {
            for (int i = 0; i < monsters.Length; i++)
            {
                if (monsters[i].hpData[i] == 0)
                {
                    monsters[i] = null;
                    monsterCount -= 1;
                }
            }
        }

        
    }
}

