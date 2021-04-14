#region using

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using NetAppCommon.Logging.ClientMessageInspector.Models.Base;
using Newtonsoft.Json;
using PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport;
using PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty;

#endregion

#nullable enable annotations

#region namespace

namespace PortalApiGus.ApiRegon.Core.Models
{
    /// <summary>
    ///     Model danych inspektor wiadomości soap
    ///     Data model inspector soap
    /// </summary>
    [Table(nameof(MessageInspector), Schema = "pagard")]
    [JsonObject(nameof(MessageInspector))]
    [Display(Name = "Inspektor wiadomości soap", Description = "Model danych inspektor wiadomości soap")]
    public class MessageInspector : MessageInspectorModel
    {
        #region public override DateTime DateOfCreate...

        /// <summary>
        ///     Data utworzenia
        ///     Date of create
        /// </summary>
        [Column("DataUtworzenia", Order = 3)]
        [JsonProperty("DataUtworzenia", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Data utworzenia", Prompt = "Wpisz lub wybierz datę utworzenia",
            Description = "Data utworzenia")]
        [DataType(DataType.Date)]
        public override DateTime DateOfCreate => base.DateOfCreate;

        #endregion

        #region public override DateTime? DateOfModification...

        /// <summary>
        ///     Data modyfikacji
        ///     Date of modification
        /// </summary>
        [Column("DataModyfikacji", Order = 3)]
        [JsonProperty("DataModyfikacji", Order = 3)]
        [Display(Name = "Data modyfikacji", Prompt = "Wpisz lub wybierz datę modyfikacji",
            Description = "Data modyfikacji")]
        [DataType(DataType.Date)]
        public override DateTime? DateOfModification => base.DateOfModification;

        #endregion

        //#region private ICollection<DaneSzukajPodmiotyMessageInspector>...

        //private ICollection<DaneSzukajPodmiotyMessageInspector>? _daneSzukajPodmiotyMessageInspector;

        ///// <summary>
        /////     Kolekcja elementów inspektora wiadomości usługi
        /////     Service Message Inspector Item Collection
        ///// </summary>
        //[XmlIgnore]
        //[JsonProperty(nameof(DaneSzukajPodmiotyMessageInspector), Order = 2)]
        //[Display(Name = "Inspektor wiadomości usługi",
        //    Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
        //    Description = "Kolekcja elementów inspektora wiadomości usługi")]
        //public virtual ICollection<DaneSzukajPodmiotyMessageInspector>? DaneSzukajPodmiotyMessageInspector
        //{
        //    get => _daneSzukajPodmiotyMessageInspector;
        //    set
        //    {
        //        if (!Equals(value, _daneSzukajPodmiotyMessageInspector))
        //        {
        //            _daneSzukajPodmiotyMessageInspector = value;
        //            OnPropertyChanged(nameof(DaneSzukajPodmiotyMessageInspector));
        //        }
        //    }
        //}

        //#endregion

        //#region private ICollection<BIR11JednLokalnaOsFizycznejMessageInspector>...

        //private ICollection<BIR11JednLokalnaOsFizycznejMessageInspector>? _bir11JednLokalnaOsFizycznejMessageInspector;

        ///// <summary>
        /////     Kolekcja elementów inspektora wiadomości usługi
        /////     Service Message Inspector Item Collection
        ///// </summary>
        //[XmlIgnore]
        //[JsonProperty(nameof(BIR11JednLokalnaOsFizycznejMessageInspector), Order = 2)]
        //[Display(Name = "Inspektor wiadomości usługi",
        //    Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
        //    Description = "Kolekcja elementów inspektora wiadomości usługi")]
        //public virtual ICollection<BIR11JednLokalnaOsFizycznejMessageInspector>? BIR11JednLokalnaOsFizycznejMessageInspector
        //{
        //    get => _bir11JednLokalnaOsFizycznejMessageInspector;
        //    set
        //    {
        //        if (!Equals(value, _bir11JednLokalnaOsFizycznejMessageInspector))
        //        {
        //            _bir11JednLokalnaOsFizycznejMessageInspector = value;
        //            OnPropertyChanged(nameof(BIR11JednLokalnaOsFizycznejMessageInspector));
        //        }
        //    }
        //}

        //#endregion

