using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ViaCep.ViaCepConsulta;

namespace ViaCep
{
    public partial class Frm_ViaCep : Form
    {
        public string logradouro { get; set; }
        public Frm_ViaCep()
        {
            InitializeComponent();
        }

        public void Btn_Click_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        public async void Btn_Click_Consultar_Click(object sender, EventArgs e)
        {
            ViaCepConsulta consulta = new ViaCepConsulta();
            string cepDigitado = Tbx_Cep.Text;

            try
            {
                Endereco endereco = await consulta.ObterEnderecoPorCepAsync(cepDigitado);

                this.Tbx_Rua.Text = endereco.Logradouro;
                this.Tbx_Bairro.Text = endereco.Bairro;
                this.Tbx_Localidade.Text = endereco.Localidade;
                this.Tbx_Uf.Text = endereco.UF;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            this.Tbx_Cep.Text = "";
            this.Tbx_Rua.Text = "";
            this.Tbx_Bairro.Text = "";
            this.Tbx_Localidade.Text = "";
            this.Tbx_Uf.Text = "";
        }

        private void Tbx_Cep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Click_Consultar_Click(sender, e);
            }
        }
    }
}
