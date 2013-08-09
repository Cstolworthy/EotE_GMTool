using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EotE_GMTool.Objects.Characters.Skills;

namespace EotE_GMTool.Objects.Characters.Career {
    public class Specialization {
        public Career Career { get; set; }
        public List<Skill> SpecializationCareerSkills { get; set; }
        public string Description { get; set; }
    }
}
