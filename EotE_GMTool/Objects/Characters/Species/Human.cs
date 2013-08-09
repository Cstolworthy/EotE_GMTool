using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Species {
    [Serializable]
    public class Human : Species {
        public Human()
        {
            StartingXp = 110;
            StartingWoundThreshold = 10;
            StartingStrainThreshold = 10;
            StartingBrawn = 2;
            StartingPresence = 2;
            StartingIntellect = 2;
            StartingCunning = 2;
            StartingAgility = 2;
            StartingWillpower = 2;
            SpecialAbilities = "Humans and near-humans start the game with access to one additional specialization in their chosen career.  This still counts against the three specialization limit.  It does not give the character additional beginning training in additional skills (the player must choose one of the two starting specs to select ranks in starting skills from)";
            Description =
                @"    Humans are the most populous and gregarious of the galaxy's sapient species.  They seem to be present on almost every open planet that harbors life while traveling the spacelanes looking for more." +
                Environment.NewLine +
                "    Human ambition and competition have split their species into many different societies.  Across the galaxy, humans live under every political system ever devised, from feudalism and thocracy to democracy and autocracy.  Humans inhabit the most advanced worlds and are proficient at the most advanced technologies.  There are also primitive, agricultural-based human communitiies who reject all aspects of the technology, either because of ignorance or philosophical belief." +
                Environment.NewLine +
                "    As a species, humans' ethical outlook cannot be pinned down.  They are both conquerors and champions, savage oppressors and compassionate benefactors.  If one thing is certain about humans, it is that they gravitate towards the new and unexplored - and are willing to take risks well beyond those of other species.";
        }

        public override string ToString ( ) {
            return "Human";
        }
    }

}
