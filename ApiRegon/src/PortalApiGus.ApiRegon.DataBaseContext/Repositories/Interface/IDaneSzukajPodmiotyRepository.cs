#region using

using System.Threading.Tasks;
using PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty;

#endregion

#nullable enable annotations

namespace PortalApiGus.ApiRegon.DataBase.Repositories.Interface
{
    public interface IDaneSzukajPodmiotyRepository
    {
        public DaneSzukajPodmiotyResult AddRange(DaneSzukajPodmiotyResult daneSzukajPodmiotyResult);

        public Task<DaneSzukajPodmiotyResult> AddRangeAsync(DaneSzukajPodmiotyResult daneSzukajPodmiotyResult);

        public Task<DaneSzukajPodmiotyResult>? FindByKrsAsync(string krs, int cacheLifeTime = 0);

        public DaneSzukajPodmiotyResult? FindByKrs(string krs, int cacheLifeTime = 0);

        public Task<DaneSzukajPodmiotyResult>? FindByKrsyAsync(string krsy, int cacheLifeTime = 0);

        public DaneSzukajPodmiotyResult? FindByKrsy(string krsy, int cacheLifeTime = 0);

        public Task<DaneSzukajPodmiotyResult>? FindByNipAsync(string nip, int cacheLifeTime = 0);

        public DaneSzukajPodmiotyResult? FindByNip(string nip, int cacheLifeTime = 0);
    }
}