        //#region private ICollection<BIR11JednLokalnaOsFizycznejPkdMessageInspector>...

        //private ICollection<BIR11JednLokalnaOsFizycznejPkdMessageInspector>? _bir11JednLokalnaOsFizycznejPkdMessageInspector;

        ///// <summary>
        /////     Kolekcja elementów inspektora wiadomości usługi
        /////     Service Message Inspector Item Collection
        ///// </summary>
        //[XmlIgnore]
        //[JsonProperty(nameof(BIR11JednLokalnaOsFizycznejPkdMessageInspector), Order = 2)]
        //[Display(Name = "Inspektor wiadomości usługi",
        //    Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
        //    Description = "Kolekcja elementów inspektora wiadomości usługi")]
        //public virtual ICollection<BIR11JednLokalnaOsFizycznejPkdMessageInspector>? BIR11JednLokalnaOsFizycznejPkdMessageInspector
        //{
        //    get => _bir11JednLokalnaOsFizycznejPkdMessageInspector;
        //    set
        //    {
        //        if (!Equals(value, _bir11JednLokalnaOsFizycznejPkdMessageInspector))
        //        {
        //            _bir11JednLokalnaOsFizycznejPkdMessageInspector = value;
        //            OnPropertyChanged(nameof(BIR11JednLokalnaOsFizycznejPkdMessageInspector));
        //        }
        //    }
        //}

        //#endregion

        //#region private ICollection<BIR11JednLokalnaOsPrawnejMessageInspector>...

        //private ICollection<BIR11JednLokalnaOsPrawnejMessageInspector>? _bir11JednLokalnaOsPrawnejMessageInspector;

        ///// <summary>
        /////     Kolekcja elementów inspektora wiadomości usługi
        /////     Service Message Inspector Item Collection
        ///// </summary>
        //[XmlIgnore]
        //[JsonProperty(nameof(BIR11JednLokalnaOsPrawnejMessageInspector), Order = 2)]
        //[Display(Name = "Inspektor wiadomości usługi",
        //    Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
        //    Description = "Kolekcja elementów inspektora wiadomości usługi")]
        //public virtual ICollection<BIR11JednLokalnaOsPrawnejMessageInspector>? BIR11JednLokalnaOsPrawnejMessageInspector
        //{
        //    get => _bir11JednLokalnaOsPrawnejMessageInspector;
        //    set
        //    {
        //        if (!Equals(value, _bir11JednLokalnaOsPrawnejMessageInspector))
        //        {
        //            _bir11JednLokalnaOsPrawnejMessageInspector = value;
        //            OnPropertyChanged(nameof(BIR11JednLokalnaOsPrawnejMessageInspector));
        //        }
        //    }
        //}

        //#endregion

        //#region private ICollection<BIR11JednLokalnaOsPrawnejPkdMessageInspector>...

        //private ICollection<BIR11JednLokalnaOsPrawnejPkdMessageInspector>? _bir11JednLokalnaOsPrawnejPkdMessageInspector;

        ///// <summary>
        /////     Kolekcja elementów inspektora wiadomości usługi
        /////     Service Message Inspector Item Collection
        ///// </summary>
        //[XmlIgnore]
        //[JsonProperty(nameof(BIR11JednLokalnaOsPrawnejPkdMessageInspector), Order = 2)]
        //[Display(Name = "Inspektor wiadomości usługi",
        //    Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
        //    Description = "Kolekcja elementów inspektora wiadomości usługi")]
        //public virtual ICollection<BIR11JednLokalnaOsPrawnejPkdMessageInspector>? BIR11JednLokalnaOsPrawnejPkdMessageInspector
        //{
        //    get => _bir11JednLokalnaOsPrawnejPkdMessageInspector;
        //    set
        //    {
        //        if (!Equals(value, _bir11JednLokalnaOsPrawnejPkdMessageInspector))
        //        {
        //            _bir11JednLokalnaOsPrawnejPkdMessageInspector = value;
        //            OnPropertyChanged(nameof(BIR11JednLokalnaOsPrawnejPkdMessageInspector));
        //        }
        //    }
        //}

        //#endregion

        //#region private ICollection<BIR11OsFizycznaDaneOgolneMessageInspector>...

