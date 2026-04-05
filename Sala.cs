using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeRoomDigitalPOO
{
    public partial class Sala : Form
    {
        public GameManager gameManager;
        private int estadoPuerta = 0;
        Item itemSeleccionado = null!;
        PictureBox pbSeleccionado = null!;
        public Sala(GameManager gm)
        {
            InitializeComponent();
            this.gameManager = gm;
            MostrarInventario();
            AgregarLog();

            pbPuerta.Tag = "llave_Final";

            pbPuerta.Image = Properties.Resources.Puerta;
            pbLlave.Image = Properties.Resources.LlaveFinal;

            pbPuerta.SizeMode = PictureBoxSizeMode.Zoom;
            pbLlave.SizeMode = PictureBoxSizeMode.Zoom;

            pbPuerta.Image = Properties.Resources.Puerta;
            pbLlave.Image = Properties.Resources.LlaveFinal;

            pbPuerta.Parent = pbSala;
            pbLlave.Parent = pbSala;

            pbPuerta.BackColor = Color.Transparent;
            pbLlave.BackColor = Color.Transparent;

            pbPuerta.Location = new Point(391, 75);
            pbLlave.Location = new Point(50, 100);
            pbSala.Image = Properties.Resources.Sala;

            if (gameManager.LlaveRecogida)
                pbLlave.Visible = false;
        }
        private void AgregarLog(string mensaje = "¡Bienvenido a la sala final!")
        {
            txtLog.AppendText(mensaje + Environment.NewLine);
        }
        private void MostrarInventario()
        {
            flpInventario.Controls.Clear();

            foreach (var item in gameManager.Inventario)
            {
                PictureBox pb = new PictureBox();
                pb.Width = 50;
                pb.Height = 50;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Image = item.Imagen;
                pb.Tag = item;

                pb.Click += (s, e) =>
                {
                    itemSeleccionado = (Item)pb.Tag;
                    pbSeleccionado = (PictureBox)s;

                    AgregarLog("Seleccionaste: " + itemSeleccionado.Nombre);
                };

                flpInventario.Controls.Add(pb);
            }
        }
        private void SeleccionarItem()
        {
            foreach (Control ctrl in flpInventario.Controls)
            {
                if (ctrl is PictureBox pb)
                {
                    pb.Click += (s, e) =>
                    {
                        itemSeleccionado = pb.Tag as Item;
                        AgregarLog("Seleccionaste: " + itemSeleccionado?.Nombre);
                    };
                }
            }
        }
        private void ConsumirItem()
        {
            if (itemSeleccionado != null)
            {
                gameManager.Inventario.Remove(itemSeleccionado);
                MostrarInventario();
                itemSeleccionado = null;
                AgregarLog("Consumiste el objeto");
            }
        }

        private void PuertaFinall_Click(object sender, EventArgs e)
        {
            if (estadoPuerta == 0)
            {
                if (itemSeleccionado == null)
                {
                    AgregarLog("Selecciona un objeto primero");
                    return;
                }

                PictureBox pb = sender as PictureBox;
                string llaveNecesaria = pb.Tag as string;

                if (itemSeleccionado.Id == llaveNecesaria)
                {
                    estadoPuerta = 1;
                    AgregarLog("Abriste el candado");

                    pb.Image = Properties.Resources.PuertaAbierta;

                    ConsumirItem();

                }
                else
                {
                    AgregarLog("Ese objeto no sirve aquí ?");
                }
            }
            else
            {
                MessageBox.Show("¡Has escapado!");
                this.Close();
            }
        }

        private void pbLlave_Click(object sender, EventArgs e)
        {
            gameManager.LlaveRecogida = true;

            Item Llave = new Item(
                "llave_Final",
                "LlaveFinal",
                Properties.Resources.LlaveFinal
            );
            gameManager.Inventario.Add(Llave);

            pbLlave.Visible = false;
            MostrarInventario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Escenario1 escenario1 = new Escenario1(gameManager);
            escenario1.Show();
            this.Hide();
        }
        private void Sala_Load(object sender, EventArgs e)
        {
            pbSala.Image = Properties.Resources.Sala;
            pbSala.SizeMode = PictureBoxSizeMode.StretchImage;

            pbPuerta.Parent = pbSala;
            pbPuerta.Image = Properties.Resources.Puerta;
            pbPuerta.SizeMode = PictureBoxSizeMode.Zoom;
            pbPuerta.BackColor = Color.Transparent;
            pbPuerta.Location = new Point(391, 75);
            pbPuerta.Tag = "llave_Final";

            pbLlave.Parent = pbSala;
            pbLlave.Image = Properties.Resources.LlaveFinal;
            pbLlave.SizeMode = PictureBoxSizeMode.Zoom;
            pbLlave.BackColor = Color.Transparent;
            pbLlave.Location = new Point(50, 100);
            pbLlave.Visible = !gameManager.LlaveRecogida;

            MostrarInventario();
            AgregarLog("¡Bienvenido a la sala final!");
        }
    }
}
