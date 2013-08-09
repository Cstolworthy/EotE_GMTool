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

namespace EotE_GMTool {

    public partial class MainWindow : Window {
        public User User { get; set; }
        public MainWindow ( User user )
        {
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

        private void btn_Rulebook_Click ( object sender, RoutedEventArgs e )
        {
            const string filepath = "SW-EotE Beta Rulebook.pdf";
            //var di = Directory.GetFiles("");
            if (File.Exists(filepath))
                Process.Start(filepath);
        }

        #endregion


    }
}
