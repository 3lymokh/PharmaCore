using System;
using System.Collections.Generic;
using System.Linq;

namespace PharamaCore
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string BatchNumber { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Supplier { get; set; }

        public string Status
        {
            get
            {
                if (ExpiryDate.Date < DateTime.Today) return "Expired";
                if (Quantity <= 10) return "Low Stock";
                if (ExpiryDate.Date <= DateTime.Today.AddDays(30)) return "Expiring Soon";
                return "In Stock";
            }
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }

    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
    }

    public class SaleItem
    {
        public int MedicineId { get; set; }
        public string MedicineName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get { return Quantity * UnitPrice; } }
    }

    public class Sale
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<SaleItem> Items { get; set; }
        public decimal Total
        {
            get { return Items == null ? 0m : Items.Sum(i => i.LineTotal); }
        }
    }
}
