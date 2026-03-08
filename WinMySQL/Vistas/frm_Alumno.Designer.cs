namespace WinMySQL.Vistas
{
    partial class frm_Alumno
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
            btn_Aceptar = new Button();
            txt_Nombre = new TextBox();
            label1 = new Label();
            txt_ApellidoM = new TextBox();
            label3 = new Label();
            txt_ApellidoP = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txt_NumControl = new TextBox();
            txt_Carrera = new TextBox();
            label5 = new Label();
            txt_Semestre = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Location = new Point(181, 455);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(112, 34);
            btn_Aceptar.TabIndex = 11;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(12, 46);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(459, 31);
            txt_Nombre.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            // 
            // txt_ApellidoM
            // 
            txt_ApellidoM.Location = new Point(12, 183);
            txt_ApellidoM.Name = "txt_ApellidoM";
            txt_ApellidoM.Size = new Size(459, 31);
            txt_ApellidoM.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 155);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 14;
            label3.Text = "Apellido Materno";
            // 
            // txt_ApellidoP
            // 
            txt_ApellidoP.Location = new Point(12, 113);
            txt_ApellidoP.Name = "txt_ApellidoP";
            txt_ApellidoP.Size = new Size(459, 31);
            txt_ApellidoP.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 85);
            label4.Name = "label4";
            label4.Size = new Size(143, 25);
            label4.TabIndex = 16;
            label4.Text = "Apellido Paterno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 226);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 18;
            label2.Text = "Num. Control";
            // 
            // txt_NumControl
            // 
            txt_NumControl.Location = new Point(12, 254);
            txt_NumControl.Name = "txt_NumControl";
            txt_NumControl.Size = new Size(457, 31);
            txt_NumControl.TabIndex = 19;
            // 
            // txt_Carrera
            // 
            txt_Carrera.Location = new Point(12, 320);
            txt_Carrera.Name = "txt_Carrera";
            txt_Carrera.Size = new Size(457, 31);
            txt_Carrera.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 292);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 20;
            label5.Text = "Carrera";
            // 
            // txt_Semestre
            // 
            txt_Semestre.Location = new Point(12, 391);
            txt_Semestre.Name = "txt_Semestre";
            txt_Semestre.Size = new Size(457, 31);
            txt_Semestre.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 363);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 22;
            label6.Text = "Semestre";
            // 
            // frm_Alumno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 501);
            Controls.Add(txt_Semestre);
            Controls.Add(label6);
            Controls.Add(txt_Carrera);
            Controls.Add(label5);
            Controls.Add(txt_NumControl);
            Controls.Add(label2);
            Controls.Add(txt_ApellidoP);
            Controls.Add(label4);
            Controls.Add(txt_ApellidoM);
            Controls.Add(label3);
            Controls.Add(btn_Aceptar);
            Controls.Add(txt_Nombre);
            Controls.Add(label1);
            Name = "frm_Alumno";
            Text = "Alumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Aceptar;
        private TextBox txt_Nombre;
        private Label label1;
        private TextBox txt_ApellidoM;
        private Label label3;
        private TextBox txt_ApellidoP;
        private Label label4;
        private Label label2;
        private TextBox txt_NumControl;
        private TextBox txt_Carrera;
        private Label label5;
        private TextBox txt_Semestre;
        private Label label6;
    }
}