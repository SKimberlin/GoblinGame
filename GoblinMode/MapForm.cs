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
    public partial class MapForm : Form
    {
        private List<Town> towns;
        public MapForm()
        {
            InitializeComponent();
            InitializeMap();
        }

        private void InitializeMap()
        {
            towns = TownManager.Instance.GetTowns();
            foreach (Town town in towns)
            {
                if (town != null) 
                { 
                    CurrentTown.Items.Add(town.name);
                }
            }
        }

        private void GoToTown(object sender, EventArgs e)
        {
            TownForm townForm = new TownForm(TownManager.Instance.GetTownByName(CurrentTown.Text));
            townForm.Show();
            this.Close();
        }
    }
}
