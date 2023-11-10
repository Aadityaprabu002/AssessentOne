using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AssessentOne {
    internal class Question11 {
        public static void Run() {
            
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", null, null));

            xmlDoc.AppendChild(xmlDoc.CreateDocumentType("Students", null, "students.dtd", null));
  
            XmlElement rootElement = xmlDoc.CreateElement("Students");
            xmlDoc.AppendChild(rootElement);
    
            InsertStudent(xmlDoc, rootElement, "Aaditya", "22", "A");
            InsertStudent(xmlDoc, rootElement, "Prabu", "25", "B");
        
            Console.WriteLine("Original XML Data:");
            Console.WriteLine(xmlDoc.OuterXml);
      
            DeleteStudent(rootElement, "Aaditya");
          
            InsertStudent(xmlDoc, rootElement, "Assessment", "20", "C");
      
            Console.WriteLine("\nModified XML Data:");
            Console.WriteLine(xmlDoc.OuterXml);

            xmlDoc.Save("./students.xml");
            Console.WriteLine("\nXML file saved to 'students.xml'");

        }
        static void InsertStudent(XmlDocument xmlDoc, XmlElement rootElement, string name, string age, string grade) {
            
            XmlElement studentElement = xmlDoc.CreateElement("Student");

        
            XmlElement nameElement = xmlDoc.CreateElement("Name");
            nameElement.InnerText = name;

            XmlElement ageElement = xmlDoc.CreateElement("Age");
            ageElement.InnerText = age;

            XmlElement gradeElement = xmlDoc.CreateElement("Grade");
            gradeElement.InnerText = grade;

           
            studentElement.AppendChild(nameElement);
            studentElement.AppendChild(ageElement);
            studentElement.AppendChild(gradeElement);

         
            rootElement.AppendChild(studentElement);
        }
        static void DeleteStudent(XmlElement rootElement, string studentName) {
          
            XmlNode studentToDelete = rootElement.SelectSingleNode($"Student[Name='{studentName}']");

          
            if (studentToDelete != null) {
                rootElement.RemoveChild(studentToDelete);
                Console.WriteLine($"Deleted student: {studentName}");
            } else {
                Console.WriteLine($"Student not found: {studentName}");
            }
        }
    }
}
