#region using

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

#endregion

namespace PortalApiGusApiRegonData.Models.DaneSzukajPodmioty
{
    [Serializable]
    [XmlRoot("root")]
    public class DaneSzukajPodmiotyList
    {
        [XmlElement(ElementName = "dane", Type = typeof(DaneSzukajPodmioty))]
        public List<DaneSzukajPodmioty> Dane { get; set; }
    }
}
