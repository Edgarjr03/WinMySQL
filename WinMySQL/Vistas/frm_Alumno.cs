using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinMySQL.Vistas
{
    public partial class frm_Alumno : Form
    {
        int id = 0;
        bool updating = false;
        Datos dt = new Datos();
        public frm_Alumno()
        {
            InitializeComponent();
        }

        public frm_Alumno(int id, string nombre, string apellidoP, string apellidoM, int NumControl, string carrera, int Semestre)
        {
            InitializeComponent();
            this.id = id;
            txt_Nombre.Text = nombre;
            txt_ApellidoP.Text = apellidoP;
            txt_ApellidoM.Text = apellidoM;
            txt_NumControl.Text = NumControl.ToString();
            txt_Carrera.Text = carrera;
            txt_Semestre.Text = Semestre.ToString();
            updating = true;
        }
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (!updating)
            {

                bool resultado = dt.ejecutarComando($"INSERT INTO Alumnos (Nombre, ApellidoP, ApellidoM, NumControl, Carrera, Semestre)" +
           $" VALUES ('{txt_Nombre.Text}','{txt_ApellidoP.Text}','{txt_ApellidoM.Text}','{txt_NumControl.Text}','{txt_Carrera.Text}','{txt_Semestre.Text}')");
                if (resultado)
                {
                    MessageBox.Show("Alumn@ agregad@ correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar al(a) alumn@.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                bool resultado = dt.ejecutarComando($"UPDATE Alumnos SET Nombre='{txt_Nombre.Text}', ApellidoP='{txt_ApellidoP.Text}', " +
                    $"ApellidoM='{txt_ApellidoM.Text}', NumControl='{txt_NumControl}', Carrera='{txt_Carrera}', Semestre='{txt_Semestre}' WHERE idAlumnos={id}");
                if (resultado)
                {
                    MessageBox.Show("Alumn@ actualizad@ correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Error al actualizar al(a) Alumn@.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

        