using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoomDigitalPOO
{
    public class GameManager
    {
        private List<Acertijo> acertijos;
        private List<Item> inventario;

        public int Puntaje { get; set; }
        public Acertijo AcertijoActual { get; set; }

        public List<Item> Inventario
        {
            get { return inventario; }
        }

        public GameManager()
        {
            acertijos = new List<Acertijo>();
            inventario = new List<Item>();
            InicializarJuego();
        }

        private void InicializarJuego()
        {
            acertijos.Add(new AcertijoCodigo("Código de la puerta:", 3, "1234"));
            acertijos.Add(new AcertijoRandom("Adivina número (1-5):", 3));

            SiguienteAcertijo();
        }

        public void SiguienteAcertijo()
        {
            if (acertijos.Count == 0)
            {
                AcertijoActual = null;
                return;
            }

            AcertijoActual = acertijos[0];
            acertijos.RemoveAt(0);
        }

        public bool ResolverAcertijo(string respuesta)
        {
            if (AcertijoActual == null)
                return false;

            bool correcto = AcertijoActual.Intentar(respuesta);

            if (correcto)
            {
                Puntaje += 10;
                inventario.Add(new Item("llave", "Llave", Properties.Resources.LlaveRoja));
                SiguienteAcertijo();
            }

            return correcto;
        }

        public bool JuegoTerminado()
        {
            return AcertijoActual == null;
        }
    }
}
