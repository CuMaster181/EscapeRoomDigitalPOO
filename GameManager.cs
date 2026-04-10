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
        // ── Colecciones ────────────────────────────────────────────
        private List<Acertijo> acertijosCocina;   // acertijos de la Cocina
        private List<Acertijo> acertijosSotano;   // acertijos del Sótano
        private List<Item> inventario;

        // ── Estado del juego ───────────────────────────────────────
        public Acertijo AcertijoActual { get; private set; }
        public int Puntaje { get; private set; }
        public bool LlaveRecogida { get; set; }
        public int EstadoEstanteria { get; set; }
        public int EstadoAlfombra { get; set; }

        // Cuántos acertijos del sótano se han resuelto correctamente
        public int AciertosSotano { get; private set; }

        // Código de la caja fuerte: se genera cuando se resuelven
        // todos los acertijos del sótano
        public string CodigoCajaFuerte { get; private set; } = "";

        // ── Ruta de archivo ────────────────────────────────────────
        private readonly string rutaArchivo =
            Path.Combine(Application.StartupPath, "Resultados.txt");

        // ── Inventario público ─────────────────────────────────────
        public List<Item> Inventario => inventario;

        // ── Constructor ────────────────────────────────────────────
        public GameManager()
        {
            acertijosCocina = new List<Acertijo>();
            acertijosSotano = new List<Acertijo>();
            inventario = new List<Item>();
            InicializarJuego();
        }

        // ──────────────────────────────────────────────────────────
        private void InicializarJuego()
        {
            // ── ACERTIJOS DE LA COCINA ─────────────────────────────

            // Tipo 1 — AcertijoCodigo
            acertijosCocina.Add(new AcertijoCodigo(
                pregunta: "Ingresa el código escondido en la sala:",
                pista: "Se esconde en la Estantería",
                intentos: 3,
                puntaje: 30,
                codigo: "2134"
            ));

            // Tipo 2 — AcertijoTexto
            acertijosCocina.Add(new AcertijoTexto(
                pregunta: "¿Qué horas son? (usa ':' )",
                pista: "Deberías checar el reloj de la Cocina",
                intentos: 3,
                puntaje: 20,
                respuesta: "3:30"
            ));

            // Tipo 3 — AcertijoRandom
            acertijosCocina.Add(new AcertijoRandom(
                pregunta: "Adivina el número secreto entre 1 y 5:",
                pista: "Es un número impar.",
                intentos: 4,
                puntaje: 20,
                minimo: 1,
                maximo: 5
            ));

            // ── ACERTIJOS DEL SÓTANO ───────────────────────────────

            // Acertijo S1 — Texto
            acertijosSotano.Add(new AcertijoTexto(
                pregunta: "¿Qué animal no hace ningún ruido? (una palabra)",
                pista: "Piensa en un animal de granja silencioso...",
                intentos: 3,
                puntaje: 25,
                respuesta: "pez"
            ));

            // Acertijo S2 — Código numérico
            acertijosSotano.Add(new AcertijoCodigo(
                pregunta: "El año en que se fundó el edificio está grabado en la pared. Ingrésalo:",
                pista: "Busca en la pared del fondo del sótano",
                intentos: 3,
                puntaje: 25,
                codigo: "1987"
            ));

            // Acertijo S3 — Random
            acertijosSotano.Add(new AcertijoRandom(
                pregunta: "Adivina el número de la cerradura (entre 1 y 10):",
                pista: "Es un número par menor que 6.",
                intentos: 5,
                puntaje: 25,
                minimo: 1,
                maximo: 10
            ));

            MessageBox.Show(
                "¡Bienvenido al Escape Room Digital!\n" +
                "Resuelve los acertijos para ganar puntos y avanzar.",
                "Escape Room", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Carga el primer acertijo de cocina
            SiguienteAcertijo();
        }

        // ── Manejo de acertijos ────────────────────────────────────

        /// <summary>
        /// Saca el siguiente acertijo de la lista de COCINA.
        /// Cuando no quedan más, AcertijoActual queda en null.
        /// </summary>
        public void SiguienteAcertijo()
        {
            if (acertijosCocina.Count == 0)
            {
                AcertijoActual = null;
                return;
            }
            AcertijoActual = acertijosCocina[0];
            acertijosCocina.RemoveAt(0);
        }

        /// <summary>
        /// Saca el siguiente acertijo de la lista de SÓTANO.
        /// Devuelve true si quedaba uno, false si ya no hay más.
        /// </summary>
        public bool SiguienteAcertijoSotano()
        {
            if (acertijosSotano.Count == 0)
            {
                AcertijoActual = null;
                return false;
            }
            AcertijoActual = acertijosSotano[0];
            acertijosSotano.RemoveAt(0);
            return true;
        }

        /// <summary>
        /// Resuelve el acertijo actual (cocina O sótano, el que esté activo).
        /// Devuelve true si la respuesta fue correcta.
        /// </summary>
        public bool ResolverAcertijo(string respuesta)
        {
            if (AcertijoActual == null) return false;

            // ── FIX: guardamos referencia ANTES de avanzar ──────────
            Acertijo acertijoResuelto = AcertijoActual;
            bool correcto = acertijoResuelto.Resolver(respuesta);

            if (correcto)
            {
                Puntaje += acertijoResuelto.PuntajeBase;
                AgregarItemSegunAcertijo(acertijoResuelto); // pasamos el resuelto
            }

            return correcto;
        }

        /// <summary>
        /// Entrega un ítem al inventario según el tipo de acertijo resuelto.
        /// Recibe el acertijo ya resuelto para no depender de AcertijoActual.
        /// </summary>
        private void AgregarItemSegunAcertijo(Acertijo resuelto)
        {
            switch (resuelto)
            {
                case AcertijoCodigo:
                    // El primer AcertijoCodigo entrega la llave maestra
                    if (!LlaveRecogida)
                    {
                        inventario.Add(new Item(
                            "llave", "Llave maestra",
                            Properties.Resources.LlaveFinal));
                        LlaveRecogida = true;
                    }
                    break;

                case AcertijoTexto:
                    // Podrías agregar una nota o fragmento de pista aquí
                    break;

                case AcertijoRandom:
                    // Podrías agregar una gema u otro coleccionable aquí
                    break;
            }
        }

        // ── Sótano: registrar acierto y generar código ─────────────

        /// <summary>
        /// Llamar desde Sotano.cs cada vez que se resuelve un acertijo
        /// del sótano correctamente. Cuando se alcanzan 3 aciertos
        /// genera el código de la caja fuerte.
        /// </summary>
        public void RegistrarAciertoSotano()
        {
            AciertosSotano++;

            if (AciertosSotano >= 3 && CodigoCajaFuerte == "")
            {
                // Genera un código de 4 dígitos y lo guarda
                CodigoCajaFuerte = Random.Shared.Next(1000, 9999).ToString();
            }
        }

        /// <summary>
        /// Devuelve true si ya se generó el código de la caja fuerte.
        /// </summary>
        public bool CajaFuerteDesbloqueada => CodigoCajaFuerte != "";

        // ── Puntaje ────────────────────────────────────────────────

        public void UsarPista() => Puntaje = Math.Max(0, Puntaje - 5);
        public void PenalizarPorTiempo() => Puntaje = Math.Max(0, Puntaje - 1);

        // ── Estado general ─────────────────────────────────────────

        /// <summary>
        /// True cuando no quedan acertijos de cocina pendientes.
        /// </summary>
        public bool JuegoTerminado() => AcertijoActual == null;

        // ── Persistencia ───────────────────────────────────────────

        public void GuardarResultado(int tiempoSegundos)
        {
            try
            {
                string contenido =
                    $"=== RESULTADO ESCAPE ROOM ==={Environment.NewLine}" +
                    $"Fecha:   {DateTime.Now:dd/MM/yyyy HH:mm}{Environment.NewLine}" +
                    $"Puntaje: {Puntaje} pts{Environment.NewLine}" +
                    $"Tiempo:  {tiempoSegundos} segundos{Environment.NewLine}" +
                    $"Ítems:   {inventario.Count}{Environment.NewLine}" +
                    $"----------------------------{Environment.NewLine}";

                File.AppendAllText(rutaArchivo, contenido);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Sin permiso para guardar: {ex.Message}",
                    "Error de archivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (IOException ex)
            {
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