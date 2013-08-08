using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EotE_GMTool.Objects.Characters.Skills;

namespace EotE_GMTool.Objects.Characters.Career.Colonist {
    public class Doctor : Specialization {
        public Doctor() {
            Career = new Colonist();
            SpecializationCareerSkills = new List<Skill>(){ new Cool(), new Medicine(), new Resilience(), new Survival() };
            Description =
                "Of all the Colonists who come to the Outer Rim, Doctors probably have the easiest time finding employment.  They are in demand almost anywhere they go.  Had he wished to work in high-tech, state-of-the-art medical facilities, however, a Doctor would not likely have come to the Outer Rim (at least, not by choice.)  With the specialization skills of Cool, Medicine, Resilience, and Survival, a doctor brings not only healing and the treatment of illnesses with him, he brings a broad spectrum of knowledge, and a solid persona in the face of adversity.";

        }
    }
}
