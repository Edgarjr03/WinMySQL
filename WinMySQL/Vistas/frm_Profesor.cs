using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinMySQL.Vistas
{
    public partial class frm_Profesor : Form
    {
        int id =0;
        bool updating = false;
        Datos dt = new Datos();
        public frm_Profesor()
        {
            InitializeComponent();
        }

        public frm_Profesor(int id, string Nombre, string ApellidoP, string ApellidoM, string Telefono, string Materia, string Horario)
        {
            InitializeComponent();
            this.id = id;
            txt_Nombre.Text = Nombre;
            txt_ApellidoP.Text = ApellidoP;
            txt_ApellidoM.Text = ApellidoM;
            txt_Telefono.Text = Telefono;
            txt_Materia.Text = Materia;
            txt_Horario.Text = Horario;
            updating = true;
        }
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (!updating)
            {

                bool resultado = dt.ejecutarComando($"INSERT INTO Profesores (Nombre, ApellidoP, ApellidoM, Telefono, Materia, Horario)" +
           $" VALUES ('{txt_Nombre.Text}','{txt_ApellidoP.Text}','{txt_ApellidoM.Text}','{txt_Telefono.Text}','{txt_Materia.Text}','{txt_Horario.Text}')");
                if (resultado)
                {
                    MessageBox.Show("Profesor(a) agregad@ correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar al(a) profesor(a).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                

                bool resultado = dt.ejecutarComando($"UPDATE Profesores SET Nombre='{txt_Nombre.Text}', ApellidoP='{txt_ApellidoP.Text}', ApellidoM='{txt_ApellidoM.Text}' " +
                    $",Telefono='{txt_Telefono}', Materia='{txt_Materia}', Horario='{txt_Horario}' WHERE idProfesores={id}");
                if (resultado)
                {
                    MessageBox.Show("profesor(a) actualizad@ correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Error al actualizar al(a) profesor(a).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
