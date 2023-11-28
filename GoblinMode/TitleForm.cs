using GoblinMode.Character;
using GoblinMode.Dialogue;
using GoblinMode.Item;
using GoblinMode.UI;
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
            CharacterCreate form = new CharacterCreate();

            form.Left = this.Left;
            form.Top = this.Top;
            form.Size = this.Size;

            this.Hide();
            form.Show();
        }
        
    }
}
