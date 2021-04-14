#nullable enable

#region using

using System;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty;
using PortalApiGus.ApiRegon.Core.Services.UslugaBIRzewnPublVer11Prod;

#endregion

namespace PortalApiGus.ApiRegon.PortalApiGus.ApiRegon.ConsoleApp
{
    internal class Program
    {
        private static async Task Main(string[] args) => await FindByRegonAsync();

        private static async Task FindByRegonAsync()
        {
            Console.WriteLine("Test FindByRegonAsync");

            DaneSzukajPodmiotyResult daneSzukajPodmiotyList =
                await new DaneSzukajPodmiotyService().FindByRegonAsync("002759278", null, true);

            DaneSzukajPodmioty? daneSzukajPodmioty = daneSzukajPodmiotyList.Data.FirstOrDefault();

            var output = JsonConvert.SerializeObject(daneSzukajPodmioty,
                Formatting.Indented,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    PreserveReferencesHandling = PreserveReferencesHandling.Objects
                });

            Console.WriteLine(output);
        }
    }
}
