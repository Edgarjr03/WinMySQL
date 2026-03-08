namespace WinMySQL.Vistas
{
    partial class frm_Alumnos
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
            btn_Agregar = new Button();
            label1 = new Label();
            txt_Buscar = new TextBox();
            dgv_Alumnos = new DataGridView();
            cms_Data = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Alumnos).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(btn_Agregar);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(txt_Buscar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgv_Alumnos);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 124;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(676, 42);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(112, 34);
            btn_Agregar.TabIndex = 2;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 1;
            label1.Text = "Buscar";
            // 
            // txt_Buscar
            // 
            txt_Buscar.Location = new Point(12, 45);
            txt_Buscar.Name = "txt_Buscar";
            txt_Buscar.Size = new Size(640, 31);
            txt_Buscar.TabIndex = 0;
            // 
            // dgv_Alumnos
            // 
            dgv_Alumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Alumnos.ContextMenuStrip = cms_Data;
            dgv_Alumnos.Dock = DockStyle.Fill;
            dgv_Alumnos.Location = new Point(0, 0);
            dgv_Alumnos.Name = "dgv_Alumnos";
            dgv_Alumnos.RowHeadersWidth = 62;
            dgv_Alumnos.Size = new Size(800, 322);
            dgv_Alumnos.TabIndex = 0;
            dgv_Alumnos.CellContentDoubleClick += dgv_Alumnos_CellContentDoubleClick;
            // 
            // cms_Data
            // 
            cms_Data.ImageScalingSize = new Size(24, 24);
            cms_Data.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem });
            cms_Data.Name = "cms_Data";
            cms_Data.Size = new Size(147, 36);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(146, 32);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // frm_Alumnos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "frm_Alumnos";
            Text = "Alumnos";
            Load += frm_Alumnos_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Alumnos).EndInit();
            cms_Data.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txt_Buscar;
        private Label label1;
        private Button btn_Agregar;
        private DataGridView dgv_Alumnos;
        private ContextMenuStrip cms_Data;
        private ToolStripMenuItem eliminarToolStripMenuItem;
    }
}