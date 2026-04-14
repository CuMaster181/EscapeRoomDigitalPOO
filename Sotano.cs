using System;
using System.Windows.Forms;

namespace EscapeRoomDigitalPOO
{
    public partial class Sotano : Form
    {
        private GameManager gameManager;
        private System.Windows.Forms.Timer timer;
        private int segundosTranscurridos = 0;

        public Sotano(GameManager gm)
        {
            InitializeComponent();
            gameManager = gm;

            ConfigurarTimer();
            CargarPrimerAcertijo();
            MostrarInventario();
            ActualizarHUD();

        }
        private void AgregarLog(string mensaje)
        {
            txtLog.AppendText(mensaje + Environment.NewLine);
        }

        // ── Timer ──────────────────────────────────────────────────
        private void ConfigurarTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            segundosTranscurridos++;

            if (segundosTranscurridos % 10 == 0)
                gameManager.PenalizarPorTiempo();

            ActualizarHUD();
        }

        private void ActualizarHUD()
        {
            lblTiempo.Text = $"Tiempo: {segundosTranscurridos}s";
            lblPuntaje.Text = $"Puntaje: {gameManager.Puntaje}";
            lblIntentos.Text = $"Intentos: {gameManager.AcertijoActual?.IntentosRestantes ?? 0}";
        }

        // ── Acertijos ──────────────────────────────────────────────

        /// <summary>
        /// Carga el primer acertijo del sótano desde GameManager.
        /// </summary>
        private void CargarPrimerAcertijo()
        {
            // SiguienteAcertijoSotano pone el primero en AcertijoActual
            gameManager.SiguienteAcertijoSotano();
            MostrarAcertijo();
        }

        private void MostrarAcertijo()
        {
            if (gameManager.AcertijoActual == null)
            {
                // No quedan acertijos — revisar si ya se puede abrir la caja
                VerificarCajaFuerte();
                return;
            }

            lblPregunta.Text = gameManager.AcertijoActual.Pregunta;
            ActualizarHUD();
            txtRespuesta.Clear();
            txtRespuesta.Focus();
        }

        // ── Botón Validar ──────────────────────────────────────────
        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = txtRespuesta.Text;

                if (string.IsNullOrWhiteSpace(respuesta))
                    throw new ArgumentException("Escribe una respuesta antes de validar.");

                bool correcto = gameManager.ResolverAcertijo(respuesta);

