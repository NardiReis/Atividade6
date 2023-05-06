namespace PClasses
{
    partial class frmHorista
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
            this.btnInstanciarHorista = new System.Windows.Forms.Button();
            this.txtSalarioHora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxHome = new System.Windows.Forms.GroupBox();
            this.rbtnHnao = new System.Windows.Forms.RadioButton();
            this.rbtnHsim = new System.Windows.Forms.RadioButton();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumHora = new System.Windows.Forms.TextBox();
            this.txtDiasfalta = new System.Windows.Forms.TextBox();
            this.gbxHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInstanciarHorista
            // 
            this.btnInstanciarHorista.Location = new System.Drawing.Point(287, 325);
            this.btnInstanciarHorista.Name = "btnInstanciarHorista";
            this.btnInstanciarHorista.Size = new System.Drawing.Size(200, 85);
            this.btnInstanciarHorista.TabIndex = 20;
            this.btnInstanciarHorista.Text = "Instanciar Horista";
            this.btnInstanciarHorista.UseVisualStyleBackColor = true;
            this.btnInstanciarHorista.Click += new System.EventHandler(this.BtnInstanciarHorista_Click);
            // 
            // txtSalarioHora
            // 
            this.txtSalarioHora.Location = new System.Drawing.Point(192, 188);
            this.txtSalarioHora.Name = "txtSalarioHora";
            this.txtSalarioHora.Size = new System.Drawing.Size(250, 20);
            this.txtSalarioHora.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Salario Hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Data entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome Empregado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Matricula";
            // 
            // gbxHome
            // 
            this.gbxHome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gbxHome.Controls.Add(this.rbtnHnao);
            this.gbxHome.Controls.Add(this.rbtnHsim);
            this.gbxHome.Location = new System.Drawing.Point(524, 67);
            this.gbxHome.Name = "gbxHome";
            this.gbxHome.Size = new System.Drawing.Size(235, 141);
            this.gbxHome.TabIndex = 14;
            this.gbxHome.TabStop = false;
            this.gbxHome.Text = "Trabalha em Home office";
            // 
            // rbtnHnao
            // 
            this.rbtnHnao.AutoSize = true;
            this.rbtnHnao.Location = new System.Drawing.Point(20, 71);
            this.rbtnHnao.Name = "rbtnHnao";
            this.rbtnHnao.Size = new System.Drawing.Size(45, 17);
            this.rbtnHnao.TabIndex = 1;
            this.rbtnHnao.TabStop = true;
            this.rbtnHnao.Text = "Não";
            this.rbtnHnao.UseVisualStyleBackColor = true;
            // 
            // rbtnHsim
            // 
            this.rbtnHsim.AutoSize = true;
            this.rbtnHsim.Location = new System.Drawing.Point(20, 48);
            this.rbtnHsim.Name = "rbtnHsim";
            this.rbtnHsim.Size = new System.Drawing.Size(42, 17);
            this.rbtnHsim.TabIndex = 0;
            this.rbtnHsim.TabStop = true;
            this.rbtnHsim.Text = "Sim";
            this.rbtnHsim.UseVisualStyleBackColor = true;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(192, 147);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(250, 20);
            this.txtData.TabIndex = 13;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(192, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(250, 20);
            this.txtNome.TabIndex = 12;
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(192, 60);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(250, 20);
            this.txtmatricula.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Numero Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Dias de falta";
            // 
            // txtNumHora
            // 
            this.txtNumHora.Location = new System.Drawing.Point(192, 225);
            this.txtNumHora.Name = "txtNumHora";
            this.txtNumHora.Size = new System.Drawing.Size(250, 20);
            this.txtNumHora.TabIndex = 24;
            // 
            // txtDiasfalta
            // 
            this.txtDiasfalta.Location = new System.Drawing.Point(192, 262);
            this.txtDiasfalta.Name = "txtDiasfalta";
            this.txtDiasfalta.Size = new System.Drawing.Size(250, 20);
            this.txtDiasfalta.TabIndex = 25;
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDiasfalta);
            this.Controls.Add(this.txtNumHora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInstanciarHorista);
            this.Controls.Add(this.txtSalarioHora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxHome);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtmatricula);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.gbxHome.ResumeLayout(false);
            this.gbxHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInstanciarHorista;
        private System.Windows.Forms.TextBox txtSalarioHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxHome;
        private System.Windows.Forms.RadioButton rbtnHnao;
        private System.Windows.Forms.RadioButton rbtnHsim;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumHora;
        private System.Windows.Forms.TextBox txtDiasfalta;
    }
}