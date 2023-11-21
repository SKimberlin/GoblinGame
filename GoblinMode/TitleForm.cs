using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoblinMode
{
    public partial class TitleForm : Form
    {
        public TitleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CharacterCreate f1 = new CharacterCreate();
            this.Hide();
            f1.ShowDialog();

            f1.Left = this.Left;
            f1.Top = this.Top;
            f1.Size = this.Size;

            this.Close();
        }
    }
}
