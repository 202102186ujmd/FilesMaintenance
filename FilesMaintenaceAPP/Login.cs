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

                var respuesta = db.Database.ExecuteSqlCommand("exec Sp_Authenticate @Option,@UserName,@Password",
                                
                //prueba de lectura para benjamin//
                //Segunda prueba de Github

            }
        }
    }
}
