using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Skills {
    [Serializable]
    public class Melee : Skill {
        public Melee() {
            BaseCharacteristic = Characteristic.Brawn;
            Type = SkillType.Combat;
        }

        public override string ToString ( ) {
            return "Melee";
        }
    }
}
