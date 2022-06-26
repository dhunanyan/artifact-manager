using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactManager.Data.Models
{
    public class Entity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EntityID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        public int? Rank { get; set; }
        public int? Power { get; set; }
        public int? Size { get; set; }


        public int? CategoryID { get; set; }
        public Category Category { get; set; } = null!;

        public ICollection<CurrentEntityAttribute> CurrentEntityAttributes { get; set; } = null!;

        public override string ToString()
        {
            return Name;
        }
    }
}
