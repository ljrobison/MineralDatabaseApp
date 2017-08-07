using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using MineralDatabase.App.Models;
using System.Collections.ObjectModel;
using System.Data.Entity;

namespace MineralDatabase.App.ViewModels
{
    /// <summary>
    /// Interaction logic for ManufacturerView.xaml
    /// </summary>
    public partial class ManufacturerViewModel : PropertyChangedBase
    {
        public ManufacturerViewModel()
        {
            GetAllManufacturers();
        }

        #region Properties

        MineralDBEntities db = new MineralDBEntities();

        private ObservableCollection<Manufacturer> _manufacturerList;
        public ObservableCollection<Manufacturer> ManufacturerList
        {
            get { return _manufacturerList; }
            set
            {
                _manufacturerList = value;
                NotifyOfPropertyChange(() => ManufacturerList);
            }
        }

        private Manufacturer _selectedManufacturer;
        public Manufacturer SelectedManufacturer
        {
            get
            {
                return _selectedManufacturer;
            }
            set
            {
                _selectedManufacturer = value;
                NotifyOfPropertyChange(() => SelectedManufacturer);
            }
        }

        #endregion

        #region Methods

        public void GetAllManufacturers()
        {
            db.Manufacturers.Load();
            ManufacturerList = db.Manufacturers.Local;
        }

        #endregion
    }
}
