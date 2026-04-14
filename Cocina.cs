using System.Runtime.CompilerServices;

namespace EscapeRoomDigitalPOO
{
    public partial class Cocina : Form
    {
        private GameManager gameManager;
        private System.Windows.Forms.Timer timer;
        private int segundosTranscurridos = 0;
        private int estadoPuerta = 0;
        Item itemSeleccionado = null!;
        PictureBox pbSeleccionado = null!;

        public Cocina(GameManager gm)
        {
            InitializeComponent();
            gameManager = gm;
            ConfigurarTimer();
            MostrarInventario();
        }

        private void ConfigurarTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;   // cada 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
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

        private void Cocina_Load(object sender, EventArgs e)
        {
            pbAlfombra.Tag = "palanca";

            if (gameManager.EstadoEstanteria == 0)
                pbEstanteria.Image = Properties.Resources.EstanteriaCerrada;
            else if (gameManager.EstadoEstanteria == 1)
                pbEstanteria.Image = Properties.Resources.EstanteriaPalanca;
            else if (gameManager.EstadoEstanteria == 2)
                pbEstanteria.Image = Properties.Resources.EstanteriaAbierta;

            if (gameManager.EstadoAlfombra == 0)
                pbAlfombra.Image = Properties.Resources.Alfombra;
            else if (gameManager.EstadoAlfombra == 1)
                pbAlfombra.Image = Properties.Resources.Recogida;
            else if (gameManager.EstadoAlfombra == 2)
                pbAlfombra.Image = Properties.Resources.PuertaSotano;

            if (gameManager.EstadoCajon == 0)
                pbCajon.Image = Properties.Resources.CajonCerrado;
            else if (gameManager.EstadoCajon == 1)
                pbCajon.Image = Properties.Resources.CajonUSB;
            else if (gameManager.EstadoCajon == 2)
                pbCajon.Image = Properties.Resources.CajonVacio;
        }
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

                flpInventario.Controls.Add(pb);
            }
        }
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
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Image = item.Imagen;
            pb.Tag = item;

            pb.Click += SeleccionarItem!;

            flpInventario.Controls.Add(pb);

            AgregarLog("Recogiste: " + item.Nombre);
        }
        private void SeleccionarItem(object sender, EventArgs e)
        {
            PictureBox? pb = sender as PictureBox;

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
        private void pbCajon_Click(object sender, EventArgs e)
        {
            if (gameManager.EstadoCajon == 0)
            {
                gameManager.EstadoCajon = 1;
                pbCajon.Image = Properties.Resources.CajonUSB;
                
            }
            else if (gameManager.EstadoCajon == 1)
            {
                gameManager.EstadoCajon = 2;
                Item usb = new Item(
                    "USB",
                    "Usb",
                    Properties.Resources.Usb
                );
                AgregarItem(usb);
                AgregarLog("Encontraste una USB ");
                pbCajon.Image = Properties.Resources.CajonVacio;
            }
            else
            {
                AgregarLog("El cajón está vacío");
            }   
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Sala sala = new Sala(gameManager);
            sala.Show();
            this.Hide();
        }

        private void pbAlfombra_Click(object sender, EventArgs e)
        {
            if (gameManager.EstadoAlfombra == 0)
            {
                gameManager.EstadoAlfombra = 1;
                pbAlfombra.Image = Properties.Resources.Recogida;

                AgregarLog("Levantaste la alfombra");
            }
            else if (gameManager.EstadoAlfombra == 1)
            {
                if (itemSeleccionado == null)
                {
                    AgregarLog("Selecciona un objeto primero");
                    return;
                }

                PictureBox? pb = sender as PictureBox;
                string? PalancaNecesaria = pb.Tag as string;

                if (itemSeleccionado.Id == PalancaNecesaria)
                {
                    gameManager.EstadoAlfombra = 2;
                    pb.Image = Properties.Resources.PuertaSotano;

                    ConsumirItem();
                }
                else
                {
                    AgregarLog("Ese objeto no sirve aquí");
                }
            }
            else
            {
                Sotano sotano = new Sotano(gameManager);
                sotano.Show();
                this.Hide();
            }
        }
    }
}
