namespace ListaCédulas
{
    public partial class Cedulas : Form
    {
        public Cedulas()
        {
            InitializeComponent();
        }
        
        Dictionary<string, string> cedulas = new Dictionary<string, string>();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text;
            string nombre = txtNombre.Text;

            if (cedulas.Count == 12)
            {
                MessageBox.Show("No se pueden agregar más elementos");
                return;
            }

            if (string.IsNullOrEmpty(cedula) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Cédula o Nombre no pueden estar vacíos");
                return;
            }

            // Agregar elementos al diccionario
            cedulas.Add(cedula, nombre);
            MessageBox.Show("Elemento agregado");
            txtCedula.Text = "";
            txtNombre.Text = "";

        }

        private void btnVer_Click(object sender, EventArgs e)
        {

            // Mostrar el contenido del diccionario
            foreach (var item in cedulas)
            {
                MessageBox.Show($"Cédula: {item.Key} - Nombre: {item.Value}");
            }
        }
    }
}