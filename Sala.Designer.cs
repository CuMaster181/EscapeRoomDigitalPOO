namespace EscapeRoomDigitalPOO
{
    partial class Sala
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbLlave = new PictureBox();
            pbPuerta = new PictureBox();
            flpInventario = new FlowLayoutPanel();
            pbSala = new PictureBox();
            txtLog = new TextBox();
            bttncocina = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLlave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPuerta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSala).BeginInit();
            SuspendLayout();
            // 
            // pbLlave
            // 
            pbLlave.Image = Properties.Resources.LlaveFinal;
            pbLlave.Location = new Point(189, 318);
            pbLlave.Name = "pbLlave";
            pbLlave.Size = new Size(60, 50);
            pbLlave.SizeMode = PictureBoxSizeMode.Zoom;
            pbLlave.TabIndex = 0;
            pbLlave.TabStop = false;
            pbLlave.Click += pbLlave_Click;
            // 
            // pbPuerta
            // 
            pbPuerta.Image = Properties.Resources.Puerta;
            pbPuerta.Location = new Point(358, 215);
            pbPuerta.Name = "pbPuerta";
            pbPuerta.Size = new Size(169, 223);
            pbPuerta.SizeMode = PictureBoxSizeMode.Zoom;
            pbPuerta.TabIndex = 1;
            pbPuerta.TabStop = false;
            pbPuerta.Click += PuertaFinall_Click;
            // 
            // flpInventario
            // 
            flpInventario.Location = new Point(584, 12);
            flpInventario.Name = "flpInventario";
            flpInventario.Size = new Size(204, 202);
            flpInventario.TabIndex = 2;
            // 
            // pbSala
            // 
            pbSala.Location = new Point(12, 12);
            pbSala.Name = "pbSala";
            pbSala.Size = new Size(515, 426);
            pbSala.SizeMode = PictureBoxSizeMode.Zoom;
            pbSala.TabIndex = 3;
            pbSala.TabStop = false;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(605, 296);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(155, 123);
            txtLog.TabIndex = 4;
            // 
            // bttncocina
            // 
            bttncocina.BackgroundImage = Properties.Resources.Fond;
            bttncocina.Location = new Point(22, 185);
            bttncocina.Name = "bttncocina";
            bttncocina.Size = new Size(71, 29);
            bttncocina.TabIndex = 5;
            bttncocina.Text = "Cocina";
            bttncocina.UseVisualStyleBackColor = true;
            bttncocina.Click += button1_Click;
            // 
            // Sala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(800, 450);
            Controls.Add(bttncocina);
            Controls.Add(txtLog);
            Controls.Add(flpInventario);
            Controls.Add(pbPuerta);
            Controls.Add(pbLlave);
            Controls.Add(pbSala);
            Name = "Sala";
            Text = "Sala";
            ((System.ComponentModel.ISupportInitialize)pbLlave).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPuerta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSala).EndInit();
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
    }
}