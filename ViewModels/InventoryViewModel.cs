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
    public partial class InventoryViewModel : PropertyChangedBase
    {
        #region Constructor
        public InventoryViewModel()
        {
            GetAllIngredients();
            GetAllSuppliers();
            GetSuppliersNames();
        }
        #endregion

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
            get { return _selectedSupplier; }
            set
            {
                _selectedSupplier = value;
                NotifyOfPropertyChange(() => SelectedSupplier);
            }
        }

        private ObservableCollection<Ingredient> _ingredientList;
        public ObservableCollection<Ingredient> IngredientList
        {
            get { return _ingredientList; }
            set
            {
                _ingredientList = value;
                NotifyOfPropertyChange(() => IngredientList);
            }
        }

        private Ingredient _selectedIngredient;
        public Ingredient SelectedIngredient
        {
            get
            {
                return _selectedIngredient;
            }
            set
            {
                _selectedIngredient = value;
                NotifyOfPropertyChange(() => SelectedIngredient);
            }
        }

        private List<string> _supplierNameList;
        public List<string> SupplierNameList
        {
            get { return _supplierNameList; }
            set
            {
                _supplierNameList = value;
                NotifyOfPropertyChange(() => SupplierNameList);
            }
        }

        #endregion

        #region Methods
        public void GetAllIngredients()
        {
            db.Ingredients.Load();
            IngredientList = db.Ingredients.Local;
        }

        public void GetAllSuppliers()
        {
            db.Manufacturers.Load();
            SupplierList = db.Manufacturers.Local;
        }

        public void GetSuppliersNames()
        {
            db.Manufacturers.Load();
            var result = db.Manufacturers.Select(x => x.CompanyName).ToList();
            SupplierNameList = result;
        }
        #endregion
    }
}
