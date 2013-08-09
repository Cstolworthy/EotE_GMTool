using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EotE_GMTool.Objects.Characters.Skills;

namespace EotE_GMTool.Objects.Characters.Career.Bounty_Hunter {
    public class Gadgeteer : Specialization {
        public Gadgeteer() {
            SpecializationCareerSkills = new List<Skill>() { new Computers(), new Mechanics(), new Perception(), new LightRanged()};
            Description =
                "Considering how often a single Bounty Hunter finds himself faced with terrible odds (more often than not, an Acquisition has friends or employees who work hard to protect him), it's not surprising how many specialize in high-tech gear and weapons.  The Gadgeteer excels at presenting himself as a one-man battle force, at least for a short time.  Using both the latest tech and his own personally-modified gear, a Bounty Hunter with this specialization can be hard to stop.  Gadgeteers add the skills Computers, Mechanics, Perception, and Ranged (Light) to their repertoire, making them effective technicians, ranged combat experts, and masters of surveillance.  Gadgeteer talents lean heavily towards gear use, taking down targets, and adapting to hard situations.";
        }
    }
}
