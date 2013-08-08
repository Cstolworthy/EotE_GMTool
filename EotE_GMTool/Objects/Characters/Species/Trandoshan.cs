using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Species {
    [Serializable]
    public class Trandoshan : Species {
        public Trandoshan()
        {
            StartingXp = 90;
            StartingWoundThreshold = 12;
            StartingStrainThreshold = 9;
            SpecialAbilities =
                "Trandoshans begin the game with one rank in Perception.  They still may not train Percception above rank 2 during character creation" +
                Environment.NewLine +
                "Regenration: Whenever a Trandoshan would recover one or more wounds from natural rest or recuperation in a Bacta tank, it recovers one additional wound  It does not recover one additional wound when receiving first aid or medical treatment from a character, or when using a tstimpack.  Trandoshans can regrow loast limbs as well, though it usually takes at least a month before the limb is usuable." +
                Environment.NewLine +
                "Claws: When a trandoshan makes a Brawn check to deal damage to an opponent, he deals +1 damage and has a critical rating of 3"
                ;
            StartingBrawn = 3;
            StartingPresence = 2;
            StartingIntellect = 2;
            StartingCunning = 2;
            StartingAgility = 1;
            StartingWillpower = 2; 
            Description =
                @"    Trandoshans are belligerent, lizard-like humanoids who have an avowed hatred of Wookiees.  They can be found whrever a strong hand or a big gun is desired." +
                Environment.NewLine +
                "    Trandoshans, who call themselves the  T'doshok in Dosh, comes from a soiety that emphasizes strength, skill at hunting, resilience, and self-reliance.  Young Trandoshans can walk and possess an instinctual hunting ability almost from birth.  By two years of age, their mother takes them on their first hunts and by 10 they are largely self-sufficient." +
                Environment.NewLine +
                "    Trandoshan society revolves around the hunt, and worship of a goddess known as the Scorekeeper.  She watches over the Trandoshan people, blessing or punishing them based on the success of their hunts.  For each successful hunt and quarry brought tot he ground, the Trandoshans receive jagannath - 'divine marks' that when tallied, show a Trandoshan's status in society..  The slaughtering of one of the trandoshans bitter enemies - namely Wookiees - earns an excess of jagannath, as do accomplishing other particularly difficult hunts." +
                Environment.NewLine +
                "    As a Trandoshan gains jagannath, the more favored he is by the goddess, and therefore, the more desirable he is to possible mate4s.  When a Trandoshan dies, he bows before the Scorekeeper and presents his jagannath quiver. That final tally of jagannath decides his place in the afterlife." +
                Environment.NewLine +
                "    As Trandoshan society has evolved in the galactic community, the importance of the hunt has merved with other societal pursuits as well.  Almost any action that betters the Trandoshan people can be justified as a worthy hunt in the eyes of trandoshan culture.  Of course, this leaves little room for frivolous pursuits such as the arts.";
        }

        public override string ToString ( ) {
            return "Trandoshan";
        }
    }
}
