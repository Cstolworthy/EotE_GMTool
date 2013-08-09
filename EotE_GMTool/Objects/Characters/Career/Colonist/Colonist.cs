using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EotE_GMTool.Objects.Characters.Skills;

namespace EotE_GMTool.Objects.Characters.Career.Colonist {
    public class Colonist : Career {
        public Colonist() {
            CareerSkills = new List<Skill>(){ new Charm(), new Deceit(), new Leadership(), new Negotiate(), new Streetwise(), new CoreWorlds(), new Education(), new Lore()};
            Description =
                "In a way, Colonists are the most out-of-place people in the Outer Rim.  They are most often from the Core Worlds, where they were well educated and part of the cultural and professional elite.  A Colonist doesnt tend to have the training to survive in areas of high conflict, and he isnt partuclarly adept at physical exploits.  What he does possess, however, is a keen grasp of the bigger picture, and he usually has the knowledge to understand problems and the capacity to get them solved.  He probably came to the Outer Rim to create opportunities for himself, or to find a better life than what he left behind.  If he cannot find that better life, he'll apply everything he knows to create it, and he'll use his considerable social skills to gather like-minded allies to his cause.";
        }
    }

}
