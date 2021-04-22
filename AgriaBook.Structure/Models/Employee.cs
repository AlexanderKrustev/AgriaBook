namespace AgriaBook.Structure.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public String FirstName { get; set; }

        [Required]
        public String LastName { get; set;  }
        
        public IEnumerable<Position> Positions { get; set; } = new List<Position>();

        [Required]
        public string PictureURL { get; set; }

        
        public string PhoneNumber { get; set; }

        
        public string email { get; set; }
        
    }
}
