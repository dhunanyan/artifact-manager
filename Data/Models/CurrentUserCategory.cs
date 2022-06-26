using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactManager.Data.Models
{
    public class CurrentUserCategory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CurrentUserCategoryID { get; set; }
        public string CategoryOwner { get; set; } = null!;

        public int? UserID { get; set; }
        public User User { get; set; } = null!;
        public int? CategoryID { get; set; }
        public Category Category { get; set; } = null!;
    }
}
