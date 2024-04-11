using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NT_VIZE3.Hafta3.D2
{
    public partial class Ders_2_Soru_1 : System.Web.UI.Page
    {
        //Soru
        //Form üzerine bir adet buton bir adet checkbox ve bir adet label yerleştirin
        //Form load edildiği zaman butonun textinde onayla, checkbox 1 in ve label'ın textinde ise hiçbir şey görüntülenmesin.
        //checkbox 1 in checked change i gerçekleştiğinde checkbox 1 in textinde bilgilendirilmek istiyorum yazısı görüntülensin.
        //checked change gerçekleşmediği sürece checkbox 1 in textinde hiçbir şey görüntülenmesin.
        //checkbox 1 change i işaretli iken ve textinde bilgilendirmek istiyorum yazısı görüntülendiğinde buton 1'e basıldığı zaman 
        //label'1'in textinde tüm gelişmelerden haberdar edileceksiniz yazısı ile checkbox 1 in textinde isteiğiniz dikkate alınmıştır yazısı görüntülensin.
        //AutoPostBack kullanmayın dedi haberiniz olsun.

        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Text = "Onayla";
            CheckBox1.Text = "";
            Label1.Text = "";
            
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                CheckBox1.Text = "Bilgilendirilmek istiyorum";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                Label1.Text = "Tüm gelişmelerden haberdar olacağım.";
                CheckBox1.Text = "İsteğiniz dikkate alınmıştır.";

            }
        }
    }
}