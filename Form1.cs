namespace WinFormsApp1
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validar

            if (idtxt.Text == "")
                MessageBox.Show("Debe ingresar un id");
            else if (nombretxt.Text == "")
                MessageBox.Show("Debe ingresar un nombre");
            else if (apellidotxt.Text == "")
                MessageBox.Show("Debe ingresar un apellido");
            else if (direcciontxt.Text == "")
                MessageBox.Show("Debe ingresar una direccion");

            {

                //Captura de datos
                string id = idtxt.Text;
                string nombre = nombretxt.Text;
                string apellido = apellidotxt.Text;
                string direccion = direcciontxt.Text;


                //impresion de resultados

                ListViewItem fila = new ListViewItem(id);
                fila.SubItems.Add(nombre.ToString());
                fila.SubItems.Add(apellido.ToString());
                fila.SubItems.Add(direccion.ToString());

                listView1.Items.Add(fila);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView1.SelectedItems)
            {
                lista.Remove();
            }
        }
    }
}