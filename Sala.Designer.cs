namespace EscapeRoomDigitalPOO
{
    partial class Sala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sala));
            pbLlave = new PictureBox();
            pbPuerta = new PictureBox();
            flpInventario = new FlowLayoutPanel();
            pbSala = new PictureBox();
            txtLog = new TextBox();
            bttncocina = new Button();
            bttnSotano = new Button();
            pbLibro = new PictureBox();
            lblPuntaje = new Label();
            lblIntentos = new Label();
            lblTiempo = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLlave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPuerta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSala).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLibro).BeginInit();
            SuspendLayout();
            // 
            // pbLlave
            // 
            pbLlave.BackColor = Color.Transparent;
            pbLlave.Image = Properties.Resources.LlaveFinal;
            pbLlave.Location = new Point(248, 279);
            pbLlave.Name = "pbLlave";
            pbLlave.Size = new Size(59, 51);
            pbLlave.SizeMode = PictureBoxSizeMode.Zoom;
            pbLlave.TabIndex = 0;
            pbLlave.TabStop = false;
            pbLlave.Click += pbLlave_Click;
            // 
            // pbPuerta
            // 
            pbPuerta.BackColor = Color.Transparent;
            pbPuerta.Image = Properties.Resources.Puerta;
            pbPuerta.Location = new Point(419, 123);
            pbPuerta.Name = "pbPuerta";
            pbPuerta.Size = new Size(145, 278);
            pbPuerta.SizeMode = PictureBoxSizeMode.Zoom;
            pbPuerta.TabIndex = 1;
            pbPuerta.TabStop = false;
            pbPuerta.Click += PuertaFinal_Click;
            // 
            // flpInventario
            // 
            flpInventario.BackColor = Color.Transparent;
            flpInventario.Location = new Point(677, 45);
            flpInventario.Name = "flpInventario";
            flpInventario.Size = new Size(203, 200);
            flpInventario.TabIndex = 2;
            // 
            // pbSala
            // 
            pbSala.BackColor = Color.Transparent;
            pbSala.Image = Properties.Resources.Sala;
            pbSala.Location = new Point(58, 45);
            pbSala.Name = "pbSala";
            pbSala.Size = new Size(515, 427);
            pbSala.SizeMode = PictureBoxSizeMode.Zoom;
            pbSala.TabIndex = 3;
            pbSala.TabStop = false;
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
            txtLog.TabIndex = 4;
            // 
            // bttncocina
            // 
            bttncocina.BackgroundImage = Properties.Resources.Fond;
            bttncocina.Location = new Point(677, 405);
            bttncocina.Name = "bttncocina";
            bttncocina.Size = new Size(100, 32);
            bttncocina.TabIndex = 5;
            bttncocina.Text = "Cocina";
            bttncocina.UseVisualStyleBackColor = true;
            bttncocina.Click += btnCocina;
            // 
            // bttnSotano
            // 
            bttnSotano.BackgroundImage = Properties.Resources.Fond;
            bttnSotano.Location = new Point(790, 405);
            bttnSotano.Name = "bttnSotano";
            bttnSotano.Size = new Size(100, 32);
            bttnSotano.TabIndex = 6;
            bttnSotano.Text = "Sótano";
            bttnSotano.UseVisualStyleBackColor = true;
            bttnSotano.Click += btnSotano_Click;
            // 
            // pbLibro
            // 
            pbLibro.BackColor = Color.Transparent;
            pbLibro.BackgroundImage = Properties.Resources.LibroClick;
            pbLibro.BackgroundImageLayout = ImageLayout.Zoom;
            pbLibro.Location = new Point(137, 174);
            pbLibro.Name = "pbLibro";
            pbLibro.Size = new Size(29, 46);
            pbLibro.TabIndex = 7;
            pbLibro.TabStop = false;
            pbLibro.Click += pbLibro_Click;
            // 
            // lblPuntaje
            // 
            lblPuntaje.AutoSize = true;
            lblPuntaje.BackColor = Color.Transparent;
            lblPuntaje.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblPuntaje.ForeColor = SystemColors.Control;
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
            lblIntentos.ForeColor = SystemColors.Control;
            lblIntentos.Location = new Point(140, 12);
            lblIntentos.Name = "lblIntentos";
            lblIntentos.Size = new Size(94, 18);
            lblIntentos.TabIndex = 1;
            lblIntentos.Text = "Intentos: —";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.BackColor = Color.Transparent;
            lblTiempo.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblTiempo.ForeColor = SystemColors.Control;
            lblTiempo.Location = new Point(270, 12);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(89, 18);
            lblTiempo.TabIndex = 2;
            lblTiempo.Text = "Tiempo: 0s";
            // 
            // Sala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(939, 633);
            Controls.Add(lblPuntaje);
            Controls.Add(lblIntentos);
            Controls.Add(lblTiempo);
            Controls.Add(pbLibro);
            Controls.Add(bttnSotano);
            Controls.Add(bttncocina);
            Controls.Add(txtLog);
            Controls.Add(flpInventario);
            Controls.Add(pbPuerta);
            Controls.Add(pbLlave);
            Controls.Add(pbSala);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Sala";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sala";
            Load += Sala_Load;
            ((System.ComponentModel.ISupportInitialize)pbLlave).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPuerta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSala).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLibro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLlave;
        private PictureBox pbPuerta;
        private FlowLayoutPanel flpInventario;
        private PictureBox pbSala;
        private TextBox txtLog;
        private Button bttncocina;
        private Button bttnSotano;
        private PictureBox pbLibro;
        private Label lblPuntaje;
        private Label lblIntentos;
        private Label lblTiempo;
    }
}