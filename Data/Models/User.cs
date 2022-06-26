using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactManager.Data.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; } = null!;

        [MaxLength(50)]
        public string LastName { get; set; } = null!;

        [MaxLength(50)]
        public string Username { get; set; } = null!;

        [MaxLength(100)]
        public string Password { get; set; } = null!;

        public ICollection<CurrentUserRole> CurrentUserRoles { get; set; } = null!;
        public ICollection<CurrentUserCategory> CurrentUserCategories { get; set; } = null!;

        public override string ToString()
        {
            return Username;
        }
    }
}
