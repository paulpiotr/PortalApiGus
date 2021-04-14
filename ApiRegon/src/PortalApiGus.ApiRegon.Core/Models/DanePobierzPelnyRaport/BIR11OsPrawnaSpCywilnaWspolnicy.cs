#region using

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    #region public class BIR11OsPrawnaSpCywilnaWspolnicy : DanePobierzPelnyRaport

    /// <summary>
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport BIR11OsPrawnaSpCywilnaWspolnicy
    ///     Data model of entities found in the basic report
    /// </summary>
    [Table(nameof(BIR11OsPrawnaSpCywilnaWspolnicy), Schema = "pagard")]
    [JsonObject(nameof(BIR11OsPrawnaSpCywilnaWspolnicy))]
    [Display(Name = "BIR11OsPrawnaSpCywilnaWspolnicy", Description = "BIR11OsPrawnaSpCywilnaWspolnicy")]
    [Serializable]
    [XmlRoot("dane")]
    [Index(nameof(WspolscRegonWspolnikSpolki))]
    [Index(nameof(WspolscImiePierwsze))]
    [Index(nameof(WspolscImieDrugie))]
    [Index(nameof(WspolscNazwisko))]
    [Index(nameof(WspolscFirmaNazwa))]
    public class BIR11OsPrawnaSpCywilnaWspolnicy : DanePobierzPelnyRaport
    {
        #region public override ICollection<TModel> CreateCollection<TModel>...

        public override ICollection<TModel> CreateCollection<TModel>(
            DaneSzukajPodmioty.DaneSzukajPodmioty daneSzukajPodmioty, string pRegon, string pNazwaRaportu, string xml,
            ICollection<MessageInspector> messageInspectorCollection = null!)
        {
            ICollection<BIR11OsPrawnaSpCywilnaWspolnicy> collection =
                (ICollection<BIR11OsPrawnaSpCywilnaWspolnicy>)XmlHelper
                    .DeserializeXmlFromString<DanePobierzPelnyRaportResult<BIR11OsPrawnaSpCywilnaWspolnicy>>(xml)
                    .Dane ??
                new Collection<BIR11OsPrawnaSpCywilnaWspolnicy> {new()};
            DaneSzukajPodmiotyKomunikatyOBledach error =
                XmlHelper.DeserializeXmlFromString<DaneSzukajPodmiotyKomunikatyOBledach>(
                    xml);
            foreach (BIR11OsPrawnaSpCywilnaWspolnicy item in collection)
            {
                item.DaneSzukajPodmiotyKomunikatyOBledach = error;
                if (null != messageInspectorCollection && messageInspectorCollection.Count > 0)
                {
                    item.BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector =
                        new List<BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector>();
                    foreach (MessageInspector messageInspector in messageInspectorCollection)
                    {
                        item.BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector.Add(
                            new BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector(item,
                                messageInspector));
                    }
                }
            }

            return (ICollection<TModel>)collection;
        }

        #endregion

        #region private Guid? _daneSzukajPodmiotyId...

        private Guid? _daneSzukajPodmiotyId;

        /// <summary>
        ///     Identyfikator podmiotu, relacja do encji DaneSzukajPodmioty
        ///     Entity identifier, relation to the entity DaneSzukajPodmioty
        /// </summary>
        [Column(Order = 2)]
        [XmlIgnore]
        [JsonProperty(nameof(DaneSzukajPodmiotyId), Order = 2)]
        [Display(Name = "Identyfikator podmiotu", Prompt = "Wybierz lub wpisz identyfikator podmiotu",
            Description = "Identyfikator podmiotu, relacja do encji DaneSzukajPodmioty")]
        public Guid? DaneSzukajPodmiotyId
        {
            get => _daneSzukajPodmiotyId;
            set
            {
                if (value != _daneSzukajPodmiotyId)
                {
                    _daneSzukajPodmiotyId = value;
                    OnPropertyChanged(nameof(DaneSzukajPodmiotyId));
                }
            }
        }

        #endregion

        #region private DaneSzukajPodmioty? _daneSzukajPodmioty...

        private DaneSzukajPodmioty.DaneSzukajPodmioty? _daneSzukajPodmioty;

        /// <summary>
        ///     Podmiot, relacja do encji DaneSzukajPodmioty
        ///     The entity to entity relationship DaneSzukajPodmioty
        /// </summary>
        [Column(Order = 2)]
        [XmlIgnore]
        [ForeignKey(nameof(DaneSzukajPodmiotyId))]
        [JsonProperty(nameof(DaneSzukajPodmioty), Order = 2)]
        [Display(Name = "Podmiot", Prompt = "Uzupełnij lub wybierz podmiot",
            Description = "Podmiot, relacja do encji DaneSzukajPodmioty")]
        public virtual DaneSzukajPodmioty.DaneSzukajPodmioty? DaneSzukajPodmioty
        {
            get => _daneSzukajPodmioty;
            set
            {
                if (value != _daneSzukajPodmioty)
                {
                    _daneSzukajPodmioty = value;
                    OnPropertyChanged(nameof(DaneSzukajPodmioty));
                }
            }
        }

        #endregion

        #region private ICollection<BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector>...

        private ICollection<BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector> _bir11OsPrawnaSpCywilnaWspolnicyMessageInspector;

        /// <summary>
        ///     Kolekcja elementów inspektora wiadomości usługi, relacja do encji DaneSzukajPodmioty, zawiera informacje dotyczące
        ///     przetwarzania żądań
        ///     Service Message Inspector Item Collection, DaneSzukajPodmioty relationship, contains information about request
        ///     processing
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector), Order = 2)]
        //[InverseProperty("DaneSzukajPodmioty")]
        //[ForeignKey("DaneSzukajPodmiotyId")]
        [Display(Name = "Inspektor wiadomości usługi",
            Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
            Description =
                "Kolekcja elementów inspektora wiadomości usługi")]
        public virtual ICollection<BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector> BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector
        {
            get => _bir11OsPrawnaSpCywilnaWspolnicyMessageInspector;
            set
            {
                if (!Equals(value, _bir11OsPrawnaSpCywilnaWspolnicyMessageInspector))
                {
                    _bir11OsPrawnaSpCywilnaWspolnicyMessageInspector = value;
                    OnPropertyChanged(nameof(BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector));
                }
            }
        }

        #endregion

        #region private string? _wspolscRegonWspolnikSpolki; public string? WspolscRegonWspolnikSpolki

        private string? _wspolscRegonWspolnikSpolki;

        /// Wspolsc regon wspolnik spolki
        /// Wspolsc regon wspolnik spolki
        [Column(Order = 2)]
        [XmlElement("wspolsc_regonWspolnikSpolki")]
        [JsonProperty(nameof(WspolscRegonWspolnikSpolki), Order = 2)]
        [Display(Name = "Wspolsc regon wspolnik spolki", Prompt = "Wpisz Wspolsc regon wspolnik spolki",
            Description = "Wspolsc regon wspolnik spolki")]
        [StringLength(9)]
        [MaxLength(9)]

        public string? WspolscRegonWspolnikSpolki
        {
            get => _wspolscRegonWspolnikSpolki;
            set
            {
                if (value != _wspolscRegonWspolnikSpolki)
                {
                    _wspolscRegonWspolnikSpolki = value;
                    OnPropertyChanged(nameof(WspolscRegonWspolnikSpolki));
                }
            }
        }

        #endregion

        #region private string? _wspolscImiePierwsze; public string? WspolscImiePierwsze

        private string? _wspolscImiePierwsze;

        /// Wspolsc imie pierwsze
        /// Wspolsc imie pierwsze
        [Column(Order = 2)]
        [XmlElement("wspolsc_imiePierwsze")]
        [JsonProperty(nameof(WspolscImiePierwsze), Order = 2)]
        [Display(Name = "Wspolsc imie pierwsze", Prompt = "Wpisz Wspolsc imie pierwsze",
            Description = "Wspolsc imie pierwsze")]
        [StringLength(30)]
        [MaxLength(30)]

        public string? WspolscImiePierwsze
        {
            get => _wspolscImiePierwsze;
            set
            {
                if (value != _wspolscImiePierwsze)
                {
                    _wspolscImiePierwsze = value;
                    OnPropertyChanged(nameof(WspolscImiePierwsze));
                }
            }
        }

        #endregion

        #region private string? _wspolscImieDrugie; public string? WspolscImieDrugie

        private string? _wspolscImieDrugie;

        /// Wspolsc imie drugie
        /// Wspolsc imie drugie
        [Column(Order = 2)]
        [XmlElement("wspolsc_imieDrugie")]
        [JsonProperty(nameof(WspolscImieDrugie), Order = 2)]
        [Display(Name = "Wspolsc imie drugie", Prompt = "Wpisz Wspolsc imie drugie",
            Description = "Wspolsc imie drugie")]
        [StringLength(30)]
        [MaxLength(30)]

        public string? WspolscImieDrugie
        {
            get => _wspolscImieDrugie;
            set
            {
                if (value != _wspolscImieDrugie)
                {
                    _wspolscImieDrugie = value;
                    OnPropertyChanged(nameof(WspolscImieDrugie));
                }
            }
        }

        #endregion

        #region private string? _wspolscNazwisko; public string? WspolscNazwisko

        private string? _wspolscNazwisko;

        /// Wspolsc nazwisko
        /// Wspolsc nazwisko
        [Column(Order = 2)]
        [XmlElement("wspolsc_nazwisko")]
        [JsonProperty(nameof(WspolscNazwisko), Order = 2)]
        [Display(Name = "Wspolsc nazwisko", Prompt = "Wpisz Wspolsc nazwisko", Description = "Wspolsc nazwisko")]
        [StringLength(40)]
        [MaxLength(40)]

        public string? WspolscNazwisko
        {
            get => _wspolscNazwisko;
            set
            {
                if (value != _wspolscNazwisko)
                {
                    _wspolscNazwisko = value;
                    OnPropertyChanged(nameof(WspolscNazwisko));
                }
            }
        }

        #endregion

        #region private string? _wspolscFirmaNazwa; public string? WspolscFirmaNazwa

        private string? _wspolscFirmaNazwa;

        /// Wspolsc firma nazwa
        /// Wspolsc firma nazwa
        [Column(Order = 2)]
        [XmlElement("wspolsc_firmaNazwa")]
        [JsonProperty(nameof(WspolscFirmaNazwa), Order = 2)]
        [Display(Name = "Wspolsc firma nazwa", Prompt = "Wpisz Wspolsc firma nazwa",
            Description = "Wspolsc firma nazwa")]
        [StringLength(2000)]
        [MaxLength(2000)]

        public string? WspolscFirmaNazwa
        {
            get => _wspolscFirmaNazwa;
            set
            {
                if (value != _wspolscFirmaNazwa)
                {
                    _wspolscFirmaNazwa = value;
                    OnPropertyChanged(nameof(WspolscFirmaNazwa));
                }
            }
        }

        #endregion
    }

    #endregion
}

#endregion
