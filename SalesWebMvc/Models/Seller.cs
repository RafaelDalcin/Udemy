using System.Collections.Generic;
using System.Linq;
namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalart { get; set; }
        public Department Department { get; set; } 
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalart, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalart = baseSalart;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void Remove(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales (DateTime initital, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initital && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
