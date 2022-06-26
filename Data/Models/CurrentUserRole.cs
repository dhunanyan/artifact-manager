using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactManager.Data.Models
{
    public class CurrentUserRole
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CurrentUserRoleID { get; set; }
        public string RoleOwner { get; set; } = null!;

        public int? UserID { get; set; }
        public User User { get; set; } = null!;
        public int? RoleID { get; set; }
        public Role Role { get; set; } = null!;
    }
}
