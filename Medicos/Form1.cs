using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();

            medico.setnombre(textBoxNombre.Text);
            medico.setapellido(textBoxApellido.Text);
            medico.setespecialidad(textBoxEspecialidad.Text);
            medico.settelefono(Convert.ToInt32(textBoxTelefono.Text));
            medico.setdireccion(textBoxDireccion.Text);

            dataGridViewInfo.Rows.Add(medico.getnombre(), medico.getapellido(), medico.getespecialidad(), medico.gettelefono(), medico.getdireccion());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewInfo.Columns.Add("nombre", "Nombre");
            dataGridViewInfo.Columns.Add("apellido", "Apellido");
            dataGridViewInfo.Columns.Add("especialidad", "Especialidad");
            dataGridViewInfo.Columns.Add("telefono", "Telefono");
            dataGridViewInfo.Columns.Add("direccionClinica", "Direccion Clinica");
        }
    }
}
