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
    public partial class Resultado : Form
    {
        private static int idVersiculo;
        private static bool VeioEdição;
        public Resultado()
        {
            InitializeComponent();
        }
        public Resultado(string versiculo, int id)
        {
            InitializeComponent();
            txbVersiculo.Text = versiculo;
            idVersiculo = id;
        }

        public Resultado(Anotação nota, int id, bool isEdição)
        {
            InitializeComponent();
            idVersiculo = id;
            txbVersiculo.Text = nota.Versiculo;
            txbComentario.Text = nota.Comentario;
            VeioEdição = isEdição;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txbComentario.Text != "")
            {
                Anotação anotacao = new Anotação();
                anotacao.Versiculo = txbVersiculo.Text;
                anotacao.Comentario = txbComentario.Text;
                if (VeioEdição)
                {
                    Manipuladores.ManipularXML.EditarAnotação(idVersiculo,anotacao);
                }
                else
                {
                    Manipuladores.ManipularXML.AdicionarAnotação(idVersiculo, anotacao);
                }
                MessageBox.Show("Anotação Salva!", "Conclusão");
                Close();
            }
            else
            {
                MessageBox.Show("Insira um comentário!!!", "Erro");
            }
        }
    }
}
