using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practicaPII
{
    public class EnvioGranel : Envio, Icosteable, Itrackeable
    {

        public enum TipoDeGranel
        {
            Granos,
            Mineral,
        }

        public string TipoGranel { get; set; }
        private int contador = 0;

        public EnvioGranel(int id, string puertoOrigen, string puertoDestino, double pesoToneladas, string tipoGranel) : base(id, puertoOrigen, puertoDestino, pesoToneladas)
        {
            tipoGranel = TipoGranel;
        }

        public void Copiar()
        {
            Console.WriteLine("Envío granel copiado.");
        }

        public void Editar()
        {
            Console.WriteLine("Envío granel editado.");
        }

        public float CalcularCosto(string tipo)
        {

            TipoGranel = tipo;
            float costoGranel = 0;
            if (TipoGranel == "Granos")
            {
                costoGranel = 50;
            }
            else if (TipoGranel == "Mineral")
            {
                costoGranel = 80;
            }

            int costoBasePorTonelada = 100;
            return (float)(PesoToneladas * costoBasePorTonelada + costoGranel);
        }

        public string obtenerEstadoRural()
        {
            string estado = "";

            switch (contador)
            {
                case 0:
                    estado = "Cargando";
                    break;
                case 1:
                    estado = "En transito";
                    break;
                case 2:
                default:
                    estado = "Descargando";
                    break;
            }
            if (contador < 2)
            {
                contador++;
            }

            return estado;

        }
    }
}