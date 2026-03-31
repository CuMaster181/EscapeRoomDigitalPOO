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
            ((System.ComponentModel.ISupportInitialize)pbLlaveRoja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCandado).BeginInit();
            SuspendLayout();
            // 
            // flpInventario
            // 
            flpInventario.Location = new Point(247, 324);
            flpInventario.Name = "flpInventario";
            flpInventario.Size = new Size(506, 114);
            flpInventario.TabIndex = 0;
            // 
            // txtRespuesta
            // 
            txtRespuesta.Location = new Point(457, 277);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(296, 27);
            txtRespuesta.TabIndex = 1;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Location = new Point(247, 277);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(85, 20);
            lblPregunta.TabIndex = 2;
            lblPregunta.Text = "lblPregunta";
            // 
            // pbLlaveRoja
            // 
            pbLlaveRoja.Location = new Point(127, 59);
            pbLlaveRoja.Name = "pbLlaveRoja";
            pbLlaveRoja.Size = new Size(121, 130);
            pbLlaveRoja.TabIndex = 3;
            pbLlaveRoja.TabStop = false;
            pbLlaveRoja.Click += pbLlaveRoja_Click_1;
            // 
            // pbCandado
            // 
            pbCandado.Location = new Point(527, 59);
            pbCandado.Name = "pbCandado";
            pbCandado.Size = new Size(78, 80);
            pbCandado.TabIndex = 4;
            pbCandado.TabStop = false;
            pbCandado.Click += pbCandado_Click;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(25, 324);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(201, 114);
            txtLog.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLog);
            Controls.Add(pbCandado);
            Controls.Add(pbLlaveRoja);
            Controls.Add(lblPregunta);
            Controls.Add(txtRespuesta);
            Controls.Add(flpInventario);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbLlaveRoja).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCandado).EndInit();
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
    }
}
