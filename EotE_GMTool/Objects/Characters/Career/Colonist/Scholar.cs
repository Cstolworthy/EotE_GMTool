using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EotE_GMTool.Objects.Characters.Skills;

namespace EotE_GMTool.Objects.Characters.Career.Colonist {
    public class Scholar : Specialization {
        public Scholar() {
            Career = new Colonist();
            SpecializationCareerSkills = new List<Skill>() { new Perception(), new OuterRim(), new Underworld(), new Xenology()};
            Description =
                "At first, the idea of a Scholar wandering with a bunch of ne'er-do-wells in the Outer Rim might seem a bit odd, if not downright ridiculous.  However, with all of the dangers and wonders of a thousand thousand worlds, having someone aroudn who actually knows something more than how to reload a heavy blaster could be exceedingly useful under any number of circumstances.  Perception, Outer Rim Knowledge, Underworld Knowledge, and Xenology are the Scholar's bonus skills from his specialization.  These skills emphasize his role as a font of information, as well as his keen awareness of his surroundings.  His talents further enhance his capacity for knowing things, or at least knowing how to find out.  Additionally, he's particularly useful in adapting to unforseen crises and conditions.";
        }
    }
}
