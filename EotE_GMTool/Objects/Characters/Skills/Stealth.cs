using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Skills {
    [Serializable]
    public class Stealth : Skill {
        public Stealth() {
            BaseCharacteristic = Characteristic.Agility;
            Type = SkillType.General;
        }

        public override string ToString ( ) {
            return "Stealth";
        }
    }
}
