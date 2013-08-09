using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EotE_GMTool.Objects.Characters.Skills;

namespace EotE_GMTool.Objects.Characters.Career.Explorer {
    public class Scout : Specialization {
        public Scout ( ) {
            Career = new Explorer();
            SpecializationCareerSkills = new List<Skill>() { new Athletics(), new PilotPlanetary(), new Survival(), new Perception()};
            Description =
                "There's finding a planet, and then there's going down to the planet and seeing what's what.  The Scout is the professional for the task, trained to survey and survive, gathering all of the information he can while keeping his head attached to his body.  While bravery in combat is one thing, there can be no denying the fearlessness of anyone willing to touch down on a completely unknown planet and trod about with only scanners andhis wits to discover its secrets.  A Scout knows his way around in any environment, and he's both tough and knowledgeable enough to make the most of his situation.  His additional skills, Athletics, Pilot (Planet), Survival, and Perception, make his job much easier.  Most Scouts are skilled with covering any ground (or lack therof); how to find what to eat, and where to sleep.  Scouts are often excellent at driving or piloting atmospheric craft as well, since they dont necessarily want to walk everywhere.  They're also adept at taking advantage of opportunities in combat.  Most Scouts feel it's better to strike fast and strike first, so they only have to strike once.";
        }
    }
}
