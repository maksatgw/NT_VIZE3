using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NT_VIZE3.Hafta4.D2
{
    public partial class Ders_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "IMYO";
            HiddenField1.Value = "ogr ismail dusmez izmir 1959";

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = HiddenField1.Value;
        }
    }
}