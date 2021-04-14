#region using

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

#endregion

namespace PortalApiGusApiRegonData.Models.DanePobierzPelnyRaport
{
    [Serializable]
    [XmlRoot("root")]
    public class OsFizycznaDaneOgolneList
    {
        [XmlElement(ElementName = "dane", Type = typeof(OsFizycznaDaneOgolne))]
        public List<OsFizycznaDaneOgolne> Dane { get; set; }
    }
}