                if (correcto)
                {
                    // Registrar acierto en el contador del sótano
                    gameManager.RegistrarAciertoSotano();

                    MessageBox.Show("¡Correcto! Avanzas al siguiente acertijo.",
                        "Bien hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Avanzar al siguiente acertijo del SÓTANO
                    gameManager.SiguienteAcertijoSotano();
                    MostrarAcertijo();
                }
                else if (gameManager.AcertijoActual != null &&
                         gameManager.AcertijoActual.Agotado)
                {
                    MessageBox.Show("Sin intentos. Pasas al siguiente acertijo sin puntos.",
                        "Fallaste", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    gameManager.SiguienteAcertijoSotano();
                    MostrarAcertijo();
                }
                else
                {
                    ActualizarHUD();
                    MessageBox.Show("Respuesta incorrecta. Intenta de nuevo.",
                        "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ── Botón Pista ────────────────────────────────────────────
        private void btnPista_Click(object sender, EventArgs e)
        {
            if (gameManager.AcertijoActual == null) return;

            gameManager.UsarPista();

            MessageBox.Show(
                $"Pista (-5 pts): {gameManager.AcertijoActual.Pista}",
                "Pista", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ActualizarHUD();
        }

        // ── Caja fuerte ────────────────────────────────────────────

        /// <summary>
        /// Se llama cuando ya no quedan acertijos del sótano.
        /// Si se alcanzaron 3 aciertos, muestra el código de la caja.
        /// </summary>
        private void VerificarCajaFuerte()
        {
            lblPregunta.Text = "Has terminado los acertijos del sótano.";
            txtRespuesta.Enabled = false;
            btnValidar.Enabled = false;
            btnPista.Enabled = false;

            if (gameManager.CajaFuerteDesbloqueada)
            {
                // Muestra el código que ya fue generado
                MessageBox.Show(
                    $"¡Lograste abrir la caja fuerte!\n\n" +
                    $"El código es: {gameManager.CodigoCajaFuerte}\n\n" +
                    "Recuérdalo y úsalo en la puerta principal.",
                    "Caja Fuerte",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);

                // Agregar llave al inventario si no se tiene ya
                if (!gameManager.LlaveRecogida)
                {
                    gameManager.Inventario.Add(new Item(
                        "llave_Final",
                        "Llave de la caja fuerte",
                        Properties.Resources.LlaveFinal));
                    gameManager.LlaveRecogida = true;
                    MostrarInventario();
                }
            }
            else
            {
                MessageBox.Show(
                    $"No resolviste suficientes acertijos.\n" +
                    $"Aciertos: {gameManager.AciertosSotano} / 3\n\n" +
                    "Necesitas al menos 3 para abrir la caja fuerte.",
                    "Caja Fuerte bloqueada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }


        // ── Navegación ─────────────────────────────────────────────
        private void btnCocina_Click(object sender, EventArgs e)
        {
            Cocina sala = new Cocina(gameManager);
            sala.Show();
            this.Hide();
        }

        // ── Inventario ─────────────────────────────────────────────
        private void MostrarInventario()
        {
            flpInventario.Controls.Clear();

            foreach (var item in gameManager.Inventario)
            {
                PictureBox pb = new PictureBox
                {
                    Width = 50,
                    Height = 50,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = item.Imagen,
                    Tag = item
                };

                flpInventario.Controls.Add(pb);
            }
        }
        private void pbCajaFuerte_Click(object sender, EventArgs e)
        {
            if (gameManager.EstadoCajaFuerte == 0)
            {
                // Verificar si ya tiene el código disponible
                if (!gameManager.CajaFuerteDesbloqueada)
                {
                    MessageBox.Show(
                        "La caja fuerte está cerrada.\n" +
                        "Resuelve los acertijos para obtener el código.",
                        "Caja Fuerte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ya tiene el código — pedir que lo ingrese
                string intento = Microsoft.VisualBasic.Interaction.InputBox(
                    $"Ingresa el código de la caja fuerte\n" +
                    $"(Lo obtuviste al resolver los acertijos):",
                    "Caja Fuerte", "");

                if (string.IsNullOrWhiteSpace(intento))
                    return;

                if (intento.Trim() == gameManager.CodigoCajaFuerte)
                {
                    // Código correcto — abrir caja
                    gameManager.EstadoCajaFuerte = 1;
                    pbCajaFuerte.Image = Properties.Resources.CajaFuerteLLave;
                    AgregarLog("¡Abriste la caja fuerte!");
                }
                else
                {
                    // Código incorrecto — volver a pedir
                    MessageBox.Show(
                        "Código incorrecto. Inténtalo de nuevo.",
                        "Caja Fuerte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (gameManager.EstadoCajaFuerte == 1)
            {
                // Segunda interacción — recoger la llave
                gameManager.EstadoCajaFuerte = 2;
                pbCajaFuerte.Image = Properties.Resources.CajaFuerteVacia;

                gameManager.LlaveRecogida = true;
                gameManager.Inventario.Add(new Item(
                    "llave_Final",
                    "Llave Final",
                    Properties.Resources.LlaveFinal));

                MostrarInventario();
                AgregarLog("Recogiste la Llave Final de la caja fuerte.");
            }
            else
            {
                // Estado 2 — ya vacía
                AgregarLog("La caja fuerte ya está vacía.");
            }
        }
    }
}