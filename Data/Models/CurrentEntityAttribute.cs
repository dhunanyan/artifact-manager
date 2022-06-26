using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactManager.Data.Models
{
    public class CurrentEntityAttribute
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CurrentEntityAttributeID { get; set; }
        public string AttributeOwner { get; set; } = null!;

        public int? EntityID { get; set; }
        public Entity Entity { get; set; } = null!;
        public int? AttributeID { get; set; }
        public Attribute Attribute { get; set; } = null!;
    }
}
