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
            
            string origen = txtOrigen.Text;
            string destino = txtDestino.Text;
            double peso = double.Parse(txtPeso.Text);
            
            EnvioTipo = ddlTipoEnvio.SelectedItem.Text;

            if (EnvioTipo == "granel")
            {
                panelGranel.Visible = true;
            }
            else if (EnvioTipo == "contenedor")
            {
                panelContenedor.Visible = true;
            }

                switch (EnvioTipo)
            {
                case "Granel":
                    panelGranel.Visible = true;
                    string granel = txtContenedores.Text;
                    EnvioGranel envioGranel = new EnvioGranel(1, "Puerto A", "Puerto B", 10, GranelTipo);
                     costo = envioGranel.CalcularCosto(granel, peso);
                    lblEnvio.Text = $"El costo es: {costo}";
                    lblEnvio.Visible = true;
                    break;
                case "Contenedor":
                    panelContenedor.Visible = true;
                    int cantidad = int.Parse(txtContenedores.Text);
                    EnvioContenedor envioContenedor = new EnvioContenedor(1, "Puerto A", "Puerto B", 10, 6);
                     costo = envioContenedor.CalcularCosto(cantidad,peso);
                    lblEnvio.Text = $"El costo es: {costo}";
                    lblEnvio.Visible = true;
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