//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MineralDatabase.App.Models
{
    using System;
    using System.Collections.Generic;
    using Caliburn.Micro;
    
    public partial class Ingredient : PropertyChangedBase
    {
        private long _id;
        public long Id
        {
            get { return _id; }
            set
            {
                _id = value;
                NotifyOfPropertyChange(() => Id);
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }

        private decimal _defaultPercentage;
        public decimal DefaultPercentage
        {
            get { return _defaultPercentage; }
            set
            {
                _defaultPercentage = value;
                NotifyOfPropertyChange(() => DefaultPercentage);
            }
        }

        private byte[] _notes;
        public byte[] Notes
        {
            get { return _notes; }
            set
            {
                _notes = value;
                NotifyOfPropertyChange(() => Notes);
            }
        }

        private long _type;
        public long Type
        {
            get { return _type; }
            set
            {
                _type = value;
                NotifyOfPropertyChange(() => Type);
            }
        }

        private decimal _totalCost;
        public decimal TotalCost
        {
            get { return _totalCost; }
            set
            {
                _totalCost = value;
                NotifyOfPropertyChange(() => TotalCost);
            }
        }

        private decimal _costGrams;
        public decimal CostGrams
        {
            get { return _costGrams; }
            set
            {
                _costGrams = value;
                NotifyOfPropertyChange(() => CostGrams);
            }
        }

        private decimal _costPerGrams;
        public decimal CostPerGrams
        {
            get { return _costPerGrams; }
            set
            {
                _costPerGrams = value;
                NotifyOfPropertyChange(() => CostPerGrams);
            }
        }

        private decimal _inventoryAmount;
        public decimal InventoryAmount
        {
            get { return _inventoryAmount; }
            set
            {
                _inventoryAmount = value;
                NotifyOfPropertyChange(() => InventoryAmount);
            }
        }

        private decimal _inventoryThreshold;
        public decimal InventoryThreshold
        {
            get { return _inventoryThreshold; }
            set
            {
                _inventoryThreshold = value;
                NotifyOfPropertyChange(() => InventoryThreshold);
            }
        }

        private string _manufacturer;
        public string Manufacturer
        {
            get { return _manufacturer; }
            set
            {
                _manufacturer = value;
                NotifyOfPropertyChange(() => Manufacturer);
            }
        }

        private string _folderName;
        public string FolderName
        {
            get { return _folderName; }
            set
            {
                _folderName = value;
                NotifyOfPropertyChange(() => FolderName);
            }
        }

        private long _activated;
        public long Activated
        {
            get { return _activated; }
            set
            {
                _activated = value;
                NotifyOfPropertyChange(() => Activated);
            }
        }

        private string _vendor;
        public string Vendor
        {
            get { return _vendor; }
            set
            {
                _vendor = value;
                NotifyOfPropertyChange(() => Vendor);
            }
        }

        private string _location;
        public string Location
        {
            get { return _location; }
            set
            {
                _location = value;
                NotifyOfPropertyChange(() => Location);
            }
        }
    }
}
