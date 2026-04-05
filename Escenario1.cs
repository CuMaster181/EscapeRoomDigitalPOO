using System.Runtime.CompilerServices;

namespace EscapeRoomDigitalPOO
{
    public partial class Escenario1 : Form
    {
        private GameManager gameManager;
        private System.Windows.Forms.Timer timer;
        private int segundosTranscurridos = 0;

        private int estadoPuerta = 0;
        Item itemSeleccionado = null!;
        PictureBox pbSeleccionado = null!;

        public Escenario1(GameManager gm)
        {
            InitializeComponent();
            gameManager = gm;
            ConfigurarTimer();
        }

        private void ConfigurarTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;   // cada 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            segundosTranscurridos++;

            // Penalizar 1 pt cada 10 segundos
            if (segundosTranscurridos % 10 == 0)
                gameManager.PenalizarPorTiempo();

            // Actualizar etiquetas en pantalla
            lblTiempo.Text = $"Tiempo: {segundosTranscurridos}s";
            lblPuntaje.Text = $"Puntaje: {gameManager.Puntaje}";
            lblIntentos.Text = $"Intentos: {gameManager.AcertijoActual?.IntentosRestantes ?? 0}";
        }

        private void MostrarAcertijo()
        {
            if (gameManager.JuegoTerminado())
            {
                TerminarJuego();
                return;
            }

            lblPregunta.Text = gameManager.AcertijoActual.Pregunta;
            lblIntentos.Text = $"Intentos: {gameManager.AcertijoActual.IntentosRestantes}";
            txtRespuesta.Clear();
            txtRespuesta.Focus();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            // try-catch en el parseo del input del usuario
            try
            {
                string respuesta = txtRespuesta.Text;

                if (string.IsNullOrWhiteSpace(respuesta))
                    throw new ArgumentException("Escribe una respuesta antes de validar.");

                bool correcto = gameManager.ResolverAcertijo(respuesta);

                if (correcto)
                {
                    MessageBox.Show("¡Correcto! Avanzas al siguiente acertijo.",
                        "Bien hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarAcertijo();
                }
                else if (gameManager.AcertijoActual != null &&
                         gameManager.AcertijoActual.Agotado)
                {
                    MessageBox.Show("Sin intentos. Pasas al siguiente acertijo sin puntos.",
                        "Fallaste", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gameManager.SiguienteAcertijo();
                    MostrarAcertijo();
                }
                else
                {
                    int restantes = gameManager.AcertijoActual?.IntentosRestantes ?? 0;
                    lblIntentos.Text = $"Intentos: {restantes}";
                    MessageBox.Show("Respuesta incorrecta. Intenta de nuevo.",
                        "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex)
            {
                // Input vacío u otro error de argumento
                MessageBox.Show(ex.Message, "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SalaPrincipal_Load(object sender, EventArgs e)
        {
            MostrarInventario();
            MostrarAcertijo();

            pbEstanteria.Image = Properties.Resources.EstanteriaCerrada;
            pbEstanteria.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEscenario.SizeMode = PictureBoxSizeMode.Zoom;
            pbEscenario.Image = Properties.Resources.Cocina;

            if (gameManager.EstadoEstanteria == 0)
                pbEstanteria.Image = Properties.Resources.EstanteriaCerrada;
            else if (gameManager.EstadoEstanteria == 1)
                pbEstanteria.Image = Properties.Resources.EstanteriaPalanca;
            else if (gameManager.EstadoEstanteria == 2)
                pbEstanteria.Image = Properties.Resources.EstanteriaAbierta;
        }
        /*private void MostrarAcertijo()
        {
            if (gameManager.JuegoTerminado())
            {
                GuardarPuntaje();
                MessageBox.Show("¡Ganaste! Puntaje: " + gameManager.Puntaje);
                return;
            }

            lblPregunta.Text = gameManager.AcertijoActual.Pregunta;
        }
        */

        private void btnPista_Click(object sender, EventArgs e)
        {
            if (gameManager.AcertijoActual == null) return;

            gameManager.UsarPista();   // resta 5 pts

            MessageBox.Show(
                $"Pista (-5 pts): {gameManager.AcertijoActual.Pista}",
                "Pista",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            lblPuntaje.Text = $"Puntaje: {gameManager.Puntaje}";
        }

        // ── fin del juego ─────────────────────────────────────────
        private void TerminarJuego()
        {
            timer.Stop();

            // Guardar en archivo (con try-catch interno en el método)
            gameManager.GuardarResultado(segundosTranscurridos);

            MessageBox.Show(
                $"¡Escapaste!\n\nPuntaje final: {gameManager.Puntaje} pts\n" +
                $"Tiempo: {segundosTranscurridos} segundos\n" +
                $"Ítems recogidos: {gameManager.Inventario.Count}\n\n" +
                "Tu resultado fue guardado en resultados.txt",
                "¡Victoria!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }
        private void MostrarInventario()
        {
            flpInventario.Controls.Clear();

            foreach (var item in gameManager.Inventario)
            {
                PictureBox pb = new PictureBox();
                pb.Width = 50;
                pb.Height = 50;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Image = item.Imagen;
                pb.Tag = item;

                pb.Click += (s, e) =>
                {
                    MessageBox.Show("Seleccionaste: " + item.Nombre);
                };


                flpInventario.Controls.Add(pb);
            }
        }
        /*private void GuardarPuntaje()
        {
            try
            {
                File.WriteAllText("puntaje.txt", gameManager.Puntaje.ToString());
            }
            catch
            {
                MessageBox.Show("Error al guardar");
            }
        }
        */
        private void AgregarLog(string mensaje)
        {
            txtLog.AppendText(mensaje + Environment.NewLine);
        }
        private void AgregarItem(Item item)
        {
            gameManager.Inventario.Add(item);

            PictureBox pb = new PictureBox();
            pb.Width = 50;
            pb.Height = 50;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Image = item.Imagen;
            pb.Tag = item;

            pb.Click += SeleccionarItem!;

            flpInventario.Controls.Add(pb);

            AgregarLog("Recogiste: " + item.Nombre);
        }
        private void SeleccionarItem(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;

            itemSeleccionado = pb.Tag as Item;
            pbSeleccionado = pb;

            AgregarLog("Seleccionaste: " + itemSeleccionado!.Nombre);
        }
        private void ConsumirItem()
        {
            gameManager.Inventario.Remove(itemSeleccionado);

            flpInventario.Controls.Remove(pbSeleccionado);

            itemSeleccionado = null!;
            pbSeleccionado = null!;
        }
        private bool CodigoCorrecto(string codigo)
        {
            return codigo == "2007";
        }

        private void pbEstanteria_Click(object sender, EventArgs e)
        {
            if (gameManager.EstadoEstanteria == 0)
            {
                string codigo = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingresa el código:",
                    "Estantería",
                    ""
                );

                if (CodigoCorrecto(codigo))
                {
                    gameManager.EstadoEstanteria = 1;
                    pbEstanteria.Image = Properties.Resources.EstanteriaPalanca;

                    AgregarLog("La estantería se abrió ");
                }
                else
                {
                    AgregarLog("Código incorrecto ");
                }
            }

            else if (gameManager.EstadoEstanteria == 1)
            {
                gameManager.EstadoEstanteria = 2;

                pbEstanteria.Image = Properties.Resources.EstanteriaAbierta;

                Item palanca = new Item(
                    "palanca",
                    "Palanca",
                    Properties.Resources.Palanca
                );

                AgregarItem(palanca);

                AgregarLog("Encontraste una Palanca ");
            }

            else if (gameManager.EstadoEstanteria == 2)
            {
                AgregarLog("La estantería está vacía");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Sala sala = new Sala(gameManager);
            sala.Show();
            this.Hide();
        }
    }
}
