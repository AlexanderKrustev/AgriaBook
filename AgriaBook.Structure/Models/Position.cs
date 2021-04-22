namespace AgriaBook.Structure.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Position
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        public Employee SuperVisor { get; set; }

        public IEnumerable<Employee> UnderlingEmployees { get; set; } = new List<Employee>();
    }
}
