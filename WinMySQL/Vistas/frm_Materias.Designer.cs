namespace WinMySQL.Vistas
{
    partial class frm_Materias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            txt_Materia = new TextBox();
            dgv_Materias = new DataGridView();
            btn_AgregarMateria = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Materias).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btn_AgregarMateria);
            splitContainer1.Panel1.Controls.Add(txt_Materia);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgv_Materias);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 127;
            splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Buscar";
            // 
            // txt_Materia
            // 
            txt_Materia.Location = new Point(12, 37);
            txt_Materia.Name = "txt_Materia";
            txt_Materia.Size = new Size(627, 31);
            txt_Materia.TabIndex = 1;
            // 
            // dgv_Materias
            // 
            dgv_Materias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Materias.Dock = DockStyle.Fill;
            dgv_Materias.Location = new Point(0, 0);
            dgv_Materias.Name = "dgv_Materias";
            dgv_Materias.RowHeadersWidth = 62;
            dgv_Materias.Size = new Size(800, 319);
            dgv_Materias.TabIndex = 1;
            // 
            // btn_AgregarMateria
            // 
            btn_AgregarMateria.Location = new Point(666, 37);
            btn_AgregarMateria.Name = "btn_AgregarMateria";
            btn_AgregarMateria.Size = new Size(112, 34);
            btn_AgregarMateria.TabIndex = 2;
            btn_AgregarMateria.Text = "Agregar";
            btn_AgregarMateria.UseVisualStyleBackColor = true;
            // 
            // frm_Materias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "frm_Materias";
            Text = "Materias";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Materias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txt_Materia;
        private Label label1;
        private Button btn_AgregarMateria;
        private DataGridView dgv_Materias;
    }
}