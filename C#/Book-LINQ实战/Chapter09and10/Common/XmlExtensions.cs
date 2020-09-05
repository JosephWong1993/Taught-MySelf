using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace Common
{
    public static class XmlExtensions
    {
        public static XDocument XslTransform(this XNode node, string xsl)
        {
            XDocument output = new XDocument();
            using (XmlWriter writer = output.CreateWriter())
            {
                XslCompiledTransform xslTransformer = new XslCompiledTransform();
                xslTransformer.Load(XmlReader.Create(new StringReader(xsl)));
                xslTransformer.Transform(node.CreateReader(), writer);
            }
            return output;
        }
    }
}
