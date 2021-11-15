using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioTarea.Modelos.DAO;
using EjercicioTarea.Modelos.Entidades;
using EjercicioTarea.Vista;
using System.Windows.Forms;
using EjercicioTarea;

namespace EjercicioTarea.Controladores
{
    public class UsuarioController
    {


        UsuariosView vista;
        string operacion = string.Empty;
        UsuarioDAO userDAO = new UsuarioDAO();
        Usuario user = new Usuario();

        public UsuarioController(UsuariosView view)
        {
            vista = view;
          
           
            vista.Load += new EventHandler(Load);
          
        }

        
        private void Nuevo(object serder, EventArgs e)
        {
          
        }
        
        private void Load(object serder, EventArgs e)
        {
            ListarUsuarios();
        }

        private void ListarUsuarios()
        {

            vista.dtg.DataSource = userDAO.getusuarios();


        }


        private void LimpiarControles()
        {

        }

        private void HabilitarControles()
        {
    
        }
        private void DesabilitarControles()
        {
     
        }

    }
}
