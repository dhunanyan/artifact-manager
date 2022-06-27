using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtifactManager.Forms.AllCollection
{
    public partial class AllCollection : Form
    {
        public AllCollection caller;

        public AllCollectionStyles AllCollectionStyles;
        public AllCollectionReq AllCollectionReq;
        public AllCollectionController AllCollectionController;
        public AllCollection(AllCollection caller)
        {
            InitializeComponent();

            this.caller = caller;
            AllCollectionStyles = new AllCollectionStyles(this);
            AllCollectionReq = new AllCollectionReq(this);
            AllCollectionController = new AllCollectionController(this);
        }

        public FlowLayoutPanel flowLayoutPanelAllRecords;
    }
}
