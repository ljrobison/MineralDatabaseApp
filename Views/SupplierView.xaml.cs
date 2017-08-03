using MineralDatabase.App.ViewModels;
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
using System.Windows.Shapes;

namespace MineralDatabase.App.Views
{
    /// <summary>
    /// Interaction logic for SupplierView.xaml
    /// </summary>
    public partial class SupplierView : Window
    {
        public SupplierView()
        {
            InitializeComponent();
            this.Loaded += SupplierView_Loaded;
        }

        private void SupplierView_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = new SupplierViewModel();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRename_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
