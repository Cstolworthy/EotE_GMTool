using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Skills {
    [Serializable]
    public class Resilience : Skill {
        public Resilience() {
            BaseCharacteristic = Characteristic.Brawn;
            Type = SkillType.General;
        }

        public override string ToString ( ) {
            return "Resilience";
        }
    }
}
