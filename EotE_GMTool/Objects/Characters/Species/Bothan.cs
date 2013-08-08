using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Species {
    [Serializable]
    public class Bothan : Species {
        public Bothan()
        {
            StartingXp = 100;
            StartingWoundThreshold = 10;
            StartingStrainThreshold = 11;
            SpecialAbilities = "Bothans begin the game with one rank in Streetwise.  They still may not train Streetwise above rank 2 during character creation.";
            StartingBrawn = 1;
            StartingPresence = 2;
            StartingIntellect = 2;
            StartingCunning = 3;
            StartingAgility = 2;
            StartingWillpower = 2;
            Description =
                @"    Bothans are the galaxy's information brokers.  Adept at picking up on secrets or seeing things other species ignore, Bothans can be valuable assets in any endeavor - or untrustworthy partners." +
                Environment.NewLine +
                "    Every layer of Bothan society is based on the acquisition , manipulation, and utilization of knowledge.  Sometimes likened to the Hutts and Twi'leks, Bothans take such comparisons as an inslut.  Prestige, not wealth, motivates them.  A Bothan's reputation is, at the end of the day, all he has.  Loyalty and respect of one's elders are of supreme importance, for Bothans never climb the ladder of power through disobedience.  Nonetheless, their loyalties can shift at a moment's notice, depending on the knowledge at hand." +
                Environment.NewLine +
                "    The Bothan council governs the Bothan worlds.  The major clans all have one representative int he Council, which then elects the Council Chief.  Clans confer prestige to their members by appointing them to manage the committees and ministries that each clan oversees.  Those administrators in turn appoint their own deputies, forming a network that stretches down the lowest bothan.  Many Bothans can trace their genealogy through a diagram of the council bureaucracy." +
                Environment.NewLine +
                "    Bothans shun outright confrontation.  Information is their weapon, and bothans play secrets like a corellian plays sabacc; the truth is the ace up their sleeve.";
        }

        public override string ToString ( ) {
            return"Bothan";
        }
    }
}
