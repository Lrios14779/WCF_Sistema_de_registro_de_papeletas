using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Final
{
    public partial class WindowsFechas : Form
    {
        Papeletas.ServicioPapeletasClient Fecha = new Papeletas.ServicioPapeletasClient();
        public WindowsFechas()
        {
            InitializeComponent();
        }

        private void WindowsFechas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'infraccionesFechas.Tb_Papeleta' Puede moverla o quitarla según sea necesario.
            this.tb_PapeletaTableAdapter.Fill(this.infraccionesFechas.Tb_Papeleta);

        }

        private void btnFechas_Click(object sender, EventArgs e)
        {
            dtgListadoFechas.DataSource
                = Fecha.ListarPapeletasPorFechas(Convert.ToDateTime(dtpFecini.Text), Convert.ToDateTime(dtpFecfin.Text));
        }
    }
}
