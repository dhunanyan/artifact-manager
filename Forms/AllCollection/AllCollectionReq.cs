using ArtifactManager.Data;
using ArtifactManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactManager.Forms.AllCollection
{
    public class AllCollectionReq
    {
        AllCollection caller;
        public AllCollectionReq(AllCollection caller)
        {
            this.caller = caller;
        }
        public List<Category> GetAllCategories()
        {
            using var context = new ArtifactManagerContext();
            var categories = context.Categories.ToList();
            return categories;
        }

        public List<Entity> GetCurrentCategoryAllEntities(Category category)
        {
            using var context = new ArtifactManagerContext();
            var entities = context.Entities.Where(e => e.Category == category).ToList();
            return entities;
        }

    }
}
