﻿namespace PortalApiGusApiRegonData.Models.DanePobierzPelnyRaport
{
    public partial class DanePobierzPelnyRaport
    {
        public DaneSzukajPodmioty.DaneSzukajPodmioty DaneSzukajPodmioty { get; set; }
        public OsFizycznaDaneOgolne OsFizycznaDaneOgolne { get; set; }
        public JednLokalnaOsFizycznej JednLokalnaOsFizycznej { get; set; }
    }
}