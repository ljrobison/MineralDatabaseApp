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
            GetAllManufacturers();
            GetManufacturersNames();
        }
        #endregion

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
            get { return _selectedManufacturer; }
            set
            {
                _selectedManufacturer = value;
                NotifyOfPropertyChange(() => SelectedManufacturer);
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

        private List<string> _manufacturerNameList;
        public List<string> ManufacturerNameList
        {
            get { return _manufacturerNameList; }
            set
            {
                _manufacturerNameList = value;
                NotifyOfPropertyChange(() => ManufacturerNameList);
            }
        }

        #endregion

        #region Methods
        public void GetAllIngredients()
        {
            db.Ingredients.Load();
            IngredientList = db.Ingredients.Local;
        }

        public void GetAllManufacturers()
        {
            db.Manufacturers.Load();
            ManufacturerList = db.Manufacturers.Local;
        }

        public void GetManufacturersNames()
        {
            db.Manufacturers.Load();
            var result = db.Manufacturers.Select(x => x.CompanyName).ToList();
            ManufacturerNameList = result;
        }
        #endregion
    }
}
