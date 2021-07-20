using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swebui.Controls;


namespace SwebuiDemo
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class cartListLayout : SwebUserControl
    {
        public bool IsChecked = false;
        public cartListLayout(OrderShopProductInfo orderShopProductInfo, ShopInfo shopInfo) : base()
        {
            InitializeComponent();
            proImg.ResourceID = orderShopProductInfo.Img;
            proName.Text = orderShopProductInfo.Name;
            promoImg1.ResourceID = shopInfo.Promos[0].SImgID;
            promoImg2.ResourceID = shopInfo.Promos[1].SImgID;
            promoImg3.ResourceID = shopInfo.Promos[2].SImgID;
            promoImg4.ResourceID = shopInfo.Promos[3].SImgID;
            typeLab.Text = orderShopProductInfo.Type;
            priceLab.Text = "гд" + orderShopProductInfo.Price.ToString();
            numText.Text = orderShopProductInfo.Num.ToString();
            allLab.Text = "гд" + (orderShopProductInfo.Price * orderShopProductInfo.Num).ToString();
        }

        private void panel5_MouseEnter(object sender, SwebMouseMoveEventArgs e)
        {
            findbtn.Visible = true;
        }

        private void panel5_MouseLeave(object sender, SwebMouseMoveEventArgs e)
        {
            findbtn.Visible = false;
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            numText.Text = ((Convert.ToInt32(numText.Text)) + 1).ToString();
            float price = Convert.ToSingle(priceLab.Text.Replace("гд", ""));
            allLab.Text = "гд" + (price * (Convert.ToInt32(numText.Text))).ToString();
            if (checkBox1.Checked) ((shopCartTabLayout)this.Parent.Parent.Parent.Parent).SetSelectAmout();                              
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            numText.Text = ((Convert.ToInt32(numText.Text)) - 1).ToString();
            float price = Convert.ToSingle(priceLab.Text.Replace("гд", ""));
            allLab.Text = "гд" + (price * (Convert.ToInt32(numText.Text))).ToString();
            if (checkBox1.Checked) ((shopCartTabLayout)this.Parent.Parent.Parent.Parent).SetSelectAmout();
        }

        private void numText_TextChanged(object sender, EventArgs e)
        {
            if (numText.Text != null)
            {
                System.Text.RegularExpressions.Regex rex =
                new System.Text.RegularExpressions.Regex(@"^\d+$");
                if (rex.IsMatch(numText.Text))
                {
                    float price = Convert.ToSingle(priceLab.Text.Replace("гд", ""));
                    allLab.Text = "гд" + (price * (Convert.ToInt32(numText.Text))).ToString();
                }
                else
                {
                    numText.Text = "1"; 
                    allLab.Text = priceLab.Text;
                }
            }
            if (checkBox1.Checked) ((shopCartTabLayout)this.Parent.Parent.Parent.Parent).SetSelectAmout();
        }
        public void SetCheckbox(bool isCheck)
        {
            checkBox1.Checked = isCheck;
            IsChecked = isCheck;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            IsChecked = checkBox1.Checked;
            ((cartSectLayout)this.Parent.Parent).IsAllProductSelect();
            ((shopCartTabLayout)this.Parent.Parent.Parent.Parent).IsAllShopProductSelect();
            ((shopCartTabLayout)this.Parent.Parent.Parent.Parent).SetSelectNum();
            ((shopCartTabLayout)this.Parent.Parent.Parent.Parent).SetSelectAmout();
        }
        public float GetAmount()
        {
            if (IsChecked)
                return Convert.ToSingle(allLab.Text.Replace("гд", ""));
            else return 0f;
        }
    }
}