        //private ICollection<BIR11OsFizycznaDaneOgolneMessageInspector>? _bir11OsFizycznaDaneOgolneMessageInspector;

        ///// <summary>
        /////     Kolekcja elementów inspektora wiadomości usługi
        /////     Service Message Inspector Item Collection
        ///// </summary>
        //[XmlIgnore]
        //[JsonProperty(nameof(BIR11OsFizycznaDaneOgolneMessageInspector), Order = 2)]
        //[Display(Name = "Inspektor wiadomości usługi",
        //    Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
        //    Description = "Kolekcja elementów inspektora wiadomości usługi")]
        //public virtual ICollection<BIR11OsFizycznaDaneOgolneMessageInspector>? BIR11OsFizycznaDaneOgolneMessageInspector
        //{
        //    get => _bir11OsFizycznaDaneOgolneMessageInspector;
        //    set
        //    {
        //        if (!Equals(value, _bir11OsFizycznaDaneOgolneMessageInspector))
        //        {
        //            _bir11OsFizycznaDaneOgolneMessageInspector = value;
        //            OnPropertyChanged(nameof(BIR11OsFizycznaDaneOgolneMessageInspector));
        //        }
        //    }
        //}

        //#endregion

        //#region private ICollection<BIR11OsFizycznaDzialalnoscCeidgMessageInspector>...

        //private ICollection<BIR11OsFizycznaDzialalnoscCeidgMessageInspector>? _bir11OsFizycznaDzialalnoscCeidgMessageInspector;

        ///// <summary>
        /////     Kolekcja elementów inspektora wiadomości usługi
        /////     Service Message Inspector Item Collection
        ///// </summary>
        //[XmlIgnore]
        //[JsonProperty(nameof(BIR11OsFizycznaDzialalnoscCeidgMessageInspector), Order = 2)]
        //[Display(Name = "Inspektor wiadomości usługi",
        //    Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
        //    Description = "Kolekcja elementów inspektora wiadomości usługi")]
        //public virtual ICollection<BIR11OsFizycznaDzialalnoscCeidgMessageInspector>? BIR11OsFizycznaDzialalnoscCeidgMessageInspector
        //{
        //    get => _bir11OsFizycznaDzialalnoscCeidgMessageInspector;
        //    set
        //    {
        //        if (!Equals(value, _bir11OsFizycznaDzialalnoscCeidgMessageInspector))
        //        {
        //            _bir11OsFizycznaDzialalnoscCeidgMessageInspector = value;
        //            OnPropertyChanged(nameof(BIR11OsFizycznaDzialalnoscCeidgMessageInspector));
        //        }
        //    }
        //}

        //#endregion

        //#region private ICollection<BIR11OsFizycznaDzialalnoscPozostalaMessageInspector>...

        //private ICollection<BIR11OsFizycznaDzialalnoscPozostalaMessageInspector>? _bir11OsFizycznaDzialalnoscPozostalaMessageInspector;

        ///// <summary>
        /////     Kolekcja elementów inspektora wiadomości usługi
        /////     Service Message Inspector Item Collection
        ///// </summary>
        //[XmlIgnore]
        //[JsonProperty(nameof(BIR11OsFizycznaDzialalnoscPozostalaMessageInspector), Order = 2)]
        //[Display(Name = "Inspektor wiadomości usługi",
        //    Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
        //    Description = "Kolekcja elementów inspektora wiadomości usługi")]
        //public virtual ICollection<BIR11OsFizycznaDzialalnoscPozostalaMessageInspector>? BIR11OsFizycznaDzialalnoscPozostalaMessageInspector
        //{
        //    get => _bir11OsFizycznaDzialalnoscPozostalaMessageInspector;
        //    set
        //    {
        //        if (!Equals(value, _bir11OsFizycznaDzialalnoscPozostalaMessageInspector))
        //        {
        //            _bir11OsFizycznaDzialalnoscPozostalaMessageInspector = value;
        //            OnPropertyChanged(nameof(BIR11OsFizycznaDzialalnoscPozostalaMessageInspector));
        //        }
        //    }
        //}

        //#endregion

        //#region private ICollection<BIR11OsFizycznaDzialalnoscRolniczaMessageInspector>...

        //private ICollection<BIR11OsFizycznaDzialalnoscRolniczaMessageInspector>? _bir11OsFizycznaDzialalnoscRolniczaMessageInspector;

