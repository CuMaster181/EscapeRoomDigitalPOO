using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoomDigitalPOO
{
    public class AcertijoRandom : Acertijo
    {
        private int numeroCorrecto;

        public AcertijoRandom(string pregunta, int intentos)
            : base(pregunta, intentos)
        {
            Random random = new Random();
            numeroCorrecto = random.Next(1, 6);
        }

        protected override bool ValidarRespuesta(string respuesta)
        {
            int numero;
            return int.TryParse(respuesta, out numero) && numero == numeroCorrecto;
        }
    }
}