using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FiscalBr.Common;
using FiscalBr.MotorTributario;

namespace FiscalBr.App
{
    public partial class frmMotorTributario : Form
    {
        public frmMotorTributario()
        {
            InitializeComponent();


        }

        private void btnBackTo_Click(object sender, EventArgs e)
        {
            MdiHelper.MdiContainer.NovaInstanciaChildren(typeof (frmHome));
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtToken.Text) || string.IsNullOrWhiteSpace(txtToken.Text))
            {
                MessageBox.Show("Token não informado!");
                return;
            }

            if (string.IsNullOrEmpty(txtCnpj.Text) || string.IsNullOrWhiteSpace(txtCnpj.Text))
            {
                MessageBox.Show("CNPJ não informado!");
                return;
            }

            if (string.IsNullOrEmpty(txtUf.Text) || string.IsNullOrWhiteSpace(txtUf.Text))
            {
                MessageBox.Show("UF não informada!");
                return;
            }

            if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Código não informado!");
                return;
            }

            TributacaoMediaIbpt.TipoConsulta tipoConsulta;

            if (radioButtonProduto.Checked)
                tipoConsulta = TributacaoMediaIbpt.TipoConsulta.Produto;
            else
                tipoConsulta = TributacaoMediaIbpt.TipoConsulta.Servico;

            var resultado = FiscalBr.MotorTributario.TributacaoMediaIbpt.ObterJsonResposta(txtToken.Text, txtCnpj.Text,
                txtCodigo.Text, txtUf.Text, 0, tipoConsulta);

            txtResult.Text = resultado.ToString();
        }
    }
}
