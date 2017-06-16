using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace ErrorWindowSample
{
    /// <summary>
    /// Interaction logic for DemoUserControl.xaml
    /// </summary>
    public partial class DemoUserControl : UserControl
    {
        public DemoUserControl()
        {
            InitializeComponent();
        }
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            MetroWindow metroWindow = Application.Current.MainWindow as MetroWindow;
            metroWindow.MetroDialogOptions.ColorScheme = MetroDialogColorScheme.Inverted;
            metroWindow.ShowMessageAsync("Error", "Debe elegir un tipo de incidente.");
        }
    }
}
