using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PortalApiGusApiRegonData.Models.DanePobierzPelnyRaport
{
    [Serializable, XmlRoot("root")]
    public partial class OsFizycznaDaneOgolneList
    {
        [XmlElement(ElementName = "dane", Type = typeof(OsFizycznaDaneOgolne))]
        public List<OsFizycznaDaneOgolne> Dane { get; set; }
    }
}