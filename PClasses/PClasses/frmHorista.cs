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
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void BtnInstanciarHorista_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();
            //set
            objHorista.Matricula = Convert.ToInt32(txtmatricula.Text);
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.SalarioHora = Convert.ToDouble(txtSalarioHora.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtNumHora.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtDiasfalta.Text);
            if (rbtnHsim.Checked)
                objHorista.HomeOffice = 'S';
            else
                objHorista.HomeOffice = 'N';


            //get
            MessageBox.Show("Matricula: " + objHorista.Matricula + '\n' +
                "Nome: " + objHorista.NomeEmpregado + '\n' +
                "Data Entrada: " +
                objHorista.DataEntradaEmpresa.ToShortDateString() +
                "\n" + "Salario Bruto" +
                objHorista.SalarioBruto().ToString("N2") +
                "\n" + "Tempo Empresa (dias): " +
                objHorista.TempoTrabalho() +
                "\n" + objHorista.VerificaHome());
        }
    }
}
