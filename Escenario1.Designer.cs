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
            flpInventario = new FlowLayoutPanel();
            lblPregunta = new Label();
            txtRespuesta = new TextBox();
            txtLog = new TextBox();
            pbEscenario = new PictureBox();
            pbEstanteria = new PictureBox();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pbEscenario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEstanteria).BeginInit();
            SuspendLayout();
            // 
            // flpInventario
            // 
            flpInventario.BackColor = Color.Transparent;
            flpInventario.Location = new Point(584, 12);
            flpInventario.Name = "flpInventario";
            flpInventario.Size = new Size(204, 202);
            flpInventario.TabIndex = 0;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.BackColor = Color.Black;
            lblPregunta.ForeColor = SystemColors.ButtonHighlight;
            lblPregunta.Location = new Point(589, 244);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(85, 20);
            lblPregunta.TabIndex = 2;
            lblPregunta.Text = "lblPregunta";
            // 
            // txtRespuesta
            // 
            txtRespuesta.Location = new Point(589, 267);
            txtRespuesta.Multiline = true;
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(199, 27);
            txtRespuesta.TabIndex = 1;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(589, 313);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(169, 73);
            txtLog.TabIndex = 5;
            // 
            // pbEscenario
            // 
            pbEscenario.ErrorImage = null;
            pbEscenario.Image = Properties.Resources.Cocina;
            pbEscenario.Location = new Point(12, 12);
            pbEscenario.Name = "pbEscenario";
            pbEscenario.Size = new Size(515, 426);
            pbEscenario.SizeMode = PictureBoxSizeMode.Zoom;
            pbEscenario.TabIndex = 6;
            pbEscenario.TabStop = false;
            // 
            // pbEstanteria
            // 
            pbEstanteria.BackColor = Color.Transparent;
            pbEstanteria.Image = Properties.Resources.EstanteriaCerrada;
            pbEstanteria.Location = new Point(86, 12);
            pbEstanteria.Name = "pbEstanteria";
            pbEstanteria.Size = new Size(146, 93);
            pbEstanteria.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEstanteria.TabIndex = 7;
            pbEstanteria.TabStop = false;
            pbEstanteria.Click += pbEstanteria_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.Fond;
            button1.Location = new Point(450, 235);
            button1.Name = "button1";
            button1.Size = new Size(62, 29);
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
            // Escenario1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lblPregunta);
            Controls.Add(pbEstanteria);
            Controls.Add(txtRespuesta);
            Controls.Add(txtLog);
            Controls.Add(flpInventario);
            Controls.Add(pbEscenario);
            Name = "Escenario1";
            Text = "Form1";
            Load += SalaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pbEscenario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEstanteria).EndInit();
            ResumeLayout(false);
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
    }
}
