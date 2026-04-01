namespace EscapeRoomDigitalPOO
{
    partial class Form1
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
            txtRespuesta = new TextBox();
            lblPregunta = new Label();
            pbLlaveRoja = new PictureBox();
            pbCandado = new PictureBox();
            txtLog = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLlaveRoja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCandado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flpInventario
            // 
            flpInventario.BackColor = Color.Transparent;
            flpInventario.Location = new Point(619, 12);
            flpInventario.Name = "flpInventario";
            flpInventario.Size = new Size(169, 426);
            flpInventario.TabIndex = 0;
            // 
            // txtRespuesta
            // 
            txtRespuesta.Location = new Point(331, 384);
            txtRespuesta.Multiline = true;
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(199, 27);
            txtRespuesta.TabIndex = 1;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.BackColor = Color.Black;
            lblPregunta.ForeColor = SystemColors.ButtonHighlight;
            lblPregunta.Location = new Point(229, 384);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(85, 20);
            lblPregunta.TabIndex = 2;
            lblPregunta.Text = "lblPregunta";
            // 
            // pbLlaveRoja
            // 
            pbLlaveRoja.BackColor = Color.Transparent;
            pbLlaveRoja.Location = new Point(100, 196);
            pbLlaveRoja.Name = "pbLlaveRoja";
            pbLlaveRoja.Size = new Size(54, 56);
            pbLlaveRoja.TabIndex = 3;
            pbLlaveRoja.TabStop = false;
            pbLlaveRoja.Click += pbLlaveRoja_Click;
            // 
            // pbCandado
            // 
            pbCandado.BackColor = Color.Transparent;
            pbCandado.Location = new Point(404, 75);
            pbCandado.Name = "pbCandado";
            pbCandado.Size = new Size(160, 284);
            pbCandado.TabIndex = 4;
            pbCandado.TabStop = false;
            pbCandado.Click += pbCandado_Click;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(12, 365);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(201, 73);
            txtLog.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Fond;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(601, 347);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(800, 450);
            Controls.Add(pbLlaveRoja);
            Controls.Add(pbCandado);
            Controls.Add(txtLog);
            Controls.Add(lblPregunta);
            Controls.Add(txtRespuesta);
            Controls.Add(flpInventario);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbLlaveRoja).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCandado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpInventario;
        private TextBox txtRespuesta;
        private Label lblPregunta;
        private PictureBox pbLlaveRoja;
        private PictureBox pbCandado;
        private TextBox txtLog;
        private PictureBox pictureBox1;
    }
}
