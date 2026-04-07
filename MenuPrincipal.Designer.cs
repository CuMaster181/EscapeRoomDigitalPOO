namespace EscapeRoomDigitalPOO
{
    partial class MenuPrincipal
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
            bttnInicio = new Button();
            BttnCargarPartida = new Button();
            SuspendLayout();
            // 
            // bttnInicio
            // 
            bttnInicio.Location = new Point(259, 158);
            bttnInicio.Name = "bttnInicio";
            bttnInicio.Size = new Size(220, 44);
            bttnInicio.TabIndex = 0;
            bttnInicio.Text = "Iniciar Partida";
            bttnInicio.UseVisualStyleBackColor = true;
            bttnInicio.Click += bttnInicio_Click;
            // 
            // BttnCargarPartida
            // 
            BttnCargarPartida.Location = new Point(259, 217);
            BttnCargarPartida.Name = "BttnCargarPartida";
            BttnCargarPartida.Size = new Size(220, 49);
            BttnCargarPartida.TabIndex = 1;
            BttnCargarPartida.Text = "Cargar Partida";
            BttnCargarPartida.UseVisualStyleBackColor = true;
            BttnCargarPartida.Click += BttnCargarPartida_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(721, 450);
            Controls.Add(BttnCargarPartida);
            Controls.Add(bttnInicio);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button bttnInicio;
        private Button BttnCargarPartida;
    }
}