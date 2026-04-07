using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeRoomDigitalPOO
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void bttnInicio_Click(object sender, EventArgs e)
        {
            // Inicia una nueva partida: crea un GameManager y abre Escenario1
            GameManager gm = new GameManager();
            Cocina escenario = new Cocina(gm);
            escenario.Show();
            this.Hide();
        }

        private void BttnCargarPartida_Click(object sender, EventArgs e)
        {
            // Muestra el historial de partidas guardadas (Resultados.txt)
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
