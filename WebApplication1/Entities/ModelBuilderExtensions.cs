using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace HospitalDB.Entities
{
	public static class ModelBuilderExtensions
	{
		public static void Seed(this ModelBuilder modelBuilder)
		{
            //customers
            var mockCustomer = new List<Customer>();
            mockCustomer.Add(new Customer { IdClient= 1, FName = "Ahmad", LName = "Alaziz"});
            mockCustomer.Add(new Customer { IdClient = 2, FName = "Taha", LName = "Savas" });
            mockCustomer.Add(new Customer { IdClient = 3, FName = "Artem", LName = "Rymar" });
            modelBuilder.Entity<Customer>().HasData(mockCustomer);

            //Employees
            var mockEmployee = new List<Employee>();
            mockEmployee.Add(new Employee { IdEmployee = 1, FName = "Aghiad", LName = "Alaziz" });
            mockEmployee.Add(new Employee { IdEmployee = 2, FName = "maximus", LName = "Savas" });
            mockEmployee.Add(new Employee { IdEmployee = 3, FName = "Luis", LName = "Rymar" });
            modelBuilder.Entity<Employee>().HasData(mockEmployee);


            //Orders
            var mockOrder = new List<Order>();
            mockOrder.Add(new Order
            {
                IdOrder = 1,
                DateAccepted = new DateTime(1999, 2, 11),
                DateFinished = new DateTime(2000, 2, 11),
                Notes = "sdfdsf",
                IdClient = 1,
                IdEmployee = 1
            });
            mockOrder.Add(new Order
            {
                IdOrder = 2,
                DateAccepted = new DateTime(1998, 2, 11),
                DateFinished = new DateTime(2000, 2, 11),
                Notes = "sdfdsf",
                IdClient = 1,
                IdEmployee = 3
            });

            mockOrder.Add(new Order
            {
                IdOrder = 3,
                DateAccepted = new DateTime(1998, 2, 11),
                DateFinished = new DateTime(2000, 2, 11),
                Notes = "sdfdsf",
                IdClient = 2,
                IdEmployee = 2
            });
            modelBuilder.Entity<Order>().HasData(mockOrder);

            var mockConfectionary = new List<Confectionary>();
            mockConfectionary.Add(new Confectionary { IdConfectionary = 1, Name = "Chocolate", PricePerIte = 100, Type="food" });
            mockConfectionary.Add(new Confectionary { IdConfectionary = 2, Name = "Cake for birthday", PricePerIte = 200, Type = "food" });
            mockConfectionary.Add(new Confectionary { IdConfectionary = 3, Name = "baklawa", PricePerIte = 150, Type = "food" });
            modelBuilder.Entity<Confectionary>().HasData(mockConfectionary);

            var mockConfectOrder = new List<Confectionary_Order>();
            mockConfectOrder.Add(new Confectionary_Order { IdConfection = 1,IdOrder = 1, Quantity = 2, Notes ="" });
            mockConfectOrder.Add(new Confectionary_Order { IdConfection = 2, IdOrder = 1, Quantity = 4, Notes = "" });
            mockConfectOrder.Add(new Confectionary_Order { IdConfection = 3, IdOrder = 2, Quantity = 1, Notes = "" });
            mockConfectOrder.Add(new Confectionary_Order { IdConfection = 3, IdOrder = 3, Quantity = 50, Notes = "" });
            mockConfectOrder.Add(new Confectionary_Order { IdConfection = 2, IdOrder = 3, Quantity = 70, Notes = "" });
            modelBuilder.Entity<Confectionary_Order>().HasData(mockConfectOrder);
            /*
            var mockDoc = new List<Doctor>();
            mockDoc.Add(new Doctor { IdDoctor = 1, FirstName = "Ahmad", LastName = "Alaziz", Email = "s19047@pjwstk.edu.pl" });
            mockDoc.Add(new Doctor { IdDoctor = 2, FirstName = "Alice", LastName = "Lashuk", Email = "AliceLashuk@gmail.com" });
            mockDoc.Add(new Doctor { IdDoctor = 3, FirstName = "Roman", LastName = "Isianko", Email = "Roma@gmail.com" });
            modelBuilder.Entity<Doctor>().HasData(mockDoc);

            var mockPatient = new List<Patient>();
            mockPatient.Add(new Patient { IdPatient = 1, FirstName = "Max", LastName = "Alaziz", Birthdate = new DateTime(2000, 1, 2) });
            mockPatient.Add(new Patient { IdPatient = 2, FirstName = "Connor", LastName = "Lashuk", Birthdate = new DateTime(1982, 1, 2) });
            mockPatient.Add(new Patient { IdPatient = 3, FirstName = "Khabib", LastName = "Isianko", Birthdate = new DateTime(1977, 1, 2) });
            modelBuilder.Entity<Patient>().HasData(mockPatient);

            var mockPrescription = new List<Prescription>();
            mockPrescription.Add(new Prescription { IdPrescription = 1, Date = new DateTime(1999, 2, 11), DueDate = new DateTime(2002, 2, 11), IdPatient = 3, IdDoctor = 1 });
            mockPrescription.Add(new Prescription { IdPrescription = 2, Date = new DateTime(1967, 3, 12), DueDate = new DateTime(2002, 2, 11), IdPatient = 2, IdDoctor = 2 });
            mockPrescription.Add(new Prescription { IdPrescription = 3, Date = new DateTime(1996, 4, 24), DueDate = new DateTime(2002, 2, 11), IdPatient = 1, IdDoctor = 3 });
            modelBuilder.Entity<Prescription>().HasData(mockPrescription);

            var mockMedicament = new List<Confectionary>();
            mockMedicament.Add(new Confectionary { IdMedicament = 1, Name = "Med1", Description = "Alaziz", Type = "KushKush" });
            mockMedicament.Add(new Confectionary { IdMedicament = 2, Name = "Med2", Description = "Lashuk", Type = "SmokeTillYouDrop" });
            mockMedicament.Add(new Confectionary { IdMedicament = 3, Name = "Med3", Description = "Isianko", Type = "420" });
            modelBuilder.Entity<Confectionary>().HasData(mockMedicament);

            var mockPrescMed = new List<Prescription_Medicament>();
            mockPrescMed.Add(new Prescription_Medicament { IdMedicament = 1, IdPrescription = 1, Dose = 31, Details = "ksdlsd" });
            mockPrescMed.Add(new Prescription_Medicament { IdMedicament = 2, IdPrescription = 2, Dose = 23, Details = "wedfwef" });
            mockPrescMed.Add(new Prescription_Medicament { IdMedicament = 3, IdPrescription = 2, Dose = 45, Details = "swefwe" });
            modelBuilder.Entity<Prescription_Medicament>().HasData(mockPrescMed);

             */
        }
	}
}
