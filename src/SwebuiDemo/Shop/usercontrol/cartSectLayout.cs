using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swebui.Controls;


namespace SwebuiDemo
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class cartSectLayout : SwebUserControl
    {
        private ShopInfo _ShopInfo;
        public bool IsChecked = false;
        private List<OrderShopProductInfo> _orderShopProductInfos;
        public cartSectLayout(OrderListItem orderListItem) : base()
        {
            InitializeComponent();
            _ShopInfo = orderListItem.ShopInfo;
            _orderShopProductInfos = orderListItem.OrderShopProductInfos;
        }

        private void cartSectLayout_Load(object sender, EventArgs e)
        {
            shopicon.ResourceID = _ShopInfo.ShopIcon;
            shopnamebtn.Text = _ShopInfo.Name;
            for (int i = 0; i < _orderShopProductInfos.Count; i++)
            {
                panel3.Controls.Add(new cartListLayout(_orderShopProductInfos[i], _ShopInfo));
            }

            this.Height = 40 + _orderShopProductInfos.Count * 134;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            IsChecked = checkBox1.Checked;
            foreach(cartListLayout cartListLayout in panel3.Controls)
            {
                cartListLayout.SetCheckbox(checkBox1.Checked);
            }
           ((shopCartTabLayout)this.Parent.Parent).IsAllShopProductSelect();

        }
        public void SetShopCheckbox(bool ischeck)
        {
           IsChecked= checkBox1.Checked = ischeck;
            foreach (cartListLayout cartListLayout in panel3.Controls)
            {
                cartListLayout.SetCheckbox(checkBox1.Checked);
            }
        }

        public void IsAllProductSelect()
        {
            int i = GetSelectProductNum();
            if (i == panel3.Controls.Count)
            IsChecked=checkBox1.Checked = true;
            else IsChecked=checkBox1.Checked = false;
        } 

        public int GetSelectProductNum()
        {
            int i = 0;
            foreach (cartListLayout cartListLayout in panel3.Controls)
            {
                if (cartListLayout.IsChecked)
                    i++;
            }
            return i;
        }
        public float GetShopAmount()
        {
            float i = 0f;
            foreach (cartListLayout cartListLayout in panel3.Controls)
            {

                i += cartListLayout.GetAmount();
            }
            return i;
        }

    }

}