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
            ActualizarHUD();

            pbPuerta.Tag = "llave_Final";

            pbPuerta.Image = Properties.Resources.Puerta;
            pbLlave.Image = Properties.Resources.LlaveFinal;
            pbLibro.Image = Properties.Resources.LibroClick;

            pbPuerta.SizeMode = PictureBoxSizeMode.Zoom;
            pbLlave.SizeMode = PictureBoxSizeMode.Zoom;
            pbLibro.SizeMode = PictureBoxSizeMode.Zoom;

            pbPuerta.Parent = pbSala;
            pbLlave.Parent = pbSala;
            pbLibro.Parent = pbSala;

            pbPuerta.BackColor = Color.Transparent;
            pbLlave.BackColor = Color.Transparent;
            pbLibro.BackColor = Color.Transparent;

            pbSala.Image = Properties.Resources.Sala;

            if (gameManager.LlaveRecogida)
                pbLlave.Visible = false;
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
            pbSala.Image = Properties.Resources.Sala;
            pbSala.SizeMode = PictureBoxSizeMode.StretchImage;

            pbPuerta.Parent = pbSala;
            pbPuerta.Image = Properties.Resources.Puerta;
            pbPuerta.SizeMode = PictureBoxSizeMode.Zoom;
            pbPuerta.BackColor = Color.Transparent;
            pbPuerta.Location = new Point(391, 75);

            pbLlave.Parent = pbSala;
            pbLlave.Image = Properties.Resources.LlaveFinal;
            pbLlave.SizeMode = PictureBoxSizeMode.Zoom;
            pbLlave.BackColor = Color.Transparent;
            pbLlave.Visible = !gameManager.LlaveRecogida;

            MostrarInventario();
            AgregarLog("¡Bienvenido a la sala final!");
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

                PictureBox pb = (PictureBox)sender;
                string llaveNecesaria = pb.Tag as string ?? "";

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
        private void pbLlave_Click(object sender, EventArgs e)
        {
            gameManager.LlaveRecogida = true;

            gameManager.Inventario.Add(new Item(
                "llave_Final",
                "Llave Final",
                Properties.Resources.LlaveFinal));

            pbLlave.Visible = false;
            MostrarInventario();
            AgregarLog("Recogiste la Llave Final");
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
