using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practicaPII
{
    public class EnvioContenedor : Envio, Itrackeable, Icosteable
    {
        public int CantidadContenedores { get; set; }
        private int contador = 0;
        public EnvioContenedor(int id, string puertoOrigen, string puertoDestino, double pesoToneladas, int cantidadContenedores) : base(id, puertoOrigen, puertoDestino, pesoToneladas)
        {
            CantidadContenedores = cantidadContenedores;
        }

        public void Copiar()
        {
            Console.WriteLine("Envío granel copiado.");
        }

        public void Editar()
        {
            Console.WriteLine("Envío granel editado.");
        }

        public float CalcularCosto(int CantidadContenedores, double peso)
        {
            int costoBasePorTonelada = 100;
            return (float)(peso * costoBasePorTonelada * CantidadContenedores);
        }

        public string obtenerEstadoRural()
        {
            string estado = "";

            switch (contador)
            {
                case 0:
                    estado = "En puerto";
                    break;
                case 1:
                    estado = "En alta mar";
                    break;
                case 2:
                default:
                    estado = "Entregado";
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