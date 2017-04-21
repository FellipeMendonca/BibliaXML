using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliaXML
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnEncontrar_Click(object sender, EventArgs e)
        {
            if (txbLivro.Text != "" || txbCapitulo.Text != "" || txbVersiculo.Text != "")
            {
                string versiculoEncontrado = Manipuladores.LerArquivoTexto.Lerbiblia(txbLivro.Text, txbCapitulo.Text, txbVersiculo.Text);
                /*if (versiculoEncontrado != "")
                {
                    MessageBox.Show(versiculoEncontrado, "Resultado");
                }
                else
                {
                    MessageBox.Show("Versículo não encontrado!!", "Resultado");
                }*/
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!!!", "Erro!");
            }
        }

        private void tbcBiblia_Click(object sender, EventArgs e)
        {
            List<Anotação> anotações = Manipuladores.ManipularXML.LerArquivo();
            dgvAnotações.DataSource = anotações;
        }
    }
}
