using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtifactManager.Forms.Main
{
    public class MainReq
    {
        Form caller;

        public MainReq(Form caller)
        {
            this.caller = caller;
        }
    }
}
