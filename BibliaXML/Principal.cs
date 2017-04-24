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
            CarregarDGV(dgvAnotações);
        }

        private void btnEncontrar_Click(object sender, EventArgs e)
        {
            if (txbLivro.Text != "" || txbCapitulo.Text != "" || txbVersiculo.Text != "")
            {
                string livro = txbLivro.Text.Trim();
                string capitulo = txbCapitulo.Text.Trim();
                string versiculo = txbVersiculo.Text.Trim();
                string versiculoEncontrado = Manipuladores.LerArquivoTexto.Lerbiblia(livro, capitulo,versiculo);
                if (versiculoEncontrado != "")
                {
                    
                    if(DialogResult.Yes == ObterResposta("Versiculo Encontrado!! Desejas Comentar?", "Resultado"))
                    {
                        int idUltimoVersiculo = dgvAnotações.RowCount;
                        int idNovaAnotação = idUltimoVersiculo + 1;
                        Resultado resultado = new Resultado(versiculoEncontrado,idNovaAnotação);
                        resultado.ShowDialog();
                        CarregarDGV(dgvAnotações);
                    }
                    else
                    {
                        MessageBox.Show(versiculoEncontrado,"Versiculo");
                    }
                }
                else
                {
                    MessageBox.Show("Versículo não encontrado!!", "Resultado");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!!!", "Erro!");
            }
        }

        private void tbcBiblia_Click(object sender, EventArgs e)
        {
            CarregarDGV(dgvAnotações);
        }

        private void btnExcluirAnotação_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == ObterResposta("Deseja cancelar anotação?", "Confirmação"))
            {
                int linhaSelecionada = dgvAnotações.CurrentRow.Index;              
                linhaSelecionada++; // linha no xml comeca do 1, logo temos q adicionar
                Manipuladores.ManipularXML.DeletarAnotação(linhaSelecionada);
                CarregarDGV(dgvAnotações);
            }
            else
            {
                MessageBox.Show("Cancelando Exclusão","Conclusão");
            }

        }


        private static DialogResult ObterResposta(string mensagem, string titulo)
        {
            DialogResult resposta = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo);
            return resposta;
        }

        private static void CarregarDGV(DataGridView dgvAnotações)
        {
            List<Anotação> anotações = Manipuladores.ManipularXML.LerArquivo();
            dgvAnotações.DataSource = anotações;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == ObterResposta("Desejas Editar?", "Confirmação"))
            {
                int idAnotação = dgvAnotações.CurrentRow.Index;
                idAnotação++; // id no xml é um a mais do que no DGV
                Anotação nota = new Anotação();
                nota.Versiculo = dgvAnotações.CurrentRow.Cells[0].Value.ToString();
                nota.Comentario = dgvAnotações.CurrentRow.Cells[1].Value.ToString();
                Resultado resultado = new Resultado(nota, idAnotação,true);
                resultado.ShowDialog();
                CarregarDGV(dgvAnotações);
            }
        }
    }
}
