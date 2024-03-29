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
    
    public partial class Ingredient
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal DefaultPercentage { get; set; }
        public byte[] Notes { get; set; }
        public long Type { get; set; }
        public decimal TotalCost { get; set; }
        public decimal CostGrams { get; set; }
        public decimal CostPerGrams { get; set; }
        public decimal InventoryAmount { get; set; }
        public decimal InventoryThreshold { get; set; }
        public string Manufacturer { get; set; }
        public string FolderName { get; set; }
        public long Activated { get; set; }
        public string Vendor { get; set; }
        public string Location { get; set; }
    }
}
