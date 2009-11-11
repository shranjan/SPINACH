using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
namespace xml_demo
{
    class LinqXML
    {
        
        static void Main(string[] args)
        {
            
            string Pid="trial";
            string read="first read";
            string name="this is name";
            string write="first write";
            XDocument doc=XDocument.Parse("<MessageType type=\"change\">"+"<Pid>"+Pid.ToString()+"</Pid>"
                +"<Uname>"+name+"</Uname>"+"<read>"+read+"</read>"+"<write>"+write+"</write>"
                +"</MessageType>");
            var q = from x in doc.Elements("MessageType").Attributes() select x;
            foreach (var item in q)
            {
                Console.WriteLine("{0}=={1}", item.Name, item.Value);
            }
            Console.WriteLine("=====================");
             var q1 = from x in doc.Elements().Descendants() select x;
            foreach (var item in q1)
            {
                Console.WriteLine("{0}=={1}",item.Name,item.Value);
            }
            Console.Read();
        }

        
    }
}
