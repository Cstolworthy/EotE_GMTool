using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EotE_GMTool.Objects.Characters.Skills;

namespace EotE_GMTool.Objects.Characters.Career.Bounty_Hunter {
    public class Survivalist : Specialization {
        public Survivalist() {
            Career = new BountyHunter();
            SpecializationCareerSkills = new List<Skill>(){ new Resilience(), new Survival(), new Lore(), new Xenology()};
            Description =
                "Beyond civilization, in the furthest reaches of the galaxy, there are places where few (if any) sentients have ever trodden the ground. Places like these are ideal hiding places for those fleeing retribution for their actions.  Places like these are where Bounty Hunters who specialize as Survivalists thrive in their craft.  Harkening back to the ancient practices of true wilderness hunters, the Survivalist gains Resilience, Survival, Lore Knowledge, and Xenology Knowledge as his specialization skills.  With his talent array, he can keep himself and his companions alive, and he knows where and what to look for when searching for just about anything, or anyone.  He's also gifted at hunting any kind of target and taking it down.";
        }
    }
}
