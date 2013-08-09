using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Skills {
    [Serializable]
    public class Discipline : Skill{
        public Discipline() {
            BaseCharacteristic = Characteristic.Willpower;
            Type = SkillType.General;
        }

        public override string ToString ( ) {
            return "Discipline";
        }
    }
}
