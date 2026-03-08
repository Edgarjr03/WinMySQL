namespace WinMySQL.Vistas
{
    partial class frm_Profesores
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            btn_AgregarProfesor = new Button();
            txt_Profesor = new TextBox();
            label1 = new Label();
            dgv_Profesores = new DataGridView();
            cms_Data = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Profesores).BeginInit();
            cms_Data.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(btn_AgregarProfesor);
            splitContainer1.Panel1.Controls.Add(txt_Profesor);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgv_Profesores);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 120;
            splitContainer1.TabIndex = 1;
            // 
            // btn_AgregarProfesor
            // 
            btn_AgregarProfesor.Location = new Point(666, 39);
            btn_AgregarProfesor.Name = "btn_AgregarProfesor";
            btn_AgregarProfesor.Size = new Size(112, 34);
            btn_AgregarProfesor.TabIndex = 5;
            btn_AgregarProfesor.Text = "Agregar";
            btn_AgregarProfesor.UseVisualStyleBackColor = true;
            btn_AgregarProfesor.Click += btn_AgregarProfesor_Click;
            // 
            // txt_Profesor
            // 
            txt_Profesor.Location = new Point(12, 39);
            txt_Profesor.Name = "txt_Profesor";
            txt_Profesor.Size = new Size(627, 31);
            txt_Profesor.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 3;
            label1.Text = "Buscar";
            // 
            // dgv_Profesores
            // 
            dgv_Profesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Profesores.ContextMenuStrip = cms_Data;
            dgv_Profesores.Dock = DockStyle.Fill;
            dgv_Profesores.Location = new Point(0, 0);
            dgv_Profesores.Name = "dgv_Profesores";
            dgv_Profesores.RowHeadersWidth = 62;
            dgv_Profesores.Size = new Size(800, 326);
            dgv_Profesores.TabIndex = 0;
            dgv_Profesores.CellContentDoubleClick += dgv_Profesores_CellContentDoubleClick;
            // 
            // cms_Data
            // 
            cms_Data.ImageScalingSize = new Size(24, 24);
            cms_Data.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem });
            cms_Data.Name = "cms_Data";
            cms_Data.Size = new Size(241, 69);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(240, 32);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // frm_Profesores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = cms_Data;
            Controls.Add(splitContainer1);
            Name = "frm_Profesores";
            Text = "Profesores";
            Load += frm_Profesores_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Profesores).EndInit();
            cms_Data.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btn_AgregarProfesor;
        private TextBox txt_Profesor;
        private Label label1;
        private DataGridView dgv_Profesores;
        private ContextMenuStrip cms_Data;
        private ToolStripMenuItem eliminarToolStripMenuItem;
    }
}