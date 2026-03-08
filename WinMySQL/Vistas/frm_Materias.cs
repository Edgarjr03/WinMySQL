using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using WinMySQL.Vistas;

namespace WinMySQL.Vistas
{
    public partial class frm_Materias : Form
    {
        Datos datos = new Datos();
        DataSet ds = new DataSet();
        public frm_Materias()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargarMaterias()
        {
            DataSet ds = datos.ejecutar("SELECT * FROM Materias");
            if (ds != null && ds.Tables.Count > 0)
            {
                dgv_Materias.DataSource = ds.Tables[0];
            }
        }

        private void frm_Materias_Load(object sender, EventArgs e)
        {
            CargarMaterias();
        }



        private void btn_AgregarMateria_Click(object sender, EventArgs e)
        {
            frm_Materia materia = new frm_Materia();
            materia.ShowDialog();
            CargarMaterias();
        }

        private void frm_Materias_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar("SELECT * FROM Materias");
                if (ds != null)
                {
                    dgv_Materias.DataSource = ds.Tables[0];
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

        private void dgv_Materias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_Materia Materia = new frm_Materia(
               Convert.ToInt32(dgv_Materias.CurrentRow.Cells[0].Value),
                dgv_Materias.CurrentRow.Cells[1].Value.ToString(),
                dgv_Materias.CurrentRow.Cells[2].Value.ToString(),
                Convert.ToInt32(dgv_Materias.CurrentRow.Cells[3].Value));
            Materia.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Materias.CurrentRow != null)
            {
                int idMaterias = Convert.ToInt32(dgv_Materias.CurrentRow.Cells[0].Value);

                // Confirmación sin el punto y coma al final
                if (MessageBox.Show("¿Deseas eliminar la materia: " + dgv_Materias.CurrentRow.Cells[1].Value.ToString(),
                    "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool f = datos.ejecutarComando($"DELETE FROM Materias WHERE idMaterias={idMaterias}");
                    if (f)
                    {
                        MessageBox.Show("Registro eliminado", "Sistema");
                        CargarMaterias(); // refresca el DataGridView en tiempo de ejecución
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar", "Sistema");
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
