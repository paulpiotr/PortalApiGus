using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PortalApiGusApiRegonData.Models.DaneSzukajPodmioty
{
    [Serializable, XmlRoot("root")]
    public partial class DaneSzukajPodmiotyList
    {
        [XmlElement(ElementName = "dane", Type = typeof(DaneSzukajPodmioty))]
        public List<DaneSzukajPodmioty> Dane { get; set; }
    }
}