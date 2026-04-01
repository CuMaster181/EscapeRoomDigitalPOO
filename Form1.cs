namespace EscapeRoomDigitalPOO
{
    public partial class Form1 : Form
    {
        private GameManager gameManager;

        Item itemSeleccionado = null;
        PictureBox pbSeleccionado = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameManager = new GameManager();
            pbCandado.Tag = "llave_roja";
            pbLlaveRoja.Image = Properties.Resources.LlaveFinal;
            pbCandado.Image = Properties.Resources.Puerta;

            pbLlaveRoja.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCandado.SizeMode = PictureBoxSizeMode.StretchImage;
            MostrarAcertijo();
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

        private void btnResponder_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = txtRespuesta.Text;

                bool correcto = gameManager.ResolverAcertijo(respuesta);

                if (correcto)
                {
                    MessageBox.Show("Correcto");
                }
                else
                {
                    int intentos = gameManager.AcertijoActual.IntentosRestantes;

                    if (intentos <= 0)
                    {
                        MessageBox.Show("Perdiste");
                        Application.Exit();
                        return;
                    }

                    MessageBox.Show("Incorrecto. Intentos: " + intentos);
                }

                MostrarAcertijo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void MostrarInventario()
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

        private void pbCandado_Click(object sender, EventArgs e)
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

        private void pbLlaveRoja_Click(object sender, EventArgs e)
        {
            Item llave = new Item(
                "llave_roja",
                "LlaveRoja",
                Properties.Resources.LlaveFinal
            );

            AgregarItem(llave);

            pbLlaveRoja.Visible = false;
        }
    }
}
