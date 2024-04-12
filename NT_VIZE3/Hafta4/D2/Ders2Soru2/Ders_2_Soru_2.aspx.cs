using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NT_VIZE3.Hafta4.D2
{
    public partial class Ders_2_Soru_2 : System.Web.UI.Page
    {
        //SORU-1 Form üzerine 3 adet hyperlink yerleştirin.
        //1. hyperlink anasayfa 2. hyperlink resim-1 3. hyperlink
        //resim-2 text olarak ekranda görüntülensin hyperlink resim1
        //tıklandığı zaman ilgili form sayfasına gidip orada resim1
        //görüntülensin resim1 görüntülenirken ana sayfaya tıklandıgında
        //anasayfaya dönsün resim2 linki tıklandığında resim2 link sayfasında resim2
        //görüntülensin ana sayfa linkine basınca anasayfaya dönüş olsun
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink1.Text = "Anasayfa";
            HyperLink2.Text = "Resim 1";
            HyperLink3.Text = "Resim 2";
            HyperLink1.NavigateUrl = "ders_2_soru_2.aspx";
            HyperLink2.NavigateUrl = "Resim1.aspx";
            HyperLink3.NavigateUrl = "Resim2.aspx";

        }
    }
}