using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace Project2
{
    public class Arena
    {
        
        int monsterCount;
        int mosterAddSelection;
        
        //Monster 등록: 상속을 통해 Monster 등록(예: 고블린, 오크, 슬라임)
        //생명력 출력: 생명력이 0이 되면 맨 마지막에 등록된 몬스터 이름을 출력하는 함수 생성
        //공격 함수: 몬스터 등록된 순서대로 각각 한 대씩 공격하는 함수 생성(예: 고블린 -> 오크 -> 슬라임 -> 고블린...)

        //남은 몬스터 수: 현재 남아있는 몬스터 숫자를 가져오는 함수
        //등록 불가: 동적 배열을 활용해서 정해진 배열의 길이를 초과 시 "등록 불가" 출력

        // monsterAddQustionAnswer에 따라 몬스터 추가 결정
        // monster class에 저장된 int로 된 배열 10개 불러오기 
        // monster 생성 시 몬스터 숫자를 세는 기능 필요 -> monster Count
        // 배열 추가 시 정해진 배열의 길이를 초과 시 "등록 불가" 출력
        // 몬스터는 몬스터 class에서 관리하고 있다가 Arena class에서 추가한다고 했을 때 arena에 있는 몬스터 관리하는 배열에 추가하는 것으로 설정
        // 몬스터 클래스에 배열에 있는 것들이 추가 선택할 때마다 배열에 있던 것들이 Arena에 추가 그럴려면 만들 공간 즉 어떤 또 다른 배열이 필요
        // 속성은 랜덩으로 발생하도록 설정

        public Arena()
        {
            Random random = new Random();
            monsterAttribute monsterAttribute = (monsterAttribute)random.Next(Enum.GetValues(typeof(monsterAttribute)).Length);
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
                            for(int j = 0; j < monster.monstersTimes.Length;j++) { 
                            monster.monstersTimes[i] = new monster(monster.monster_nameData[j] , monster.hpData[j], monster.atkData[j], monster.defData[j], monsterAttribute);
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
        


        // monster 추가 시 [0] ~ [10] 인덱스 배열 추가
        // monster 생성 시 


        
        // 몬스터의 체력이 0인 경우 mosterCount -1 제거 
        public int monsterRemove(monster monsterHp, monster monsterTimes)
        {
           



            return monsterCount;
        }

        //몬스터 제거: 몬스터 생명력이 0 이하이면 몬스터는 아레나에서 사라지는 함수 생성




    }
}

