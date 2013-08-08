using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Species {
    [Serializable]
    public class Twilek : Species {
        public Twilek()
        {
            StartingXp = 100;
            StartingWoundThreshold = 10;
            StartingStrainThreshold = 11;
            SpecialAbilities = "Twi'leks begin the game withone rank in either Charm or Deceit.  They still may not train Charm or Deceit above rank 2 during character creation.";
            StartingBrawn = 1;
            StartingPresence = 3;
            StartingIntellect = 2;
            StartingCunning = 2;
            StartingAgility = 2;
            StartingWillpower = 2;
            Description =
                @"    The Twi'leks are among the mo0st prominent non-human species in the galaxy.  They are expert bargainers, sly at reading other species and using cunning to get what they want." +
                Environment.NewLine +
                "    The government on Ryloth is an alliance of 'head clans', each of which control a small town or larger districts in the icty.  Fa family's five most import Twi'leks lead their respected head-clans, with the power of influence radiating down the bloodline.  According to tradition, when one leader of the head clan dies, the four remaining members must take exile to the sun-baked bright lands where the vicious lyleks roam.  In practive, however, clan leaders find new and cunning w3ays to subvert exile." +
                Environment.NewLine +
                "    The clan system has stratified Twi'lek society into castes.  Twi'leks at the bottom of a bloodline are considered of the low birth caste and used as chattel in the slave trade.  Twi'lek leaders exhibit disgust at any accusation of slavery and deny that they would ever put their own people in bondage.  Nontheless, nearly every clan engages in 'contracted indenturehood'." +
                Environment.NewLine +
                "    Ambitious clan members who want to rise in the family will do whatever it takes to get ahead within the social bounds.  Direct confrontation is only a last resort for Twi'leks.  They prefer more craft ways of bringing down their rivals, using political schemes to disgrace an opponent's entire family.  On Ryloth, shame has more power than assassination - Twi'leks never forget the stains of a scandal.";
        }

        public override string ToString ( ) {
            return "Twi'lek";
        }
    }
}
