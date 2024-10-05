using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models.Entities
{
    public class Student
    {
        [Key]
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public string Adress { get; set; }
    }
}
