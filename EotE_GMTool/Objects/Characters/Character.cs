using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EotE_GMTool.Objects.Characters;
using System.Collections.ObjectModel;
using EotE_GMTool.Objects.Characters.Skills;
using EotE_GMTool.Objects.Characters.Species;

namespace EotE_GMTool {
    [Serializable]
    public class Character {
        public string Name { get; set; }
        public string Background { get; set; }
        public int Credits { get; set; }
        public int TotalExperience { get; set; }
        public int AvailableExperience { get; set; }
        public int Brawn { get; set; }
        public int Presence { get; set; }
        public int Intellect { get; set; }
        public int Cunning { get; set; }
        public int Agility { get; set; }
        public int Willpower { get; set; }
        public int Wounds { get; set; }
        public int WoundThreshold { get; set; }
        public int Strain { get; set; }
        public int StrainThreshold { get; set; }
        public Species Species { get; set; }
        public ObservableCollection<Obligation> Obligations { get; set; }
        public ObservableCollection<Skill> Skills { get; set; }
        public ObservableCollection<Skill> CareerSkills {get{ return new ObservableCollection<Skill>(Skills.Where(s => s.IsCareerSkill).ToList());}}
        public ObservableCollection<Motivation> Motivations { get; set; }
        public ObservableCollection<String> SpecialAbilities { get; set; }
        public bool ObligationsSeverityLevel0Chosen { get; set; }
        public bool ObligationsSeverityLevel1Chosen { get; set; }
        public bool ObligationsSeverityLevel2Chosen { get; set; }

        public Character() {
            Name = "Scooter";
            Obligations = new ObservableCollection<Obligation>();
            Skills = new ObservableCollection<Skill>();
            Motivations = new ObservableCollection<Motivation>();
            SpecialAbilities = new ObservableCollection<string>();
            ObligationsSeverityLevel0Chosen = true;
            Credits = 500;
        }

        public string GetFileName() {
            return Name.Trim().Replace("'", "").Replace(".","") + ".bin";
        }
    }
}
