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

        public AcertijoRandom(string pregunta, string pista, 
            int intentos, int puntaje, int minimo, int maximo)
            : base(pregunta, pista, intentos, puntaje)
        {
            numeroCorrecto = Random.Shared.Next(minimo, maximo + 1);
        }
        public override string Pista
        {
            get
            {
                string paridad = numeroCorrecto % 2 == 0 ? "par" : "impar";
                string rango = numeroCorrecto <= 5 ? "menor o igual a 5" : "mayor a 5";
                return $"El número es {paridad} y {rango}.";
            }
        }

        protected override bool ValidarRespuesta(string respuesta)
        {
            return int.TryParse(respuesta.Trim(), out int numero)
                   && numero == numeroCorrecto;
        }
    }
}