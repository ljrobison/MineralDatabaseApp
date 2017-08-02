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
        List<Ingredient> _ingredientList = new List<Ingredient>();
        MineralDBEntities db = new MineralDBEntities();

        public InventoryViewModel()
        {
            _ingredientList = GetAllIngredients();
        }

        public List<Ingredient> GetAllIngredients()
        {
            var IngredientList = db.Ingredients
                        .Where(ingredient => ingredient.Id == ingredient.Id)
                        .ToList();

            return IngredientList;
        }

        public List<Ingredient> IngredientList
        {
            get { return _ingredientList; }
            set
            {
                _ingredientList = value;
                NotifyOfPropertyChange(() => IngredientList);
            }
        }
    }
}
