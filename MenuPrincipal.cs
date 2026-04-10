using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EscapeRoomDigitalPOO
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            VerificarPartidaGuardada();
        }

        // 🔍 Verifica si existe archivo de guardado
        private void VerificarPartidaGuardada()
        {
            string ruta = "resultados.txt";

            BttnCargarPartida.Enabled = File.Exists(ruta);
        }

        // 🔄 Se ejecuta cada vez que vuelves al menú
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            VerificarPartidaGuardada();
        }

        // ▶️ Nueva partida
        private void bttnInicio_Click(object sender, EventArgs e)
        {
            GameManager gm = new GameManager();
            Cocina escenario = new Cocina(gm);
            escenario.Show();
            this.Hide();
        }

        // 📂 Cargar partida (mostrar historial)
        private void BttnCargarPartida_Click(object sender, EventArgs e)
        {
            if (!File.Exists("resultados.txt"))
            {
                MessageBox.Show("No hay partidas guardadas.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GameManager gm = new GameManager();
            string historial = gm.LeerHistorial();

            using Form frm = new Form()
            {
                Text = "Historial de partidas",
                StartPosition = FormStartPosition.CenterParent,
                Size = new Size(700, 500),
                MinimizeBox = false,
                MaximizeBox = false
            };

            TextBox tb = new TextBox()
            {
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                Dock = DockStyle.Fill,
                Font = new Font("Consolas", 9F),
                Text = historial
            };

            frm.Controls.Add(tb);
            frm.ShowDialog(this);
        }
    }
}