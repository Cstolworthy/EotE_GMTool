using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Species {
    [Serializable]
    public class Gand : Species {
        public Gand()
        {
            StartingXp = 100;
            StartingWoundThreshold = 10;
            StartingStrainThreshold = 10;
            SpecialAbilities = "Begin the game with one rank in Discipline.  May not train Discipline above rank 2 in character creation";
            StartingBrawn = 2;
            StartingPresence = 2;
            StartingIntellect = 1;
            StartingCunning = 2;
            StartingAgility = 2;
            StartingWillpower = 3;
            Description =
                @"    Gands are a mysterious insectoid species whose 'findsmen' treat tracking quarry as a religious duty.  They are exceptionally good at divining the location of individuals through ritualistic methods that off-worlders might consider backward and barbaric." +
                Environment.NewLine +
                "    Gands have a closed culture.  What is known about them is that religion and life are closely entwined.  A gathering of elders called the Ruetsavii observes the various religious sects that represent the virtues of Gand life." +
                Environment.NewLine +
                "    Off-worlders are most familiar with the religous sect known as the 'findsmen.'  These are the Gand who leave their home planet on ritualistic hunts to catch prey and bring divine blessings to their people.  Many other sects are rumored to exist, particularly in the fields of genetics, medicine, and engineering, but their exact natures are unknown." +
                Environment.NewLine +
                "    Gands embrace technology, frequently modifying it for their own use.  You can almost guarantee that a Gand's breathing apparatus, translator, blaster, and shockprod staff is customized or of personal manufacture.";
        }

        public override string ToString ( ) {
            return "Gand";
        }
    }
}
