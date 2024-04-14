using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NT_VIZE3.Hafta5.D1
{
    public partial class Ders_2_Soru_2 : System.Web.UI.Page
    {
        //Soru -2 Form üzerine 1 den fazla label ve textbox nesnesi
        //yerleştirelerek kullanıcının textlere değer girerken boş geçmesini
        //engelleyen aralık değerlerini kontrol eden ve bunları karşılaştıran program kodunu yazınız
        protected void Page_Load(object sender, EventArgs e)
        {
            //Bir alanın Required olup olmadığını kontrol ederiz.
            RequiredFieldValidator1.ControlToValidate = TextBox1.ClientID;
            RequiredFieldValidator1.Text = "Abi sınavda çıkar bak boş geçme";
            RequiredFieldValidator1.InitialValue = "";

            RequiredFieldValidator2.ControlToValidate = TextBox1.ClientID;
            RequiredFieldValidator2.Text = "Abi sınavda çıkar bak boş geçme";
            RequiredFieldValidator2.InitialValue = "";
            

            //Framework 4> olanlar, client tarafında 
            //UnobtrusiveValidationMode="None" bu satırı eklemeli.

            //Birden fazla alanın değerlerinin eşitliğini kontrol eder
            CompareValidator1.ControlToValidate = TextBox1.ClientID;
            CompareValidator1.ControlToValidate = TextBox2.ClientID;
            CompareValidator1.Text = "Aynı degil";

        }
    }
}