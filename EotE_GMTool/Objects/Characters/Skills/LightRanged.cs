using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Skills {
    [Serializable]
    public class LightRanged : Skill {
        public LightRanged() {
            BaseCharacteristic = Characteristic.Agility;
            Type = SkillType.Combat;
        }

        public override string ToString ( ) {
            return "Ranged (Light)";
        }
    }
}
