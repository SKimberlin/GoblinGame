﻿using System;
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
    public partial class ShopForm : Form
    {
        public ShopForm()
        {
            InitializeComponent();
        }

        private void LeaveShop(object sender, EventArgs e)
        {
            Town.Instance.OpenTownForm();
            Shop.Shop.Instance.CloseShopForm();
        }
    }
}
