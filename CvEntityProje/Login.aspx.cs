using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{

    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DBCVENTİTYEntities4 db = new DBCVENTİTYEntities4();
        protected void Button1_Click(object sender, EventArgs e)
        {


            var sorgu = from x in db.TBLADMIN where x.KULLANICIAD == TextBox1.Text
                        && x.SIFRE == TextBox2.Text select x;

            

            if (sorgu.Any())  //any durumu yani sorgu dogruysa bir şey dondürürse kullanılır
            {
                Response.Redirect("İletisim.Aspx");

            }
            else
            {
                Response.Redirect("Hatalı kullanıcı adı ya da şifre girişi yaptınız.Lütfen tekrar deneyiniz!");
            }

        }
    }
}