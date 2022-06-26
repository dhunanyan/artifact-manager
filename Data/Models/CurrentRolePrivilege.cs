using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactManager.Data.Models
{
    public class CurrentRolePrivilege
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CurrentRolePrivilegeID { get; set; }
        public string PrivilegeOwner { get; set; } = null!;

        public int? PrivelegeID { get; set; }
        public Privelege Privelege { get; set; } = null!;
        public int? RoleID { get; set; }
        public Role Role { get; set; } = null!;
    }
}
