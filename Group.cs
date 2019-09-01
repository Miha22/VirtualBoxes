using System.Collections.Generic;
using System.Xml.Serialization;

namespace ItemRestrictorAdvanced
{
    public class Group
    {
        [XmlAttribute]
        public string GroupID { get; set; }
        [XmlAttribute("BoxLimit")]
        public ushort BoxLimit { get; set; }

        public Group()
        {

        }
    }
}
