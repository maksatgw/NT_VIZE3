using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NT_VIZE3.Hafta3.D3
{
    public partial class Ders_3_Odev_1 : System.Web.UI.Page
    {
        //Form üzerine checkbox, checked list, calendar gibi nesneleri yerleştirerek bunlarla ilgili soru oluşturun
        //ve oluşturduğunuz sorunun yanıtlarını program kodu olarak yazın.
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)//Checkboxlist içindeki tekrarı engeller
            {
                Label1.Text = "Randevu alınabilecek klinikleri göster";
                Label2.Text = "";
                CheckBoxList1.Items.Add("KBB");
                CheckBoxList1.Items.Add("ortopedi");
                CheckBoxList1.Items.Add("dahiliye");
                CheckBoxList1.Items.Add("dermotoloji");
                CheckBoxList1.AutoPostBack = true;
                CheckBox1.AutoPostBack = true;
            }
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                CheckBoxList1.Items[2].Enabled = false;
                CheckBoxList1.Items[3].Enabled = false;
            }
            else
            {
                CheckBoxList1.Items[2].Enabled = true;
                CheckBoxList1.Items[3].Enabled = true;
            }
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Text = "";
            int index = 0;
            foreach (ListItem item in CheckBoxList1.Items)
            {
                index++;
                if (item.Selected)
                {
                    TextBox1.Text += item.Text + " " + Calendar1.SelectedDate.ToShortDateString();
                }
            }
        }

        
    }
}