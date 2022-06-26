using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactManager.Data.Models
{
    public class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }

        [MaxLength(100)] 
        public string Name { get; set; } = null!;

        public ICollection<CurrentUserCategory> CurrentUserCategories { get; set; } = null!;
        public ICollection<Entity> Entities { get; set; } = null!;

        public override string ToString()
        {
            return Name;
        }
    }
}
