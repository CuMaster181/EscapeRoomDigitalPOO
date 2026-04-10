namespace EscapeRoomDigitalPOO
{
    partial class Cocina
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cocina));
            lblPuntaje = new Label();
            lblIntentos = new Label();
            lblTiempo = new Label();
            flpInventario = new FlowLayoutPanel();
            lblPregunta = new Label();
            txtRespuesta = new TextBox();
            btnValidar = new Button();
            btnPista = new Button();
            txtLog = new TextBox();
            button1 = new Button();
            pbEscenario = new PictureBox();
            pbAlfombra = new PictureBox();
            pbEstanteria = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pbEscenario).BeginInit();
            pbEscenario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAlfombra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEstanteria).BeginInit();
            SuspendLayout();
            // 
            // lblPuntaje
            // 
            lblPuntaje.AutoSize = true;
            lblPuntaje.BackColor = Color.Transparent;
            lblPuntaje.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPuntaje.ForeColor = SystemColors.Control;
            lblPuntaje.Location = new Point(12, 12);
            lblPuntaje.Name = "lblPuntaje";
            lblPuntaje.Size = new Size(84, 18);
            lblPuntaje.TabIndex = 9;
            lblPuntaje.Text = "Puntaje: 0";
            // 
            // lblIntentos
            // 
            lblIntentos.AutoSize = true;
            lblIntentos.BackColor = Color.Transparent;
            lblIntentos.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIntentos.ForeColor = SystemColors.Control;
            lblIntentos.Location = new Point(140, 12);
            lblIntentos.Name = "lblIntentos";
            lblIntentos.Size = new Size(90, 18);
            lblIntentos.TabIndex = 10;
            lblIntentos.Text = "Intentos: 3";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.BackColor = Color.Transparent;
            lblTiempo.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiempo.ForeColor = SystemColors.Control;
            lblTiempo.Location = new Point(270, 12);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(89, 18);
            lblTiempo.TabIndex = 11;
            lblTiempo.Text = "Tiempo: 0s";
            // 
            // flpInventario
            // 
            flpInventario.BackColor = Color.Transparent;
            flpInventario.Location = new Point(677, 45);
            flpInventario.Name = "flpInventario";
            flpInventario.Size = new Size(240, 180);
            flpInventario.TabIndex = 0;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.BackColor = Color.Transparent;
            lblPregunta.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPregunta.ForeColor = SystemColors.ButtonHighlight;
            lblPregunta.Location = new Point(677, 240);
            lblPregunta.MaximumSize = new Size(240, 0);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(23, 18);
            lblPregunta.TabIndex = 2;
            lblPregunta.Text = "...";
            // 
            // txtRespuesta
            // 
            txtRespuesta.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRespuesta.Location = new Point(677, 300);
            txtRespuesta.Multiline = true;
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(240, 27);
            txtRespuesta.TabIndex = 1;
            // 
            // btnValidar
            // 
            btnValidar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidar.Location = new Point(677, 340);
            btnValidar.Margin = new Padding(3, 4, 3, 4);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(112, 37);
            btnValidar.TabIndex = 12;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // btnPista
            // 
            btnPista.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPista.Location = new Point(805, 340);
            btnPista.Margin = new Padding(3, 4, 3, 4);
            btnPista.Name = "btnPista";
            btnPista.Size = new Size(112, 37);
            btnPista.TabIndex = 13;
            btnPista.Text = "Pista";
            btnPista.UseVisualStyleBackColor = true;
            btnPista.Click += btnPista_Click;
            // 
            // txtLog
            // 
            txtLog.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLog.Location = new Point(677, 390);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(240, 110);
            txtLog.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.Fond;
            button1.Location = new Point(579, 73);
            button1.Name = "button1";
            button1.Size = new Size(100, 32);
            button1.TabIndex = 8;
            button1.Text = "Sala";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pbEscenario
            // 
            pbEscenario.BackColor = Color.Transparent;
            pbEscenario.BackgroundImage = Properties.Resources.Cocina;
            pbEscenario.Controls.Add(pbAlfombra);
            pbEscenario.ErrorImage = null;
            pbEscenario.Image = Properties.Resources.Cocina;
            pbEscenario.Location = new Point(58, 45);
            pbEscenario.Name = "pbEscenario";
            pbEscenario.Size = new Size(515, 427);
            pbEscenario.SizeMode = PictureBoxSizeMode.Zoom;
            pbEscenario.TabIndex = 6;
            pbEscenario.TabStop = false;
            // 
            // pbAlfombra
            // 
            pbAlfombra.BackColor = Color.Transparent;
            pbAlfombra.Cursor = Cursors.Hand;
            pbAlfombra.Image = Properties.Resources.Alfombra;
            pbAlfombra.Location = new Point(95, 360);
            pbAlfombra.Name = "pbAlfombra";
            pbAlfombra.Size = new Size(295, 62);
            pbAlfombra.SizeMode = PictureBoxSizeMode.Zoom;
            pbAlfombra.TabIndex = 14;
            pbAlfombra.TabStop = false;
            pbAlfombra.Click += pbAlfombra_Click;
            // 
            // pbEstanteria
            // 
            pbEstanteria.BackColor = Color.Transparent;
            pbEstanteria.Image = Properties.Resources.EstanteriaCerrada;
            pbEstanteria.Location = new Point(95, 45);
            pbEstanteria.Name = "pbEstanteria";
            pbEstanteria.Size = new Size(146, 93);
            pbEstanteria.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEstanteria.TabIndex = 7;
            pbEstanteria.TabStop = false;
            pbEstanteria.Click += pbEstanteria_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Cocina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(939, 633);
            Controls.Add(pbEscenario);
            Controls.Add(pbEstanteria);
            Controls.Add(lblPuntaje);
            Controls.Add(lblIntentos);
            Controls.Add(lblTiempo);
            Controls.Add(flpInventario);
            Controls.Add(lblPregunta);
            Controls.Add(txtRespuesta);
            Controls.Add(btnValidar);
            Controls.Add(btnPista);
            Controls.Add(txtLog);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cocina";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escape Room Digital";
            Load += Cocina_Load;
            ((System.ComponentModel.ISupportInitialize)pbEscenario).EndInit();
            pbEscenario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAlfombra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEstanteria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // ── Campos ─────────────────────────────────────────────────
        private Label lblPuntaje;
        private Label lblIntentos;
        private Label lblTiempo;
        private FlowLayoutPanel flpInventario;
        private Label lblPregunta;
        private TextBox txtRespuesta;
        private Button btnValidar;
        private Button btnPista;
        private TextBox txtLog;
        private Button button1;
        private PictureBox pbEscenario;
        private PictureBox pbEstanteria;
        private PictureBox pbAlfombra;
        private ContextMenuStrip contextMenuStrip1;
    }
}
