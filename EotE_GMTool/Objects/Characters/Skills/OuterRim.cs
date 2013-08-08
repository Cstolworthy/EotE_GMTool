using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Skills {
    [Serializable]
    public class OuterRim : Skill {
        public OuterRim() {
            BaseCharacteristic = Characteristic.Intellect;
            Type = SkillType.Knowledge;
        }

        public override string ToString ( ) {
            return "Outer Rim";
        }
    }
}
