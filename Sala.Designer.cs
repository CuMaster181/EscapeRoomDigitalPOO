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
            pbLibro = new PictureBox();
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
            pbPuerta.Click += PuertaFinall_Click;
            // 
            // flpInventario
            // 
            flpInventario.Location = new Point(677, 27);
            flpInventario.Name = "flpInventario";
            flpInventario.Size = new Size(203, 203);
            flpInventario.TabIndex = 2;
            // 
            // pbSala
            // 
            pbSala.BackColor = Color.Transparent;
            pbSala.Image = Properties.Resources.Sala;
            pbSala.Location = new Point(58, 59);
            pbSala.Name = "pbSala";
            pbSala.Size = new Size(515, 427);
            pbSala.SizeMode = PictureBoxSizeMode.Zoom;
            pbSala.TabIndex = 3;
            pbSala.TabStop = false;
            // 
            // txtLog
            // 
            txtLog.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLog.Location = new Point(677, 293);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(203, 144);
            txtLog.TabIndex = 4;
            // 
            // bttncocina
            // 
            bttncocina.BackgroundImage = Properties.Resources.Fond;
            bttncocina.Location = new Point(76, 301);
            bttncocina.Name = "bttncocina";
            bttncocina.Size = new Size(71, 29);
            bttncocina.TabIndex = 5;
            bttncocina.Text = "Cocina";
            bttncocina.UseVisualStyleBackColor = true;
            bttncocina.Click += button1_Click;
            // 
            // pbLibro
            // 
            pbLibro.BackColor = Color.Transparent;
            pbLibro.BackgroundImage = Properties.Resources.LibroClick;
            pbLibro.BackgroundImageLayout = ImageLayout.Zoom;
            pbLibro.Location = new Point(137, 174);
            pbLibro.Name = "pbLibro";
            pbLibro.Size = new Size(29, 46);
            pbLibro.TabIndex = 6;
            pbLibro.TabStop = false;
            pbLibro.Click += pictureBox1_Click;
            // 
            // Sala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(939, 633);
            Controls.Add(pbLibro);
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
        private PictureBox pbLibro;
    }
}