using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliaXML.Manipuladores
{
    class LerArquivoTexto
    {
        private static string caminhoTexto = @"C:\Users\Natsu\Documents\Visual Studio 2015\Projects\BibliaXML\BibliaXML\bin\Debug\Biblia.txt";

        public static string Lerbiblia(string livro, string capitulo, string versiculo)
        {
            // Para validar melhor necessário colocar em CaixaAlta!!
            string livroUpper = livro.ToUpper();
            string capituloUpper = livroUpper + " [" + capitulo + "]";
            // Arrumar metodo de leitura!!
            string versiculoEncontrado = "";
            bool acheiLivro = false;
            bool acheiCapitulo = false;
            bool acheiVersiculo = false;
            if (File.Exists(caminhoTexto))
            {
                using (StreamReader leitor = File.OpenText(caminhoTexto))
                {
                    while (leitor.Peek() >= 0)
                    {
                        string frase = leitor.ReadLine();
                        if (frase != "")
                        {
                            if (frase.ToUpper() == livroUpper)
                            {
                                acheiLivro = true;
                                versiculoEncontrado += frase + "-";
                            }
                            else if (frase.ToUpper() == capituloUpper && acheiLivro)
                            {
                                acheiCapitulo = true;
                                versiculoEncontrado += frase + "-";
                            }
                            else if (frase.Contains(versiculo) && acheiLivro && acheiCapitulo)
                            {
                                acheiVersiculo = true;
                                versiculoEncontrado += frase;
                            }
                            if (acheiLivro && acheiCapitulo && acheiVersiculo)
                            {
                                return versiculoEncontrado;
                            }
                        }
                    }
                }
            }

            return versiculoEncontrado;

        }
    }
}
