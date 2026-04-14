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
            btnCocina = new Button();
            flpInventario = new FlowLayoutPanel();
            pbSotano = new PictureBox();
            pbCajaFuerte = new PictureBox();
            txtLog = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbSotano).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCajaFuerte).BeginInit();
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
            lblPregunta.Location = new Point(58, 482);
            lblPregunta.MaximumSize = new Size(280, 0);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(23, 18);
            lblPregunta.TabIndex = 3;
            lblPregunta.Text = "...";
            // 
            // txtRespuesta
            // 
            txtRespuesta.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            txtRespuesta.Location = new Point(58, 533);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(220, 26);
            txtRespuesta.TabIndex = 4;
            // 
            // btnValidar
            // 
            btnValidar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnValidar.Location = new Point(58, 573);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(100, 35);
            btnValidar.TabIndex = 5;
            btnValidar.Text = "Validar";
            btnValidar.Click += btnValidar_Click;
            // 
            // btnPista
            // 
            btnPista.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnPista.Location = new Point(178, 573);
            btnPista.Name = "btnPista";
            btnPista.Size = new Size(100, 35);
            btnPista.TabIndex = 6;
            btnPista.Text = "Pista";
            btnPista.Click += btnPista_Click;
            // 
            // btnCocina
            // 
            btnCocina.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnCocina.Location = new Point(593, 561);
            btnCocina.Name = "btnCocina";
            btnCocina.Size = new Size(125, 30);
            btnCocina.TabIndex = 8;
            btnCocina.Text = "Subir a Cocina";
            btnCocina.Click += btnCocina_Click;
            // 
            // flpInventario
            // 
            flpInventario.BackColor = Color.Transparent;
            flpInventario.Location = new Point(677, 45);
            flpInventario.Name = "flpInventario";
            flpInventario.Size = new Size(203, 200);
            flpInventario.TabIndex = 9;
            // 
            // pbSotano
            // 
            pbSotano.BackColor = Color.Black;
            pbSotano.Image = Properties.Resources.Sotano;
            pbSotano.Location = new Point(58, 45);
            pbSotano.Name = "pbSotano";
            pbSotano.Size = new Size(515, 427);
            pbSotano.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSotano.TabIndex = 10;
            pbSotano.TabStop = false;
            // 
            // pbCajaFuerte
            // 
            pbCajaFuerte.BackColor = Color.Transparent;
            pbCajaFuerte.Cursor = Cursors.Hand;
            pbCajaFuerte.Image = Properties.Resources.CajaFuerte;
            pbCajaFuerte.Location = new Point(412, 275);
            pbCajaFuerte.Name = "pbCajaFuerte";
            pbCajaFuerte.Size = new Size(150, 108);
            pbCajaFuerte.SizeMode = PictureBoxSizeMode.Zoom;
            pbCajaFuerte.TabIndex = 11;
            pbCajaFuerte.TabStop = false;
            pbCajaFuerte.Click += pbCajaFuerte_Click;
            // 
            // txtLog
            // 
            txtLog.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            txtLog.Location = new Point(677, 260);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(220, 130);
            txtLog.TabIndex = 12;
            // 
            // Sotano
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(939, 633);
            Controls.Add(txtLog);
            Controls.Add(pbCajaFuerte);
            Controls.Add(lblPuntaje);
            Controls.Add(lblIntentos);
            Controls.Add(lblTiempo);
            Controls.Add(lblPregunta);
            Controls.Add(txtRespuesta);
            Controls.Add(btnValidar);
            Controls.Add(btnPista);
            Controls.Add(btnCocina);
            Controls.Add(flpInventario);
            Controls.Add(pbSotano);
            Name = "Sotano";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sótano — Escape Room";
            ((System.ComponentModel.ISupportInitialize)pbSotano).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCajaFuerte).EndInit();
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
        private Button btnCocina;
        private FlowLayoutPanel flpInventario;
        private PictureBox pbSotano;
        private PictureBox pbCajaFuerte;
        private TextBox txtLog;
    }
}