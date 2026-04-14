using System;
using System.Windows.Forms;

namespace EscapeRoomDigitalPOO
{
    public partial class Sala : Form
    {
        public GameManager gameManager;
        private int estadoPuerta = 0;

        // Timer propio de la Sala (el tiempo sigue corriendo)
        private System.Windows.Forms.Timer timer;
        private int segundosTranscurridos = 0;

        Item itemSeleccionado = null!;
        PictureBox pbSeleccionado = null!;

        public Sala(GameManager gm)
        {
            InitializeComponent();
            gameManager = gm;

            ConfigurarTimer();
            MostrarInventario();
            ActualizarHUD();;
            pbPuerta.Tag = "llave_Final";
            pbPc.Tag = "USB";

            if (gameManager.LlaveRecogida)
                pbPc.Visible = false;
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
            // En la Sala no hay acertijo activo, mostramos 0
            lblIntentos.Text = $"Intentos: {gameManager.AcertijoActual?.IntentosRestantes ?? 0}";
        }

        // ── Load ───────────────────────────────────────────────────
        private void Sala_Load(object sender, EventArgs e)
        {
            // Mover los hijos a pbSala aquí, no en el Designer
            pbSala.Controls.Add(pbPc);
            pbSala.Controls.Add(pbPuerta);
            pbSala.Controls.Add(pbLibro);

            // Ajustar locations ya que ahora son relativas a pbSala
            pbPc.Location = new Point(221, 223);
            pbPuerta.Location = new Point(419, 123);
            pbLibro.Location = new Point(140, 158);

            MostrarInventario();
        }

        // ── Log ────────────────────────────────────────────────────
        private void AgregarLog(string mensaje = "")
        {
            txtLog.AppendText(mensaje + Environment.NewLine);
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

                pb.Click += (s, e) =>
                {
                    itemSeleccionado = (Item)pb.Tag;
                    pbSeleccionado = (PictureBox)s!;
                    AgregarLog("Seleccionaste: " + itemSeleccionado.Nombre);
                };

                flpInventario.Controls.Add(pb);
            }
        }

        private void ConsumirItem()
        {
            if (itemSeleccionado != null)
            {
                gameManager.Inventario.Remove(itemSeleccionado);
                MostrarInventario();
                itemSeleccionado = null!;
                pbSeleccionado = null!;
                AgregarLog("Consumiste el objeto");
            }
        }

        // ── Puerta final ───────────────────────────────────────────
        private void PuertaFinal_Click(object sender, EventArgs e)
        {
            if (estadoPuerta == 0)
            {
                if (itemSeleccionado == null)
                {
                    AgregarLog("Selecciona un objeto primero");
                    return;
                }

                PictureBox? pb = sender as PictureBox;
                string? llaveNecesaria = pb.Tag as string;

                if (itemSeleccionado.Id == llaveNecesaria)
                {
                    estadoPuerta = 1;
                    pb.Image = Properties.Resources.PuertaAbierta;
                    AgregarLog("¡Abriste la puerta!");
                    ConsumirItem();
                }
                else
                {
                    AgregarLog("Ese objeto no sirve aquí");
                }
            }
            else
            {
                // Puerta ya abierta — fin del juego
                timer.Stop();
                gameManager.GuardarResultado(segundosTranscurridos);

                MessageBox.Show(
                    $"¡Has escapado!\n\n" +
                    $"Puntaje final: {gameManager.Puntaje} pts\n" +
                    $"Tiempo: {segundosTranscurridos}s\n\n" +
                    "Resultado guardado en Resultados.txt",
                    "¡Victoria!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);

                Application.Exit();
            }
        }

        // ── Llave en suelo ─────────────────────────────────────────
        private void pbPc_Click(object sender, EventArgs e)
        {
            if (gameManager.EstadoPC == 0)
            {
                if (itemSeleccionado == null)
                {
                    AgregarLog("itemSeleccionado un item primero");
                    return;
                }
                PictureBox? pb = sender as PictureBox;
                string? USB = pb.Tag as string;

                if (itemSeleccionado.Id == USB)
                {
                    gameManager.EstadoPC = 1;
                    pb.Image = Properties.Resources.PcOn;
                    ConsumirItem();
                }
                else
                {
                    AgregarLog("Ese objeto no sirve aquí");
                }
            }
            else
            {
                MessageBox.Show("La Pc ya esta encendida");
            }
        }

                // ── Navegación ─────────────────────────────────────────────
        private void btnCocina(object sender, EventArgs e)
        {
             Cocina cocina = new Cocina(gameManager);
             cocina.Show();
             this.Hide();
        }

        private void btnSotano_Click(object sender, EventArgs e)
        {
            Sotano sotano = new Sotano(gameManager);
            sotano.Show();
            this.Hide();
        }

        // ── Libro ──────────────────────────────────────────────────
        private void pbLibro_Click(object sender, EventArgs e)
        {
            libro libro = new libro();
            libro.ShowDialog(this);   // modal para que no pierdan el foco
        }
    }
}
