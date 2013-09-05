using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace HCMIS.Extensions.Business
{
    [Serializable]
    [XmlRoot(ElementName = "Definitions")]
    public class Rule
    {
        #region Fields

        #endregion

        #region Static Members
        public static Rule GetRule(string xml)
        {
            return null;
        }

        #endregion

        #region Properties

        [XmlElement("Definition")]
        public List<Guid> KeyList { get; set; }

        #endregion
    }
}
