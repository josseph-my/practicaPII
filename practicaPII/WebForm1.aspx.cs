using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practicaPII
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string GranelTipo = "";
        public string EnvioTipo = "";
        public float costo = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlTipoEnvio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            
            GranelTipo = tipoGranelList.SelectedItem.Text;
            EnvioTipo = ddlTipoEnvio.SelectedItem.Text;

            switch (EnvioTipo)
            {
                case "Granel":
                    EnvioGranel envioGranel = new EnvioGranel(1, "Puerto A", "Puerto B", 10, GranelTipo);
                     costo = envioGranel.CalcularCosto(GranelTipo);
                    lblEnvio.Text = $"El costo es: {costo}";
                    break;
                case "Contenedor":
                    EnvioContenedor envioContenedor = new EnvioContenedor(1, "Puerto A", "Puerto B", 10, 6);
                     costo = envioContenedor.CalcularCosto(CantidadContenedores);
                    lblEnvio.Text = $"El costo es: {costo}";
                    break;
                default:
                    lblEnvio.Text = "Tipo de envío no reconocido.";
                    break;
            }
            
        }

        public void tipoGranelList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}