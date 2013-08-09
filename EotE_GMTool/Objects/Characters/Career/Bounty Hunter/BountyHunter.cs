using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EotE_GMTool.Objects.Characters.Skills;

namespace EotE_GMTool.Objects.Characters.Career {
    [Serializable]
    public class BountyHunter : Career {
        public BountyHunter ( ) {
            CareerSkills = new List<Skill>() { new Athletics(), new Perception(), new PilotPlanetary(), new PilotSpace(), new Streetwise(), new Perception(), new Vigilance(), new HeavyRanged() };
            Description =
                "The name says it all; this is ahunter who seeks to collect bounties for his work.  Bounty Hunters tend to be feared, reviled, looked down upon...and in great demand throughout the galaxy.  They are expert trackers, brutal combatants, and effective investigators.  They tend to prefer skulduggery, stealth, and traps over frontal assaults, but the most respected Bounty Hunters will do whatever it takes to catch their quarries and collect their fees.";
        }
    }
}
