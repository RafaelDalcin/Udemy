using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace SalesWebMvc.Models
{
    public class Seller
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Base salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalary { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; } 
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
            
        }

        public Seller(string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
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
