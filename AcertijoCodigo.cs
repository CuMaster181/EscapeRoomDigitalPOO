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

        public AcertijoCodigo(string pregunta, int intentos, string codigo)
            : base(pregunta, intentos)
        {
            codigoCorrecto = codigo;
        }

        protected override bool ValidarRespuesta(string respuesta)
        {
            return respuesta == codigoCorrecto;
        }
    }
}