using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ETAAutomationTesting.Access
{
    public partial class TextBoxData
    {
        private XElement _dataNode;

        public TextBoxData(int dataSetNumber)
        {
            LoadData(dataSetNumber);
            FullName = GetValue("FullName");
            Email = GetValue("Email");
            CurrentAddress = GetValue("CurrentAddress");
            PermanentAddress = GetValue("PermanentAddress");
        }

        private void LoadData(int dataSetNumber)
        {
            string path = Path.Combine("C:\\dev\\ETA 2025\\ETATestingProject\\ETAAutomationTesting\\Resources\\TextBoxData.xml");
            XDocument doc = XDocument.Load(path);
            string nodeName = $"DataSet_{dataSetNumber}";
            _dataNode = doc.Root.Element(nodeName);
            if(_dataNode==null)
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
