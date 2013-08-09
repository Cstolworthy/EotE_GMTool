using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EotE_GMTool.Objects.Characters {
    [Serializable]
    public class Obligation {
        public string Type { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public int SeverityUpgrade { get; set; }
    }
}
