using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Species {
    public class Species {
        public string Description { get; set; }
        public int StartingXp { get; set; }
        public int StartingWoundThreshold { get; set; }
        public int StartingStrainThreshold { get; set; }
        public List<string> SpecialAbilities { get; set; }
        public int StartingBrawn { get; set; }
        public int StartingPresence { get; set; }
        public int StartingIntellect { get; set; }
        public int StartingCunning { get; set; }
        public int StartingAgility { get; set; }
        public int StartingWillpower { get; set; }
    }
}
