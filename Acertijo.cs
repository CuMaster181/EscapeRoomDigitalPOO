using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoomDigitalPOO
{
    public abstract class Acertijo
    {
        public string Pregunta { get; }
        public int IntentosRestantes { get; private set; }

        protected Acertijo(string pregunta, int intentos)
        {
            Pregunta = pregunta;
            IntentosRestantes = intentos;
        }

        public bool Intentar(string respuesta)
        {
            if (ValidarRespuesta(respuesta))
                return true;

            IntentosRestantes--;
            return false;
        }

        protected abstract bool ValidarRespuesta(string respuesta);
    }
}
