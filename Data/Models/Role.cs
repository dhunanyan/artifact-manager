using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactManager.Data.Models
{
    public class Role
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoleID { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = null!;

        public ICollection<CurrentUserRole> CurrentUserRoles { get; set; } = null!;
        public ICollection<CurrentRolePrivilege> CurrentRolePrivileges { get; set; } = null!;

        public override string ToString()
        {
            return Name;
        }
    }
}
