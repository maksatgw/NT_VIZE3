using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NT_VIZE3.Hafta5.D1
{
    public partial class Ders_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Bir alanın Required olup olmadığını kontrol ederiz.
            RequiredFieldValidator1.ControlToValidate = TextBox1.ClientID;
            RequiredFieldValidator1.Text = "Abi sınavda çıkar bak boş geçme";
            RequiredFieldValidator1.InitialValue = "";
            //veya 
            //RequiredFieldValidator1.ControlToValidate = "TextBox1";

            //Framework 4> olanlar, client tarafında 
            //UnobtrusiveValidationMode="None" bu satırı eklemeli.

            //Bir alanın değer aralığını kontrol ederiz.
            RangeValidator1.ControlToValidate = TextBox1.ClientID;
            RangeValidator1.Text = "1 ile 2 arasinda sayi girmelisiniz";

            RangeValidator1.Type = ValidationDataType.Integer;
            RangeValidator1.MinimumValue = "1";
            RangeValidator1.MaximumValue = "2";

            //Birden fazla alanın değerlerinin eşitliğini kontrol eder
            CompareValidator1.ControlToValidate = TextBox1.ClientID;
            CompareValidator1.ControlToValidate = TextBox2.ClientID;
            CompareValidator1.Text = "Aynı degil";


        }
    }
}