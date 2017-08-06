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

        private ObservableCollection<Supplier> _supplierList;
        public ObservableCollection<Supplier> SupplierList
        {
            get { return _supplierList; }
            set
            {
                _supplierList = value;
                NotifyOfPropertyChange(() => SupplierList);
            }
        }

        private Supplier _selectedSupplier;
        public Supplier SelectedSupplier
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
            db.Suppliers.Load();
            SupplierList = db.Suppliers.Local;
        }


        #endregion
    }
}
