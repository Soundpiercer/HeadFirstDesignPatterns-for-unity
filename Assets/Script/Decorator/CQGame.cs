// [HEAD FIRST DESIGN PATTERNS - 03. DECORATOR PATTERN]
// 
// C.Q. Characters & Buffs
// Author : Soundpiercer
// soundpiercer@gmail.com
//
// 권장하는 보는 순서
// 1. CQ Game.cs
// 2. Character.cs
// 3. Buffs
// 4. CQ Game.cs 다시 한번 둘러보기

using UnityEngine;

namespace headfirst.decorator
{
    public class CQGame : MonoBehaviour
    {
        private void Start()
        {
            // 전투력 100의 V
            Character v = new V();
            v.ShowInfo();

            v = new GoddessBuff(v); // 여신의 가호로 인해 전투력이 1.2 배 상승합니다.
            v.ShowInfo();

            v = new MachineGodBuff(v); // 기계신의 가호로 인해 전투력이 1.25 배 복리 상승합니다.
            v.ShowInfo();
            // V 의 최종 전투력 = 100 * 1.2 * 1.25 = 150


            // 전투력 100의 몽테
            Character monte = new Monte();
            monte.ShowInfo();

            monte = new MachineGodBuff(monte); // 기계신의 가호로 인해 전투력이 1.25 배 상승합니다.
            monte.ShowInfo();

            monte = new GoddessBuff(monte); // 여신의 가호로 인해 전투력이 1.2 배 복리 상승합니다.
            monte.ShowInfo();
            // 몽테의 최종 전투력 = 100 * 1.25 * 1.2 = 150


            // 전투력 100의 스파이니
            Character spiny = new Spiny();
            spiny.ShowInfo();

            spiny = new GoddessBuff(spiny);
            spiny.ShowInfo();

            spiny = new GoddessBuff(spiny); // 여신의 버프를 이중으로 걸었습니다.
            spiny.ShowInfo();
            // 스파이니의 최종 전투력 = 100 * 1.2 * 1.2 = 144
        }
    }
}