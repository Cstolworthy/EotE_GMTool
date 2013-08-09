using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Skills {
    [Serializable]
    public class Skill {
        public bool IsCareerSkill { get; set; }
        public Characteristic BaseCharacteristic { get; set; }
        public SkillType Type { get; set; }
        public int Rank { get; set; }

        public int ExperienceRequiredForNextRank { get { return (Rank + 1)*(IsCareerSkill ? 5 : 10); } }
    }

    public enum Characteristic { Brawn, Intellect, Presence, Cunning, Agility, Willpower}
    public enum SkillType {Social, Combat, Knowledge, General}
}
