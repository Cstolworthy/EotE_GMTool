using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EotE_GMTool.Objects.Characters.Skills;

namespace EotE_GMTool.Objects.Characters.Career.Colonist {
    public class Politico : Specialization {
        public Politico() {
            Career = new Colonist();
            SpecializationCareerSkills = new List<Skill>() { new Charm(), new Coerce(), new Deceit(), new Negotiate() };
            Description =
                "A Politico can talk to anyone about anything in a way he needs to, and only another Politico or a being of iron will is likely to be able to resist him if he's out to win a point or achieve a goal.  What others might acomplish with might and fear, a talented Politico may well achieve with a few well placed words and a decent plan.  Politicos gain the specialization skills of Charm, Coerce, Deceit, and negotiation.  A politico might join a speech or debate in any number of ways.  With his talents, he might act to inspire greatness in those around him, or he might know just what to say to cut an opponent to the core, diminishing his confidence and leaving him vulnerable.";
        }
    }
}
