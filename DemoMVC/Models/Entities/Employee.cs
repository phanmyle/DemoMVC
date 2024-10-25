using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models.Entities
{
    public class Employee : Person
    {

        public string EmployeeID { get;set;}

       public int Age {get;set;}

    }
}
dotnet aspnet-codegenerator controller -name EmployeeController -m Employee -dc DemoMVC.Data.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite

