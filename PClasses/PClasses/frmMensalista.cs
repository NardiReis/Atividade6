using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RbtnHnao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnInstanciarMensalista_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();
            //set
            objMensalista.Matricula = Convert.ToInt32(txtmatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalario.Text);
            if (rbtnHsim.Checked)
                objMensalista.HomeOffice = 'S';
            else
                objMensalista.HomeOffice = 'N';


            //get
            MessageBox.Show("Matricula: " + objMensalista.Matricula + '\n' +
                "Nome: " + objMensalista.NomeEmpregado + '\n' + 
                "Data Entrada: " +
                objMensalista.DataEntradaEmpresa.ToShortDateString() +
                "\n"+ "Salario Bruto" +
                objMensalista.SalarioBruto().ToString("N2") +
                "\n" + "Tempo Empresa (dias): " +
                objMensalista.TempoTrabalho() +
                "\n" + objMensalista.VerificaHome());





        }
    }
}
