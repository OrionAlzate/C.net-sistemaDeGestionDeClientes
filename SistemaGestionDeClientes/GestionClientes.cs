using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionDeClientes
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void cargarLista() 
        {
            string nombre = txt_nombre.Text;
            if (nombre.Length == 0)
            {
                MessageBox.Show("Debe ingresar un nombre.");
            }
            else
            {
                listClientes.Items.Add(nombre);
            }



            /*List<string> list = new List<string>();
            
            list.Add("cliente 1-");
            list.Add("cliente 2-");
            list.Add("cliente 3-");
            list.Add("cliente 4-");
            */

            /*
            list.ForEach(item =>
            {
                listClientes.Items.Add(item);
            });
            */
        }
    }
}
