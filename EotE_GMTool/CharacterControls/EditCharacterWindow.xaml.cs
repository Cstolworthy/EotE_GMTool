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
using System.Windows.Shapes;
using EotE_GMTool.CharacterControls.Editing_Controls;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace EotE_GMTool {
    public partial class EditCharacterWindow : Window {
        public Character Character { get; set; }

        public EditCharacterWindow ( Character character ) {
            Character = character ?? new Character();
            Initialize();
            g_Background.Children.Add(new EditCharacter_BackgroundControl(Character));
            g_Obligation.Children.Add(new EditCharacter_ObligationControl(Character));
            g_Species.Children.Add(new EditCharacter_SpeciesControl(Character));
            g_Careers.Children.Add(new EditCharacter_CareerControl(Character));
        }

        public void Initialize ( ) {
            if (Character != null)
                Title = "Edit " + Character.Name;
            InitializeComponent();
        }

        private bool SerializeCharacter ( ) {
            if (string.IsNullOrEmpty(Character.Name)) {
                MessageBox.Show("Characters Need a Name!");
                return false;
            }
            var formatter = new BinaryFormatter();
            var fileName = Character.GetFileName();
            var stream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
            formatter.Serialize(stream, Character);
            stream.Close();
            return true;
        }

        private void btn_Save_Click ( object sender, RoutedEventArgs e ) {
            if (SerializeCharacter()) {
                MessageBox.Show(Character.Name + " Saved");
                Close();
            }
        }
    }
}
