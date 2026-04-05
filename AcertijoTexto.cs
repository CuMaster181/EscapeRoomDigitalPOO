using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoomDigitalPOO
{
    public class AcertijoTexto : Acertijo
    {
        private string respuestaCorrecta;

        public AcertijoTexto(string pregunta, string pista,
            int intentos, int puntaje, string respuesta)
            : base(pregunta, pista, intentos, puntaje)
        {
            respuestaCorrecta = respuesta.ToLower().Trim();
        }

        protected override bool ValidarRespuesta(string respuesta)
        {
            return respuesta.ToLower().Trim() == respuestaCorrecta;
        }
    }
}
