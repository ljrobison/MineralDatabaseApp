using Caliburn.Micro;
using MineralDatabase.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MineralDatabase.App
{
    public class Bootstrapper : BootstrapperBase
    {
        private SimpleContainer container;

        public Bootstrapper()
        {
            Initialize();

            string _appDataFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var _fileName = Path.Combine(_appDataFilePath, "MineralDB.db");

            if (!System.IO.File.Exists(_fileName))
            {
                Console.WriteLine("Just entered to create Sync DB");

                SQLiteConnection.CreateFile(_fileName);

                using (var sqlite2 = new SQLiteConnection("Data Source=" + _fileName))
                {
                    sqlite2.Open();
                    //string sql = "create table highscores (Id t)";
                    string sql = "CREATE TABLE Ingredients (Id long, Name text, DefaultPercentage numeric not null)";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite2);
                    command.ExecuteNonQuery();
                }
            }
        }

        protected override void Configure()
        {
            container = new SimpleContainer();

            container.Singleton<IWindowManager, WindowManager>();

            container.PerRequest<ShellViewModel>();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        protected override object GetInstance(Type service, string key)
        {
            return container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            container.BuildUp(instance);
        }
    }
}