        ///// <summary>
        /////     Kolekcja elementów inspektora wiadomości usługi
        /////     Service Message Inspector Item Collection
        ///// </summary>
        //[XmlIgnore]
        //[JsonProperty(nameof(BIR11OsFizycznaDzialalnoscRolniczaMessageInspector), Order = 2)]
        //[Display(Name = "Inspektor wiadomości usługi",
        //    Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
        //    Description = "Kolekcja elementów inspektora wiadomości usługi")]
        //public virtual ICollection<BIR11OsFizycznaDzialalnoscRolniczaMessageInspector>? BIR11OsFizycznaDzialalnoscRolniczaMessageInspector
        //{
        //    get => _bir11OsFizycznaDzialalnoscRolniczaMessageInspector;
        //    set
        //    {
        //        if (!Equals(value, _bir11OsFizycznaDzialalnoscRolniczaMessageInspector))
        //        {
        //            _bir11OsFizycznaDzialalnoscRolniczaMessageInspector = value;
        //            OnPropertyChanged(nameof(BIR11OsFizycznaDzialalnoscRolniczaMessageInspector));
        //        }
        //    }
        //}

        //#endregion

        //#region private ICollection<BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector>...

        //private ICollection<BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector>? _bir11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector;

        ///// <summary>
        /////     Kolekcja elementów inspektora wiadomości usługi
        /////     Service Message Inspector Item Collection
        ///// </summary>
        //[XmlIgnore]
        //[JsonProperty(nameof(BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector), Order = 2)]
        //[Display(Name = "Inspektor wiadomości usługi",
        //    Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
        //    Description = "Kolekcja elementów inspektora wiadomości usługi")]
        //public virtual ICollection<BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector>? BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector
        //{
        //    get => _bir11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector;
        //    set
        //    {
        //        if (!Equals(value, _bir11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector))
        //        {
        //            _bir11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector = value;
        //            OnPropertyChanged(nameof(BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector));
        //        }
        //    }
        //}

        //#endregion

        //#region private ICollection<BIR11OsFizycznaListaJednLokalnychMessageInspector>...

        //private ICollection<BIR11OsFizycznaListaJednLokalnychMessageInspector>? _bir11OsFizycznaListaJednLokalnychMessageInspector;

        ///// <summary>
        /////     Kolekcja elementów inspektora wiadomości usługi
        /////     Service Message Inspector Item Collection
        ///// </summary>
        //[XmlIgnore]
        //[JsonProperty(nameof(BIR11OsFizycznaListaJednLokalnychMessageInspector), Order = 2)]
        //[Display(Name = "Inspektor wiadomości usługi",
        //    Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
        //    Description = "Kolekcja elementów inspektora wiadomości usługi")]
        //public virtual ICollection<BIR11OsFizycznaListaJednLokalnychMessageInspector>? BIR11OsFizycznaListaJednLokalnychMessageInspector
        //{
        //    get => _bir11OsFizycznaListaJednLokalnychMessageInspector;
        //    set
        //    {
        //        if (!Equals(value, _bir11OsFizycznaListaJednLokalnychMessageInspector))
        //        {
        //            _bir11OsFizycznaListaJednLokalnychMessageInspector = value;
        //            OnPropertyChanged(nameof(BIR11OsFizycznaListaJednLokalnychMessageInspector));
        //        }
        //    }
        //}

        //#endregion

        //#region private ICollection<BIR11OsFizycznaPkdMessageInspector>...

        //private ICollection<BIR11OsFizycznaPkdMessageInspector>? _bir11OsFizycznaPkdMessageInspector;

        ///// <summary>
        /////     Kolekcja elementów inspektora wiadomości usługi
        /////     Service Message Inspector Item Collection
        ///// </summary>
        //[XmlIgnore]
        //[JsonProperty(nameof(BIR11OsFizycznaPkdMessageInspector), Order = 2)]
        //[Display(Name = "Inspektor wiadomości usługi",
        //    Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
        //    Description = "Kolekcja elementów inspektora wiadomości usługi")]
        //public virtual ICollection<BIR11OsFizycznaPkdMessageInspector>? BIR11OsFizycznaPkdMessageInspector
        //{
        //    get => _bir11OsFizycznaPkdMessageInspector;
        //    set
        //    {
        //        if (!Equals(value, _bir11OsFizycznaPkdMessageInspector))
        //        {
        //            _bir11OsFizycznaPkdMessageInspector = value;
        //            OnPropertyChanged(nameof(BIR11OsFizycznaPkdMessageInspector));
        //        }
        //    }
        //}

