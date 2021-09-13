using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web_Final_01.WCFFinal01;

namespace Web_Final_01.TestPapeletas
{
    public partial class WebFechas : System.Web.UI.Page
    {
        ServicioPapeletasClient miWeb01 = new ServicioPapeletasClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dtgFechas01.DataSource
                = miWeb01.ListarPapeletasPorFechas(Convert.ToDateTime(txtFecini.Text), Convert.ToDateTime(txtFecfin.Text));
            dtgFechas01.DataBind();
                    }
    }
}