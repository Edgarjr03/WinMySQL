using WinMySQL.Vistas;

namespace WinMySQL
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Materias Materias = new frm_Materias();
            Materias.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Alumnos Alumnos = new frm_Alumnos();
            Alumnos.ShowDialog();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Profesores Profesores = new frm_Profesores();
            Profesores.ShowDialog();
        }
    }
}
