using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoomDigitalPOO
{
    public class AcertijoCodigo : Acertijo
    {
        private string codigoCorrecto;

        public AcertijoCodigo(string pregunta, string pista, 
            int intentos, int puntaje, string codigo)
            : base(pregunta, pista, intentos, puntaje)
        {
            codigoCorrecto = codigo;
        }

        protected override bool ValidarRespuesta(string respuesta)
        {
            return respuesta.Trim() == codigoCorrecto;
        }
    }
}