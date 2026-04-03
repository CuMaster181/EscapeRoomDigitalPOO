namespace EscapeRoomDigitalPOO
{
    public partial class SalaPrincipal : Form
    {
        private GameManager gameManager;
        private int estadoEstanteria = 0;
        Item itemSeleccionado = null!;
        PictureBox pbSeleccionado = null!;
        public SalaPrincipal()
        {
            InitializeComponent();
        }

        private void SalaPrincipal_Load(object sender, EventArgs e)
        {
            gameManager = new GameManager();
            pbPuertaFinal.Tag = "llave_Final";
            pbLlaveFinal.Image = Properties.Resources.LlaveFinal;
            pbPuertaFinal.Image = Properties.Resources.Puerta;

            pbEstanteria.Image = Properties.Resources.EstanteriaCerrada;
            pbEstanteria.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLlaveFinal.SizeMode = PictureBoxSizeMode.Zoom;
            pbPuertaFinal.SizeMode = PictureBoxSizeMode.Zoom;
            pbEscenario.SizeMode = PictureBoxSizeMode.Zoom;
            MostrarAcertijo();

            pbEscenario.Image = Properties.Resources.Cocina;

            pbLlaveFinal.Image = Properties.Resources.LlaveFinal;
            pbPuertaFinal.Image = Properties.Resources.Puerta;
            pbLlaveFinal.Parent = pbEscenario;
            pbPuertaFinal.Parent = pbEscenario;

            pbLlaveFinal.BackColor = Color.Transparent;
            pbPuertaFinal.BackColor = Color.Transparent;

            pbLlaveFinal.Location = new Point(50, 100);
            pbPuertaFinal.Location = new Point(391, 75);
        }
        private void MostrarAcertijo()
        {
            if (gameManager.JuegoTerminado())
            {
                GuardarPuntaje();
                MessageBox.Show("¡Ganaste! Puntaje: " + gameManager.Puntaje);
                return;
            }

            lblPregunta.Text = gameManager.AcertijoActual.Pregunta;
        }
        public void MostrarInventario()
        {
            flpInventario.Controls.Clear();

            foreach (var item in gameManager.Inventario)
            {
                Button btn = new Button();
                btn.Text = item.Nombre;

                btn.Click += (s, e) =>
                {
                    MessageBox.Show("Usaste: " + item.Nombre);
                };

                flpInventario.Controls.Add(btn);
            }
        }
        private void GuardarPuntaje()
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

            pb.Click += SeleccionarItem;

            flpInventario.Controls.Add(pb);

            AgregarLog("Recogiste: " + item.Nombre);
        }
        private void SeleccionarItem(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;

            itemSeleccionado = pb.Tag as Item;
            pbSeleccionado = pb;

            AgregarLog("Seleccionaste: " + itemSeleccionado.Nombre);
        }
        private void ConsumirItem()
        {
            gameManager.Inventario.Remove(itemSeleccionado);

            flpInventario.Controls.Remove(pbSeleccionado);

            itemSeleccionado = null;
            pbSeleccionado = null;
        }

        private void pbPuertaFinal_Click(object sender, EventArgs e)
        {
            if (itemSeleccionado == null)
            {
                AgregarLog("Selecciona un objeto primero");
                return;
            }

            PictureBox pb = sender as PictureBox;
            string llaveNecesaria = pb.Tag.ToString();

            if (itemSeleccionado.Id == llaveNecesaria)
            {
                AgregarLog("Abriste el candado");

                pb.Image = Properties.Resources.PuertaAbierta;

                ConsumirItem();

            }
            else
            {
                AgregarLog("Ese objeto no sirve aquí ?");
            }
        }

        private void pbLlaveFinal_Click(object sender, EventArgs e)
        {
            Item Llave = new Item(
                "llave_Final",
                "LlaveFinal",
                Properties.Resources.LlaveFinal
            );

            AgregarItem(Llave);

            pbLlaveFinal.Visible = false;
        }
        private bool CodigoCorrecto(string codigo)
        {
            return codigo == "2007";
        }

        private void pbEstanteria_Click(object sender, EventArgs e)
        {

            if (estadoEstanteria == 0)
            {
                string codigo = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingresa el código:",
                "Caja",
                ""
                );

                if (CodigoCorrecto(codigo))
                {
                    estadoEstanteria = 1;
                    pbEstanteria.Image = Properties.Resources.EstanteriaPalanca;

                    AgregarLog("La estantería se abrió");
                }
                else
                {
                    AgregarLog("Código incorrecto");
                }
            }

            else if (estadoEstanteria == 1)
            {
                estadoEstanteria = 2;
                pbEstanteria.Image = Properties.Resources.EstanteriaAbierta;

                Item premio = new Item(
                    "palanca",
                    "Palanca",
                    Properties.Resources.Palanca
                );

                AgregarItem(premio);

                AgregarLog("Encontraste una Palanca");
            }

            else
            {
                AgregarLog("La estantería está vacía");
            }
        }
    }
}
