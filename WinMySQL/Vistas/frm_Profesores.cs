using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinMySQL.Vistas
{
    public partial class frm_Profesores : Form
    {
        Datos datos = new Datos();
        DataSet ds = new DataSet();
        public frm_Profesores()
        {
            InitializeComponent();
        }

        private void CargarProfesores()
        {
            DataSet ds = datos.ejecutar("SELECT * FROM Profesores");
            if (ds != null && ds.Tables.Count > 0)
            {
                dgv_Profesores.DataSource = ds.Tables[0];
            }
        }

        private void frm_Profesores_Load(object sender, EventArgs e)
        {
            CargarProfesores();
        }





        private void frm_Profesores_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar("SELECT * FROM Profesores");
                if (ds != null)
                {
                    dgv_Profesores.DataSource = ds.Tables[0];
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

        private void dgv_Profesores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_Profesor Profesor = new frm_Profesor(
               Convert.ToInt32(dgv_Profesores.CurrentRow.Cells[0].Value),
                dgv_Profesores.CurrentRow.Cells[1].Value.ToString(),
                dgv_Profesores.CurrentRow.Cells[2].Value.ToString(),
                dgv_Profesores.CurrentRow.Cells[3].Value.ToString(),
                dgv_Profesores.CurrentRow.Cells[4].Value.ToString(),
                dgv_Profesores.CurrentRow.Cells[5].Value.ToString(),
                dgv_Profesores.CurrentRow.Cells[6].Value.ToString());
            Profesor.ShowDialog();
        }



        private void btn_AgregarProfesor_Click(object sender, EventArgs e)
        {
            frm_Profesor profesor = new frm_Profesor();
            profesor.ShowDialog();
            CargarProfesores();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Profesores.CurrentRow != null)
            {
                int idProfesores = Convert.ToInt32(dgv_Profesores.CurrentRow.Cells[0].Value);

                // Confirmación sin el punto y coma al final
                if (MessageBox.Show("¿Deseas eliminar al(a) Profesor(a): " + dgv_Profesores.CurrentRow.Cells[1].Value.ToString(),
                    "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool f = datos.ejecutarComando($"DELETE FROM Profesores WHERE idProfesores={idProfesores}");
                    if (f)
                    {
                        MessageBox.Show("Registro eliminado", "Sistema");
                        CargarProfesores(); // refresca el DataGridView en tiempo de ejecución
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

