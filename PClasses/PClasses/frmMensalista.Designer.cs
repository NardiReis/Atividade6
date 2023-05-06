namespace PClasses
{
    partial class frmMensalista
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
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.gbxHome = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.rbtnHsim = new System.Windows.Forms.RadioButton();
            this.rbtnHnao = new System.Windows.Forms.RadioButton();
            this.btnInstanciarMensalista = new System.Windows.Forms.Button();
            this.btnInstanciarPara = new System.Windows.Forms.Button();
            this.gbxHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(206, 34);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(250, 20);
            this.txtmatricula.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(206, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(250, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(206, 121);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(250, 20);
            this.txtData.TabIndex = 2;
            // 
            // gbxHome
            // 
            this.gbxHome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gbxHome.Controls.Add(this.rbtnHnao);
            this.gbxHome.Controls.Add(this.rbtnHsim);
            this.gbxHome.Location = new System.Drawing.Point(536, 57);
            this.gbxHome.Name = "gbxHome";
            this.gbxHome.Size = new System.Drawing.Size(235, 141);
            this.gbxHome.TabIndex = 3;
            this.gbxHome.TabStop = false;
            this.gbxHome.Text = "Trabalha em Home office";
            this.gbxHome.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome Empregado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salario Mensal";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(206, 178);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(250, 20);
            this.txtSalario.TabIndex = 8;
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
            this.rbtnHnao.CheckedChanged += new System.EventHandler(this.RbtnHnao_CheckedChanged);
            // 
            // btnInstanciarMensalista
            // 
            this.btnInstanciarMensalista.Location = new System.Drawing.Point(101, 279);
            this.btnInstanciarMensalista.Name = "btnInstanciarMensalista";
            this.btnInstanciarMensalista.Size = new System.Drawing.Size(200, 85);
            this.btnInstanciarMensalista.TabIndex = 9;
            this.btnInstanciarMensalista.Text = "Instanciar Mensalista";
            this.btnInstanciarMensalista.UseVisualStyleBackColor = true;
            this.btnInstanciarMensalista.Click += new System.EventHandler(this.BtnInstanciarMensalista_Click);
            // 
            // btnInstanciarPara
            // 
            this.btnInstanciarPara.Location = new System.Drawing.Point(475, 279);
            this.btnInstanciarPara.Name = "btnInstanciarPara";
            this.btnInstanciarPara.Size = new System.Drawing.Size(198, 85);
            this.btnInstanciarPara.TabIndex = 10;
            this.btnInstanciarPara.Text = "Instanciar Mensalista passando parâmetro";
            this.btnInstanciarPara.UseVisualStyleBackColor = true;
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInstanciarPara);
            this.Controls.Add(this.btnInstanciarMensalista);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxHome);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtmatricula);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.gbxHome.ResumeLayout(false);
            this.gbxHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.GroupBox gbxHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.RadioButton rbtnHnao;
        private System.Windows.Forms.RadioButton rbtnHsim;
        private System.Windows.Forms.Button btnInstanciarMensalista;
        private System.Windows.Forms.Button btnInstanciarPara;
    }
}