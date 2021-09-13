using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Final_01
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioPapeletas" en el código y en el archivo de configuración a la vez.
    public class ServicioPapeletas : IServicioPapeletas
    {
        public List<PapeletaBE> ListarPapeleta()
        {
            InfraccionesEntities MisInfracciones = new InfraccionesEntities();
            List<PapeletaBE> objListaPapeleta = new List<PapeletaBE>();

            try
            {
                var query = MisInfracciones.Tb_Papeleta;

                foreach (var resultado in query)
                {
                    PapeletaBE objPapeletaBE = new PapeletaBE();

                    objPapeletaBE.Num_Papeleta = resultado.Num_Papeleta;
                    objPapeletaBE.Fec_Papeleta = Convert.ToDateTime(resultado.Fec_Papeleta);
                    objPapeletaBE.Num_Placa = resultado.Num_Placa;
                    objPapeletaBE.Cod_Infraccion = resultado.Cod_Infraccion;
                    objPapeletaBE.Est_Papeleta = resultado.Est_Papeleta;

                    objListaPapeleta.Add(objPapeletaBE);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objListaPapeleta;
        }
        public List<PapeletaBE> ListarPapeletasPorFechas(DateTime fecini, DateTime fecfin)
        {
            InfraccionesEntities misInfracciones = new WCF_Final_01.InfraccionesEntities();
            List<PapeletaBE> objListaPorFechas = new List<PapeletaBE>();

            try
            {
                var query = misInfracciones.Tb_Papeleta.Where(papeleta => papeleta.Fec_Papeleta >= fecini && papeleta.Fec_Papeleta <= fecfin);

                foreach (var resultado in query)
                {
                    PapeletaBE objFechaBE = new PapeletaBE();

                    objFechaBE.Num_Papeleta = resultado.Num_Papeleta;
                    objFechaBE.Fec_Papeleta = Convert.ToDateTime(resultado.Fec_Papeleta);
                    objFechaBE.Num_Placa = resultado.Num_Placa;
                    objFechaBE.Cod_Infraccion = resultado.Cod_Infraccion;
                    objFechaBE.Est_Papeleta = resultado.Est_Papeleta;

                    objListaPorFechas.Add(objFechaBE);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objListaPorFechas;
        }

        public List<PapeletaBE> ListarPapeletasImpagas(String placa)
        {
            InfraccionesEntities misInfracciones = new WCF_Final_01.InfraccionesEntities();
            List<PapeletaBE> ObjListaImpaga = new List<PapeletaBE>();

            try
            {
                var query = misInfracciones.Tb_Papeleta.Where(Estado => Estado.Est_Papeleta.Equals("1") && Estado.Num_Placa == placa);

                foreach (var resultado in query)
                {
                    PapeletaBE objImpaga = new PapeletaBE();

                    objImpaga.Num_Papeleta = resultado.Num_Papeleta;
                    objImpaga.Fec_Papeleta = Convert.ToDateTime(resultado.Fec_Papeleta);
                    objImpaga.Num_Placa = resultado.Num_Placa;
                    objImpaga.Cod_Infraccion = resultado.Cod_Infraccion;
                    objImpaga.Est_Papeleta = resultado.Est_Papeleta;

                    ObjListaImpaga.Add(objImpaga);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ObjListaImpaga;
        }
    }
}
