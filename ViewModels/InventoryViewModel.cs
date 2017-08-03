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
        }
        #endregion

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
        #endregion

        #region Methods
        public void GetAllIngredients()
        {
            db.Ingredients.Load();
            IngredientList = db.Ingredients.Local;
        }

        public void GetAllSuppliers()
        {
            db.Suppliers.Load();
            SupplierList = db.Suppliers.Local;
        }
        #endregion
    }
}
