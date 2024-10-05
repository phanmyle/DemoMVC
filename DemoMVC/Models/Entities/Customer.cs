using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models.Entities {
    public class Customer 
    {
        [Key] 
        public string CustomerID {get;set;}
        public string FullName { get;set;}
        public string Adress {get;set;}
    }

}

