using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NT_VIZE3.Hafta4.D2.Ders2Soru2
{
    public partial class Resim1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink1.Text = "Anasayfa";
            HyperLink1.NavigateUrl = "ders_2_soru_2.aspx";

            Image1.ImageUrl = "~/hafta4/D2/resim/1.jpg";
            Image1.Height = 400;
            Image1.Width = 400;
            Image1.BorderStyle = BorderStyle.Ridge;
        }
    }
}