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
using EotE_GMTool.Objects;
using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.Win32;

namespace EotE_GMTool {

    public partial class MainWindow : Window {
        public User User { get; set; }
        public MainWindow ( User user ) {
            User = user;
            Title = MainMenuLabel;
            InitializeComponent();
        }

        #region Bindings

        public string MainMenuLabel { get { return User is Player ? "Player Main Menu" : "GM Main Menu"; } }

        public bool EnabledForGm { get { return User is GalaxyMaster; } }

        public Visibility VisibleForGm { get { return User is GalaxyMaster ? Visibility.Visible : Visibility.Collapsed; } }

        #endregion

        #region Events

        private void btn_Galaxy_Click ( object sender, RoutedEventArgs e ) {
            new GalaxyWindow().Show();
        }

        private void btn_Rulebook_Click ( object sender, RoutedEventArgs e ) {
            const string filepath = "SW-EotE Beta Rulebook.pdf";
            //var di = Directory.GetFiles("");
            if (File.Exists(filepath))
                Process.Start(filepath);
        }

        #endregion

        private void btn_CreateCharacter_Click ( object sender, RoutedEventArgs e ) {
            var window = new EditCharacterWindow(null);
            window.ShowDialog();
        }

        private void btn_EditCharacter_Click ( object sender, RoutedEventArgs e ) {
            //var ofd = new OpenFileDialog();
            //ofd.ShowDialog();
            //if (!ofd.CheckFileExists) return;
            //var filename = ofd.FileName;
            //var stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            var stream = new FileStream("Scooter.bin", FileMode.Open, FileAccess.Read);
            var formatter = new BinaryFormatter();
            var character = (Character)formatter.Deserialize(stream);
            stream.Close();
            var window = new EditCharacterWindow(character);
            window.ShowDialog();
        }
    }
}
