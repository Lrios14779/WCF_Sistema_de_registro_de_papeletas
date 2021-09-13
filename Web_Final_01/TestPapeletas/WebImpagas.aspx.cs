using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web_Final_01.WCFFinal01;


namespace Web_Final_01.TestPapeletas
{
    public partial class WebImpagas : System.Web.UI.Page
    {
        ServicioPapeletasClient miWeb = new ServicioPapeletasClient();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            dtgListarPapeletas.DataSource
                = miWeb.ListarPapeletasImpagas(txtPlaca01.Text);
            
        }
    }
}