using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BibliaXML.Manipuladores
{
    class ManipularXML
    {
        private static string caminhoXml = @"C:\Users\Natsu\Documents\Visual Studio 2015\Projects\BibliaXML\BibliaXML\AnotaçõesBiblia.xml";
        public static void AdicionarAnotação(int id, Anotação nota)
        {
            XmlDocument documentoXML = new XmlDocument();
            documentoXML.Load(caminhoXml);

            XmlAttribute atributoID = documentoXML.CreateAttribute("id");
            atributoID.Value = id.ToString();

            XmlAttribute atribuloVersiculo = documentoXML.CreateAttribute("versiculo");
            atribuloVersiculo.Value = nota.Versiculo;

            XmlAttribute atributoComentario = documentoXML.CreateAttribute("comentario");
            atributoComentario.Value = nota.Comentario;

            XmlNode novaAnotação = documentoXML.CreateElement("anotação");
            novaAnotação.Attributes.Append(atributoID);
            novaAnotação.Attributes.Append(atribuloVersiculo);
            novaAnotação.Attributes.Append(atributoComentario);

            XmlNode anotações = documentoXML.SelectSingleNode("/biblioteca/anotações");
            anotações.AppendChild(novaAnotação);

            documentoXML.Save(caminhoXml);

        }

        public static List<Anotação> LerArquivo()
        {
            List<Anotação> listaAnotações = new List<Anotação>();
            XmlDocument documentoXML = new XmlDocument();
            documentoXML.Load(caminhoXml);
            XmlNodeList anotações = documentoXML.SelectNodes("/biblioteca/anotacoes/anotacao");
            foreach (XmlNode anotação in anotações)
            {
                Anotação nota = new Anotação();
                nota.Versiculo = anotação.Attributes["versiculo"].Value;
                nota.Comentario = anotação.Attributes["comentario"].Value;
                listaAnotações.Add(nota);
            }
            return listaAnotações;
        }
    }
}
