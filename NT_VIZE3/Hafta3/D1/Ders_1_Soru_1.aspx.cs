using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NT_VIZE3.Hafta3.D1
{
    public partial class Ders_1_Soru_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Her Page Reload olduğunda tekrar tekrar ekleme yapmasın istedik.
            if (BulletedList1.Items.Count == 0)
            {
                BulletedList1.BulletStyle = BulletStyle.Numbered;
                //BulletList öğelerine eklemeler yapıyoruz. Form INIT olduğunda bunlar listeye atanmış olacak.
                BulletedList1.Items.Add("A");
                BulletedList1.Items.Add("B");
                BulletedList1.Items.Add("C");
                BulletedList1.Items.Add("D");
                BulletedList1.Items.Add("E");
                BulletedList1.Items.Add("F");
            }
           
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
          
        }

        //Her bir vizenin karşısındaki textboxa calendardaki tarihi eklemek için böyle bir yol izledim.
        //Bir tane yaptım bundan altı tane olarak düşünebilirsiniz.
        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
        }
    }
}