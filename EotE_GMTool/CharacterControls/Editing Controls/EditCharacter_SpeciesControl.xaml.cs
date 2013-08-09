using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EotE_GMTool.Objects.Characters.Species;
using System.ComponentModel;

namespace EotE_GMTool.CharacterControls.Editing_Controls {
    public partial class EditCharacter_SpeciesControl : EditCharacter_Control{
        public Character Character { get; set; }

        public EditCharacter_SpeciesControl ( Character character ) {
            Character = character;
            InitializeComponent();
        }

        public List<Species> SpeciesOptions { get {
            return new List<Species>(){ new Bothan(), new Droid(), new Gand(), new Human(), new Rodian(), new Trandoshan(), new Twilek(), new Wookiee()};
        } }
    }
}
