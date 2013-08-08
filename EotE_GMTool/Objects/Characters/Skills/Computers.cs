using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Skills {
    [Serializable]
    public class Computers : Skill {
        public Computers() {
            BaseCharacteristic = Characteristic.Intellect;
            Type = SkillType.General;
        }

        public override string ToString ( ) {
            return "Computers";
        }
    }
}
