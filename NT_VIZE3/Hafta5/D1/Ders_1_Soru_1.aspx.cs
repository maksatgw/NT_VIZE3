using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NT_VIZE3.Hafta5.D1
{
    public partial class Ders_1_Soru_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Kullanıcı Adı";
            Label2.Text = "Şifre";
            RequiredFieldValidator1.ControlToValidate = TextBox1.ClientID;
            RequiredFieldValidator2.ControlToValidate = "TextBox2";
            RequiredFieldValidator1.Text = "Lütfen Kullanıcı adını boş geçmeyiniz";
            RequiredFieldValidator1.InitialValue = "";
            RequiredFieldValidator2.Text = "Şifre Gereklidir!";
            RequiredFieldValidator2.InitialValue = "";
        }
    }
}