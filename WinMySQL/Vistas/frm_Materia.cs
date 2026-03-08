using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WinMySQL.Vistas;



namespace WinMySQL.Vistas
{
    public partial class frm_Materia : Form
    {
        int id = 0;
        bool updating = false;
        Datos dt = new Datos();
        public frm_Materia()
        {
            InitializeComponent();
        }

        public frm_Materia(int id, string materia, string cve, int creditos)
        {
            InitializeComponent();
            this.id = id;
            txt_Materia.Text = materia;
            txt_CVE.Text = cve;
            lbl_creditos.Text = creditos.ToString();
            updating = true;
        }

        


        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (!updating)
            {
               
                bool resultado = dt.ejecutarComando($"INSERT INTO Materias (Materia, Clave, Creditos)" +
           $" VALUES ('{txt_Materia.Text}','{txt_CVE.Text}','{txt_Creditos.Text}')");
                if (resultado)
                {
                    MessageBox.Show("Materia agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar la materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                

                bool resultado = dt.ejecutarComando($"UPDATE Materias SET Materia='{txt_Materia.Text}', Clave='{txt_CVE.Text}', Creditos='{txt_Creditos.Text}' WHERE idMaterias={id}");
                if (resultado)
                {
                    MessageBox.Show("Materia actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Error al actualizar la materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
