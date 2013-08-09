using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Species {
    [Serializable]
    public class Rodian : Species {
        public Rodian()
        {
            StartingXp = 100;
            StartingWoundThreshold = 10;
            StartingStrainThreshold = 10;
            SpecialAbilities = "Begin the game with one rank in Survival.  May not train Survivial above rank 2 during character creation.";
            StartingBrawn = 2;
            StartingPresence = 2;
            StartingIntellect = 2;
            StartingCunning = 2;
            StartingAgility = 3;
            StartingWillpower = 1;
            Description =
                @"    Rodians are born to hunt, coming from a hostile world that breeds killer instincts. For those with a price on their heads, a glimpse of a tapered green snout or an unmistakably putrid odor means a Rodian bounty hunter is on their tail. " +
                Environment.NewLine +
                "    The history of Rodia is a history of violence.  Long ago, the tropical world used to teem with vicious predators, necessitating that the Rodians' defenseless ancestors either adapt or die.  Adapt they did, hiding in the boughs of trees or climbing high into mountain caves, where they fashioned tools and formulated plans to hunt down the predators.  They never had time to settle long enough to plant crops, and consequently did not develop agricultural competence.  However, their skills in the hunt grew by leaps and bounds, and soon became the central focus of their society.  Rodians who demonstrated the greatest hunting prowess were honored with prizes and leadership positions in the small communites." +
                Environment.NewLine +
                "    Rodians because so proficient at hunting that they gradually forced most of Rodia's other predators into extinction.  With nothing much left to hunt, they turned on each other.  Gladatorial hunts became the main method of resolving disputes between two Rodians, with the survivor being named the victor.  Over time, these contests tilted into skirmishes and then wars between twibes, later acted out in Rodian drama.  The appearance of Old Republic scouts gave Rodians a new challenge.  They hunted down the scouts and al foreigners who landed on Rodia.  The world was nearly placed on the Republic's 'no-fly' list when the Rodian leader, the Grand Protector of the Hunt, did something unparalleled in Rodian History; he called off the hunt.  He convinced his people that the off-worlders could show them the stars, where they could hunt until the end of time." +
                Environment.NewLine +
                "    Though small feuds and hunts continue on Rodia, the planet's main industry is arms manufacture.  As their ancestors did in days gone by, Rodians use their latent talent in weapon-making to craft blasters ideally suited to mercenaries and bounty hunters.";
        }

        public override string ToString ( ) {
            return "Rodian";
        }
    }
}
