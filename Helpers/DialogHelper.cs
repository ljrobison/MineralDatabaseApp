using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineralDatabase.App.Helpers
{
    public static class DialogHelper
    {
        public static void ShowDialog<T>(params Object[] param) where T : class
        {
            var windowManager = new WindowManager();
            T viewModel = Activator.CreateInstance(typeof(T), param) as T;

            windowManager.ShowWindow(viewModel);
        }
    }
}
