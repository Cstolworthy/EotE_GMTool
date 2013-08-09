using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters.Species {
    [Serializable]
    public class Species {
        public int StartingXp { get; set; }
        public int StartingWoundThreshold { get; set; }
        public int StartingStrainThreshold { get; set; }
        public int StartingBrawn { get; set; }
        public int StartingPresence { get; set; }
        public int StartingIntellect { get; set; }
        public int StartingCunning { get; set; }
        public int StartingAgility { get; set; }
        public int StartingWillpower { get; set; }
        public string Description { get; set; }
        public string SpecialAbilities { get; set; }


        public override bool Equals ( object obj ) {
            try {
                return this.ToString() == (obj as Species).ToString();
            }catch{return false;}
        }
    }
}
