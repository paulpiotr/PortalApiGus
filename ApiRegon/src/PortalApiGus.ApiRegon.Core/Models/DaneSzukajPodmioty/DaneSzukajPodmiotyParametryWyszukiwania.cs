#region using

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;
using NetAppCommon.Models;
using Newtonsoft.Json;
using UslugaBIRzewnPublVer11Prod;

#endregion

#nullable enable annotations

namespace PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty
{
    #region public class DaneSzukajPodmiotyParametryWyszukiwania : BaseEntity

    /// <summary>
    ///     Model wyszukiwanie podmiotów - parametry wyszukiwania
    ///     Entity search model - search parameters
    /// </summary>
    [JsonObject(nameof(DaneSzukajPodmiotyParametryWyszukiwania))]
    [Table(nameof(DaneSzukajPodmiotyParametryWyszukiwania), Schema = "pagard")]
    [Index(nameof(Regon))]
    [Index(nameof(Nip))]
    [Index(nameof(Krs))]
    [Index(nameof(Nipy))]
    [Index(nameof(Regony14zn))]
    [Index(nameof(Regony9zn))]
    [Index(nameof(Krsy))]
    [Index(nameof(DateOfCreate))]
    [Index(nameof(DateOfModification))]
    [Display(Name = "Parametry wyszukiwania", Description = "Parametry wyszukiwania podmiotów gospodarczych")]
    public class DaneSzukajPodmiotyParametryWyszukiwania : BaseEntity
    {
        #region private DateTime _dateOfCreate; public DateTime DateOfCreate

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

        #region private DateTime? _dateOfModification; public DateTime? DateOfModification

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

        #region public ParametryWyszukiwania AsParametryWyszukiwania()

        /// <summary>
        ///     Konwertuj obiekt do formatu UslugaBIRzewnPublVer11Prod.ParametryWyszukiwania
        ///     Convert the object to the format UslugaBIRzewnPublVer11Prod.ParametryWyszukiwania
        /// </summary>
        /// <returns>
        ///     Nowy obiekt jako UslugaBIRzewnPublVer11Prod.ParametryWyszukiwania
        ///     New object as UslugaBIRzewnPublVer11Prod.ParametryWyszukiwania
        /// </returns>
        public ParametryWyszukiwania AsParametryWyszukiwania() =>
            new()
            {
                Krs = _krs,
                Krsy = _krsy,
                Nip = _nip,
                Nipy = _nipy,
                Regon = _regon,
                Regony14zn = _regony14Zn,
                Regony9zn = _regony9Zn
            };

        #endregion

        #region private string? _regon; public string? Regon

        private string? _regon;

        /// <summary>
        ///     Numer regon 9 lub 14 znaków
        ///     Regon number 9 or 14 characters
        /// </summary>
        [Column(Order = 2)]
        [XmlElement(nameof(Regon))]
        [JsonProperty(nameof(Regon), Order = 2)]
        [StringLength(14)]
        [Display(Name = "Numer regon", Prompt = "Wpisz numer regon", Description = "Numer regon 9 lub 14 znaków")]
        public string? Regon
        {
            get => _regon;
            set
            {
                if (value != _regon)
                {
                    _regon = value;
                    OnPropertyChanged(nameof(Regon));
                }
            }
        }

        #endregion

        #region private string? _nip; public string? Nip

        private string? _nip;

        /// <summary>
        ///     Numer nip
        ///     Tax ID number
        /// </summary>
        [Column(Order = 2)]
        [XmlElement(nameof(Nip))]
        [JsonProperty(nameof(Nip), Order = 2)]
        [StringLength(10)]
        [Display(Name = "Numer nip", Prompt = "Wpisz numer nip", Description = "Numer nip")]
        public string? Nip
        {
            get => _nip;
            set
            {
                if (value != _nip)
                {
                    _nip = value;
                    OnPropertyChanged(nameof(Nip));
                }
            }
        }

        #endregion

        #region private string? _krs; public string? Krs

        private string? _krs;

        /// <summary>
        ///     Numer krs jako string?
        ///     The krs number as a string?
        /// </summary>
        [Column(Order = 2)]
        [XmlElement(nameof(Krs))]
        [JsonProperty(nameof(Krs), Order = 2)]
        [StringLength(10)]
        [Display(Name = "Numer krs", Prompt = "Wpisz numer krs", Description = "Numer krs")]
        public string? Krs
        {
            get => _krs;
            set
            {
                if (value != _krs)
                {
                    _krs = value;
                    OnPropertyChanged(nameof(Krs));
                }
            }
        }

