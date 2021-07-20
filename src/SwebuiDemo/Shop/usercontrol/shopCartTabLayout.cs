using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Swebui.Controls;

using System;

namespace SwebuiDemo
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class shopCartTabLayout : SwebUserControl
    {
        private ShopInfo shopInfo = DataProvider.GetShopInfo();
        private List<OrderListItem> orderListItems = DataProvider.GetOrderLists();
        private void shopCartTabLayout_Load(object sender, EventArgs e)
        {
            int height = 0;
            for (int i = 0; i < orderListItems.Count; i++)
            {
                cartSectLayout cartSectLayout = new cartSectLayout(orderListItems[i]);
                panel2.Controls.Add(cartSectLayout);
                height += cartSectLayout.Height;
            }
            this.Height = 115 + height;
            SetSelectNum();
            SetSelectAmout();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Name == "checkBox2")
                checkBox1.Checked = checkBox2.Checked;
            else
                checkBox2.Checked = checkBox1.Checked;
            foreach (cartSectLayout cartSectLayout in panel2.Controls)
            {
                cartSectLayout.SetShopCheckbox(checkBox2.Checked);
            }
           SetSelectNum();
            SetSelectAmout();
        }
        public void IsAllShopProductSelect()
        {
            int i = 0;
            foreach (cartSectLayout cartSectLayout in panel2.Controls)
            {
                if (cartSectLayout.IsChecked)
                    i++;
            }
            if (i == panel2.Controls.Count)
                checkBox1.Checked = checkBox2.Checked = true;
            else checkBox1.Checked = checkBox2.Checked = false;
        }
        public void SetSelectNum()
        {
            int i = 0;
            foreach (cartSectLayout cartSectLayout in panel2.Controls)
            {
                i += cartSectLayout.GetSelectProductNum();
            }
           numLab.Text= i.ToString();
        }
     
        public void SetSelectAmout()
        {
            float i = 0;
            foreach (cartSectLayout cartSectLayout in panel2.Controls)
            {
                i += cartSectLayout.GetShopAmount();
            }
             allLab.Text=i.ToString();
            ((shopCart)this.Form).SetSelectAmount(i.ToString());

        }
    }
}