using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Skills {
    [Serializable]
    public class Leadership : Skill{
        public Leadership(){
            BaseCharacteristic = Characteristic.Presence;
            Type = SkillType.Social;
        }

        public override string ToString ( ) {
            return "Leadership";
        }
    }
}
