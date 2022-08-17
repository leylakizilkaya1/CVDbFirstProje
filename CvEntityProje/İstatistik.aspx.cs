using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class İstatistik : System.Web.UI.Page
    {

     DBCVENTİTYEntities4 db=new DBCVENTİTYEntities4();
        protected void Page_Load(object sender, EventArgs e)

        {
            Label1.Text = db.TBLYETENEKLER.Count().ToString(); //yetenekler tablosundan yetenek sayısını yazdırma
            Label2.Text = db.TBLILETISIM.Count().ToString(); //iletisim tablosundan iletisim sayısını yazdırma
            Label3.Text = db.TBLYETENEKLER.Average(x=>x.DERECE).ToString(); //yetenekler tablosundan ortalama yetenek derecesini yaz
            Label4.Text = db.TBLYETENEKLER.Max(x => x.DERECE).ToString(); //maximum yetenek derecesini yazdır.
          


        }
    }
}