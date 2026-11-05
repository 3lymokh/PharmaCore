using System;
using System.Collections.Generic;
using System.Linq;

namespace PharamaCore
{
    public static class AppData
    {
        public static readonly List<Medicine> Medicines = new List<Medicine>();
        public static readonly List<Customer> Customers = new List<Customer>();
        public static readonly List<Supplier> Suppliers = new List<Supplier>();
        public static readonly List<Sale> Sales = new List<Sale>();
        public static string DemoPassword = "1234";

        static AppData()
        {
            Medicines.Add(new Medicine
            {
                Id = 1,
                Name = "Paracetamol 500mg",
                Category = "Analgesics",
                BatchNumber = "B101",
                Quantity = 45,
                UnitPrice = 12.50m,
                ExpiryDate = DateTime.Today.AddMonths(12),
                Supplier = "PharmaCorp"
            });
            Medicines.Add(new Medicine
            {
                Id = 2,
                Name = "Amoxicillin 250mg",
                Category = "Antibiotics",
                BatchNumber = "B102",
                Quantity = 8,
                UnitPrice = 35.00m,
                ExpiryDate = DateTime.Today.AddDays(15),
                Supplier = "MedLife"
            });
            Medicines.Add(new Medicine
            {
                Id = 3,
                Name = "Vitamin C 1000mg",
                Category = "Vitamins",
                BatchNumber = "B103",
                Quantity = 120,
                UnitPrice = 20.00m,
                ExpiryDate = DateTime.Today.AddMonths(8),
                Supplier = "HealthPlus"
            });

            Customers.Add(new Customer { Id = 1, Name = "Demo Customer", Phone = "01000000000" });
            Suppliers.Add(new Supplier { Id = 1, Name = "Demo Supplier", Company = "PharmaCorp", Phone = "02000000000" });
        }

        public static int NextMedicineId() { return Medicines.Count == 0 ? 1 : Medicines.Max(m => m.Id) + 1; }
        public static int NextCustomerId() { return Customers.Count == 0 ? 1 : Customers.Max(c => c.Id) + 1; }
        public static int NextSupplierId() { return Suppliers.Count == 0 ? 1 : Suppliers.Max(s => s.Id) + 1; }
        public static int NextSaleId() { return Sales.Count == 0 ? 1 : Sales.Max(s => s.Id) + 1; }
    }
}
