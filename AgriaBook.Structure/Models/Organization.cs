namespace AgriaBook.Structure.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Organization
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(120)]
        public string Name { get; set; }

        public Employee Chairman { get; set; }

        public IEnumerable<Employee> Members { get; set; } = new List<Employee>();
    }
}
