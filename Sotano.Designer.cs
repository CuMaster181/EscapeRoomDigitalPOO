namespace EscapeRoomDigitalPOO
{
    partial class Sotano
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
            lblPuntaje = new Label();
            lblIntentos = new Label();
            lblTiempo = new Label();
            lblPregunta = new Label();
            txtRespuesta = new TextBox();
            btnValidar = new Button();
            btnPista = new Button();
            btnCajaFuerte = new Button();
            btnSala = new Button();
            flpInventario = new FlowLayoutPanel();
            pbSotano = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbSotano).BeginInit();
            SuspendLayout();
            // 
            // lblPuntaje
            // 
            lblPuntaje.AutoSize = true;
            lblPuntaje.BackColor = Color.Transparent;
            lblPuntaje.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblPuntaje.ForeColor = Color.White;
            lblPuntaje.Location = new Point(12, 12);
            lblPuntaje.Name = "lblPuntaje";
            lblPuntaje.Size = new Size(84, 18);
            lblPuntaje.TabIndex = 0;
            lblPuntaje.Text = "Puntaje: 0";
            // 
            // lblIntentos
            // 
            lblIntentos.AutoSize = true;
            lblIntentos.BackColor = Color.Transparent;
            lblIntentos.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblIntentos.ForeColor = Color.White;
            lblIntentos.Location = new Point(140, 12);
            lblIntentos.Name = "lblIntentos";
            lblIntentos.Size = new Size(90, 18);
            lblIntentos.TabIndex = 1;
            lblIntentos.Text = "Intentos: 3";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.BackColor = Color.Transparent;
            lblTiempo.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblTiempo.ForeColor = Color.White;
            lblTiempo.Location = new Point(270, 12);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(89, 18);
            lblTiempo.TabIndex = 2;
            lblTiempo.Text = "Tiempo: 0s";
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.BackColor = Color.Transparent;
            lblPregunta.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblPregunta.ForeColor = Color.White;
            lblPregunta.Location = new Point(620, 50);
            lblPregunta.MaximumSize = new Size(280, 0);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(23, 18);
            lblPregunta.TabIndex = 3;
            lblPregunta.Text = "...";
            // 
            // txtRespuesta
            // 
            txtRespuesta.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            txtRespuesta.Location = new Point(620, 130);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(220, 26);
            txtRespuesta.TabIndex = 4;
            // 
            // btnValidar
            // 
            btnValidar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnValidar.Location = new Point(620, 170);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(100, 35);
            btnValidar.TabIndex = 5;
            btnValidar.Text = "Validar";
            btnValidar.Click += btnValidar_Click;
            // 
            // btnPista
            // 
            btnPista.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnPista.Location = new Point(740, 170);
            btnPista.Name = "btnPista";
            btnPista.Size = new Size(100, 35);
            btnPista.TabIndex = 6;
            btnPista.Text = "Pista";
            btnPista.Click += btnPista_Click;
            // 
            // btnCajaFuerte
            // 
            btnCajaFuerte.BackColor = Color.DarkGoldenrod;
            btnCajaFuerte.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnCajaFuerte.ForeColor = Color.White;
            btnCajaFuerte.Location = new Point(620, 220);
            btnCajaFuerte.Name = "btnCajaFuerte";
            btnCajaFuerte.Size = new Size(220, 40);
            btnCajaFuerte.TabIndex = 7;
            btnCajaFuerte.Text = "🔐 Abrir Caja Fuerte";
            btnCajaFuerte.UseVisualStyleBackColor = false;
            btnCajaFuerte.Click += btnCajaFuerte_Click;
            // 
            // btnSala
            // 
            btnSala.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnSala.Location = new Point(620, 275);
            btnSala.Name = "btnSala";
            btnSala.Size = new Size(100, 30);
            btnSala.TabIndex = 8;
            btnSala.Text = "Ir a Sala";
            btnSala.Click += btnSala_Click;
            // 
            // flpInventario
            // 
            flpInventario.BackColor = Color.Transparent;
            flpInventario.Location = new Point(620, 320);
            flpInventario.Name = "flpInventario";
            flpInventario.Size = new Size(280, 180);
            flpInventario.TabIndex = 9;
            // 
            // pbSotano
            // 
            pbSotano.BackColor = Color.Black;
            pbSotano.Location = new Point(58, 45);
            pbSotano.Name = "pbSotano";
            pbSotano.Size = new Size(515, 427);
            pbSotano.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSotano.TabIndex = 10;
            pbSotano.TabStop = false;
            // 
            // Sotano
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(939, 633);
            Controls.Add(lblPuntaje);
            Controls.Add(lblIntentos);
            Controls.Add(lblTiempo);
            Controls.Add(lblPregunta);
            Controls.Add(txtRespuesta);
            Controls.Add(btnValidar);
            Controls.Add(btnPista);
            Controls.Add(btnCajaFuerte);
            Controls.Add(btnSala);
            Controls.Add(flpInventario);
            Controls.Add(pbSotano);
            Name = "Sotano";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sótano — Escape Room";
            ((System.ComponentModel.ISupportInitialize)pbSotano).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // ── Campos ─────────────────────────────────────────────────
        private Label lblPuntaje;
        private Label lblIntentos;
        private Label lblTiempo;
        private Label lblPregunta;
        private TextBox txtRespuesta;
        private Button btnValidar;
        private Button btnPista;
        private Button btnCajaFuerte;
        private Button btnSala;
        private FlowLayoutPanel flpInventario;
        private PictureBox pbSotano;
    }
}