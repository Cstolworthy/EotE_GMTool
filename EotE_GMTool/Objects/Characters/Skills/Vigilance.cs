using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Skills {
    [Serializable]
    public class Vigilance : Skill{
        public Vigilance() {
            BaseCharacteristic = Characteristic.Willpower;
            Type = SkillType.General;
        }
    }
}
