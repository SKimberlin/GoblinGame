using GoblinMode.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinMode.Shop
{
    public class Shop
    {
        private ShopForm form = new ShopForm();
        private static Shop instance;
        private List<Item.Item> inventory = new List<Item.Item>();
        public static Shop Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Shop();
                }
                return instance;
            }
        }

        public void OpenShopForm()
        {
            form.Show();
        }
        public void CloseShopForm()
        {
            form.Hide();
        }

        public void ResetInventory()
        {
            inventory.Clear();
        }
    }
}
