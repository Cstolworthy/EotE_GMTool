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
using EotE_GMTool.Objects.Characters;

namespace EotE_GMTool.CharacterControls.Editing_Controls {
    public partial class EditCharacter_ObligationControl : EditCharacter_Control {
        public Character Character { get; set; }
        public EditCharacter_ObligationControl ( Character character ) {
            Character = character;
            InitializeComponent();
        }

        private void btn_RemoveObligation_Click ( object sender, RoutedEventArgs e ) {
            if (dg_CharacterObligations.SelectedItem != null)
                Character.Obligations.Remove(dg_CharacterObligations.SelectedItem as Obligation);
        }
    }
}
