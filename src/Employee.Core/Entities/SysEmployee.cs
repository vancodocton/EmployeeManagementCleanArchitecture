using Employee.Core.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Employee.Core.Entities
{
    public class SysEmployee : IEntity<int>
    {
        public int Id { get; set ; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress), StringLength(100)]
        public string Email { get; set; }

        public SysEmployee()
        {
            FirstName = null!;
            LastName = null!;
            DateOfBirth = default;
            PhoneNumber = null!;
            Email = null!;
        }
    }
}
