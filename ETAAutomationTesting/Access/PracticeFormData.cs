using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ETAAutomationTesting.Access
{
    public partial class PracticeFormData
    {
        private XElement _dataNode;
        public PracticeFormData(int dataSetNumber)
        {
            LoadData(dataSetNumber);
            FirstName = GetValue("FirstName");
            LastName = GetValue("LastName");
            Email = GetValue("Email");
            Gender = GetValue("Gender");
            Mobile = GetValue("Mobile");
            DateOfBirth = GetValue("DateOfBirth");
            Subjects = GetValue("Subjects");
            Hobbies = GetValue("Hobbies").Split(',').Select(h => h.Trim()).ToList();
            Address = GetValue("Address");
            State = GetValue("State");
            City = GetValue("City");

        }

        private void LoadData(int dataSetNumber)
        {
            string path = Path.Combine("C:\\dev\\ETA 2025\\ETATestingProject\\ETAAutomationTesting\\Resources\\PracticeFormData.xml");
            XDocument doc = XDocument.Load(path);
            string nodeName = $"DataSet_{dataSetNumber}";
            _dataNode = doc.Root.Element(nodeName);
            if (_dataNode == null)
            {
                throw new Exception($"DataSet_{dataSetNumber} not found in the XML file.");
            }
        }

        private string GetValue(string nodeName)
        {
            return _dataNode.Element(nodeName)?.Value ?? throw new Exception($"Node '{nodeName}' not found in the XML data.");
        }
    }
}
