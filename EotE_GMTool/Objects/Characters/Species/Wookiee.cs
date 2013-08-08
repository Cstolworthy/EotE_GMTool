using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Species {
    [Serializable]
    public class Wookiee : Species {
        public Wookiee ( )
        {
            StartingXp = 90;
            StartingWoundThreshold = 14;
            StartingStrainThreshold = 8;
            SpecialAbilities = "Wookiees begin the game with one rank in Brawl.  They still may not train Brawl avoe rank 2 during character creation." + Environment.NewLine + "Wookiee Rage: When a Wookiee has suffered any wounds, he deals +1 damage to Brawl and Melee attacks.  When a Wookiee is Critically Injured, he deals +2 damage with Brawl and Melee attacks.";
            StartingBrawn = 3;
            StartingPresence = 2;
            StartingIntellect = 2;
            StartingCunning = 2;
            StartingAgility = 2;
            StartingWillpower = 1;
            Description =
                @"    Strong, intelligent, and fierce in battle, Wookiees make the best of friends for those to whom they are loyal - and the worst of enemies for those to whom they are not.  Unfortunately, Wookiees have virtually disappeared from the population at large and are becoming a faded memory of the Old Republic." +
                Environment.NewLine +
                "    Although their physique makes for an intinidating appearance, Wookiees live by strict codes of honor and loyalty.  Friendship and family bonds knit Wookiees thightly together, for there are dangers on Kashyyyk that frighten even the most ferocious Wookiee.  Kilometers-tall wroshyr trees cover nearly half of Kashyyyk's surface, defining the world's unique ecology and serving as homes for most Wookiee conmmunities.  On the seventh level of these forests, Wookies have built immense cities in the trees, blending technology in harmony with the environment." +
                Environment.NewLine +
                "    Mechanical skills and engineering come naturally to the Wookiees.  The bowcaster, a crossbow that fires energy quarrels, is the most celebrated invention of their species.  It is a weapon that takes a Wookiee's strength to cock and pull, yet its design shows a reverence to the past while harnessing the energy of new technology." +
                Environment.NewLine +
                "    Having dominated much of Kashyyyk's upper levels, the Wookiees were on the path to explore the stars on their own, when a neighboring species, the Trandoshans, arrived on Kashyyyk to colonize and exploit the world. Even thought he Trandoshans had more advanced weaponry, the Wookiees fought the would -be-colonizers off the planet.  The Wookiees wasted no time in disassembling the technology Trandoshans left behind.  This included a starship with sublight enbgines.  When the trandoshans reeturned, the Wookiees drove them away for a second time, then took flight to the stars." +
                Environment.NewLine +
                "    The Wookiee-Trandoshan wars continued in spats throught the later years of the Old Republic, with the Republic mediators usually siding with the honorable Wookiees.  The trandoshans swaw an opportunity, however, when Palpatine declared his Empire.  They sent emissaries to Palpatine to recount their grievances against the Wookiees.  The Wookiees had hidden Jedi on Kashyyyk after Order 66, infuriating the Emperor, so he declared that Kashyyyk be occupied, to the Trandoshans' delight.  The Imperials then heeded Trandoshan advice and placed the cantankerous Wookiees in labor camps.  Wookiee children were held at gunpoint unless Wookiee adults used their technical expertise to build Imperial war material, which included parts of the Death Stars.";
        }

        public override string ToString ( ) {
            return "Wookiee";
        }
    }

}
