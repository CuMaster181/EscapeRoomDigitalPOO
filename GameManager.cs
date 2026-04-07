using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeRoomDigitalPOO
{
    public class GameManager
    {
        //Colecciones
        private List<Acertijo> acertijos;
        private List<Item> inventario;

        //Estado del juego
        public Acertijo AcertijoActual { get; private set; }
        public int Puntaje { get; private set; }
        public bool LlaveRecogida { get; set; }
        public int EstadoEstanteria { get; set; }

        //Ruta de archivo
        private readonly string rutaArchivo =
           Path.Combine(Application.StartupPath, "Resultados.txt");

        //Inventario
        public List<Item> Inventario => inventario;


        public GameManager()
        {
            acertijos = new List<Acertijo>();
            inventario = new List<Item>();
            InicializarJuego();
        }

        private void InicializarJuego()
        {
        
            // Tipo 1 — AcertijoCodigo
            // args: pregunta, pista, intentos, puntaje, código
            acertijos.Add(new AcertijoCodigo(
                pregunta: "Ingresa el código escondido en la sala:",
                pista: "Se esconde en la Estanteria",
                intentos: 3,
                puntaje: 30,
                codigo: "2134"
            ));

            // Tipo 2 — AcertijoTexto
            // args: pregunta, pista, intentos, puntaje, respuesta
            acertijos.Add(new AcertijoTexto(
                pregunta: "¿Qué horas son? (usa ':' )",
                pista: "deberias de checar el reloj de la Cocina",
                intentos: 3,
                puntaje: 20,
                respuesta: "3:30"
            ));

            // Tipo 3 — AcertijoRandom
            // args: pregunta, pista, intentos, puntaje, min, max
            acertijos.Add(new AcertijoRandom(
                pregunta: "Adivina el número secreto entre 1 y 5:",
                pista: "Es un número impar.",
                intentos: 4,
                puntaje: 20,
                minimo: 1,
                maximo: 5
            ));
            MessageBox.Show("¡Bienvenido al Escape Room Digital! Resuelve los acertijos para ganar puntos y avanzar.",
                "Escape Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            bool correcto = AcertijoActual.Resolver(respuesta);

            if (correcto)
            {
                Puntaje += AcertijoActual.PuntajeBase;
                AgregarItemSegunAcertijo();
                SiguienteAcertijo();
            }

            return correcto;
        }

        public void AgregarItemSegunAcertijo()
        {
            // Cada tipo de acertijo entrega un ítem diferente
            switch (AcertijoActual)
            {
                case AcertijoCodigo:
                    inventario.Add(new Item("llave", "Llave maestra",
                        Properties.Resources.LlaveFinal));
                    LlaveRecogida = true;
                    break;

                case AcertijoTexto:
                    // puedes agregar otro ítem aquí, ej. una nota
                    break;

                case AcertijoRandom:
                    // ej. un código extra, una gema, etc.
                    break;
            }
        }

        public void UsarPista()
        {
            Puntaje = Math.Max(0, Puntaje - 5);
        }

        public void PenalizarPorTiempo()
        {
            Puntaje = Math.Max(0, Puntaje - 1);
        }

        public bool JuegoTerminado() => AcertijoActual == null;

        // Aquí viven los try-catch de I/O (10 pts de excepciones)
        public void GuardarResultado(int tiempoSegundos)
        {
            try
            {
                // Construir el texto del resultado
                string contenido =
                    $"=== RESULTADO ESCAPE ROOM ==={Environment.NewLine}" +
                    $"Fecha:   {DateTime.Now:dd/MM/yyyy HH:mm}{Environment.NewLine}" +
                    $"Puntaje: {Puntaje} pts{Environment.NewLine}" +
                    $"Tiempo:  {tiempoSegundos} segundos{Environment.NewLine}" +
                    $"Ítems:   {inventario.Count}{Environment.NewLine}" +
                    $"----------------------------{Environment.NewLine}";

                // AppendAllText: agrega al archivo sin borrar partidas anteriores
                File.AppendAllText(rutaArchivo, contenido);
            }
            catch (UnauthorizedAccessException ex)
            {
                // Sin permiso para escribir en esa carpeta
                MessageBox.Show($"Sin permiso para guardar: {ex.Message}",
                    "Error de archivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (IOException ex)
            {
                // Disco lleno, archivo bloqueado, etc.
                MessageBox.Show($"Error al guardar resultado: {ex.Message}",
                    "Error de archivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public string LeerHistorial()
        {
            try
            {
                if (!File.Exists(rutaArchivo))
                    return "No hay partidas guardadas aún.";

                return File.ReadAllText(rutaArchivo);
            }
            catch (IOException ex)
            {
                return $"No se pudo leer el historial: {ex.Message}";
            }
        }
    }
}
