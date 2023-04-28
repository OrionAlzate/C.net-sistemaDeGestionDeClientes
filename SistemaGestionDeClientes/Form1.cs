namespace SistemaGestionDeClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_gestionClientes_Click(object sender, EventArgs e)
        {
            GestionClientes ventanaGestion = new GestionClientes();
            ventanaGestion.ShowDialog();
            //ventanaGestion.Visible = true;
        }
    }
}