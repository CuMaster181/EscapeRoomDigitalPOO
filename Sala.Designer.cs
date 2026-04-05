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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sala));
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
            pbLlave.Location = new Point(165, 238);
            pbLlave.Margin = new Padding(3, 2, 3, 2);
            pbLlave.Name = "pbLlave";
            pbLlave.Size = new Size(52, 38);
            pbLlave.SizeMode = PictureBoxSizeMode.Zoom;
            pbLlave.TabIndex = 0;
            pbLlave.TabStop = false;
            pbLlave.Click += pbLlave_Click;
            // 
            // pbPuerta
            // 
            pbPuerta.Image = Properties.Resources.Puerta;
            pbPuerta.Location = new Point(362, 216);
            pbPuerta.Margin = new Padding(3, 2, 3, 2);
            pbPuerta.Name = "pbPuerta";
            pbPuerta.Size = new Size(148, 167);
            pbPuerta.SizeMode = PictureBoxSizeMode.Zoom;
            pbPuerta.TabIndex = 1;
            pbPuerta.TabStop = false;
            pbPuerta.Click += PuertaFinall_Click;
            // 
            // flpInventario
            // 
            flpInventario.Location = new Point(592, 20);
            flpInventario.Margin = new Padding(3, 2, 3, 2);
            flpInventario.Name = "flpInventario";
            flpInventario.Size = new Size(178, 152);
            flpInventario.TabIndex = 2;
            // 
            // pbSala
            // 
            pbSala.Location = new Point(10, 9);
            pbSala.Margin = new Padding(3, 2, 3, 2);
            pbSala.Name = "pbSala";
            pbSala.Size = new Size(500, 374);
            pbSala.SizeMode = PictureBoxSizeMode.Zoom;
            pbSala.TabIndex = 3;
            pbSala.TabStop = false;
            // 
            // txtLog
            // 
            txtLog.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLog.Location = new Point(592, 220);
            txtLog.Margin = new Padding(3, 2, 3, 2);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(178, 109);
            txtLog.TabIndex = 4;
            // 
            // bttncocina
            // 
            bttncocina.BackgroundImage = Properties.Resources.Fond;
            bttncocina.Location = new Point(19, 139);
            bttncocina.Margin = new Padding(3, 2, 3, 2);
            bttncocina.Name = "bttncocina";
            bttncocina.Size = new Size(62, 22);
            bttncocina.TabIndex = 5;
            bttncocina.Text = "Cocina";
            bttncocina.UseVisualStyleBackColor = true;
            bttncocina.Click += button1_Click;
            // 
            // Sala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(782, 449);
            Controls.Add(bttncocina);
            Controls.Add(txtLog);
            Controls.Add(flpInventario);
            Controls.Add(pbPuerta);
            Controls.Add(pbLlave);
            Controls.Add(pbSala);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Sala";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sala";
            Load += Sala_Load;
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