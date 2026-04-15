namespace EscapeRoomDigitalPOO
{
    partial class Oficina
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // ── Declarar controles ─────────────────────────────────
            pbEscenario = new PictureBox();
            pbCuadro = new PictureBox();
            pbEstanteria = new PictureBox();
            pbEscritorio = new PictureBox();
            flpInventario = new FlowLayoutPanel();
            lblPuntaje = new Label();
            lblIntentos = new Label();
            lblTiempo = new Label();
            lblPregunta = new Label();
            txtRespuesta = new TextBox();
            btnValidar = new Button();
            btnPista = new Button();
            txtLog = new TextBox();
            btnSala = new Button();
            btnCocina = new Button();

            ((System.ComponentModel.ISupportInitialize)pbEscenario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCuadro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEstanteria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEscritorio).BeginInit();
            SuspendLayout();

            // ── pbEscenario (fondo de la oficina) ──────────────────
            pbEscenario.Image = Properties.Resources.FondoOficina;
            pbEscenario.Location = new Point(58, 45);
            pbEscenario.Name = "pbEscenario";
            pbEscenario.Size = new Size(515, 427);
            pbEscenario.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEscenario.TabIndex = 0;
            pbEscenario.TabStop = false;

            // ── pbCuadro (hijo de pbEscenario) ─────────────────────
            // Cuadro con símbolos en la pared
            pbCuadro.BackColor = Color.Transparent;
            pbCuadro.Image = Properties.Resources.Cuadro;
            pbCuadro.Location = new Point(60, 60);   // relativo a pbEscenario
            pbCuadro.Name = "pbCuadro";
            pbCuadro.Size = new Size(120, 120);
            pbCuadro.SizeMode = PictureBoxSizeMode.Zoom;
            pbCuadro.TabIndex = 1;
            pbCuadro.TabStop = false;
            pbCuadro.Cursor = Cursors.Hand;
            pbCuadro.Click += pbCuadro_Click;

            // ── pbEstanteria (hijo de pbEscenario) ─────────────────
            // Estantería con libros que esconde el papel clave
            pbEstanteria.BackColor = Color.Transparent;
            pbEstanteria.Image = Properties.Resources.EstanteriaOficina;
            pbEstanteria.Location = new Point(220, 30);   // relativo a pbEscenario
            pbEstanteria.Name = "pbEstanteria";
            pbEstanteria.Size = new Size(230, 160);
            pbEstanteria.SizeMode = PictureBoxSizeMode.Zoom;
            pbEstanteria.TabIndex = 2;
            pbEstanteria.TabStop = false;
            pbEstanteria.Cursor = Cursors.Hand;
            pbEstanteria.Click += pbEstanteria_Click;

            // ── pbEscritorio (hijo de pbEscenario) ─────────────────
            // Escritorio: cerrado → con lupa → vacío
            pbEscritorio.BackColor = Color.Transparent;
            pbEscritorio.Image = Properties.Resources.Escritorio;
            pbEscritorio.Location = new Point(240, 270);   // relativo a pbEscenario
            pbEscritorio.Name = "pbEscritorio";
            pbEscritorio.Size = new Size(220, 140);
            pbEscritorio.SizeMode = PictureBoxSizeMode.Zoom;
            pbEscritorio.TabIndex = 3;
            pbEscritorio.TabStop = false;
            pbEscritorio.Cursor = Cursors.Hand;
            pbEscritorio.Click += pbEscritorio_Click;

            // ── HUD ────────────────────────────────────────────────
            lblPuntaje.AutoSize = true;
            lblPuntaje.BackColor = Color.Transparent;
            lblPuntaje.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblPuntaje.ForeColor = SystemColors.Control;
            lblPuntaje.Location = new Point(12, 12);
            lblPuntaje.Text = "Puntaje: 0";

            lblIntentos.AutoSize = true;
            lblIntentos.BackColor = Color.Transparent;
            lblIntentos.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblIntentos.ForeColor = SystemColors.Control;
            lblIntentos.Location = new Point(140, 12);
            lblIntentos.Text = "Intentos: 3";

            lblTiempo.AutoSize = true;
            lblTiempo.BackColor = Color.Transparent;
            lblTiempo.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblTiempo.ForeColor = SystemColors.Control;
            lblTiempo.Location = new Point(270, 12);
            lblTiempo.Text = "Tiempo: 0s";

            // ── Panel derecho ──────────────────────────────────────

            // Inventario
            flpInventario.BackColor = Color.Transparent;
            flpInventario.Location = new Point(620, 45);
            flpInventario.Name = "flpInventario";
            flpInventario.Size = new Size(300, 180);

            // Pregunta
            lblPregunta.AutoSize = true;
            lblPregunta.BackColor = Color.Transparent;
            lblPregunta.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblPregunta.ForeColor = SystemColors.ButtonHighlight;
            lblPregunta.Location = new Point(620, 240);
            lblPregunta.MaximumSize = new Size(300, 0);
            lblPregunta.Text = "...";

            // Respuesta
            txtRespuesta.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            txtRespuesta.Location = new Point(620, 300);
            txtRespuesta.Size = new Size(300, 27);

            // Validar
            btnValidar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnValidar.Location = new Point(620, 340);
            btnValidar.Size = new Size(140, 37);
            btnValidar.Text = "Validar";
            btnValidar.Click += btnValidar_Click;

            // Pista
            btnPista.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnPista.Location = new Point(775, 340);
            btnPista.Size = new Size(140, 37);
            btnPista.Text = "Pista";
            btnPista.Click += btnPista_Click;

            // Log
            txtLog.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            txtLog.Location = new Point(620, 390);
            txtLog.Multiline = true;
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(300, 110);

            // Botones de navegación
            btnSala.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnSala.Location = new Point(620, 513);
            btnSala.Size = new Size(140, 32);
            btnSala.Text = "Ir a Sala";
            btnSala.Click += btnSala_Click;

            btnCocina.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnCocina.Location = new Point(775, 513);
            btnCocina.Size = new Size(140, 32);
            btnCocina.Text = "Ir a Cocina";
            btnCocina.Click += btnCocina_Click;

            // ── Form ───────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(939, 633);
            StartPosition = FormStartPosition.CenterScreen;
            Name = "Oficina";
            Text = "Oficina — Escape Room";
            Load += Oficina_Load;

            // Controles directos del Form
            Controls.Add(lblPuntaje);
            Controls.Add(lblIntentos);
            Controls.Add(lblTiempo);
            Controls.Add(flpInventario);
            Controls.Add(lblPregunta);
            Controls.Add(txtRespuesta);
            Controls.Add(btnValidar);
            Controls.Add(btnPista);
            Controls.Add(txtLog);
            Controls.Add(btnSala);
            Controls.Add(btnCocina);
            Controls.Add(pbEscenario);   // pbEscenario al Form

            // pbCuadro, pbEstanteria y pbEscritorio como hijos de pbEscenario
            // NOTA: también se reasignan en Oficina_Load para que
            // el diseñador visual no los pierda si mueves controles
            pbEscenario.Controls.Add(pbCuadro);
            pbEscenario.Controls.Add(pbEstanteria);
            pbEscenario.Controls.Add(pbEscritorio);

            ((System.ComponentModel.ISupportInitialize)pbEscenario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCuadro).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEstanteria).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEscritorio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbEscenario;
        private PictureBox pbCuadro;
        private PictureBox pbEstanteria;
        private PictureBox pbEscritorio;
        private FlowLayoutPanel flpInventario;
        private Label lblPuntaje;
        private Label lblIntentos;
        private Label lblTiempo;
        private Label lblPregunta;
        private TextBox txtRespuesta;
        private Button btnValidar;
        private Button btnPista;
        private TextBox txtLog;
        private Button btnSala;
        private Button btnCocina;
    }
}