        //#endregion

        //#region private ICollection<BIR11OsPrawnaMessageInspector>...

        //private ICollection<BIR11OsPrawnaMessageInspector>? _bir11OsPrawnaMessageInspector;

        ///// <summary>
        /////     Kolekcja elementów inspektora wiadomości usługi
        /////     Service Message Inspector Item Collection
        ///// </summary>
        //[XmlIgnore]
        //[JsonProperty(nameof(BIR11OsPrawnaMessageInspector), Order = 2)]
        //[Display(Name = "Inspektor wiadomości usługi",
        //    Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
        //    Description = "Kolekcja elementów inspektora wiadomości usługi")]
        //public virtual ICollection<BIR11OsPrawnaMessageInspector>? BIR11OsPrawnaMessageInspector
        //{
        //    get => _bir11OsPrawnaMessageInspector;
        //    set
        //    {
        //        if (!Equals(value, _bir11OsPrawnaMessageInspector))
        //        {
        //            _bir11OsPrawnaMessageInspector = value;
        //            OnPropertyChanged(nameof(BIR11OsPrawnaMessageInspector));
        //        }
        //    }
        //}

        //#endregion

        //#region private ICollection<BIR11OsPrawnaListaJednLokalnychMessageInspector>...

        //private ICollection<BIR11OsPrawnaListaJednLokalnychMessageInspector>? _bir11OsPrawnaListaJednLokalnychMessageInspector;

        ///// <summary>
        /////     Kolekcja elementów inspektora wiadomości usługi
        /////     Service Message Inspector Item Collection
        ///// </summary>
        //[XmlIgnore]
        //[JsonProperty(nameof(BIR11OsPrawnaListaJednLokalnychMessageInspector), Order = 2)]
        //[Display(Name = "Inspektor wiadomości usługi",
        //    Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
        //    Description = "Kolekcja elementów inspektora wiadomości usługi")]
        //public virtual ICollection<BIR11OsPrawnaListaJednLokalnychMessageInspector>? BIR11OsPrawnaListaJednLokalnychMessageInspector
        //{
        //    get => _bir11OsPrawnaListaJednLokalnychMessageInspector;
        //    set
        //    {
        //        if (!Equals(value, _bir11OsPrawnaListaJednLokalnychMessageInspector))
        //        {
        //            _bir11OsPrawnaListaJednLokalnychMessageInspector = value;
        //            OnPropertyChanged(nameof(BIR11OsPrawnaListaJednLokalnychMessageInspector));
        //        }
        //    }
        //}

        //#endregion

        //#region private ICollection<BIR11OsPrawnaPkdMessageInspector>...

        //private ICollection<BIR11OsPrawnaPkdMessageInspector>? _bir11OsPrawnaPkdMessageInspector;

        ///// <summary>
        /////     Kolekcja elementów inspektora wiadomości usługi
        /////     Service Message Inspector Item Collection
        ///// </summary>
        //[XmlIgnore]
        //[JsonProperty(nameof(BIR11OsPrawnaPkdMessageInspector), Order = 2)]
        //[Display(Name = "Inspektor wiadomości usługi",
        //    Prompt = "Wybierz elementy kolekcji inspektora wiadomości usługi",
        //    Description = "Kolekcja elementów inspektora wiadomości usługi")]
        //public virtual ICollection<BIR11OsPrawnaPkdMessageInspector>? BIR11OsPrawnaPkdMessageInspector
        //{
        //    get => _bir11OsPrawnaPkdMessageInspector;
        //    set
        //    {
        //        if (!Equals(value, _bir11OsPrawnaPkdMessageInspector))
        //        {
        //            _bir11OsPrawnaPkdMessageInspector = value;
        //            OnPropertyChanged(nameof(BIR11OsPrawnaPkdMessageInspector));
        //        }
        //    }
        //}

        //#endregion
    }
}

#endregion
