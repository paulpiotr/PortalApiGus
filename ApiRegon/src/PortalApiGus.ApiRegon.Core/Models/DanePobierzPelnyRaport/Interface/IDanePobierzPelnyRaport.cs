#region using

using System.Collections.Generic;
using PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty;

#endregion

namespace PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport.Interface
{
    public interface IDanePobierzPelnyRaport
    {
        public TModel Create<TModel>(string pRegon, string pNazwaRaportu, string xml,
            ICollection<MessageInspector> messageInspectorCollection = null!)
            where TModel : DanePobierzPelnyRaport, new();

        public ICollection<TModel> CreateCollection<TModel>(
            DaneSzukajPodmioty.DaneSzukajPodmioty daneSzukajPodmioty, string pRegon, string pNazwaRaportu, string xml,
            ICollection<MessageInspector> messageInspectorCollection = null!)
            where TModel : DanePobierzPelnyRaport, new();
    }
}
