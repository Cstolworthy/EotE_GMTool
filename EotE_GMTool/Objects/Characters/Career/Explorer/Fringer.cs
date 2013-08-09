using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EotE_GMTool.Objects.Characters.Skills;

namespace EotE_GMTool.Objects.Characters.Career.Explorer {
    public class Fringer : Specialization {
        public Fringer() {
            Career = new Explorer();
            SpecializationCareerSkills = new List<Skill>() { new Astrogation(), new Coordination(), new Negotiate(), new Streetwise()};
            Description =
                "Part-negotiator, part-astrogator, and savvy in the ways of the galaxy beyond the Core Worlds, the Fringer is a jack of all trades.  He focuses on knowing how to find what he needs and how to get where he needs to go.  He's got the gift of gab when it's time to talk and the awareness to maneuver away when it's time to run.  The additional skills for a Fringer are indivcative of his diversified nature: Astrogation, Coordination, Negotiation, and Streetwise.  Fringers can start strong int heir knowledge of how to get around the galaxy, and the other skills showcase their talents in getting around quietly, talking to the right people and navigating urban settings.  They also have a strong capacity to endure rough situations.";
        }
    }
}
