using System.ComponentModel.DataAnnotations;

namespace DemoWeb.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }

        [DataType(DataType.Date)]
        public required DateTime DateOfBirth { get; set; }
        public required string Address { get; set; }
        public required string City { get; set; }
    }
}
