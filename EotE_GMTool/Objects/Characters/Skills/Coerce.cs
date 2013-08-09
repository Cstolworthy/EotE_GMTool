using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Skills {
    [Serializable]
    public class Coerce : Skill {
        public Coerce ( ) {
            BaseCharacteristic = Characteristic.Willpower;
            Type = SkillType.Social;
        }

        public override string ToString ( ) {
            return "Coerce";
        }
    }
}
