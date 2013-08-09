using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EotE_GMTool.Objects.Characters.Skills;

namespace EotE_GMTool.Objects.Characters.Career.Explorer {
    public class Trader : Specialization {
        public Trader() {
            Career = new Explorer();
            SpecializationCareerSkills = new List<Skill>() { new Deceit(), new Negotiate(), new CoreWorlds(), new Education()};
            Description =
                "Those seeking to take what they discover as they explore the Outer Rim and beyond and turn a serious profit out of it are Traders.  For a Trader, a new planet represents nigh-infinite potential for resource exploration, while a new culture or hidden community is a customer base just begging for his particular talents.  Traders gain access to the additional skills of Deceit, Negotiation, Core Worlds Knowledge, High Education.  Most Traders know how to build connections between the center of civilization and the far reaches, and they are often educated folks who bring knoledge and proficiency in econimics, socialogy, and politics with them, As well, an effective Trader knows the art of the deal, and he knows when a well-placed lie is the right tactic.";
        }
    }
}
