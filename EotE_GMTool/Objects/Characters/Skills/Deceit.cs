using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Skills {
    [Serializable]
    public class Deceit : Skill{
        public Deceit() {
            BaseCharacteristic = Characteristic.Cunning;
            Type = SkillType.Social;
        }

        public override string ToString ( ) {
            return "Deceit";
        }
    }
}
