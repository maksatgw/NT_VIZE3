using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NT_VIZE3.Hafta4.D3
{
    public partial class Ders_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ImageButton1.ImageUrl = "~/hafta4/D2/resim/1.jpg";
            ImageButton1.Height = 400;
            ImageButton1.Width = 400;
            ImageButton1.BorderStyle = BorderStyle.Ridge;

            LinkButton1.Text = "Mekatronik";
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("url");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Mekatronik Bolumune hos geldiniz!";
        }
    }
}