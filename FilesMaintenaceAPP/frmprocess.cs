using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilesMaintenaceAPP
{
    public partial class frmprocess : Form
    {
        public frmprocess()
        {
            InitializeComponent();
        }

        private void btnbuscarprocess_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txbrutafolder.Text = folderBrowserDialog1.SelectedPath;
            #region BusquedaArchivos
            var myDirectory = new DirectoryInfo(txbrutafolder.Text);

            //Contamos los archivos que hay en el directorio
           int FileCount = myDirectory.GetFiles().Count();
            //Guardar en la base de datos   
            using(var db = new DBA_FilesMaintenaceContext())
            {
                var newProcess = new Process
                {
                    ProcessName = txbrutafolder.Text,
                    FileCount = FileCount,
                    Path = txbrutafolder.Text,
                    Date = DateTime.Now
                };
                db.Process.Add(newProcess);
                db.SaveChanges();
                dgvVista.DataSource = db.Process.ToList();
                txbnameprocess.Focus();
            }


            #endregion


        }
    }
}
