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
    public partial class UsuariosView : Form
    {
        public UsuariosView()
        {
            InitializeComponent();
        }

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        public void listausuarios()
        {

        


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();

            fila.CreateCells(dtg);
            fila.Cells[1].Value = "Nombre";
            fila.Cells[1].Value = "Nombre";


        }

        private void UsuariosView_Load(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();

            fila.CreateCells(dtg);
            fila.Cells[1].Value = "Nombre";
            fila.Cells[2].Value = "Nombre";



        }
    }
}
