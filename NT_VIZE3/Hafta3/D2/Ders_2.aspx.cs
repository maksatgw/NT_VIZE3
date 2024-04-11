using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NT_VIZE3.Hafta3.D2
{
    public partial class Ders_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //isPostBack veri tekrarını engelliyor. Dikkat edin sınavda mutlaka çıkacağını düşünüyorum
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("1");
                DropDownList1.Items.Add("2");
                DropDownList1.Items.Add("3");

                CheckBox1.Text = "a";
                CheckBox2.Text = "b";
                CheckBox3.Text = "c";
                CheckBox4.Text = "d";
                CheckBox5.Text = "e";
                CheckBox6.Text = "f";
                CheckBox7.Text = "g";
                //AutoPostBack geriye veri döndürülmemesini engelliyor. Eski kız arkadaşım gibi.
                DropDownList1.AutoPostBack = true;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                CheckBox1.Checked = true;
                CheckBox2.Checked = true;
                CheckBox3.Checked = false;
                CheckBox4.Checked = false;
                CheckBox5.Checked = false;
                CheckBox6.Checked = false;
                CheckBox7.Checked = false;
            }
            else if (DropDownList1.SelectedIndex == 1)
            {
                CheckBox1.Checked = false;
                CheckBox2.Checked = false;
                CheckBox3.Checked = true;
                CheckBox4.Checked = true;
                CheckBox5.Checked = false;
                CheckBox6.Checked = false;
                CheckBox7.Checked = false;
            }
            else if (DropDownList1.SelectedIndex == 2)
            {
                CheckBox1.Checked = false;
                CheckBox2.Checked = false;
                CheckBox3.Checked = false;
                CheckBox4.Checked = false;
                CheckBox5.Checked = true;
                CheckBox6.Checked = true;
                CheckBox7.Checked = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string selectedIndex = "";
            if (CheckBox1.Checked)
            {
                selectedIndex += CheckBox1.Text + ", ";
            }
            if (CheckBox2.Checked)
            {
                selectedIndex += CheckBox2.Text + ", ";
            }
            if (CheckBox3.Checked)
            {
                selectedIndex += CheckBox3.Text + ", ";
            }
            if (CheckBox4.Checked)
            {
                selectedIndex += CheckBox4.Text + ", ";
            }
            if (CheckBox5.Checked)
            {
                selectedIndex += CheckBox5.Text + ", ";
            }
            if (CheckBox6.Checked)
            {
                selectedIndex += CheckBox6.Text + ", ";
            }
            if (CheckBox7.Checked)
            {
                selectedIndex += CheckBox7.Text + ", ";
            }
            TextBox1.Text = selectedIndex.TrimEnd(',', ' ');

        }

        //Soru
        //Form üzerine bir adet buton bir adet checkbox ve bir adet label yerleştirin
        //Form load edildiği zaman butonun textinde onayla, checkbox 1 in ve label'ın textinde ise hiçbir şey görüntülenmesin.
        //checkbox 1 in checked change i gerçekleştiğinde checkbox 1 in textinde bilgilendirilmek istiyorum yazısı görüntülensin.
        //checked change gerçekleşmediği sürece checkbox 1 in textinde hiçbir şey görüntülenmesin.
        //checkbox 1 change i işaretli iken ve textinde bilgilendirmek istiyorum yazısı görüntülendiğinde buton 1'e basıldığı zaman 
        //label'1'in textinde tüm gelişmelerden haberdar edileceksiniz yazısı ile checkbox 1 in textinde isteiğiniz dikkate alınmıştır yazısı görüntülensin.

    }
}