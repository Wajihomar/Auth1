using System.ComponentModel.DataAnnotations;

namespace Studentcontroller.Models
{
    public class User
    {
        [Key]
        public Guid UsersId { get; set; }
        public string? UserName { get; set; }

        [DataType(DataType.Password)]
        public string? Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
