using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EotE_GMTool.Objects.Characters.Skills;

namespace EotE_GMTool.Objects.Characters.Career {
    [Serializable]
    public class Career {
        public List<Skill> CareerSkills { get; set; }
        public string Description { get; set; }
    }
}
