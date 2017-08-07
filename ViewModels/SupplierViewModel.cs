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
    public partial class SupplierViewModel : PropertyChangedBase
    {
        public SupplierViewModel()
        {
            GetAllSuppliers();
        }

        #region Properties

        MineralDBEntities db = new MineralDBEntities();

        private ObservableCollection<Manufacturer> _supplierList;
        public ObservableCollection<Manufacturer> SupplierList
        {
            get { return _supplierList; }
            set
            {
                _supplierList = value;
                NotifyOfPropertyChange(() => SupplierList);
            }
        }

        private Manufacturer _selectedSupplier;
        public Manufacturer SelectedSupplier
        {
            get
            {
                return _selectedSupplier;
            }
            set
            {
                _selectedSupplier = value;
                NotifyOfPropertyChange(() => SelectedSupplier);
            }
        }

        #endregion

        #region Methods

        public void GetAllSuppliers()
        {
            db.Manufacturers.Load();
            SupplierList = db.Manufacturers.Local;
        }


        #endregion
    }
}
