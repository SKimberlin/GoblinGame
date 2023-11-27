using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinMode
{
    internal class FormController
    {
        public static void SwitchForm(Form previousForm, Form nextForm)
        {
            nextForm.Show();
            previousForm.Close();
        }
    }
}
