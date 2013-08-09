using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EotE_GMTool.Objects.Characters.Skills;

namespace EotE_GMTool.Objects.Characters.Career.Bounty_Hunter {
    public class Assassin : Specialization {
        public Assassin() {
            Career = new BountyHunter();
            SpecializationCareerSkills = new List<Skill>(){ new Coordination(), new Skulduggery(), new Stealth(), new Melee()};
            Description =
                "Whereas most bounty Hunters focus primarily on the capture of quarry, those who specialize as Assassins are generally tasked with the straightforward proposition of terminating their targets.  Most Hunters are considered failures if they end up with too many kills on their records, while the worth of an Assissin can readily be measured with how many bodies he's left lying on the deck.  The selection of additional skills for an Assassin very much point towards his focus: Coordination, Skulduggery, Stealth, and Melee.  Assassins tend to prefer getting in, taking out targets either up close or sniping from afar, and leaving just as silently as they came in, and their talents are appropriate for this kind of work.";
        }
    }
}
