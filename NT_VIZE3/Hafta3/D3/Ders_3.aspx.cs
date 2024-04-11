using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NT_VIZE3.Hafta3.D3
{
    public partial class Ders_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)//Checkboxlist içindeki tekrarı engeller
            {
                Label1.Text = "Lütfen aşaığdaki checkboxlardan seçim yapın";
                Label2.Text = "";
                CheckBoxList1.Items.Add("matematik");
                CheckBoxList1.Items.Add("cografya");
                CheckBoxList1.Items.Add("tarih");
                CheckBoxList1.Items.Add("ingilizce");
                CheckBoxList1.AutoPostBack = true;//kullanmadığında belirli nesnelerde hareket özgürlüğünü kısıtlar.
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "";
            int index = 0;
            foreach (ListItem item in CheckBoxList1.Items)
            {
                index++;
                if (item.Selected)
                {
                    Label2.Text += index.ToString() + " Seçildi: " + item.Text + " ";
                    TextBox1.Text += item.Text + " ";
                }
            }
        }

        //Form üzerine checkbox, checked list, calendar gibi nesneleri yerleştirerek bunlarla ilgili soru oluşturun
        //ve oluşturduğunuz sorunun yanıtlarını program kodu olarak yazın.

    }
}