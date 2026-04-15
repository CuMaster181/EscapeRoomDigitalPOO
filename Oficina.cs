namespace EscapeRoomDigitalPOO
{
    public partial class Oficina : Form
    {
        private GameManager gameManager;
        private System.Windows.Forms.Timer timer;
        private int segundosTranscurridos = 0;
        Item itemSeleccionado = null!;
        PictureBox pbSeleccionado = null!;

        public Oficina(GameManager gm)
        {
            InitializeComponent();
            gameManager = gm;
            ConfigurarTimer();
            MostrarInventario();
            MostrarAcertijo();
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

            lblTiempo.Text = $"Tiempo: {segundosTranscurridos}s";
            lblPuntaje.Text = $"Puntaje: {gameManager.Puntaje}";
            lblIntentos.Text = $"Intentos: {gameManager.AcertijoActual?.IntentosRestantes ?? 0}";
        }

        // ── Load ───────────────────────────────────────────────────
        private void Oficina_Load(object sender, EventArgs e)
        {
            // Restaurar estados visuales al volver al formulario
            pbEscritorio.Image = gameManager.EstadoEscritorio switch
            {
                0 => Properties.Resources.Escritorio,
                1 => Properties.Resources.EscritorioLupa,
                _ => Properties.Resources.EscritorioVacio
            };

            // Hacer hijos de pbEscenario para fondo transparente
            pbEscenario.Controls.Add(pbCuadro);
            pbEscenario.Controls.Add(pbEstanteria);
            pbEscenario.Controls.Add(pbEscritorio);

            pbCuadro.Location = new Point(60, 60);
            pbEstanteria.Location = new Point(220, 30);
            pbEscritorio.Location = new Point(280, 290);
        }

        // ── Acertijo ───────────────────────────────────────────────
        private void MostrarAcertijo()
        {
            if (gameManager.AcertijoActual == null)
                return;

            lblPregunta.Text = gameManager.AcertijoActual.Pregunta;
            lblIntentos.Text = $"Intentos: {gameManager.AcertijoActual.IntentosRestantes}";
            txtRespuesta.Clear();
            txtRespuesta.Focus();
        }

        // ── Botón Pista ────────────────────────────────────────────
        private void btnPista_Click(object sender, EventArgs e)
        {
            if (gameManager.AcertijoActual == null) return;

            gameManager.UsarPista();

            MessageBox.Show(
                $"Pista (-5 pts): {gameManager.AcertijoActual.Pista}",
                "Pista", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblPuntaje.Text = $"Puntaje: {gameManager.Puntaje}";
        }

        // ── Zoom ───────────────────────────────────────────────────
        private void MostrarZoom(Image imagen, string titulo = "Detalle")
        {
            using Form frmZoom = new Form()
            {
                Text = titulo,
                Size = new Size(500, 420),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            PictureBox pb = new PictureBox()
            {
                Image = imagen,
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Fill
            };

            frmZoom.Controls.Add(pb);
            frmZoom.ShowDialog(this);
        }

        // ── Cuadro ─────────────────────────────────────────────────
        // Estado 0: muestra el cuadro con símbolos pequeños
        // Al clickear: abre zoom con SimbolosCuadro para que el jugador
        // pueda leer los 4 símbolos y buscar su valor en el papel
        private void pbCuadro_Click(object sender, EventArgs e)
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
            // Muestra SimbolosCuadro en grande:
            // triángulo=1, X=2, estrella=7, luna=8 → código 1278
            MostrarZoom(Properties.Resources.SimbolosCuadro, "Cuadro — Símbolos");
            AgregarLog("Usaste la lupa para ver el cuadro.");
        }

        // ── Estantería ─────────────────────────────────────────────
        // Estado 0: estantería con libros
        // Click → recoge el papel con la clave de símbolos (CodigoCuadro)
        private void pbEstanteria_Click(object sender, EventArgs e)
        {
            if (gameManager.EstadoEstanteriaOficina == 0)
            {
                gameManager.EstadoEstanteriaOficina = 1;

                // El papel tiene zoom: al clickearlo en el inventario
                // muestra CodigoCuadro con la tabla símbolo → número
                Item papel = new Item(
                    "papel_clave",
                    "Clave de símbolos",
                    Properties.Resources.CodigoCuadro,   // icono en inventario
                    Properties.Resources.CodigoCuadro    // zoom al clickear
                );

                AgregarItem(papel);
                AgregarLog("Encontraste la clave de símbolos.");
            }
            else
            {
                AgregarLog("La estantería ya no tiene nada.");
            }
        }

        // ── Escritorio ─────────────────────────────────────────────
        // Estado 0: cerrado
        // Estado 1: abierto con lupa visible → recoge lupa
        // Estado 2: vacío
        private void pbEscritorio_Click(object sender, EventArgs e)
        {
            if (gameManager.EstadoEscritorio == 0)
            {
                gameManager.EstadoEscritorio = 1;
                pbEscritorio.Image = Properties.Resources.EscritorioLupa;
                AgregarLog("Abriste el escritorio.");
            }
            else if (gameManager.EstadoEscritorio == 1)
            {
                gameManager.EstadoEscritorio = 2;
                pbEscritorio.Image = Properties.Resources.EscritorioVacio;

                // La lupa tiene zoom para verse en detalle en el inventario
                Item lupa = new Item(
                    "lupa",
                    "Lupa",
                    Properties.Resources.lupa,   // icono en inventario
                    Properties.Resources.lupa    // zoom al clickear
                );

                AgregarItem(lupa);
                AgregarLog("Recogiste la lupa.");
            }
            else
            {
                AgregarLog("El escritorio está vacío.");
            }
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
                    Tag = item,
                    Cursor = Cursors.Hand
                };

                pb.Click += (s, e) =>
                {
                    itemSeleccionado = (Item)pb.Tag;
                    pbSeleccionado = pb;
                    AgregarLog("Seleccionaste: " + item.Nombre);

                    // Si el ítem tiene zoom definido, mostrarlo
                    if (item.ImagenZoom != null)
                        MostrarZoom(item.ImagenZoom, item.Nombre);
                };

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

            PictureBox pb = new PictureBox
            {
                Width = 50,
                Height = 50,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = item.Imagen,
                Tag = item,
                Cursor = Cursors.Hand
            };

            pb.Click += (s, e) =>
            {
                itemSeleccionado = (Item)pb.Tag;
                pbSeleccionado = pb;
                AgregarLog("Seleccionaste: " + item.Nombre);

                if (item.ImagenZoom != null)
                    MostrarZoom(item.ImagenZoom, item.Nombre);
            };

            flpInventario.Controls.Add(pb);
            AgregarLog("Recogiste: " + item.Nombre);
        }

        // ── Navegación ─────────────────────────────────────────────
        private void btnSala_Click(object sender, EventArgs e)
        {
            Sala sala = new Sala(gameManager);
            sala.Show();
            this.Hide();
        }

        private void btnCocina_Click(object sender, EventArgs e)
        {
            Cocina cocina = new Cocina(gameManager);
            cocina.Show();
            this.Hide();
        }
    }
}