using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Alberti.Entity;
namespace Escritorio
{
    public partial class Lista : Form
    {
        public Lista()
        {
            InitializeComponent();            
        }


        private void Lista_Load(object sender, EventArgs e)
        {

            try
            {
                List<Alberti.Entity.Alumno> LisAlumnos = new List<Alberti.Entity.Alumno>();
                Datos.Alumno recupAlum = new Datos.Alumno();
                LisAlumnos = recupAlum.RecuperarTodos();
                comboBox1.DataSource = LisAlumnos;
                comboBox1.DisplayMember = "ApellidoNombre";
                comboBox1.ValueMember = "Id";
            }
            catch(Exception ee)
            {
                MessageBox.Show("no anda " + ee.ToString());
            }

            }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int idseleccionado = (int)comboBox1.SelectedValue;
            Datos.Alumno buscaAlum = new Datos.Alumno();
            Alberti.Entity.Alumno buscado = buscaAlum.getOne(idseleccionado);
            MessageBox.Show(buscado.ApellidoNombre + "/n" + buscado.Dni + "/n" + buscado.Edad.ToString() + "/n" + buscado.FechaNacimiento.ToString() + "/n" + buscado.NotaPromedio.ToString());

        }
    }
}
