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
    #region public class BIR11OsPrawna : DanePobierzPelnyRaport

    /// <summary>
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport BIR11OsPrawna
    ///     Data model of entities found in the basic report
    /// </summary>
    [Table(nameof(BIR11OsPrawna), Schema = "pagard")]
    [JsonObject(nameof(BIR11OsPrawna))]
    [Display(Name = "BIR11OsPrawna", Description = "BIR11OsPrawna")]
    [Serializable]
    [XmlRoot("dane")]
    [Index(nameof(PrawRegon9))]
    [Index(nameof(PrawNip))]
    [Index(nameof(PrawStatusNip))]
    [Index(nameof(PrawNazwa))]
    [Index(nameof(PrawNazwaSkrocona))]
    [Index(nameof(PrawNumerWRejestrzeEwidencji))]
    [Index(nameof(PrawDataWpisuDoRejestruEwidencji))]
    [Index(nameof(PrawDataPowstania))]
    [Index(nameof(PrawDataRozpoczeciaDzialalnosci))]
    [Index(nameof(PrawDataWpisuDoRegon))]
    [Index(nameof(PrawDataZawieszeniaDzialalnosci))]
    [Index(nameof(PrawDataWznowieniaDzialalnosci))]
    [Index(nameof(PrawDataZaistnieniaZmiany))]
    [Index(nameof(PrawDataZakonczeniaDzialalnosci))]
    [Index(nameof(PrawDataSkresleniaZRegon))]
    [Index(nameof(PrawDataOrzeczeniaOUpadlosci))]
    [Index(nameof(PrawDataZakonczeniaPostepowaniaUpadlosciowego))]
    [Index(nameof(PrawAdSiedzKrajSymbol))]
    [Index(nameof(PrawAdSiedzWojewodztwoSymbol))]
    [Index(nameof(PrawAdSiedzPowiatSymbol))]
    [Index(nameof(PrawAdSiedzGminaSymbol))]
    [Index(nameof(PrawAdSiedzKodPocztowy))]
    [Index(nameof(PrawAdSiedzMiejscowoscPocztySymbol))]
    [Index(nameof(PrawAdSiedzMiejscowoscSymbol))]
    [Index(nameof(PrawAdSiedzUlicaSymbol))]
    [Index(nameof(PrawAdSiedzNumerNieruchomosci))]
    [Index(nameof(PrawAdSiedzNumerLokalu))]
    [Index(nameof(PrawAdSiedzNietypoweMiejsceLokalizacji))]
    [Index(nameof(PrawNumerTelefonu))]
    [Index(nameof(PrawNumerWewnetrznyTelefonu))]
    [Index(nameof(PrawNumerFaksu))]
    [Index(nameof(PrawAdresEmail))]
    [Index(nameof(PrawAdresStronyinternetowej))]
    [Index(nameof(PrawAdSiedzKrajNazwa))]
    [Index(nameof(PrawAdSiedzWojewodztwoNazwa))]
    [Index(nameof(PrawAdSiedzPowiatNazwa))]
    [Index(nameof(PrawAdSiedzGminaNazwa))]
    [Index(nameof(PrawAdSiedzMiejscowoscNazwa))]
    [Index(nameof(PrawAdSiedzMiejscowoscPocztyNazwa))]
    [Index(nameof(PrawAdSiedzUlicaNazwa))]
    [Index(nameof(PrawPodstawowaFormaPrawnaSymbol))]
    [Index(nameof(PrawSzczegolnaFormaPrawnaSymbol))]
    [Index(nameof(PrawFormaFinansowaniaSymbol))]
    [Index(nameof(PrawFormaWlasnosciSymbol))]
    [Index(nameof(PrawOrganZalozycielskiSymbol))]
    [Index(nameof(PrawOrganRejestrowySymbol))]
    [Index(nameof(PrawRodzajRejestruEwidencjiSymbol))]
    [Index(nameof(PrawPodstawowaFormaPrawnaNazwa))]
    [Index(nameof(PrawSzczegolnaFormaPrawnaNazwa))]
    [Index(nameof(PrawFormaFinansowaniaNazwa))]
    [Index(nameof(PrawFormaWlasnosciNazwa))]
    [Index(nameof(PrawOrganZalozycielskiNazwa))]
    [Index(nameof(PrawOrganRejestrowyNazwa))]
    [Index(nameof(PrawRodzajRejestruEwidencjiNazwa))]
    [Index(nameof(PrawLiczbaJednLokalnych))]
    public class BIR11OsPrawna : DanePobierzPelnyRaport
    {
        #region public override TModel Create<TModel>...

        public override TModel Create<TModel>(string pRegon, string pNazwaRaportu, string xml,
            ICollection<MessageInspector> messageInspectorCollection = null!)
        {
            BIR11OsPrawna model = XmlHelper.DeserializeXmlFromString<BIR11OsPrawna>(xml) ?? new BIR11OsPrawna();
            model.PRegon = pRegon;
            model.PNazwaRaportu = pNazwaRaportu;
            DaneSzukajPodmiotyKomunikatyOBledach error =
                XmlHelper.DeserializeXmlFromString<DaneSzukajPodmiotyKomunikatyOBledach>(
                    xml);
            model.DaneSzukajPodmiotyKomunikatyOBledach = error;
            if(null != messageInspectorCollection && messageInspectorCollection.Count > 0)
            {
                model.BIR11OsPrawnaMessageInspector = new List<BIR11OsPrawnaMessageInspector>();
                foreach(MessageInspector messageInspector in messageInspectorCollection)
                {
                    model.BIR11OsPrawnaMessageInspector.Add(
                        new BIR11OsPrawnaMessageInspector(model, messageInspector));
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
        [InverseProperty("BIR11OsPrawna")]
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

        #region private ICollection<BIR11OsPrawnaMessageInspector>...

        private ICollection<BIR11OsPrawnaMessageInspector> _bir11OsPrawnaMessageInspector;

        /// <summary>
        ///     Kolekcja elementów inspektora wiadomości usługi, relacja do encji DaneSzukajPodmioty, zawiera informacje dotyczące
        ///     przetwarzania żądań
        ///     Service Message Inspector Item Collection, DaneSzukajPodmioty relationship, contains information about request
        ///     processing
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(BIR11OsPrawnaMessageInspector), Order = 2)]
        //[InverseProperty("DaneSzukajPodmioty")]
        //[ForeignKey("DaneSzukajPodmiotyId")]
        [Display(Name = "Inspektor wiadomości usługi",
            Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
            Description =
                "Kolekcja elementów inspektora wiadomości usługi")]
        public virtual ICollection<BIR11OsPrawnaMessageInspector> BIR11OsPrawnaMessageInspector
        {
            get => _bir11OsPrawnaMessageInspector;
            set
            {
                if (!Equals(value, _bir11OsPrawnaMessageInspector))
                {
                    _bir11OsPrawnaMessageInspector = value;
                    OnPropertyChanged(nameof(BIR11OsPrawnaMessageInspector));
                }
            }
        }

        #endregion

        #region private string? _prawRegon9; public string? PrawRegon9

        private string? _prawRegon9;

        /// Praw regon9
        /// Praw regon9
        [Column(Order = 2)]
        [XmlElement("praw_regon9")]
        [JsonProperty(nameof(PrawRegon9), Order = 2)]
        [Display(Name = "Praw regon9", Prompt = "Wpisz Praw regon9", Description = "Praw regon9")]
        [StringLength(9)]
        [MaxLength(9)]

        public string? PrawRegon9
        {
            get => _prawRegon9;
            set
            {
                if (value != _prawRegon9)
                {
                    _prawRegon9 = value;
                    OnPropertyChanged(nameof(PrawRegon9));
                }
            }
        }

        #endregion

        #region private string? _prawNip; public string? PrawNip

        private string? _prawNip;

        /// Praw nip
        /// Praw nip
        [Column(Order = 2)]
        [XmlElement("praw_nip")]
        [JsonProperty(nameof(PrawNip), Order = 2)]
        [Display(Name = "Praw nip", Prompt = "Wpisz Praw nip", Description = "Praw nip")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? PrawNip
        {
            get => _prawNip;
            set
            {
                if (value != _prawNip)
                {
                    _prawNip = value;
                    OnPropertyChanged(nameof(PrawNip));
                }
            }
        }

        #endregion

        #region private string? _prawStatusNip; public string? PrawStatusNip

        private string? _prawStatusNip;

        /// Praw status nip
        /// Praw status nip
        [Column(Order = 2)]
        [XmlElement("praw_statusNip")]
        [JsonProperty(nameof(PrawStatusNip), Order = 2)]
        [Display(Name = "Praw status nip", Prompt = "Wpisz Praw status nip", Description = "Praw status nip")]
        [StringLength(12)]
        [MaxLength(12)]

        public string? PrawStatusNip
        {
            get => _prawStatusNip;
            set
            {
                if (value != _prawStatusNip)
                {
                    _prawStatusNip = value;
                    OnPropertyChanged(nameof(PrawStatusNip));
                }
            }
        }

        #endregion

        #region private string? _prawNazwa; public string? PrawNazwa

        private string? _prawNazwa;

        /// Praw nazwa
        /// Praw nazwa
        [Column(Order = 2)]
        [XmlElement("praw_nazwa")]
        [JsonProperty(nameof(PrawNazwa), Order = 2)]
        [Display(Name = "Praw nazwa", Prompt = "Wpisz Praw nazwa", Description = "Praw nazwa")]
        [StringLength(2000)]
        [MaxLength(2000)]

        public string? PrawNazwa
        {
            get => _prawNazwa;
            set
            {
                if (value != _prawNazwa)
                {
                    _prawNazwa = value;
                    OnPropertyChanged(nameof(PrawNazwa));
                }
            }
        }

        #endregion

        #region private string? _prawNazwaSkrocona; public string? PrawNazwaSkrocona

        private string? _prawNazwaSkrocona;

        /// Praw nazwa skrocona
        /// Praw nazwa skrocona
        [Column(Order = 2)]
        [XmlElement("praw_nazwaSkrocona")]
        [JsonProperty(nameof(PrawNazwaSkrocona), Order = 2)]
        [Display(Name = "Praw nazwa skrocona", Prompt = "Wpisz Praw nazwa skrocona",
            Description = "Praw nazwa skrocona")]
        [StringLength(256)]
        [MaxLength(256)]

        public string? PrawNazwaSkrocona
        {
            get => _prawNazwaSkrocona;
            set
            {
                if (value != _prawNazwaSkrocona)
                {
                    _prawNazwaSkrocona = value;
                    OnPropertyChanged(nameof(PrawNazwaSkrocona));
                }
            }
        }

        #endregion

        #region private string? _prawNumerWRejestrzeEwidencji; public string? PrawNumerWRejestrzeEwidencji

        private string? _prawNumerWRejestrzeEwidencji;

        /// Praw numer w rejestrze ewidencji
        /// Praw numer w rejestrze ewidencji
        [Column(Order = 2)]
        [XmlElement("praw_numerWRejestrzeEwidencji")]
        [JsonProperty(nameof(PrawNumerWRejestrzeEwidencji), Order = 2)]
        [Display(Name = "Praw numer w rejestrze ewidencji", Prompt = "Wpisz Praw numer w rejestrze ewidencji",
            Description = "Praw numer w rejestrze ewidencji")]
        [StringLength(50)]
        [MaxLength(50)]

        public string? PrawNumerWRejestrzeEwidencji
        {
            get => _prawNumerWRejestrzeEwidencji;
            set
            {
                if (value != _prawNumerWRejestrzeEwidencji)
                {
                    _prawNumerWRejestrzeEwidencji = value;
                    OnPropertyChanged(nameof(PrawNumerWRejestrzeEwidencji));
                }
            }
        }

        #endregion

        #region private string? _prawDataWpisuDoRejestruEwidencji; public string? PrawDataWpisuDoRejestruEwidencji

        private string? _prawDataWpisuDoRejestruEwidencji;

        /// Praw data wpisu do rejestru ewidencji
        /// Praw data wpisu do rejestru ewidencji
        [Column(Order = 2)]
        [XmlElement("praw_dataWpisuDoRejestruEwidencji")]
        [JsonProperty(nameof(PrawDataWpisuDoRejestruEwidencji), Order = 2)]
        [Display(Name = "Praw data wpisu do rejestru ewidencji", Prompt = "Wpisz Praw data wpisu do rejestru ewidencji",
            Description = "Praw data wpisu do rejestru ewidencji")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? PrawDataWpisuDoRejestruEwidencji
        {
            get => _prawDataWpisuDoRejestruEwidencji;
            set
            {
                if (value != _prawDataWpisuDoRejestruEwidencji)
                {
                    _prawDataWpisuDoRejestruEwidencji = value;
                    OnPropertyChanged(nameof(PrawDataWpisuDoRejestruEwidencji));
                }
            }
        }

        #endregion

        #region private string? _prawDataPowstania; public string? PrawDataPowstania

        private string? _prawDataPowstania;

        /// Praw data powstania
        /// Praw data powstania
        [Column(Order = 2)]
        [XmlElement("praw_dataPowstania")]
        [JsonProperty(nameof(PrawDataPowstania), Order = 2)]
        [Display(Name = "Praw data powstania", Prompt = "Wpisz Praw data powstania",
            Description = "Praw data powstania")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? PrawDataPowstania
        {
            get => _prawDataPowstania;
            set
            {
                if (value != _prawDataPowstania)
                {
                    _prawDataPowstania = value;
                    OnPropertyChanged(nameof(PrawDataPowstania));
                }
            }
        }

        #endregion

        #region private string? _prawDataRozpoczeciaDzialalnosci; public string? PrawDataRozpoczeciaDzialalnosci

        private string? _prawDataRozpoczeciaDzialalnosci;

        /// Praw data rozpoczecia dzialalnosci
        /// Praw data rozpoczecia dzialalnosci
        [Column(Order = 2)]
        [XmlElement("praw_dataRozpoczeciaDzialalnosci")]
        [JsonProperty(nameof(PrawDataRozpoczeciaDzialalnosci), Order = 2)]
        [Display(Name = "Praw data rozpoczecia dzialalnosci", Prompt = "Wpisz Praw data rozpoczecia dzialalnosci",
            Description = "Praw data rozpoczecia dzialalnosci")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? PrawDataRozpoczeciaDzialalnosci
        {
            get => _prawDataRozpoczeciaDzialalnosci;
            set
            {
                if (value != _prawDataRozpoczeciaDzialalnosci)
                {
                    _prawDataRozpoczeciaDzialalnosci = value;
                    OnPropertyChanged(nameof(PrawDataRozpoczeciaDzialalnosci));
                }
            }
        }

        #endregion

        #region private string? _prawDataWpisuDoRegon; public string? PrawDataWpisuDoRegon

        private string? _prawDataWpisuDoRegon;

        /// Praw data wpisu do regon
        /// Praw data wpisu do regon
        [Column(Order = 2)]
        [XmlElement("praw_dataWpisuDoRegon")]
        [JsonProperty(nameof(PrawDataWpisuDoRegon), Order = 2)]
        [Display(Name = "Praw data wpisu do regon", Prompt = "Wpisz Praw data wpisu do regon",
            Description = "Praw data wpisu do regon")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? PrawDataWpisuDoRegon
        {
            get => _prawDataWpisuDoRegon;
            set
            {
                if (value != _prawDataWpisuDoRegon)
                {
                    _prawDataWpisuDoRegon = value;
                    OnPropertyChanged(nameof(PrawDataWpisuDoRegon));
                }
            }
        }

        #endregion

        #region private string? _prawDataZawieszeniaDzialalnosci; public string? PrawDataZawieszeniaDzialalnosci

        private string? _prawDataZawieszeniaDzialalnosci;

        /// Praw data zawieszenia dzialalnosci
        /// Praw data zawieszenia dzialalnosci
        [Column(Order = 2)]
        [XmlElement("praw_dataZawieszeniaDzialalnosci")]
        [JsonProperty(nameof(PrawDataZawieszeniaDzialalnosci), Order = 2)]
        [Display(Name = "Praw data zawieszenia dzialalnosci", Prompt = "Wpisz Praw data zawieszenia dzialalnosci",
            Description = "Praw data zawieszenia dzialalnosci")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? PrawDataZawieszeniaDzialalnosci
        {
            get => _prawDataZawieszeniaDzialalnosci;
            set
            {
                if (value != _prawDataZawieszeniaDzialalnosci)
                {
                    _prawDataZawieszeniaDzialalnosci = value;
                    OnPropertyChanged(nameof(PrawDataZawieszeniaDzialalnosci));
                }
            }
        }

        #endregion

        #region private string? _prawDataWznowieniaDzialalnosci; public string? PrawDataWznowieniaDzialalnosci

        private string? _prawDataWznowieniaDzialalnosci;

        /// Praw data wznowienia dzialalnosci
        /// Praw data wznowienia dzialalnosci
        [Column(Order = 2)]
        [XmlElement("praw_dataWznowieniaDzialalnosci")]
        [JsonProperty(nameof(PrawDataWznowieniaDzialalnosci), Order = 2)]
        [Display(Name = "Praw data wznowienia dzialalnosci", Prompt = "Wpisz Praw data wznowienia dzialalnosci",
            Description = "Praw data wznowienia dzialalnosci")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? PrawDataWznowieniaDzialalnosci
        {
            get => _prawDataWznowieniaDzialalnosci;
            set
            {
                if (value != _prawDataWznowieniaDzialalnosci)
                {
                    _prawDataWznowieniaDzialalnosci = value;
                    OnPropertyChanged(nameof(PrawDataWznowieniaDzialalnosci));
                }
            }
        }

        #endregion

        #region private string? _prawDataZaistnieniaZmiany; public string? PrawDataZaistnieniaZmiany

        private string? _prawDataZaistnieniaZmiany;

        /// Praw data zaistnienia zmiany
        /// Praw data zaistnienia zmiany
        [Column(Order = 2)]
        [XmlElement("praw_dataZaistnieniaZmiany")]
        [JsonProperty(nameof(PrawDataZaistnieniaZmiany), Order = 2)]
        [Display(Name = "Praw data zaistnienia zmiany", Prompt = "Wpisz Praw data zaistnienia zmiany",
            Description = "Praw data zaistnienia zmiany")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? PrawDataZaistnieniaZmiany
        {
            get => _prawDataZaistnieniaZmiany;
            set
            {
                if (value != _prawDataZaistnieniaZmiany)
                {
                    _prawDataZaistnieniaZmiany = value;
                    OnPropertyChanged(nameof(PrawDataZaistnieniaZmiany));
                }
            }
        }

        #endregion

        #region private string? _prawDataZakonczeniaDzialalnosci; public string? PrawDataZakonczeniaDzialalnosci

        private string? _prawDataZakonczeniaDzialalnosci;

        /// Praw data zakonczenia dzialalnosci
        /// Praw data zakonczenia dzialalnosci
        [Column(Order = 2)]
        [XmlElement("praw_dataZakonczeniaDzialalnosci")]
        [JsonProperty(nameof(PrawDataZakonczeniaDzialalnosci), Order = 2)]
        [Display(Name = "Praw data zakonczenia dzialalnosci", Prompt = "Wpisz Praw data zakonczenia dzialalnosci",
            Description = "Praw data zakonczenia dzialalnosci")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? PrawDataZakonczeniaDzialalnosci
        {
            get => _prawDataZakonczeniaDzialalnosci;
            set
            {
                if (value != _prawDataZakonczeniaDzialalnosci)
                {
                    _prawDataZakonczeniaDzialalnosci = value;
                    OnPropertyChanged(nameof(PrawDataZakonczeniaDzialalnosci));
                }
            }
        }

        #endregion

        #region private string? _prawDataSkresleniaZRegon; public string? PrawDataSkresleniaZRegon

        private string? _prawDataSkresleniaZRegon;

        /// Praw data skreslenia z regon
        /// Praw data skreslenia z regon
        [Column(Order = 2)]
        [XmlElement("praw_dataSkresleniaZRegon")]
        [JsonProperty(nameof(PrawDataSkresleniaZRegon), Order = 2)]
        [Display(Name = "Praw data skreslenia z regon", Prompt = "Wpisz Praw data skreslenia z regon",
            Description = "Praw data skreslenia z regon")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? PrawDataSkresleniaZRegon
        {
            get => _prawDataSkresleniaZRegon;
            set
            {
                if (value != _prawDataSkresleniaZRegon)
                {
                    _prawDataSkresleniaZRegon = value;
                    OnPropertyChanged(nameof(PrawDataSkresleniaZRegon));
                }
            }
        }

        #endregion

        #region private string? _prawDataOrzeczeniaOUpadlosci; public string? PrawDataOrzeczeniaOUpadlosci

        private string? _prawDataOrzeczeniaOUpadlosci;

        /// Praw data orzeczenia o upadlosci
        /// Praw data orzeczenia o upadlosci
        [Column(Order = 2)]
        [XmlElement("praw_dataOrzeczeniaOUpadlosci")]
        [JsonProperty(nameof(PrawDataOrzeczeniaOUpadlosci), Order = 2)]
        [Display(Name = "Praw data orzeczenia o upadlosci", Prompt = "Wpisz Praw data orzeczenia o upadlosci",
            Description = "Praw data orzeczenia o upadlosci")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? PrawDataOrzeczeniaOUpadlosci
        {
            get => _prawDataOrzeczeniaOUpadlosci;
            set
            {
                if (value != _prawDataOrzeczeniaOUpadlosci)
                {
                    _prawDataOrzeczeniaOUpadlosci = value;
                    OnPropertyChanged(nameof(PrawDataOrzeczeniaOUpadlosci));
                }
            }
        }

        #endregion

        #region private string? _prawDataZakonczeniaPostepowaniaUpadlosciowego...

        private string? _prawDataZakonczeniaPostepowaniaUpadlosciowego;

        /// Praw data zakonczenia postepowania upadlosciowego
        /// Praw data zakonczenia postepowania upadlosciowego
        [Column(Order = 2)]
        [XmlElement("praw_dataZakonczeniaPostepowaniaUpadlosciowego")]
        [JsonProperty(nameof(PrawDataZakonczeniaPostepowaniaUpadlosciowego), Order = 2)]
        [Display(Name = "Praw data zakonczenia postepowania upadlosciowego",
            Prompt = "Wpisz Praw data zakonczenia postepowania upadlosciowego",
            Description = "Praw data zakonczenia postepowania upadlosciowego")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? PrawDataZakonczeniaPostepowaniaUpadlosciowego
        {
            get => _prawDataZakonczeniaPostepowaniaUpadlosciowego;
            set
            {
                if (value != _prawDataZakonczeniaPostepowaniaUpadlosciowego)
                {
                    _prawDataZakonczeniaPostepowaniaUpadlosciowego = value;
                    OnPropertyChanged(nameof(PrawDataZakonczeniaPostepowaniaUpadlosciowego));
                }
            }
        }

        #endregion

        #region private string? _prawAdSiedzKrajSymbol; public string? PrawAdSiedzKrajSymbol

        private string? _prawAdSiedzKrajSymbol;

        /// Praw ad siedz kraj symbol
        /// Praw ad siedz kraj symbol
        [Column(Order = 2)]
        [XmlElement("praw_adSiedzKraj_Symbol")]
        [JsonProperty(nameof(PrawAdSiedzKrajSymbol), Order = 2)]
        [Display(Name = "Praw ad siedz kraj symbol", Prompt = "Wpisz Praw ad siedz kraj symbol",
            Description = "Praw ad siedz kraj symbol")]
        [StringLength(2)]
        [MaxLength(2)]

        public string? PrawAdSiedzKrajSymbol
        {
            get => _prawAdSiedzKrajSymbol;
            set
            {
                if (value != _prawAdSiedzKrajSymbol)
                {
                    _prawAdSiedzKrajSymbol = value;
                    OnPropertyChanged(nameof(PrawAdSiedzKrajSymbol));
                }
            }
        }

        #endregion

        #region private string? _prawAdSiedzWojewodztwoSymbol; public string? PrawAdSiedzWojewodztwoSymbol

        private string? _prawAdSiedzWojewodztwoSymbol;

        /// Praw ad siedz wojewodztwo symbol
        /// Praw ad siedz wojewodztwo symbol
        [Column(Order = 2)]
        [XmlElement("praw_adSiedzWojewodztwo_Symbol")]
        [JsonProperty(nameof(PrawAdSiedzWojewodztwoSymbol), Order = 2)]
        [Display(Name = "Praw ad siedz wojewodztwo symbol", Prompt = "Wpisz Praw ad siedz wojewodztwo symbol",
            Description = "Praw ad siedz wojewodztwo symbol")]
        [StringLength(2)]
        [MaxLength(2)]

        public string? PrawAdSiedzWojewodztwoSymbol
        {
            get => _prawAdSiedzWojewodztwoSymbol;
            set
            {
                if (value != _prawAdSiedzWojewodztwoSymbol)
                {
                    _prawAdSiedzWojewodztwoSymbol = value;
                    OnPropertyChanged(nameof(PrawAdSiedzWojewodztwoSymbol));
                }
            }
        }

        #endregion

        #region private string? _prawAdSiedzPowiatSymbol; public string? PrawAdSiedzPowiatSymbol

        private string? _prawAdSiedzPowiatSymbol;

        /// Praw ad siedz powiat symbol
        /// Praw ad siedz powiat symbol
        [Column(Order = 2)]
        [XmlElement("praw_adSiedzPowiat_Symbol")]
        [JsonProperty(nameof(PrawAdSiedzPowiatSymbol), Order = 2)]
        [Display(Name = "Praw ad siedz powiat symbol", Prompt = "Wpisz Praw ad siedz powiat symbol",
            Description = "Praw ad siedz powiat symbol")]
        [StringLength(2)]
        [MaxLength(2)]

        public string? PrawAdSiedzPowiatSymbol
        {
            get => _prawAdSiedzPowiatSymbol;
            set
            {
                if (value != _prawAdSiedzPowiatSymbol)
                {
                    _prawAdSiedzPowiatSymbol = value;
                    OnPropertyChanged(nameof(PrawAdSiedzPowiatSymbol));
                }
            }
        }

        #endregion

        #region private string? _prawAdSiedzGminaSymbol; public string? PrawAdSiedzGminaSymbol

        private string? _prawAdSiedzGminaSymbol;

        /// Praw ad siedz gmina symbol
        /// Praw ad siedz gmina symbol
        [Column(Order = 2)]
        [XmlElement("praw_adSiedzGmina_Symbol")]
        [JsonProperty(nameof(PrawAdSiedzGminaSymbol), Order = 2)]
        [Display(Name = "Praw ad siedz gmina symbol", Prompt = "Wpisz Praw ad siedz gmina symbol",
            Description = "Praw ad siedz gmina symbol")]
        [StringLength(3)]
        [MaxLength(3)]

        public string? PrawAdSiedzGminaSymbol
        {
            get => _prawAdSiedzGminaSymbol;
            set
            {
                if (value != _prawAdSiedzGminaSymbol)
                {
                    _prawAdSiedzGminaSymbol = value;
                    OnPropertyChanged(nameof(PrawAdSiedzGminaSymbol));
                }
            }
        }

        #endregion

        #region private string? _prawAdSiedzKodPocztowy; public string? PrawAdSiedzKodPocztowy

        private string? _prawAdSiedzKodPocztowy;

        /// Praw ad siedz kod pocztowy
        /// Praw ad siedz kod pocztowy
        [Column(Order = 2)]
        [XmlElement("praw_adSiedzKodPocztowy")]
        [JsonProperty(nameof(PrawAdSiedzKodPocztowy), Order = 2)]
        [Display(Name = "Praw ad siedz kod pocztowy", Prompt = "Wpisz Praw ad siedz kod pocztowy",
            Description = "Praw ad siedz kod pocztowy")]
        [StringLength(12)]
        [MaxLength(12)]

        public string? PrawAdSiedzKodPocztowy
        {
            get => _prawAdSiedzKodPocztowy;
            set
            {
                if (value != _prawAdSiedzKodPocztowy)
                {
                    _prawAdSiedzKodPocztowy = value;
                    OnPropertyChanged(nameof(PrawAdSiedzKodPocztowy));
                }
            }
        }

        #endregion

        #region private string? _prawAdSiedzMiejscowoscPocztySymbol; public string? PrawAdSiedzMiejscowoscPocztySymbol

        private string? _prawAdSiedzMiejscowoscPocztySymbol;

        /// Praw ad siedz miejscowosc poczty symbol
        /// Praw ad siedz miejscowosc poczty symbol
        [Column(Order = 2)]
        [XmlElement("praw_adSiedzMiejscowoscPoczty_Symbol")]
        [JsonProperty(nameof(PrawAdSiedzMiejscowoscPocztySymbol), Order = 2)]
        [Display(Name = "Praw ad siedz miejscowosc poczty symbol",
            Prompt = "Wpisz Praw ad siedz miejscowosc poczty symbol",
            Description = "Praw ad siedz miejscowosc poczty symbol")]
        [StringLength(7)]
        [MaxLength(7)]

        public string? PrawAdSiedzMiejscowoscPocztySymbol
        {
            get => _prawAdSiedzMiejscowoscPocztySymbol;
            set
            {
                if (value != _prawAdSiedzMiejscowoscPocztySymbol)
                {
                    _prawAdSiedzMiejscowoscPocztySymbol = value;
                    OnPropertyChanged(nameof(PrawAdSiedzMiejscowoscPocztySymbol));
                }
            }
        }

        #endregion

        #region private string? _prawAdSiedzMiejscowoscSymbol; public string? PrawAdSiedzMiejscowoscSymbol

        private string? _prawAdSiedzMiejscowoscSymbol;

        /// Praw ad siedz miejscowosc symbol
        /// Praw ad siedz miejscowosc symbol
        [Column(Order = 2)]
        [XmlElement("praw_adSiedzMiejscowosc_Symbol")]
        [JsonProperty(nameof(PrawAdSiedzMiejscowoscSymbol), Order = 2)]
        [Display(Name = "Praw ad siedz miejscowosc symbol", Prompt = "Wpisz Praw ad siedz miejscowosc symbol",
            Description = "Praw ad siedz miejscowosc symbol")]
        [StringLength(7)]
        [MaxLength(7)]

        public string? PrawAdSiedzMiejscowoscSymbol
        {
            get => _prawAdSiedzMiejscowoscSymbol;
            set
            {
                if (value != _prawAdSiedzMiejscowoscSymbol)
                {
                    _prawAdSiedzMiejscowoscSymbol = value;
                    OnPropertyChanged(nameof(PrawAdSiedzMiejscowoscSymbol));
                }
            }
        }

        #endregion

        #region private string? _prawAdSiedzUlicaSymbol; public string? PrawAdSiedzUlicaSymbol

        private string? _prawAdSiedzUlicaSymbol;

        /// Praw ad siedz ulica symbol
        /// Praw ad siedz ulica symbol
        [Column(Order = 2)]
        [XmlElement("praw_adSiedzUlica_Symbol")]
        [JsonProperty(nameof(PrawAdSiedzUlicaSymbol), Order = 2)]
        [Display(Name = "Praw ad siedz ulica symbol", Prompt = "Wpisz Praw ad siedz ulica symbol",
            Description = "Praw ad siedz ulica symbol")]
        [StringLength(5)]
        [MaxLength(5)]

        public string? PrawAdSiedzUlicaSymbol
        {
            get => _prawAdSiedzUlicaSymbol;
            set
            {
                if (value != _prawAdSiedzUlicaSymbol)
                {
                    _prawAdSiedzUlicaSymbol = value;
                    OnPropertyChanged(nameof(PrawAdSiedzUlicaSymbol));
                }
            }
        }

        #endregion

        #region private string? _prawAdSiedzNumerNieruchomosci; public string? PrawAdSiedzNumerNieruchomosci

        private string? _prawAdSiedzNumerNieruchomosci;

        /// Praw ad siedz numer nieruchomosci
        /// Praw ad siedz numer nieruchomosci
        [Column(Order = 2)]
        [XmlElement("praw_adSiedzNumerNieruchomosci")]
        [JsonProperty(nameof(PrawAdSiedzNumerNieruchomosci), Order = 2)]
        [Display(Name = "Praw ad siedz numer nieruchomosci", Prompt = "Wpisz Praw ad siedz numer nieruchomosci",
            Description = "Praw ad siedz numer nieruchomosci")]
        [StringLength(20)]
        [MaxLength(20)]

        public string? PrawAdSiedzNumerNieruchomosci
        {
            get => _prawAdSiedzNumerNieruchomosci;
            set
            {
                if (value != _prawAdSiedzNumerNieruchomosci)
                {
                    _prawAdSiedzNumerNieruchomosci = value;
                    OnPropertyChanged(nameof(PrawAdSiedzNumerNieruchomosci));
                }
            }
        }

        #endregion

        #region private string? _prawAdSiedzNumerLokalu; public string? PrawAdSiedzNumerLokalu

        private string? _prawAdSiedzNumerLokalu;

        /// Praw ad siedz numer lokalu
        /// Praw ad siedz numer lokalu
        [Column(Order = 2)]
        [XmlElement("praw_adSiedzNumerLokalu")]
        [JsonProperty(nameof(PrawAdSiedzNumerLokalu), Order = 2)]
        [Display(Name = "Praw ad siedz numer lokalu", Prompt = "Wpisz Praw ad siedz numer lokalu",
            Description = "Praw ad siedz numer lokalu")]
        [StringLength(10)]
        [MaxLength(10)]

        public string? PrawAdSiedzNumerLokalu
        {
            get => _prawAdSiedzNumerLokalu;
            set
            {
                if (value != _prawAdSiedzNumerLokalu)
                {
                    _prawAdSiedzNumerLokalu = value;
                    OnPropertyChanged(nameof(PrawAdSiedzNumerLokalu));
                }
            }
        }

        #endregion

        #region private string? _prawAdSiedzNietypoweMiejsceLokalizacji; public string? PrawAdSiedzNietypoweMiejsceLokalizacji

        private string? _prawAdSiedzNietypoweMiejsceLokalizacji;

        /// Praw ad siedz nietypowe miejsce lokalizacji
        /// Praw ad siedz nietypowe miejsce lokalizacji
        [Column(Order = 2)]
        [XmlElement("praw_adSiedzNietypoweMiejsceLokalizacji")]
        [JsonProperty(nameof(PrawAdSiedzNietypoweMiejsceLokalizacji), Order = 2)]
        [Display(Name = "Praw ad siedz nietypowe miejsce lokalizacji",
            Prompt = "Wpisz Praw ad siedz nietypowe miejsce lokalizacji",
            Description = "Praw ad siedz nietypowe miejsce lokalizacji")]
        [StringLength(160)]
        [MaxLength(160)]

        public string? PrawAdSiedzNietypoweMiejsceLokalizacji
        {
            get => _prawAdSiedzNietypoweMiejsceLokalizacji;
            set
            {
                if (value != _prawAdSiedzNietypoweMiejsceLokalizacji)
                {
                    _prawAdSiedzNietypoweMiejsceLokalizacji = value;
                    OnPropertyChanged(nameof(PrawAdSiedzNietypoweMiejsceLokalizacji));
                }
            }
        }

        #endregion

        #region private string? _prawNumerTelefonu; public string? PrawNumerTelefonu

        private string? _prawNumerTelefonu;

        /// Praw numer telefonu
        /// Praw numer telefonu
        [Column(Order = 2)]
        [XmlElement("praw_numerTelefonu")]
        [JsonProperty(nameof(PrawNumerTelefonu), Order = 2)]
        [Display(Name = "Praw numer telefonu", Prompt = "Wpisz Praw numer telefonu",
            Description = "Praw numer telefonu")]
        [StringLength(18)]
        [MaxLength(18)]

        public string? PrawNumerTelefonu
        {
            get => _prawNumerTelefonu;
            set
            {
                if (value != _prawNumerTelefonu)
                {
                    _prawNumerTelefonu = value;
                    OnPropertyChanged(nameof(PrawNumerTelefonu));
                }
            }
        }

        #endregion

        #region private string? _prawNumerWewnetrznyTelefonu; public string? PrawNumerWewnetrznyTelefonu

        private string? _prawNumerWewnetrznyTelefonu;

        /// Praw numer wewnetrzny telefonu
        /// Praw numer wewnetrzny telefonu
        [Column(Order = 2)]
        [XmlElement("praw_numerWewnetrznyTelefonu")]
        [JsonProperty(nameof(PrawNumerWewnetrznyTelefonu), Order = 2)]
        [Display(Name = "Praw numer wewnetrzny telefonu", Prompt = "Wpisz Praw numer wewnetrzny telefonu",
            Description = "Praw numer wewnetrzny telefonu")]
        [StringLength(6)]
        [MaxLength(6)]

        public string? PrawNumerWewnetrznyTelefonu
        {
            get => _prawNumerWewnetrznyTelefonu;
            set
            {
                if (value != _prawNumerWewnetrznyTelefonu)
                {
                    _prawNumerWewnetrznyTelefonu = value;
                    OnPropertyChanged(nameof(PrawNumerWewnetrznyTelefonu));
                }
            }
        }

        #endregion

        #region private string? _prawNumerFaksu; public string? PrawNumerFaksu

        private string? _prawNumerFaksu;

        /// Praw numer faksu
        /// Praw numer faksu
        [Column(Order = 2)]
        [XmlElement("praw_numerFaksu")]
        [JsonProperty(nameof(PrawNumerFaksu), Order = 2)]
        [Display(Name = "Praw numer faksu", Prompt = "Wpisz Praw numer faksu", Description = "Praw numer faksu")]
        [StringLength(18)]
        [MaxLength(18)]

        public string? PrawNumerFaksu
        {
            get => _prawNumerFaksu;
            set
            {
                if (value != _prawNumerFaksu)
                {
                    _prawNumerFaksu = value;
                    OnPropertyChanged(nameof(PrawNumerFaksu));
                }
            }
        }

        #endregion

        #region private string? _prawAdresEmail; public string? PrawAdresEmail

        private string? _prawAdresEmail;

        /// Praw adres email
        /// Praw adres email
        [Column(Order = 2)]
        [XmlElement("praw_adresEmail")]
        [JsonProperty(nameof(PrawAdresEmail), Order = 2)]
        [Display(Name = "Praw adres email", Prompt = "Wpisz Praw adres email", Description = "Praw adres email")]
        [StringLength(100)]
        [MaxLength(100)]

        public string? PrawAdresEmail
        {
            get => _prawAdresEmail;
            set
            {
                if (value != _prawAdresEmail)
                {
                    _prawAdresEmail = value;
                    OnPropertyChanged(nameof(PrawAdresEmail));
                }
            }
        }

        #endregion

        #region private string? _prawAdresStronyinternetowej; public string? PrawAdresStronyinternetowej

        private string? _prawAdresStronyinternetowej;

        /// Praw adres stronyinternetowej
        /// Praw adres stronyinternetowej
        [Column(Order = 2)]
        [XmlElement("praw_adresStronyinternetowej")]
        [JsonProperty(nameof(PrawAdresStronyinternetowej), Order = 2)]
        [Display(Name = "Praw adres stronyinternetowej", Prompt = "Wpisz Praw adres stronyinternetowej",
            Description = "Praw adres stronyinternetowej")]
        [StringLength(100)]
        [MaxLength(100)]

        public string? PrawAdresStronyinternetowej
        {
            get => _prawAdresStronyinternetowej;
            set
            {
                if (value != _prawAdresStronyinternetowej)
                {
                    _prawAdresStronyinternetowej = value;
                    OnPropertyChanged(nameof(PrawAdresStronyinternetowej));
                }
            }
        }

        #endregion

        #region private string? _prawAdSiedzKrajNazwa; public string? PrawAdSiedzKrajNazwa

        private string? _prawAdSiedzKrajNazwa;

        /// Praw ad siedz kraj nazwa
        /// Praw ad siedz kraj nazwa
        [Column(Order = 2)]
        [XmlElement("praw_adSiedzKraj_Nazwa")]
        [JsonProperty(nameof(PrawAdSiedzKrajNazwa), Order = 2)]
        [Display(Name = "Praw ad siedz kraj nazwa", Prompt = "Wpisz Praw ad siedz kraj nazwa",
            Description = "Praw ad siedz kraj nazwa")]
        [StringLength(200)]
        [MaxLength(200)]

        public string? PrawAdSiedzKrajNazwa
        {
            get => _prawAdSiedzKrajNazwa;
            set
            {
                if (value != _prawAdSiedzKrajNazwa)
                {
                    _prawAdSiedzKrajNazwa = value;
                    OnPropertyChanged(nameof(PrawAdSiedzKrajNazwa));
                }
            }
        }

        #endregion

        #region private string? _prawAdSiedzWojewodztwoNazwa; public string? PrawAdSiedzWojewodztwoNazwa

        private string? _prawAdSiedzWojewodztwoNazwa;

        /// Praw ad siedz wojewodztwo nazwa
        /// Praw ad siedz wojewodztwo nazwa
        [Column(Order = 2)]
        [XmlElement("praw_adSiedzWojewodztwo_Nazwa")]
        [JsonProperty(nameof(PrawAdSiedzWojewodztwoNazwa), Order = 2)]
        [Display(Name = "Praw ad siedz wojewodztwo nazwa", Prompt = "Wpisz Praw ad siedz wojewodztwo nazwa",
            Description = "Praw ad siedz wojewodztwo nazwa")]
        [StringLength(100)]
        [MaxLength(100)]

        public string? PrawAdSiedzWojewodztwoNazwa
        {
            get => _prawAdSiedzWojewodztwoNazwa;
            set
            {
                if (value != _prawAdSiedzWojewodztwoNazwa)
                {
                    _prawAdSiedzWojewodztwoNazwa = value;
                    OnPropertyChanged(nameof(PrawAdSiedzWojewodztwoNazwa));
                }
            }
        }

        #endregion

        #region private string? _prawAdSiedzPowiatNazwa; public string? PrawAdSiedzPowiatNazwa

        private string? _prawAdSiedzPowiatNazwa;

        /// Praw ad siedz powiat nazwa
        /// Praw ad siedz powiat nazwa
        [Column(Order = 2)]
        [XmlElement("praw_adSiedzPowiat_Nazwa")]
        [JsonProperty(nameof(PrawAdSiedzPowiatNazwa), Order = 2)]
        [Display(Name = "Praw ad siedz powiat nazwa", Prompt = "Wpisz Praw ad siedz powiat nazwa",
            Description = "Praw ad siedz powiat nazwa")]
        [StringLength(100)]
        [MaxLength(100)]

        public string? PrawAdSiedzPowiatNazwa
        {
            get => _prawAdSiedzPowiatNazwa;
            set
            {
                if (value != _prawAdSiedzPowiatNazwa)
                {
                    _prawAdSiedzPowiatNazwa = value;
                    OnPropertyChanged(nameof(PrawAdSiedzPowiatNazwa));
                }
            }
        }

        #endregion

        #region private string? _prawAdSiedzGminaNazwa; public string? PrawAdSiedzGminaNazwa

        private string? _prawAdSiedzGminaNazwa;

        /// Praw ad siedz gmina nazwa
        /// Praw ad siedz gmina nazwa
        [Column(Order = 2)]
        [XmlElement("praw_adSiedzGmina_Nazwa")]
        [JsonProperty(nameof(PrawAdSiedzGminaNazwa), Order = 2)]
        [Display(Name = "Praw ad siedz gmina nazwa", Prompt = "Wpisz Praw ad siedz gmina nazwa",
            Description = "Praw ad siedz gmina nazwa")]
        [StringLength(100)]
        [MaxLength(100)]

        public string? PrawAdSiedzGminaNazwa
        {
            get => _prawAdSiedzGminaNazwa;
            set
            {
                if (value != _prawAdSiedzGminaNazwa)
                {
                    _prawAdSiedzGminaNazwa = value;
                    OnPropertyChanged(nameof(PrawAdSiedzGminaNazwa));
                }
            }
        }

        #endregion

        #region private string? _prawAdSiedzMiejscowoscNazwa; public string? PrawAdSiedzMiejscowoscNazwa

        private string? _prawAdSiedzMiejscowoscNazwa;

        /// Praw ad siedz miejscowosc nazwa
        /// Praw ad siedz miejscowosc nazwa
        [Column(Order = 2)]
        [XmlElement("praw_adSiedzMiejscowosc_Nazwa")]
        [JsonProperty(nameof(PrawAdSiedzMiejscowoscNazwa), Order = 2)]
        [Display(Name = "Praw ad siedz miejscowosc nazwa", Prompt = "Wpisz Praw ad siedz miejscowosc nazwa",
            Description = "Praw ad siedz miejscowosc nazwa")]
        [StringLength(100)]
        [MaxLength(100)]

        public string? PrawAdSiedzMiejscowoscNazwa
        {
            get => _prawAdSiedzMiejscowoscNazwa;
            set
            {
                if (value != _prawAdSiedzMiejscowoscNazwa)
                {
                    _prawAdSiedzMiejscowoscNazwa = value;
                    OnPropertyChanged(nameof(PrawAdSiedzMiejscowoscNazwa));
                }
            }
        }

        #endregion

        #region private string? _prawAdSiedzMiejscowoscPocztyNazwa; public string? PrawAdSiedzMiejscowoscPocztyNazwa

        private string? _prawAdSiedzMiejscowoscPocztyNazwa;

        /// Praw ad siedz miejscowosc poczty nazwa
        /// Praw ad siedz miejscowosc poczty nazwa
        [Column(Order = 2)]
        [XmlElement("praw_adSiedzMiejscowoscPoczty_Nazwa")]
        [JsonProperty(nameof(PrawAdSiedzMiejscowoscPocztyNazwa), Order = 2)]
        [Display(Name = "Praw ad siedz miejscowosc poczty nazwa",
            Prompt = "Wpisz Praw ad siedz miejscowosc poczty nazwa",
            Description = "Praw ad siedz miejscowosc poczty nazwa")]
        [StringLength(100)]
        [MaxLength(100)]

        public string? PrawAdSiedzMiejscowoscPocztyNazwa
        {
            get => _prawAdSiedzMiejscowoscPocztyNazwa;
            set
            {
                if (value != _prawAdSiedzMiejscowoscPocztyNazwa)
                {
                    _prawAdSiedzMiejscowoscPocztyNazwa = value;
                    OnPropertyChanged(nameof(PrawAdSiedzMiejscowoscPocztyNazwa));
                }
            }
        }

        #endregion

        #region private string? _prawAdSiedzUlicaNazwa; public string? PrawAdSiedzUlicaNazwa

        private string? _prawAdSiedzUlicaNazwa;

        /// Praw ad siedz ulica nazwa
        /// Praw ad siedz ulica nazwa
        [Column(Order = 2)]
        [XmlElement("praw_adSiedzUlica_Nazwa")]
        [JsonProperty(nameof(PrawAdSiedzUlicaNazwa), Order = 2)]
        [Display(Name = "Praw ad siedz ulica nazwa", Prompt = "Wpisz Praw ad siedz ulica nazwa",
            Description = "Praw ad siedz ulica nazwa")]
        [StringLength(351)]
        [MaxLength(351)]

        public string? PrawAdSiedzUlicaNazwa
        {
            get => _prawAdSiedzUlicaNazwa;
            set
            {
                if (value != _prawAdSiedzUlicaNazwa)
                {
                    _prawAdSiedzUlicaNazwa = value;
                    OnPropertyChanged(nameof(PrawAdSiedzUlicaNazwa));
                }
            }
        }

        #endregion

        #region private string? _prawPodstawowaFormaPrawnaSymbol; public string? PrawPodstawowaFormaPrawnaSymbol

        private string? _prawPodstawowaFormaPrawnaSymbol;

        /// Praw podstawowa forma prawna symbol
        /// Praw podstawowa forma prawna symbol
        [Column(Order = 2)]
        [XmlElement("praw_podstawowaFormaPrawna_Symbol")]
        [JsonProperty(nameof(PrawPodstawowaFormaPrawnaSymbol), Order = 2)]
        [Display(Name = "Praw podstawowa forma prawna symbol", Prompt = "Wpisz Praw podstawowa forma prawna symbol",
            Description = "Praw podstawowa forma prawna symbol")]
        [StringLength(3)]
        [MaxLength(3)]

        public string? PrawPodstawowaFormaPrawnaSymbol
        {
            get => _prawPodstawowaFormaPrawnaSymbol;
            set
            {
                if (value != _prawPodstawowaFormaPrawnaSymbol)
                {
                    _prawPodstawowaFormaPrawnaSymbol = value;
                    OnPropertyChanged(nameof(PrawPodstawowaFormaPrawnaSymbol));
                }
            }
        }

        #endregion

        #region private string? _prawSzczegolnaFormaPrawnaSymbol; public string? PrawSzczegolnaFormaPrawnaSymbol

        private string? _prawSzczegolnaFormaPrawnaSymbol;

        /// Praw szczegolna forma prawna symbol
        /// Praw szczegolna forma prawna symbol
        [Column(Order = 2)]
        [XmlElement("praw_szczegolnaFormaPrawna_Symbol")]
        [JsonProperty(nameof(PrawSzczegolnaFormaPrawnaSymbol), Order = 2)]
        [Display(Name = "Praw szczegolna forma prawna symbol", Prompt = "Wpisz Praw szczegolna forma prawna symbol",
            Description = "Praw szczegolna forma prawna symbol")]
        [StringLength(3)]
        [MaxLength(3)]

        public string? PrawSzczegolnaFormaPrawnaSymbol
        {
            get => _prawSzczegolnaFormaPrawnaSymbol;
            set
            {
                if (value != _prawSzczegolnaFormaPrawnaSymbol)
                {
                    _prawSzczegolnaFormaPrawnaSymbol = value;
                    OnPropertyChanged(nameof(PrawSzczegolnaFormaPrawnaSymbol));
                }
            }
        }

        #endregion

        #region private string? _prawFormaFinansowaniaSymbol; public string? PrawFormaFinansowaniaSymbol

        private string? _prawFormaFinansowaniaSymbol;

        /// Praw forma finansowania symbol
        /// Praw forma finansowania symbol
        [Column(Order = 2)]
        [XmlElement("praw_formaFinansowania_Symbol")]
        [JsonProperty(nameof(PrawFormaFinansowaniaSymbol), Order = 2)]
        [Display(Name = "Praw forma finansowania symbol", Prompt = "Wpisz Praw forma finansowania symbol",
            Description = "Praw forma finansowania symbol")]
        [StringLength(1)]
        [MaxLength(1)]

        public string? PrawFormaFinansowaniaSymbol
        {
            get => _prawFormaFinansowaniaSymbol;
            set
            {
                if (value != _prawFormaFinansowaniaSymbol)
                {
                    _prawFormaFinansowaniaSymbol = value;
                    OnPropertyChanged(nameof(PrawFormaFinansowaniaSymbol));
                }
            }
        }

        #endregion

        #region private string? _prawFormaWlasnosciSymbol; public string? PrawFormaWlasnosciSymbol

        private string? _prawFormaWlasnosciSymbol;

        /// Praw forma wlasnosci symbol
        /// Praw forma wlasnosci symbol
        [Column(Order = 2)]
        [XmlElement("praw_formaWlasnosci_Symbol")]
        [JsonProperty(nameof(PrawFormaWlasnosciSymbol), Order = 2)]
        [Display(Name = "Praw forma wlasnosci symbol", Prompt = "Wpisz Praw forma wlasnosci symbol",
            Description = "Praw forma wlasnosci symbol")]
        [StringLength(50)]
        [MaxLength(50)]

        public string? PrawFormaWlasnosciSymbol
        {
            get => _prawFormaWlasnosciSymbol;
            set
            {
                if (value != _prawFormaWlasnosciSymbol)
                {
                    _prawFormaWlasnosciSymbol = value;
                    OnPropertyChanged(nameof(PrawFormaWlasnosciSymbol));
                }
            }
        }

        #endregion

        #region private string? _prawOrganZalozycielskiSymbol; public string? PrawOrganZalozycielskiSymbol

        private string? _prawOrganZalozycielskiSymbol;

        /// Praw organ zalozycielski symbol
        /// Praw organ zalozycielski symbol
        [Column(Order = 2)]
        [XmlElement("praw_organZalozycielski_Symbol")]
        [JsonProperty(nameof(PrawOrganZalozycielskiSymbol), Order = 2)]
        [Display(Name = "Praw organ zalozycielski symbol", Prompt = "Wpisz Praw organ zalozycielski symbol",
            Description = "Praw organ zalozycielski symbol")]
        [StringLength(9)]
        [MaxLength(9)]

        public string? PrawOrganZalozycielskiSymbol
        {
            get => _prawOrganZalozycielskiSymbol;
            set
            {
                if (value != _prawOrganZalozycielskiSymbol)
                {
                    _prawOrganZalozycielskiSymbol = value;
                    OnPropertyChanged(nameof(PrawOrganZalozycielskiSymbol));
                }
            }
        }

        #endregion

        #region private string? _prawOrganRejestrowySymbol; public string? PrawOrganRejestrowySymbol

        private string? _prawOrganRejestrowySymbol;

        /// Praw organ rejestrowy symbol
        /// Praw organ rejestrowy symbol
        [Column(Order = 2)]
        [XmlElement("praw_organRejestrowy_Symbol")]
        [JsonProperty(nameof(PrawOrganRejestrowySymbol), Order = 2)]
        [Display(Name = "Praw organ rejestrowy symbol", Prompt = "Wpisz Praw organ rejestrowy symbol",
            Description = "Praw organ rejestrowy symbol")]
        [StringLength(9)]
        [MaxLength(9)]

        public string? PrawOrganRejestrowySymbol
        {
            get => _prawOrganRejestrowySymbol;
            set
            {
                if (value != _prawOrganRejestrowySymbol)
                {
                    _prawOrganRejestrowySymbol = value;
                    OnPropertyChanged(nameof(PrawOrganRejestrowySymbol));
                }
            }
        }

        #endregion

        #region private string? _prawRodzajRejestruEwidencjiSymbol; public string? PrawRodzajRejestruEwidencjiSymbol

        private string? _prawRodzajRejestruEwidencjiSymbol;

        /// Praw rodzaj rejestru ewidencji symbol
        /// Praw rodzaj rejestru ewidencji symbol
        [Column(Order = 2)]
        [XmlElement("praw_rodzajRejestruEwidencji_Symbol")]
        [JsonProperty(nameof(PrawRodzajRejestruEwidencjiSymbol), Order = 2)]
        [Display(Name = "Praw rodzaj rejestru ewidencji symbol", Prompt = "Wpisz Praw rodzaj rejestru ewidencji symbol",
            Description = "Praw rodzaj rejestru ewidencji symbol")]
        [StringLength(3)]
        [MaxLength(3)]

        public string? PrawRodzajRejestruEwidencjiSymbol
        {
            get => _prawRodzajRejestruEwidencjiSymbol;
            set
            {
                if (value != _prawRodzajRejestruEwidencjiSymbol)
                {
                    _prawRodzajRejestruEwidencjiSymbol = value;
                    OnPropertyChanged(nameof(PrawRodzajRejestruEwidencjiSymbol));
                }
            }
        }

        #endregion

        #region private string? _prawPodstawowaFormaPrawnaNazwa; public string? PrawPodstawowaFormaPrawnaNazwa

        private string? _prawPodstawowaFormaPrawnaNazwa;

        /// Praw podstawowa forma prawna nazwa
        /// Praw podstawowa forma prawna nazwa
        [Column(Order = 2)]
        [XmlElement("praw_podstawowaFormaPrawna_Nazwa")]
        [JsonProperty(nameof(PrawPodstawowaFormaPrawnaNazwa), Order = 2)]
        [Display(Name = "Praw podstawowa forma prawna nazwa", Prompt = "Wpisz Praw podstawowa forma prawna nazwa",
            Description = "Praw podstawowa forma prawna nazwa")]
        [StringLength(200)]
        [MaxLength(200)]

        public string? PrawPodstawowaFormaPrawnaNazwa
        {
            get => _prawPodstawowaFormaPrawnaNazwa;
            set
            {
                if (value != _prawPodstawowaFormaPrawnaNazwa)
                {
                    _prawPodstawowaFormaPrawnaNazwa = value;
                    OnPropertyChanged(nameof(PrawPodstawowaFormaPrawnaNazwa));
                }
            }
        }

        #endregion

        #region private string? _prawSzczegolnaFormaPrawnaNazwa; public string? PrawSzczegolnaFormaPrawnaNazwa

        private string? _prawSzczegolnaFormaPrawnaNazwa;

        /// Praw szczegolna forma prawna nazwa
        /// Praw szczegolna forma prawna nazwa
        [Column(Order = 2)]
        [XmlElement("praw_szczegolnaFormaPrawna_Nazwa")]
        [JsonProperty(nameof(PrawSzczegolnaFormaPrawnaNazwa), Order = 2)]
        [Display(Name = "Praw szczegolna forma prawna nazwa", Prompt = "Wpisz Praw szczegolna forma prawna nazwa",
            Description = "Praw szczegolna forma prawna nazwa")]
        [StringLength(200)]
        [MaxLength(200)]

        public string? PrawSzczegolnaFormaPrawnaNazwa
        {
            get => _prawSzczegolnaFormaPrawnaNazwa;
            set
            {
                if (value != _prawSzczegolnaFormaPrawnaNazwa)
                {
                    _prawSzczegolnaFormaPrawnaNazwa = value;
                    OnPropertyChanged(nameof(PrawSzczegolnaFormaPrawnaNazwa));
                }
            }
        }

        #endregion

        #region private string? _prawFormaFinansowaniaNazwa; public string? PrawFormaFinansowaniaNazwa

        private string? _prawFormaFinansowaniaNazwa;

        /// Praw forma finansowania nazwa
        /// Praw forma finansowania nazwa
        [Column(Order = 2)]
        [XmlElement("praw_formaFinansowania_Nazwa")]
        [JsonProperty(nameof(PrawFormaFinansowaniaNazwa), Order = 2)]
        [Display(Name = "Praw forma finansowania nazwa", Prompt = "Wpisz Praw forma finansowania nazwa",
            Description = "Praw forma finansowania nazwa")]
        [StringLength(240)]
        [MaxLength(240)]

        public string? PrawFormaFinansowaniaNazwa
        {
            get => _prawFormaFinansowaniaNazwa;
            set
            {
                if (value != _prawFormaFinansowaniaNazwa)
                {
                    _prawFormaFinansowaniaNazwa = value;
                    OnPropertyChanged(nameof(PrawFormaFinansowaniaNazwa));
                }
            }
        }

        #endregion

        #region private string? _prawFormaWlasnosciNazwa; public string? PrawFormaWlasnosciNazwa

        private string? _prawFormaWlasnosciNazwa;

        /// Praw forma wlasnosci nazwa
        /// Praw forma wlasnosci nazwa
        [Column(Order = 2)]
        [XmlElement("praw_formaWlasnosci_Nazwa")]
        [JsonProperty(nameof(PrawFormaWlasnosciNazwa), Order = 2)]
        [Display(Name = "Praw forma wlasnosci nazwa", Prompt = "Wpisz Praw forma wlasnosci nazwa",
            Description = "Praw forma wlasnosci nazwa")]
        [StringLength(240)]
        [MaxLength(240)]

        public string? PrawFormaWlasnosciNazwa
        {
            get => _prawFormaWlasnosciNazwa;
            set
            {
                if (value != _prawFormaWlasnosciNazwa)
                {
                    _prawFormaWlasnosciNazwa = value;
                    OnPropertyChanged(nameof(PrawFormaWlasnosciNazwa));
                }
            }
        }

        #endregion

        #region private string? _prawOrganZalozycielskiNazwa; public string? PrawOrganZalozycielskiNazwa

        private string? _prawOrganZalozycielskiNazwa;

        /// Praw organ zalozycielski nazwa
        /// Praw organ zalozycielski nazwa
        [Column(Order = 2)]
        [XmlElement("praw_organZalozycielski_Nazwa")]
        [JsonProperty(nameof(PrawOrganZalozycielskiNazwa), Order = 2)]
        [Display(Name = "Praw organ zalozycielski nazwa", Prompt = "Wpisz Praw organ zalozycielski nazwa",
            Description = "Praw organ zalozycielski nazwa")]
        [StringLength(200)]
        [MaxLength(200)]

        public string? PrawOrganZalozycielskiNazwa
        {
            get => _prawOrganZalozycielskiNazwa;
            set
            {
                if (value != _prawOrganZalozycielskiNazwa)
                {
                    _prawOrganZalozycielskiNazwa = value;
                    OnPropertyChanged(nameof(PrawOrganZalozycielskiNazwa));
                }
            }
        }

        #endregion

        #region private string? _prawOrganRejestrowyNazwa; public string? PrawOrganRejestrowyNazwa

        private string? _prawOrganRejestrowyNazwa;

        /// Praw organ rejestrowy nazwa
        /// Praw organ rejestrowy nazwa
        [Column(Order = 2)]
        [XmlElement("praw_organRejestrowy_Nazwa")]
        [JsonProperty(nameof(PrawOrganRejestrowyNazwa), Order = 2)]
        [Display(Name = "Praw organ rejestrowy nazwa", Prompt = "Wpisz Praw organ rejestrowy nazwa",
            Description = "Praw organ rejestrowy nazwa")]
        [StringLength(240)]
        [MaxLength(240)]

        public string? PrawOrganRejestrowyNazwa
        {
            get => _prawOrganRejestrowyNazwa;
            set
            {
                if (value != _prawOrganRejestrowyNazwa)
                {
                    _prawOrganRejestrowyNazwa = value;
                    OnPropertyChanged(nameof(PrawOrganRejestrowyNazwa));
                }
            }
        }

        #endregion

        #region private string? _prawRodzajRejestruEwidencjiNazwa; public string? PrawRodzajRejestruEwidencjiNazwa

        private string? _prawRodzajRejestruEwidencjiNazwa;

        /// Praw rodzaj rejestru ewidencji nazwa
        /// Praw rodzaj rejestru ewidencji nazwa
        [Column(Order = 2)]
        [XmlElement("praw_rodzajRejestruEwidencji_Nazwa")]
        [JsonProperty(nameof(PrawRodzajRejestruEwidencjiNazwa), Order = 2)]
        [Display(Name = "Praw rodzaj rejestru ewidencji nazwa", Prompt = "Wpisz Praw rodzaj rejestru ewidencji nazwa",
            Description = "Praw rodzaj rejestru ewidencji nazwa")]
        [StringLength(240)]
        [MaxLength(240)]

        public string? PrawRodzajRejestruEwidencjiNazwa
        {
            get => _prawRodzajRejestruEwidencjiNazwa;
            set
            {
                if (value != _prawRodzajRejestruEwidencjiNazwa)
                {
                    _prawRodzajRejestruEwidencjiNazwa = value;
                    OnPropertyChanged(nameof(PrawRodzajRejestruEwidencjiNazwa));
                }
            }
        }

        #endregion

        #region private int? _prawLiczbaJednLokalnych; public int? PrawLiczbaJednLokalnych

        private int? _prawLiczbaJednLokalnych;

        /// Praw liczba jedn lokalnych
        /// Praw liczba jedn lokalnych
        [Column(Order = 2)]
        [XmlElement("praw_liczbaJednLokalnych")]
        [JsonProperty(nameof(PrawLiczbaJednLokalnych), Order = 2)]
        [Display(Name = "Praw liczba jedn lokalnych", Prompt = "Wpisz Praw liczba jedn lokalnych",
            Description = "Praw liczba jedn lokalnych")]
        [Range(int.MinValue, int.MaxValue)]
        public int? PrawLiczbaJednLokalnych
        {
            get => _prawLiczbaJednLokalnych;
            set
            {
                if (value != _prawLiczbaJednLokalnych)
                {
                    _prawLiczbaJednLokalnych = value;
                    OnPropertyChanged(nameof(PrawLiczbaJednLokalnych));
                }
            }
        }

        #endregion
    }

    #endregion
}

#endregion
