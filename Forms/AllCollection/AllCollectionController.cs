using ArtifactManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtifactManager.Forms.AllCollection
{
    public class AllCollectionController
    {
        AllCollection caller;
        AllCollectionReq AllCollectionReq;
        AllCollectionStyles AllCollectionStyles;
        public AllCollectionController (AllCollection caller)
        {
            this.caller = caller;
            AllCollectionStyles = new AllCollectionStyles(caller);
            AllCollectionReq = new AllCollectionReq(caller);
        }

        public void GenerateInitRecords()
        {
            //foreach(Category category in AllCollectionReq.GetAllCategories())
            //{
            //    foreach(Entity entity in AllCollectionReq.GetCurrentCategoryAllEntities(category))
            //    {
            //        foreach()
            //    }
            //}
        }
    }
}
