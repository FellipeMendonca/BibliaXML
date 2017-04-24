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

            XmlNode novaAnotação = documentoXML.CreateElement("anotacao");
            novaAnotação.Attributes.Append(atributoID);
            novaAnotação.Attributes.Append(atribuloVersiculo);
            novaAnotação.Attributes.Append(atributoComentario);

            XmlNode anotações = documentoXML.SelectSingleNode("/biblioteca/anotacoes");
            anotações.AppendChild(novaAnotação);

            documentoXML.Save(caminhoXml);

        }

        public static void DeletarAnotação(int id)
        {
            XmlDocument documentoXML = new XmlDocument();
            documentoXML.Load(caminhoXml);
            XmlNodeList anotações = documentoXML.SelectNodes("/biblioteca/anotacoes/anotacao");
            foreach (XmlNode anotação in anotações)
            {
                if (anotação.Attributes["id"].Value == Convert.ToString(id))
                {
                    anotação.ParentNode.RemoveChild(anotação);
                }
            }
            documentoXML.Save(caminhoXml);
            ReenumerarXml();
        }

        public static void EditarAnotação(int id, Anotação nota)
        {
            XmlDocument documentoXML = new XmlDocument();
            documentoXML.Load(caminhoXml);
            XmlNodeList anotações = documentoXML.SelectNodes("/biblioteca/anotacoes/anotacao");
            foreach (XmlNode anotação in anotações)
            {
                if (anotação.Attributes["id"].Value == Convert.ToString(id))
                {
                    anotação.Attributes["versiculo"].Value = nota.Versiculo;
                    anotação.Attributes["comentario"].Value = nota.Comentario;
                }
            }
            documentoXML.Save(caminhoXml);

        }

        private static void ReenumerarXml()
        {
            XmlDocument documentoXML = new XmlDocument();
            documentoXML.Load(caminhoXml);
            XmlNodeList anotações = documentoXML.SelectNodes("/biblioteca/anotacoes/anotacao");
            int i = 1;
            foreach (XmlNode anotação in anotações)
            {
                anotação.Attributes["id"].Value = Convert.ToString(i);
            }
            documentoXML.Save(caminhoXml);
        }
    }
}
