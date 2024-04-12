using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NT_VIZE3.Hafta4.D1
{
    public partial class Ders_1_Soru_1 : System.Web.UI.Page
    {
        //SORU-1 Dropdownlist'te yazar isimleri görüntülendiğinde label 
        //ın textinde o yazarın yazdığı son kitabın başlığı 
        //görüntülensin kural : eğer dropdownlistten yazar ismini
        //seç yazısı tıklanıyorsa labelın üstünde herhangi bir şey görüntülenmesin.
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && DropDownList1.Items.Count == 0)
            {
                DropDownList1.Items.Add("KİŞİ SEÇ");
                DropDownList1.Items.Add("ismail");
                DropDownList1.Items.Add("kemal");
                DropDownList1.Items.Add("can");
                DropDownList1.AutoPostBack = true;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                TextBox1.Text = "";

            }
            if (DropDownList1.SelectedIndex == 1)
            {
                TextBox1.Text = "Aşk ve inanç";
            }
            else if (DropDownList1.SelectedIndex == 2)
            {
                TextBox1.Text = "Kızıl ve hızıl";
            }
            else if (DropDownList1.SelectedIndex == 3)
            {
                TextBox1.Text = "Mesii Pessi";
            }
        }
    }
}