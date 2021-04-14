#region using

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;
using NetAppCommon.Helpers.Xmls;
using Newtonsoft.Json;
using PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty;

#endregion

#nullable enable annotations

#region namespace

namespace PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport
{
    #region public class BIR11TypPodmiotu : DanePobierzPelnyRaport

    /// <summary>
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport BIR11TypPodmiotu
    ///     Data model of entities found in the basic report
    /// </summary>
    [Table(nameof(BIR11TypPodmiotu), Schema = "pagard")]
    [JsonObject(nameof(BIR11TypPodmiotu))]
    [Display(Name = "BIR11TypPodmiotu", Description = "BIR11TypPodmiotu")]
    [Serializable]
    [XmlRoot("dane")]
    [Index(nameof(Typ))]
    public class BIR11TypPodmiotu : DanePobierzPelnyRaport
    {
        #region public override TModel Create<TModel>...

        public override TModel Create<TModel>(string pRegon, string pNazwaRaportu, string xml,
            ICollection<MessageInspector> messageInspectorCollection = null!)
        {
            BIR11TypPodmiotu model =
                XmlHelper.DeserializeXmlFromString<BIR11TypPodmiotu>(xml) ?? new BIR11TypPodmiotu();
            model.PRegon = pRegon;
            model.PNazwaRaportu = pNazwaRaportu;
            DaneSzukajPodmiotyKomunikatyOBledach error =
                XmlHelper.DeserializeXmlFromString<DaneSzukajPodmiotyKomunikatyOBledach>(
                    xml);
            model.DaneSzukajPodmiotyKomunikatyOBledach = error;
            if (null != messageInspectorCollection && messageInspectorCollection.Count > 0)
            {
                model.BIR11TypPodmiotuMessageInspector = new List<BIR11TypPodmiotuMessageInspector>();
                foreach (MessageInspector messageInspector in messageInspectorCollection)
                {
                    model.BIR11TypPodmiotuMessageInspector.Add(
                        new BIR11TypPodmiotuMessageInspector(model,
                            messageInspector));
                }
            }

            return (model as TModel)!;
        }

        #endregion

        #region ICollection<DaneSzukajPodmioty>? _daneSzukajPodmioty...

        private ICollection<DaneSzukajPodmioty.DaneSzukajPodmioty>? _daneSzukajPodmioty;

        /// <summary>
        ///     Raport podstawowy
        ///     Raport podstawowy
        /// </summary>
        [Column(Order = 2)]
        [XmlIgnore]
        [JsonProperty(nameof(DaneSzukajPodmioty), Order = 2)]
        [InverseProperty("BIR11TypPodmiotu")]
        [Display(Name = "Raport podstawowy", Prompt = "Wybierz raport podstawowy",
            Description = "Dane wyszukanych podmiotów w raporcie podstawowym")]
        public virtual ICollection<DaneSzukajPodmioty.DaneSzukajPodmioty>? DaneSzukajPodmioty
        {
            get => _daneSzukajPodmioty;
            set
            {
                if (!Equals(value, _daneSzukajPodmioty))
                {
                    _daneSzukajPodmioty = value;
                    OnPropertyChanged(nameof(DaneSzukajPodmioty));
                }
            }
        }

        #endregion

        #region private ICollection<BIR11TypPodmiotuMessageInspector>...

        private ICollection<BIR11TypPodmiotuMessageInspector> _modelMessageInspector;

        /// <summary>
        ///     Kolekcja elementów inspektora wiadomości usługi, relacja do encji DaneSzukajPodmioty, zawiera informacje dotyczące
        ///     przetwarzania żądań
        ///     Service Message Inspector Item Collection, DaneSzukajPodmioty relationship, contains information about request
        ///     processing
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(BIR11TypPodmiotuMessageInspector), Order = 2)]
        //[InverseProperty("DaneSzukajPodmioty")]
        //[ForeignKey("DaneSzukajPodmiotyId")]
        [Display(Name = "Inspektor wiadomości usługi",
            Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
            Description =
                "Kolekcja elementów inspektora wiadomości usługi")]
        public virtual ICollection<BIR11TypPodmiotuMessageInspector> BIR11TypPodmiotuMessageInspector
        {
            get => _modelMessageInspector;
            set
            {
                if (!Equals(value, _modelMessageInspector))
                {
                    _modelMessageInspector = value;
                    OnPropertyChanged(nameof(BIR11TypPodmiotuMessageInspector));
                }
            }
        }

        #endregion

        #region private string? _typ; public string? Typ

        private string? _typ;

        /// Typ
        /// Typ
        [Column(Order = 2)]
        [XmlElement("Typ")]
        [JsonProperty(nameof(Typ), Order = 2)]
        [Display(Name = "Typ", Prompt = "Wpisz Typ", Description = "Typ")]
        [StringLength(2)]
        [MaxLength(2)]

        public string? Typ
        {
            get => _typ;
            set
            {
                if (value != _typ)
                {
                    _typ = value;
                    OnPropertyChanged(nameof(Typ));
                }
            }
        }

        #endregion
    }

    #endregion
}

#endregion
