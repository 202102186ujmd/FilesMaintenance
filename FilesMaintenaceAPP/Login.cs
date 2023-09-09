using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace FilesMaintenaceAPP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            using (var db = new DBA_FilesMaintenaceContext())
            {
                //Option 2: Login

                //Creacion de parametros
                var option = new SqlParameter("@Option", 2);
                var username = new SqlParameter("username", txbUsusario.Text);
                var password = new SqlParameter("password",txbPassword.Text);
               
                //Creacion de objeto de retorno del procedimiento almacenado
                var Respuesta =db.Sp_Authenticate((int)option.Value,
                    username.Value.ToString(), password.Value.ToString()); 

                //Validacion de respuesta
                if(Respuesta.SingleOrDefault() == 1)
                {
                    MessageBox.Show("Bienvenido al sistema");

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
            }
        }
    }
}
