using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactManager.Data.Models
{
    public class Privelege
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PrivelegeID { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [MaxLength(20)]
        public string Type { get; set; } = null!;

        public ICollection<CurrentRolePrivilege> CurrentRolePrivileges { get; set; } = null!;
    }
}
