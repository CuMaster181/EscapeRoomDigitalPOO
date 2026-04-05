using System.Runtime.CompilerServices;

namespace EscapeRoomDigitalPOO
{
    public partial class Escenario1 : Form
    {
        private GameManager gameManager;
        private int estadoPuerta = 0;
        Item itemSeleccionado = null!;
        PictureBox pbSeleccionado = null!;
        public Escenario1(GameManager gm)
        {
            InitializeComponent();
            gameManager = gm;
            MostrarInventario();
        }

        private void SalaPrincipal_Load(object sender, EventArgs e)
        {
            pbEstanteria.Image = Properties.Resources.EstanteriaCerrada;
            pbEstanteria.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEscenario.SizeMode = PictureBoxSizeMode.Zoom;

            pbEscenario.Image = Properties.Resources.Cocina;

            if (gameManager.EstadoEstanteria == 0)
                pbEstanteria.Image = Properties.Resources.EstanteriaCerrada;

            else if (gameManager.EstadoEstanteria == 1)
                pbEstanteria.Image = Properties.Resources.EstanteriaPalanca;

            else if (gameManager.EstadoEstanteria == 2)
                pbEstanteria.Image = Properties.Resources.EstanteriaAbierta;
        }
        /*private void MostrarAcertijo()
        {
            if (gameManager.JuegoTerminado())
            {
                GuardarPuntaje();
                MessageBox.Show("¡Ganaste! Puntaje: " + gameManager.Puntaje);
                return;
            }

            lblPregunta.Text = gameManager.AcertijoActual.Pregunta;
        }
        */
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
                    MessageBox.Show("Seleccionaste: " + item.Nombre);
                };


                flpInventario.Controls.Add(pb);
            }
        }
        /*private void GuardarPuntaje()
        {
            try
            {
                File.WriteAllText("puntaje.txt", gameManager.Puntaje.ToString());
            }
            catch
            {
                MessageBox.Show("Error al guardar");
            }
        }
        */
        private void AgregarLog(string mensaje)
        {
            txtLog.AppendText(mensaje + Environment.NewLine);
        }
        private void AgregarItem(Item item)
        {
            gameManager.Inventario.Add(item);

            PictureBox pb = new PictureBox();
            pb.Width = 50;
            pb.Height = 50;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Image = item.Imagen;
            pb.Tag = item;

            pb.Click += SeleccionarItem!;

            flpInventario.Controls.Add(pb);

            AgregarLog("Recogiste: " + item.Nombre);
        }
        private void SeleccionarItem(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;

            itemSeleccionado = pb.Tag as Item;
            pbSeleccionado = pb;

            AgregarLog("Seleccionaste: " + itemSeleccionado!.Nombre);
        }
        private void ConsumirItem()
        {
            gameManager.Inventario.Remove(itemSeleccionado);

            flpInventario.Controls.Remove(pbSeleccionado);

            itemSeleccionado = null!;
            pbSeleccionado = null!;
        }
        private bool CodigoCorrecto(string codigo)
        {
            return codigo == "2007";
        }

        private void pbEstanteria_Click(object sender, EventArgs e)
        {
            if (gameManager.EstadoEstanteria == 0)
            {
                string codigo = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingresa el código:",
                    "Estantería",
                    ""
                );

                if (CodigoCorrecto(codigo))
                {
                    gameManager.EstadoEstanteria = 1;
                    pbEstanteria.Image = Properties.Resources.EstanteriaPalanca;

                    AgregarLog("La estantería se abrió ");
                }
                else
                {
                    AgregarLog("Código incorrecto ");
                }
            }

            else if (gameManager.EstadoEstanteria == 1)
            {
                gameManager.EstadoEstanteria = 2;

                pbEstanteria.Image = Properties.Resources.EstanteriaAbierta;

                Item palanca = new Item(
                    "palanca",
                    "Palanca",
                    Properties.Resources.Palanca
                );

                AgregarItem(palanca);

                AgregarLog("Encontraste una Palanca ");
            }

            else if (gameManager.EstadoEstanteria == 2)
            {
                AgregarLog("La estantería está vacía");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Sala sala = new Sala(gameManager);
            sala.Show();
            this.Hide();
        }
    }
}