        #endregion

        #region private string? _nipy; public string? Nipy

        private string? _nipy;

        /// <summary>
        ///     Numery nip rozdzielone separatorem jako string?
        ///     Nip numbers separated by a separator as string?
        /// </summary>
        [Column(Order = 2)]
        [XmlElement(nameof(Nipy))]
        [JsonProperty(nameof(Nipy), Order = 2)]
        [StringLength(220)]
        [Display(Name = "Numery nip rozdzielone separatorem", Prompt = "Wpisz numery nip rozdzielone separatorem",
            Description = "Numery nip rozdzielone separatorem")]
        public string? Nipy
        {
            get => _nipy;
            set
            {
                if (value != _nipy)
                {
                    _nipy = value;
                    OnPropertyChanged(nameof(Nipy));
                }
            }
        }

        #endregion

        #region private string? _regony14zn; public string? Regony14zn

        private string? _regony14Zn;

        /// <summary>
        ///     Numery regon 14 znakowe rozdzielone separatorem jako string?
        ///     Regon 14-character numbers separated by a separator as a string?
        /// </summary>
        [Column(Order = 2)]
        [XmlElement(nameof(Regony14zn))]
        [JsonProperty(nameof(Regony14zn), Order = 2)]
        [StringLength(300)]
        [Display(Name = "Numery regon 14 znakowe rozdzielone separatorem",
            Prompt = "Wpisz numery regon 14 znakowe rozdzielone separatorem",
            Description = "Numery regon 14 znakowe rozdzielone separatorem")]
        public string? Regony14zn
        {
            get => _regony14Zn;
            set
            {
                if (value != _regony14Zn)
                {
                    _regony14Zn = value;
                    OnPropertyChanged(nameof(Regony14zn));
                }
            }
        }

        #endregion

        #region private string? _regony9zn; public string? Regony9zn

        private string? _regony9Zn;

        /// <summary>
        ///     Numery regon 9 znaków rozdzielone separatorem jako string?
        ///     Regon numbers 9 characters separated by a separator as a string?
        /// </summary>
        [Column(Order = 2)]
        [XmlElement(nameof(Regony9zn))]
        [JsonProperty(nameof(Regony9zn), Order = 2)]
        [StringLength(200)]
        [Display(Name = "Numery regon 9 znakowe rozdzielone separatorem",
            Prompt = "Wpisz numery regon 9 znakowe rozdzielone separatorem",
            Description = "Numery regon 9 znakowe rozdzielone separatorem")]
        public string? Regony9zn
        {
            get => _regony9Zn;
            set
            {
                if (value != _regony9Zn)
                {
                    _regony9Zn = value;
                    OnPropertyChanged(nameof(Regony9zn));
                }
            }
        }

        #endregion

        #region private string? _krsy; public string? Krsy

        private string? _krsy;

        /// <summary>
        ///     Numery krs rozdzielone separatorem jako string?
        ///     Krs numbers separated by a separator as string?
        /// </summary>
        [Column(Order = 2)]
        [XmlElement(nameof(Krsy))]
        [JsonProperty(nameof(Krsy), Order = 2)]
        [StringLength(220)]
        [Display(Name = "Numery krs rozdzielone separatorem", Prompt = "Wpisz numer krs rozdzielone separatorem",
            Description = "Numery krs rozdzielone separatorem")]
        public string? Krsy
        {
            get => _krsy;
            set
            {
                if (value != _krsy)
                {
                    _krsy = value;
                    OnPropertyChanged(nameof(Krsy));
                }
            }
        }

        #endregion

        #region ICollection<DaneSzukajPodmioty>? _daneSzukajPodmioty...

        private ICollection<DaneSzukajPodmioty>? _daneSzukajPodmioty;

        /// <summary>
        ///     Raport podstawowy
        ///     Raport podstawowy
        /// </summary>
        [Column(Order = 2)]
        [XmlIgnore]
        [JsonProperty(nameof(DaneSzukajPodmioty), Order = 2)]
        [InverseProperty("DaneSzukajPodmiotyParametryWyszukiwania")]
        [Display(Name = "Raport podstawowy", Prompt = "Wybierz raport podstawowy",
            Description = "Dane wyszukanych podmiotów w raporcie podstawowym")]
        public virtual ICollection<DaneSzukajPodmioty>? DaneSzukajPodmioty
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
    }

    #endregion
}
