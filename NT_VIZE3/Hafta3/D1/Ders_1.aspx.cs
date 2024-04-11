using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NT_VIZE3.Hafta3.D1
{
    public partial class Ders_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Bulletlist
            //BulletList Nesnesine erişim sağlayıp, Bulletstyle öğesini düzenliyoruz.
            BulletedList1.BulletStyle = BulletStyle.Numbered;
            //BulletList öğelerine eklemeler yapıyoruz. Form INIT olduğunda bunlar listeye atanmış olacak.
            BulletedList1.Items.Add("A");
            BulletedList1.Items.Add("B");
            BulletedList1.Items.Add("C");
            BulletedList1.Items.Add("D");
            BulletedList1.Items.Add("E");
            BulletedList1.Items.Add("F");

            //Veri Alım tekrarını engellemek için üç ana başlık var.
            //PDFTEN BAKIN!
            //1 -  PostBack :
            //Client talep eder, sayfa sunucuya yollanır. İşlemler sunucuda yapıldıktan sonra tekrar
            //clienta yönlendirilir
            //2 - isPostBack :
            //Sayfanın geri döndürülmesi durumunu yönetir. Sayfanın init durumu ile runtime'da yapılan
            //postback işlemi arasındaki farkı yönetmek için kullanılır.
            //3 - AutoPostBack : 
            //Verilerin hemen yollanmasını sağlar. 

            //Calendarin Page Load edildiğinde nasıl formatlanacağını ayarladığımız yer.
            Calendar1.NextPrevFormat = NextPrevFormat.ShortMonth;

        }
        //Etkinlik 1. Calendar nesnesini tıklandığında textboxta görüntülenmesini isteyeceğiz.
        //Bu metoda erişmek için calendara iki defa tıklamanız yeterli.
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            //Yani, anlatmama gerek var mı?
            TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        //Soru - 1 
        //Form load edildiği zaman, ekranda vize sınavlarına gireceğiniz dersleriniz circle imgesi ile alt alta görüntülenirken,
        //her imgenin karşısındaki textbox'a nisan ayında gireceğiniz sınav gününü calendar üzerinden seçerek aktaran uygulamayı yazınız.
        //mutlaka table'ları kullanın.
    }
}