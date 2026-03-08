namespace WinMySQL.Vistas
{
    partial class frm_Materia
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
            label1 = new Label();
            txt_Materia = new TextBox();
            txt_CVE = new TextBox();
            label2 = new Label();
            btn_Aceptar = new Button();
            txt_Creditos = new TextBox();
            lbl_creditos = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "Materia";
            // 
            // txt_Materia
            // 
            txt_Materia.Location = new Point(12, 37);
            txt_Materia.Name = "txt_Materia";
            txt_Materia.Size = new Size(459, 31);
            txt_Materia.TabIndex = 1;
            // 
            // txt_CVE
            // 
            txt_CVE.Location = new Point(12, 130);
            txt_CVE.Name = "txt_CVE";
            txt_CVE.Size = new Size(192, 31);
            txt_CVE.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 2;
            label2.Text = "CVE Oficial";
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Location = new Point(177, 185);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(112, 34);
            btn_Aceptar.TabIndex = 4;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // txt_Creditos
            // 
            txt_Creditos.Location = new Point(261, 130);
            txt_Creditos.Name = "txt_Creditos";
            txt_Creditos.Size = new Size(210, 31);
            txt_Creditos.TabIndex = 5;
            // 
            // lbl_creditos
            // 
            lbl_creditos.AutoSize = true;
            lbl_creditos.Location = new Point(261, 102);
            lbl_creditos.Name = "lbl_creditos";
            lbl_creditos.Size = new Size(78, 25);
            lbl_creditos.TabIndex = 6;
            lbl_creditos.Text = "Creditos";
            // 
            // frm_Materia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 244);
            Controls.Add(lbl_creditos);
            Controls.Add(txt_Creditos);
            Controls.Add(btn_Aceptar);
            Controls.Add(txt_CVE);
            Controls.Add(label2);
            Controls.Add(txt_Materia);
            Controls.Add(label1);
            Name = "frm_Materia";
            Text = "Materia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Materia;
        private TextBox txt_CVE;
        private Label label2;
        private Button btn_Aceptar;
        private TextBox txt_Creditos;
        private Label lbl_creditos;
    }
}