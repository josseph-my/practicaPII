using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practicaPII
{
    public class Envio
    {
        public int Id { get; set; }
        public string PuertoOrigen { get; set; }
        public string PuertoDestino { get; set; }
        public double PesoToneladas { get; set; }

        public Envio(int id, string puertoOrigen, string puertoDestino, double pesoToneladas)
        {
            Id = id;
            PuertoOrigen = puertoOrigen;
            PuertoDestino = puertoDestino;
            PesoToneladas = pesoToneladas;
        }

    }
}

