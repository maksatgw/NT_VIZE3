using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NT_VIZE3.Hafta4.D1
{
    public partial class Ders_1_Konu_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink1.Text = "git bakalim";
            HyperLink1.NavigateUrl = "~/Hafta4/D1/Ders_1.aspx";
        }
    }
}