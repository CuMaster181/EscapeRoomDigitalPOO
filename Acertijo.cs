using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoomDigitalPOO
{
    public abstract class Acertijo : IResoluble
    {
        public string Pregunta { get; }
        public string Pista { get; }
        public int IntentosRestantes { get; private set; }
        public int PuntajeBase { get; }

        protected Acertijo(string pregunta, string pista, int intentos, int puntaje)
        {
            Pregunta = pregunta;
            Pista = pista;
            IntentosRestantes = intentos;
            PuntajeBase = puntaje;
        }

        public bool Resolver(string respuesta)
        {
            if (ValidarRespuesta(respuesta))
                return true;

            IntentosRestantes--;
            return false;
        }

        protected abstract bool ValidarRespuesta(string respuesta);

        public bool Agotado => IntentosRestantes <= 0;
    }
}
