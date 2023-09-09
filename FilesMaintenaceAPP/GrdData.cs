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
    public partial class GrdData : Form
    {
        public GrdData()
        {
            InitializeComponent();
        }

       

        private void GrdData_Load_1(object sender, EventArgs e)
        {
            //obteniendo todos los registros de la tabla process
            using (var db = new DBA_FilesMaintenaceContext())
            {
                dgvVistaData.DataSource = db.Process.ToList();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int IdProcess = (int)dgvVistaData.Rows[0].Cells[0].Value;

            //Buscar en la base de datos el proceso que se va a ejecutar
            using(var db = new DBA_FilesMaintenaceContext())
            {
                var procesoObtenido = db.Process.Find(IdProcess);
                if(procesoObtenido != null)
                {
                    #region BorradodeArchivos
                    var myDirectory = new DirectoryInfo(procesoObtenido.Path);
                    foreach (var file in myDirectory.GetFiles())
                    {
                        var procesoDetalle = new ProcessDetails
                        {
                            IdProcess = procesoObtenido.IdProcess,
                            FileName = file.Name,
                            Extension = file.Extension,
                            Weight_File = (int)file.Length * 1024,
                            DeleteDate = DateTime.Now
                        };
                        db.ProcessDetails.Add(procesoDetalle);
                        db.SaveChanges();
                        file.Delete();
                        //Actualizar el grid
                        dgvVistaData.DataSource = db.Process.ToList();
                    }
                    #endregion
                    MessageBox.Show("Proceso terminado Correctamente");
                }
                
                
            }
            
        }
    }
}
