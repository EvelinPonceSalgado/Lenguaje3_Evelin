using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioTarea
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guardar.ticket = textBox4.Text;
            Guardar.nombre = textBox1.Text;
            Guardar.servicio = comboBox1.SelectedItem.ToString();
            Guardar.estado = comboBox2.SelectedItem.ToString();
            Guardar.fecha = dateTimePicker1.Text;



            MessageBox.Show("Ticket generado con exito");

            

            

        }
        private void listarusuarios()
        {
           

        }
    }
}
