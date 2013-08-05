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
using EotE_GMTool.Objects;

namespace EotE_GMTool {
    public partial class SplashWindow : Window {
        public SplashWindow ( ) {
            InitializeComponent();
        }

        private void btn_Players_OnClick ( object sender, RoutedEventArgs e )
        {
            Hide();
            new MainWindow(new Player()).ShowDialog();
            Close();
        }

        private void btn_GM_OnClick(object sender, RoutedEventArgs e) {
            Hide();
            new MainWindow(new GalaxyMaster()).ShowDialog();
            Close();
        }
    }
}
