using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Skills {
    [Serializable]
    public class Perception : Skill{
        public Perception() {
            BaseCharacteristic = Characteristic.Cunning;
            Type = SkillType.General;
        }

        public override string ToString ( ) {
            return "Perception";
        }
    }
}
