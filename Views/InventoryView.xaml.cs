using MineralDatabase.App.Helpers;
using MineralDatabase.App.Models;
using MineralDatabase.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for WindowInventory.xaml
    /// </summary>
    public partial class InventoryView
    {
        public InventoryView()
        {
            InitializeComponent();
            this.Loaded += InventoryView_Loaded;
        }

        void InventoryView_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext =  new InventoryViewModel();
            ComboBoxIngredientName.SelectedIndex = 0;
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

        private void btnManufacturers_Click(object sender, RoutedEventArgs e)
        {
            DialogHelper.ShowDialog<ManufacturerViewModel>();
        }
    }
}
