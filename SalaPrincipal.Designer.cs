namespace EscapeRoomDigitalPOO
{
    partial class SalaPrincipal
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
            flpInventario = new FlowLayoutPanel();
            lblPregunta = new Label();
            txtRespuesta = new TextBox();
            pbLlaveFinal = new PictureBox();
            pbPuertaFinal = new PictureBox();
            txtLog = new TextBox();
            pbEscenario = new PictureBox();
            pbEstanteria = new PictureBox();
            flpInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLlaveFinal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPuertaFinal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEscenario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEstanteria).BeginInit();
            SuspendLayout();
            // 
            // flpInventario
            // 
            flpInventario.BackColor = Color.Transparent;
            flpInventario.Controls.Add(lblPregunta);
            flpInventario.Controls.Add(txtRespuesta);
            flpInventario.Location = new Point(533, 12);
            flpInventario.Name = "flpInventario";
            flpInventario.Size = new Size(255, 202);
            flpInventario.TabIndex = 0;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.BackColor = Color.Black;
            lblPregunta.ForeColor = SystemColors.ButtonHighlight;
            lblPregunta.Location = new Point(3, 0);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(85, 20);
            lblPregunta.TabIndex = 2;
            lblPregunta.Text = "lblPregunta";
            // 
            // txtRespuesta
            // 
            txtRespuesta.Location = new Point(3, 23);
            txtRespuesta.Multiline = true;
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(199, 27);
            txtRespuesta.TabIndex = 1;
            // 
            // pbLlaveFinal
            // 
            pbLlaveFinal.BackColor = Color.Transparent;
            pbLlaveFinal.Location = new Point(136, 333);
            pbLlaveFinal.Name = "pbLlaveFinal";
            pbLlaveFinal.Size = new Size(54, 56);
            pbLlaveFinal.TabIndex = 3;
            pbLlaveFinal.TabStop = false;
            pbLlaveFinal.Click += pbLlaveFinal_Click;
            // 
            // pbPuertaFinal
            // 
            pbPuertaFinal.BackColor = Color.Transparent;
            pbPuertaFinal.Image = Properties.Resources.Puerta;
            pbPuertaFinal.Location = new Point(371, 165);
            pbPuertaFinal.Name = "pbPuertaFinal";
            pbPuertaFinal.Size = new Size(189, 188);
            pbPuertaFinal.SizeMode = PictureBoxSizeMode.Zoom;
            pbPuertaFinal.TabIndex = 4;
            pbPuertaFinal.TabStop = false;
            pbPuertaFinal.Click += pbPuertaFinal_Click;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(536, 236);
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
            pbEstanteria.Image = Properties.Resources.EstanteriaCerrada;
            pbEstanteria.Location = new Point(86, 12);
            pbEstanteria.Name = "pbEstanteria";
            pbEstanteria.Size = new Size(146, 93);
            pbEstanteria.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEstanteria.TabIndex = 7;
            pbEstanteria.TabStop = false;
            pbEstanteria.Click += pbEstanteria_Click;
            // 
            // SalaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(800, 450);
            Controls.Add(pbEstanteria);
            Controls.Add(txtLog);
            Controls.Add(pbLlaveFinal);
            Controls.Add(pbPuertaFinal);
            Controls.Add(flpInventario);
            Controls.Add(pbEscenario);
            Name = "SalaPrincipal";
            Text = "Form1";
            Load += SalaPrincipal_Load;
            flpInventario.ResumeLayout(false);
            flpInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLlaveFinal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPuertaFinal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEscenario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEstanteria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpInventario;
        private TextBox txtRespuesta;
        private Label lblPregunta;
        private PictureBox pbLlaveFinal;
        private PictureBox pbPuertaFinal;
        private TextBox txtLog;
        private PictureBox pbEscenario;
        private PictureBox pbEstanteria;
    }
}
