using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinMySQL.Vistas
{
    public partial class frm_Alumnos : Form
    {
        Datos datos = new Datos();
        DataSet ds = new DataSet();
        private int v1;
        private string? v2;
        private string? v3;
        private string? v4;
        private int v5;
        private string? v6;
        private int v7;

        public frm_Alumnos()
        {
            InitializeComponent();
        }

       

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void CargarAlumnos()
        {
            DataSet ds = datos.ejecutar("SELECT * FROM Alumnos");
            if (ds != null && ds.Tables.Count > 0)
            {
                dgv_Alumnos.DataSource = ds.Tables[0];
            }
        }

        private void frm_Alumnos_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            frm_Alumno alumno = new frm_Alumno();
            alumno.ShowDialog();
            CargarAlumnos();  
        }

        private void frm_Alumnos_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar("SELECT * FROM Alumnos");
                if (ds != null)
                {
                    dgv_Alumnos.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Alumnos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_Alumno Alumno = new frm_Alumno(
              Convert.ToInt32(dgv_Alumnos.CurrentRow.Cells[0].Value),
               dgv_Alumnos.CurrentRow.Cells[1].Value.ToString(),
               dgv_Alumnos.CurrentRow.Cells[2].Value.ToString(),
               dgv_Alumnos.CurrentRow.Cells[3].Value.ToString(),
               Convert.ToInt32(dgv_Alumnos.CurrentRow.Cells[4].Value),
               dgv_Alumnos.CurrentRow.Cells[5].Value.ToString(),
               Convert.ToInt32(dgv_Alumnos.CurrentRow.Cells[6].Value));
            Alumno.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Alumnos.CurrentRow != null)
            {
                int idAlumnos = Convert.ToInt32(dgv_Alumnos.CurrentRow.Cells[0].Value);

                // Confirmación sin el punto y coma al final
                if (MessageBox.Show("¿Deseas eliminar al@ alumn@: " + dgv_Alumnos.CurrentRow.Cells[1].Value.ToString(),
                    "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool f = datos.ejecutarComando($"DELETE FROM Alumnos WHERE idAlumnos={idAlumnos}");
                    if (f)
                    {
                        MessageBox.Show("Registro eliminado", "Sistema");
                        CargarAlumnos(); // refresca el DataGridView en tiempo de ejecución
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar", "Sistema");
                    }
                }
            }
        }
    }
}
