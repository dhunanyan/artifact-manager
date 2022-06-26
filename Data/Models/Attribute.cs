using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactManager.Data.Models
{
    public class Attribute
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AttributeID { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(20)]
        public string Type { get; set; } = null!;

        public ICollection<CurrentEntityAttribute> CurrentEntityAttributes { get; set; } = null!;
    }
}
