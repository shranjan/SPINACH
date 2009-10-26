/* Author : Sushma Kyasaralli Thimmappa */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Schema;


namespace ParallelPrototype
{
    class xmlDataSwarm
    {
        public string writeToXml()
        {
            Matrix m1 = new Matrix();
            string fileName = "matFormat.xml";
            XmlTextWriter matXml = new XmlTextWriter(fileName,null);
            matXml.Formatting = Formatting.Indented;
            matXml.WriteStartDocument();
            matXml.WriteStartElement("Matrix");
            matXml.WriteStartElement("row");
            matXml.WriteValue(m1.getRow());
            matXml.WriteEndElement();
            matXml.WriteStartElement("col");
            matXml.WriteValue(m1.getCol());
            matXml.WriteEndElement();
            matXml.WriteStartElement("Elements");
            for (int i = 0; i < 6; i++)
            {
                matXml.WriteStartElement("Element");
                matXml.WriteValue(m1.getElem()[i]);
                matXml.WriteEndElement();
            }
            matXml.WriteEndElement();
            matXml.Flush();
            
            if (matXml != null)
                matXml.Close();
            return fileName;
        }
    }
}
