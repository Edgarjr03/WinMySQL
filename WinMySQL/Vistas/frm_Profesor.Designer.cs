namespace WinMySQL.Vistas
{
    partial class frm_Profesor
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
            txt_ApellidoP = new TextBox();
            label4 = new Label();
            txt_ApellidoM = new TextBox();
            label3 = new Label();
            txt_Nombre = new TextBox();
            label1 = new Label();
            txt_Telefono = new TextBox();
            label2 = new Label();
            txt_Materia = new TextBox();
            label5 = new Label();
            txt_Horario = new TextBox();
            label6 = new Label();
            btn_Aceptar = new Button();
            SuspendLayout();
            // 
            // txt_ApellidoP
            // 
            txt_ApellidoP.Location = new Point(12, 103);
            txt_ApellidoP.Name = "txt_ApellidoP";
            txt_ApellidoP.Size = new Size(459, 31);
            txt_ApellidoP.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 75);
            label4.Name = "label4";
            label4.Size = new Size(143, 25);
            label4.TabIndex = 22;
            label4.Text = "Apellido Paterno";
            // 
            // txt_ApellidoM
            // 
            txt_ApellidoM.Location = new Point(12, 173);
            txt_ApellidoM.Name = "txt_ApellidoM";
            txt_ApellidoM.Size = new Size(459, 31);
            txt_ApellidoM.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 145);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 20;
            label3.Text = "Apellido Materno";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(12, 36);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(459, 31);
            txt_Nombre.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 18;
            label1.Text = "Nombre";
            // 
            // txt_Telefono
            // 
            txt_Telefono.Location = new Point(12, 246);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(459, 31);
            txt_Telefono.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 218);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 24;
            label2.Text = "Telefono";
            // 
            // txt_Materia
            // 
            txt_Materia.Location = new Point(12, 318);
            txt_Materia.Name = "txt_Materia";
            txt_Materia.Size = new Size(459, 31);
            txt_Materia.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 290);
            label5.Name = "label5";
            label5.Size = new Size(71, 25);
            label5.TabIndex = 26;
            label5.Text = "Materia";
            // 
            // txt_Horario
            // 
            txt_Horario.Location = new Point(12, 388);
            txt_Horario.Name = "txt_Horario";
            txt_Horario.Size = new Size(459, 31);
            txt_Horario.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 360);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 28;
            label6.Text = "Horario";
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Location = new Point(182, 438);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(112, 34);
            btn_Aceptar.TabIndex = 30;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // frm_Profesor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 494);
            Controls.Add(btn_Aceptar);
            Controls.Add(txt_Horario);
            Controls.Add(label6);
            Controls.Add(txt_Materia);
            Controls.Add(label5);
            Controls.Add(txt_Telefono);
            Controls.Add(label2);
            Controls.Add(txt_ApellidoP);
            Controls.Add(label4);
            Controls.Add(txt_ApellidoM);
            Controls.Add(label3);
            Controls.Add(txt_Nombre);
            Controls.Add(label1);
            Name = "frm_Profesor";
            Text = "Profesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_ApellidoP;
        private Label label4;
        private TextBox txt_ApellidoM;
        private Label label3;
        private TextBox txt_Nombre;
        private Label label1;
        private TextBox txt_Telefono;
        private Label label2;
        private TextBox txt_Materia;
        private Label label5;
        private TextBox txt_Horario;
        private Label label6;
        private Button btn_Aceptar;
    }
}