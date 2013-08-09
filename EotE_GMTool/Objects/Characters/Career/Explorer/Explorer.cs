using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EotE_GMTool.Objects.Characters.Skills;

namespace EotE_GMTool.Objects.Characters.Career.Explorer {
    public class Explorer : Career {
        public Explorer() {
            CareerSkills = new List<Skill>() { new Astrogation(), new Charm(), new Cool(), new Perception(), new PilotSpace(), new Lore(), new OuterRim(), new Xenology()};
            Description =
                "No matter how large the Empire is, the Explorer seeks to uncover the countless mysteries and opportunities out in the vastness.  Explorers are both vitally important and insidiously dangerous to the New Order.  On the one hand, they reveal trade routes and resources that are deeply coveted by the Empire, and on the other hand, they expand the ranges into which rebels, criminals, and iconoclasts can spread out and avoid Imperial might.  Though the Empire employs countless scouts and mercantile agents, and there are many more such entities working for the millions of galactic corporations seeking advantage over one another as they expand, the Explorer is a free agent.  He makes his own way, tracks his own discoveries, and arranges his won special deaks and connections.";
        }
    }
}
