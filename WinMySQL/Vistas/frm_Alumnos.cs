using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OfficeOpenXml;

namespace WinMySQL.Vistas
{
    public partial class frm_Alumnos : Form
    {
        Datos datos = new Datos();
        DataSet ds = new DataSet();


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

        private void button1_Click(object sender, EventArgs e)
        {
            string path;
            DialogResult dr = ofd_Excel.ShowDialog();
            {
                if (dr == DialogResult.OK)
                {
                    path = ofd_Excel.FileName;
                    ExcelPackage.License.SetNonCommercialPersonal("Edgar");
                    using (var package = new ExcelPackage(new FileInfo(path)))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                        int rowCount = worksheet.Dimension.Rows;
                        int colCount = worksheet.Dimension.Columns;
                        DataTable dt = new DataTable();
                        for (int col = 1; col <= colCount; col++)
                        {
                            dt.Columns.Add(worksheet.Cells[1, col].Value.ToString());
                        }
                        for (int row = 2; row <= rowCount; row++)
                        {
                            DataRow drNew = dt.NewRow();
                            for (int col = 1; col <= colCount; col++)
                            {
                                drNew[col - 1] = worksheet.Cells[row, col].Value.ToString();
                            }
                            dt.Rows.Add(drNew);
                            string comando = $"INSERT INTO Alumnos (Nombre, ApellidoP, ApellidoM, NumControl, Carrera, Semestre) " +
                                          $"VALUES ('{drNew.ItemArray[0]}','{drNew.ItemArray[1]}','{drNew.ItemArray[2]}','{drNew.ItemArray[3]}','{drNew.ItemArray[4]}','{drNew.ItemArray[5]}')";
                            datos.ejecutarComando(comando);
                        }
                        dgv_Alumnos.DataSource = dt;
                    }
                }
            }
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            CargarAlumnos();
        }
    }
}
