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
            txtLog = new TextBox();
            button1 = new Button();
            pbEscenario = new PictureBox();
            pbAlfombra = new PictureBox();
            pbCajon = new PictureBox();
            pbEstanteria = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pbEscenario).BeginInit();
            pbEscenario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAlfombra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCajon).BeginInit();
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
            flpInventario.Size = new Size(203, 200);
            flpInventario.TabIndex = 0;
            // 
            // txtLog
            // 
            txtLog.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLog.Location = new Point(677, 260);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(220, 130);
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
            // pbCajon
            // 
            pbCajon.BackColor = Color.Transparent;
            pbCajon.Cursor = Cursors.Hand;
            pbCajon.Image = Properties.Resources.CajonCerrado;
            pbCajon.Location = new Point(281, 349);
            pbCajon.Name = "pbCajon";
            pbCajon.Size = new Size(78, 59);
            pbCajon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCajon.TabIndex = 12;
            pbCajon.TabStop = false;
            pbCajon.Click += pbCajon_Click;
            // 
            // pbEstanteria
            // 
            pbEstanteria.BackColor = Color.Transparent;
            pbEstanteria.Cursor = Cursors.Hand;
            pbEstanteria.Image = Properties.Resources.EstanteriaCerrada;
            pbEstanteria.Location = new Point(131, 45);
            pbEstanteria.Name = "pbEstanteria";
            pbEstanteria.Size = new Size(146, 94);
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
            Controls.Add(pbCajon);
            Controls.Add(pbEstanteria);
            Controls.Add(pbEscenario);
            Controls.Add(lblPuntaje);
            Controls.Add(lblIntentos);
            Controls.Add(lblTiempo);
            Controls.Add(flpInventario);
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
            ((System.ComponentModel.ISupportInitialize)pbCajon).EndInit();
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
        private TextBox txtLog;
        private Button button1;
        private PictureBox pbEscenario;
        private PictureBox pbEstanteria;
        private PictureBox pbAlfombra;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pbCajon;
    }
}
