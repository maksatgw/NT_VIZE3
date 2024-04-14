using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace NT_VIZE3.Hafta5.D3
{
    public partial class Ders_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegularExpressionValidator1.ControlToValidate = "TextBox1";
            RegularExpressionValidator1.Text = "Duzgun sayi gir dostum!";
            //Suslu parantez içine yazdığımız sayı kadar sayısal değer ister bu arkadaş
            //RegularExpressionValidator1.ValidationExpression = @"\d{3}";
            RegularExpressionValidator1.ValidationExpression = @"\d{1}-\d{3}-\d{3}-\d{4}";
        }
    }
}