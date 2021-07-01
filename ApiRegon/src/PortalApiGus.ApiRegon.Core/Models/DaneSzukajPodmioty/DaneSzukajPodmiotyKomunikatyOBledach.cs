#region using

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;
using NetAppCommon.Models;
using Newtonsoft.Json;

#endregion

#nullable enable annotations

namespace PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty
{
    #region public class DaneSzukajPodmiotyKomunikatyOBledach : BaseEntity

    /// <summary>
    ///     Komunikaty o błędach z usługi UslugaBIRzewnPublVer11Prod
    ///     Error messages from the service UslugaBIRzewnPublVer11Prod
    /// </summary>
    [Table(nameof(DaneSzukajPodmiotyKomunikatyOBledach), Schema = "pagard")]
    [Index(nameof(Regon))]
    [Index(nameof(Nip))]
    [Index(nameof(Krs))]
    [Index(nameof(Nipy))]
    [Index(nameof(Regony14zn))]
    [Index(nameof(Regony9zn))]
    [Index(nameof(Krsy))]
    [JsonObject(nameof(DaneSzukajPodmiotyKomunikatyOBledach))]
    [Display(Name = "Komunikaty o błędach", Description = "Komunikaty o błędach z usługi UslugaBIRzewnPublVer11Prod")]
    [Serializable]
    [XmlRoot("dane")]
    public class DaneSzukajPodmiotyKomunikatyOBledach : BaseEntity
    {
        #region public override Guid Id...

        /// <summary>
        ///     Guid Id identyfikator klucz główny
        ///     Guid Id identifier of the primary key
        /// </summary>
        [XmlIgnore]
        [Key]
        [JsonProperty(nameof(Id))]
        [Display(Name = "Identyfikator", Prompt = "Wpisz identyfikator",
            Description = "Identyfikator, klucz główny w bazie danych jako Guid")]
        public override Guid Id => base.Id;

        #endregion

        #region public override string? UniqueIdentifierOfTheLoggedInUser...

        /// <summary>
        ///     Jednoznaczny identyfikator zalogowanego użytkownika
        ///     Unique identifier of the logged in user
        /// </summary>
        [XmlIgnore]
        [JsonProperty(nameof(UniqueIdentifierOfTheLoggedInUser))]
        [Display(Name = "Użytkownik",
            Prompt = "Wybierz identyfikator zalogowanego użytkownika",
            Description = "Użytkownik")]
        [MinLength(1)]
        [MaxLength(256)]
        [StringLength(256)]
        public override string? UniqueIdentifierOfTheLoggedInUser => base.UniqueIdentifierOfTheLoggedInUser;

        #endregion

        #region private DateTime _dateOfCreate; public DateTime DateOfCreate

        /// <summary>
        ///     Data utworzenia
        ///     Date of create
        /// </summary>
        [XmlIgnore]
        [Column("DataUtworzenia")]
        [JsonProperty("DataUtworzenia")]
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
        [XmlIgnore]
        [Column("DataModyfikacji")]
        [JsonProperty("DataModyfikacji")]
        [Display(Name = "Data modyfikacji", Prompt = "Wpisz lub wybierz datę modyfikacji",
            Description = "Data modyfikacji")]
        [DataType(DataType.Date)]
        public override DateTime? DateOfModification => base.DateOfModification;

        #endregion

        #region private int? _errorCode; public int? ErrorCode

        private int? _errorCode;

        /// <summary>
        ///     Numer błędu jako int
        ///     Error number as int
        /// </summary>
        [XmlElement(nameof(ErrorCode))]
        [JsonProperty(nameof(ErrorCode))]
        [Display(Name = "Numer błędu", Prompt = "Wpisz numer błędu", Description = "Numer błędu")]
        [Range(int.MinValue, int.MaxValue)]
        public int? ErrorCode
        {
            get => _errorCode;
            set
            {
                if (value != _errorCode)
                {
                    _errorCode = value;
                }
            }
        }

        #endregion

        #region private string? _errorMessagePl; public string? ErrorMessagePl

        private string? _errorMessagePl;

        /// <summary>
        ///     Komunikat o błędzie w języku polskim jako string?
        ///     Error message in Polish as string?
        /// </summary>
        [XmlElement(nameof(ErrorMessagePl))]
        [JsonProperty(nameof(ErrorMessagePl))]
        [StringLength(2147483647)]
        [Display(Name = "Komunikat o błędzie w języku polskim", Prompt = "Wpisz komunikat o błędzie w języku polskim",
            Description = "Komunikat o błędzie w języku polskim")]
        public string? ErrorMessagePl
        {
            get => _errorMessagePl;
            set
            {
                if (value != _errorMessagePl)
                {
                    _errorMessagePl = value;
                    OnPropertyChanged(nameof(ErrorMessagePl));
                }
            }
        }

        #endregion

        #region private string? _errorMessageEn; public string? ErrorMessageEn

        private string? _errorMessageEn;

        /// <summary>
        ///     Komunikat o błędzie w języku angielskim jako string?
        ///     Error message in English as a string?
        /// </summary>
        [XmlElement(nameof(ErrorMessageEn))]
        [JsonProperty(nameof(ErrorMessageEn))]
        [StringLength(2147483647)]
        [Display(Name = "Komunikat o błędzie w języku angielskim",
            Prompt = "Wpisz komunikat o błędzie w języku angielskim",
            Description = "Komunikat o błędzie w języku angielskim")]
        public string? ErrorMessageEn
        {
            get => _errorMessageEn;
            set
            {
                if (value != _errorMessageEn)
                {
                    _errorMessageEn = value;
                    OnPropertyChanged(nameof(ErrorMessageEn));
                }
            }
        }

        #endregion

        #region private string? _regon; public string? Regon

        private string? _regon;

        /// <summary>
        ///     Numer regon 9 lub 14 znaków
        ///     Regon number 9 or 14 characters
        /// </summary>
        [XmlElement("Regon")]
        [JsonProperty(nameof(Regon))]
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
        [XmlElement("Nip")]
        [JsonProperty(nameof(Nip))]
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
        [XmlElement("Krs")]
        [JsonProperty(nameof(Krs))]
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
        [XmlElement("Nipy")]
        [JsonProperty(nameof(Nipy))]
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
        [XmlElement("Regony14zn")]
        [JsonProperty(nameof(Regony14zn))]
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
        [XmlElement("Regony9zn")]
        [JsonProperty(nameof(Regony9zn))]
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
        [XmlElement(nameof(Krsy))]
        [JsonProperty(nameof(Krsy))]
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
        [InverseProperty("DaneSzukajPodmiotyKomunikatyOBledach")]
        [Display(Name = "Raport podstawowy", Prompt = "Wybierz raport podstawowy",
            Description = "Dane wyszukanych podmiotów w raporcie podstawowym")]
        public virtual ICollection<DaneSzukajPodmioty>? DaneSzukajPodmioty
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
    }

    #endregion
}
