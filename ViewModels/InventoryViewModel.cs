using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using MineralDatabase.App.Models;

namespace MineralDatabase.App.ViewModels
{
    public partial class InventoryViewModel : PropertyChangedBase
    {
        #region Constructor
        public InventoryViewModel()
        {
            IngredientList = GetAllIngredients();
            SelectedIngredient = _ingredientList.FirstOrDefault();
        }
        #endregion

        #region Properties
        MineralDBEntities db = new MineralDBEntities();

        private List<Ingredient> _ingredientList;
        public List<Ingredient> IngredientList
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
        public List<Ingredient> GetAllIngredients()
        {
            var IngredientList = db.Ingredients
                        .Where(ingredient => ingredient.Id == ingredient.Id)
                        .ToList();

            return IngredientList;
        }
        #endregion
    }
}
