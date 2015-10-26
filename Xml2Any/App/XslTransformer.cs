using System;
using System.IO;
using System.Xml;
using System.Xml.Xsl;

namespace App
{

    public class XslTransformer : IDisposable 
    {
        private readonly XslCompiledTransform _transformer;
        private readonly MemoryStream _ms;
        private readonly StreamWriter _sw;
        private StreamReader _sr;
        private XmlReader _xmlReader;

        public XslTransformer()
        {
            _transformer = new XslCompiledTransform();
            _ms = new MemoryStream();
            _sw = new StreamWriter(_ms);
        }

        public void Initialize(string xslFilePath)
        {
            _transformer.Load(xslFilePath);
        }

        public string GenerateString(Stream streamFromXmlFile)
        {
            _xmlReader = XmlReader.Create(streamFromXmlFile);
            _transformer.Transform(_xmlReader, new XsltArgumentList(), _sw);
                    
            _ms.Seek(0, SeekOrigin.Begin);
            _sr = new StreamReader(_ms);

            return _sr.ReadToEnd();
        }

        public void Dispose()
        {
            _xmlReader.Dispose();
            _sw.Dispose();
            _sr.Dispose();
            _ms.Dispose();
        }
    }
}
