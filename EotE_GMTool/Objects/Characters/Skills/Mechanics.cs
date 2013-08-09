using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Skills {
    [Serializable]
    public class Mechanics :Skill {
        public Mechanics() {
            BaseCharacteristic = Characteristic.Intellect;
            Type = SkillType.General;
        }

        public override string ToString ( ) {
            return "Mechanics";
        }
    }
}
