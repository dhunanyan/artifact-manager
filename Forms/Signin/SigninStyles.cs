using ArtifactManager.Properties;
using CustomControls.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtifactManager.Forms.Signin
{
    public class SigninStyles
    {
        Signin caller;
        public SigninStyles(Signin caller)
        {
            this.caller = caller;
        }

        public void PasswordChecker(
            Panel panelPasswordCharCapital, 
            Panel panelPasswordCharDigit, 
            Panel panelPasswordCharSpecial, 
            Panel panelPasswordCharCount, 
            string capital, string digit, string special, string count)
        {
            panelPasswordCharCapital.BackgroundImage = Boolean.Parse(capital) ? Resources.CorrectGreen : Resources.Error;
            panelPasswordCharDigit.BackgroundImage = Boolean.Parse(digit) ? Resources.CorrectGreen : Resources.Error;
            panelPasswordCharSpecial.BackgroundImage = Boolean.Parse(special) ? Resources.CorrectGreen : Resources.Error;
            panelPasswordCharCount.BackgroundImage = Boolean.Parse(count) ? Resources.CorrectGreen : Resources.Error;
        }

        public void LoginChecker(Panel panelLoginCharSpecial, Panel panelLoginCharCount, string special, string count)
        {
            panelLoginCharSpecial.BackgroundImage = Boolean.Parse(special) ? Resources.CorrectGreen : Resources.Error;
            panelLoginCharCount.BackgroundImage = Boolean.Parse(count) ? Resources.CorrectGreen : Resources.Error;
        }
    }
}
