using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Species {
    [Serializable]
    public class Droid : Species {
        public Droid ( ) {
            StartingXp = 175;
            StartingWoundThreshold = 10;
            StartingStrainThreshold = 10;
            SpecialAbilities = "Droids do not need to eat, sleep, or breathe" + Environment.NewLine +
                               "Unaffected by toxins or poisons" + Environment.NewLine +
                               "Cybernetic implant cap of 6 instead of their Brawn Rating" + Environment.NewLine +
                               "Inorganic: Since droids are inorganic, they do not gain the benefits of recovering with a bacta tank, stimpack, or medicine skill checks.  Droids do recover naturally by resting, as their systems attempt self-repairs.  Otherwise, droids need to be tended to with a Mechanics check, using the same difficulties and results of medicine checks for organic beings. Repair kits can be used to repair damage just like stimpacks are used on organic beings." +
                               Environment.NewLine +
                               "Mechanical being: Droids cannot become Force-Sensitive, nor acquire a force rating by any means.  Droids cannot use force powers, and also cannot be affected by mind-altering force powers.";
            StartingBrawn = 1;
            StartingPresence = 1;
            StartingIntellect = 1;
            StartingCunning = 1;
            StartingAgility = 1;
            StartingWillpower = 1;
            Description =
                @"    A typical fringer may ridicule his droid to no end, yet without it, he is usually lost.  Droids serve as a variety of roles on the fringe, with security and conflict resolution essential.  Class Four droids specialize in combat applications, and make unyielding foes, because of their fearlessness and the speed and precision of their attacks" +
                Environment.NewLine +
                "    Class four droids present a special case.  Ober the millenia, models of their class have been the prime endines of destrution, having devastated - and even eliminated - entire populations and worlds.  From the ancient war robots of Xim to the droidekas of the Trade Federation, the sheer power these automated killing machines unleash without a second thought frightens sapient species to no end.  Restrictions have been placed on their use, and worlds like Naboo and Alderaan ban all combat automatons outright." +
                Environment.NewLine +
                "    Although the Old Republic tried over and over to outlaw the manufacture of Class Four models, the droid lobby was too strong to overcome.  Eventually, the accumulation of legislative defeats became the Republic's greatest failure and forged the weapon of its collapse.  Unable to hald the Trade Federation's production of battle droids, the Republic had to betray its non-military principles and raise an army of clones to fight the droids." +
                Environment.NewLine +
                "    Victory on the battlefield did not translate into a victory for democracy.  Fear of the droid armies still grips the inhabitants of the Core Worlds, permitting the militants in the government to cement their places in power.  Palpatine's New Order prohibits the operation and manufacture of Class Four war and assassin droids, on penalty of death.  Licenses for lesser security models are required for corporate and individual use, and the fees can be astronomical.  Imperial governors bestowed with special privleges, such as CSA Viceprex Mirkovig Kirken, skirt regulations and employ illegal models, often to flaunt their power.";

        }

        public override string ToString ( ) {
            return "Droid";
        }
    }
}
