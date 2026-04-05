namespace EscapeRoomDigitalPOO
{
    partial class Escenario1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Escenario1));
            flpInventario = new FlowLayoutPanel();
            lblPregunta = new Label();
            txtRespuesta = new TextBox();
            txtLog = new TextBox();
            pbEscenario = new PictureBox();
            pbEstanteria = new PictureBox();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lblPuntaje = new Label();
            lblIntentos = new Label();
            lblTiempo = new Label();
            btnValidar = new Button();
            btnPista = new Button();
            ((System.ComponentModel.ISupportInitialize)pbEscenario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEstanteria).BeginInit();
            SuspendLayout();
            // 
            // flpInventario
            // 
            flpInventario.BackColor = Color.Transparent;
            flpInventario.Location = new Point(630, 24);
            flpInventario.Margin = new Padding(3, 2, 3, 2);
            flpInventario.Name = "flpInventario";
            flpInventario.Size = new Size(178, 152);
            flpInventario.TabIndex = 0;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.BackColor = Color.Transparent;
            lblPregunta.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPregunta.ForeColor = SystemColors.ButtonHighlight;
            lblPregunta.Location = new Point(634, 198);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(0, 14);
            lblPregunta.TabIndex = 2;
            // 
            // txtRespuesta
            // 
            txtRespuesta.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRespuesta.Location = new Point(634, 215);
            txtRespuesta.Margin = new Padding(3, 2, 3, 2);
            txtRespuesta.Multiline = true;
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(175, 21);
            txtRespuesta.TabIndex = 1;
            // 
            // txtLog
            // 
            txtLog.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLog.Location = new Point(634, 250);
            txtLog.Margin = new Padding(3, 2, 3, 2);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(148, 56);
            txtLog.TabIndex = 5;
            // 
            // pbEscenario
            // 
            pbEscenario.ErrorImage = null;
            pbEscenario.Image = Properties.Resources.Cocina;
            pbEscenario.Location = new Point(51, 44);
            pbEscenario.Margin = new Padding(3, 2, 3, 2);
            pbEscenario.Name = "pbEscenario";
            pbEscenario.Size = new Size(451, 320);
            pbEscenario.SizeMode = PictureBoxSizeMode.Zoom;
            pbEscenario.TabIndex = 6;
            pbEscenario.TabStop = false;
            // 
            // pbEstanteria
            // 
            pbEstanteria.BackColor = Color.Transparent;
            pbEstanteria.Image = Properties.Resources.EstanteriaCerrada;
            pbEstanteria.Location = new Point(83, 44);
            pbEstanteria.Margin = new Padding(3, 2, 3, 2);
            pbEstanteria.Name = "pbEstanteria";
            pbEstanteria.Size = new Size(128, 70);
            pbEstanteria.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEstanteria.TabIndex = 7;
            pbEstanteria.TabStop = false;
            pbEstanteria.Click += pbEstanteria_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.Fond;
            button1.Location = new Point(435, 211);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(54, 22);
            button1.TabIndex = 8;
            button1.Text = "Sala";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lblPuntaje
            // 
            lblPuntaje.AutoSize = true;
            lblPuntaje.BackColor = Color.Transparent;
            lblPuntaje.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPuntaje.ForeColor = SystemColors.Control;
            lblPuntaje.Location = new Point(51, 9);
            lblPuntaje.Name = "lblPuntaje";
            lblPuntaje.Size = new Size(71, 14);
            lblPuntaje.TabIndex = 9;
            lblPuntaje.Text = "Puntaje: 0";
            // 
            // lblIntentos
            // 
            lblIntentos.AutoSize = true;
            lblIntentos.BackColor = Color.Transparent;
            lblIntentos.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIntentos.ForeColor = SystemColors.Control;
            lblIntentos.Location = new Point(134, 9);
            lblIntentos.Name = "lblIntentos";
            lblIntentos.Size = new Size(77, 14);
            lblIntentos.TabIndex = 10;
            lblIntentos.Text = "Intentos: 3";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.BackColor = Color.Transparent;
            lblTiempo.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiempo.ForeColor = SystemColors.Control;
            lblTiempo.Location = new Point(229, 9);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(73, 14);
            lblTiempo.TabIndex = 11;
            lblTiempo.Text = "Tiempo: 0s";
            // 
            // btnValidar
            // 
            btnValidar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidar.Location = new Point(51, 421);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(93, 28);
            btnValidar.TabIndex = 12;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // btnPista
            // 
            btnPista.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPista.Location = new Point(175, 421);
            btnPista.Name = "btnPista";
            btnPista.Size = new Size(93, 28);
            btnPista.TabIndex = 13;
            btnPista.Text = "Pista";
            btnPista.UseVisualStyleBackColor = true;
            btnPista.Click += btnPista_Click;
            // 
            // Escenario1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(822, 475);
            Controls.Add(btnPista);
            Controls.Add(btnValidar);
            Controls.Add(lblTiempo);
            Controls.Add(lblIntentos);
            Controls.Add(lblPuntaje);
            Controls.Add(button1);
            Controls.Add(lblPregunta);
            Controls.Add(pbEstanteria);
            Controls.Add(txtRespuesta);
            Controls.Add(txtLog);
            Controls.Add(flpInventario);
            Controls.Add(pbEscenario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Escenario1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escape Room Digital";
            Load += SalaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pbEscenario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEstanteria).EndInit();
            ResumeLayout(false);
            PerformLayout();
            this.Load += new System.EventHandler(this.SalaPrincipal_Load);
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            this.btnPista.Click += new System.EventHandler(this.btnPista_Click);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpInventario;
        private TextBox txtRespuesta;
        private Label lblPregunta;
        private TextBox txtLog;
        private PictureBox pbEscenario;
        private PictureBox pbEstanteria;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private Label lblPuntaje;
        private Label lblIntentos;
        private Label lblTiempo;
        private Button btnValidar;
        private Button btnPista;
    }
}
