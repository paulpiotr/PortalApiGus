#region using

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

#endregion

#region namespace

namespace PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport
{
    /// <summary>
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDzialalnoscSkreslonaDo20141108
    ///     BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector
    /// </summary>
    [Table(nameof(BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector), Schema = "pagard")]
    [JsonObject(nameof(BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector))]
    [Display(Name = "Inspektor wiadomości soap",
        Description = "Inspektor wiadomości soap dla encji BIR11OsFizycznaDzialalnoscSkreslonaDo20141108")]
    [Index(nameof(BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id))]
    [Index(nameof(MessageInspectorId))]
    public class BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector
    {
        #region public BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector...

        public BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector()
        {
        }

        #endregion 

        #region public BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector...

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="bir11OsFizycznaDzialalnoscSkreslonaDo20141108">
        /// Parametr BIR11OsFizycznaDzialalnoscSkreslonaDo20141108 jako BIR11OsFizycznaDzialalnoscSkreslonaDo20141108
        /// </param>
        /// <param name="messageInspector">
        /// Parametr messageInspector jako MessageInspector
        /// </param>
        public BIR11OsFizycznaDzialalnoscSkreslonaDo20141108MessageInspector(BIR11OsFizycznaDzialalnoscSkreslonaDo20141108 bir11OsFizycznaDzialalnoscSkreslonaDo20141108, MessageInspector messageInspector)
        {
            _bir11OsFizycznaDzialalnoscSkreslonaDo20141108 = bir11OsFizycznaDzialalnoscSkreslonaDo20141108;
            _bir11OsFizycznaDzialalnoscSkreslonaDo20141108Id = bir11OsFizycznaDzialalnoscSkreslonaDo20141108.Id;
            _messageInspector = messageInspector;
            _messageInspectorId = messageInspector.Id;
        }

        #endregion

        #region _BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id...

        private Guid _bir11OsFizycznaDzialalnoscSkreslonaDo20141108Id;

        /// <summary>
        ///     Identyfikator w tabeli BIR11OsFizycznaDzialalnoscSkreslonaDo20141108
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id), Order = 1)]
        [Display(Name = "Identyfikator w tabeli BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
            Prompt = "Wpisz lub wybierz identyfikator w tabeli BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
            Description = "Identyfikator w tabeli BIR11OsFizycznaDzialalnoscSkreslonaDo20141108")]
        public Guid BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id
        {
            get => _bir11OsFizycznaDzialalnoscSkreslonaDo20141108Id;
            set
            {
                if (value != _bir11OsFizycznaDzialalnoscSkreslonaDo20141108Id)
                {
                    _bir11OsFizycznaDzialalnoscSkreslonaDo20141108Id = value;
                }
            }
        }

        #endregion

        #region private BIR11OsFizycznaDzialalnoscSkreslonaDo20141108 _BIR11OsFizycznaDzialalnoscSkreslonaDo20141108...

        private BIR11OsFizycznaDzialalnoscSkreslonaDo20141108 _bir11OsFizycznaDzialalnoscSkreslonaDo20141108;

        /// <summary>
        ///     Obiekt w tabeli BIR11OsFizycznaDzialalnoscSkreslonaDo20141108
        /// </summary>
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11OsFizycznaDzialalnoscSkreslonaDo20141108), Order = 1)]
        [Display(Name = "Obiekt w tabeli BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
            Prompt = "Wpisz lub wybierz Obiekt w tabeli BIR11OsFizycznaDzialalnoscSkreslonaDo20141108",
            Description = "Obiekt w tabeli BIR11OsFizycznaDzialalnoscSkreslonaDo20141108")]
        public BIR11OsFizycznaDzialalnoscSkreslonaDo20141108 BIR11OsFizycznaDzialalnoscSkreslonaDo20141108
        {
            get => _bir11OsFizycznaDzialalnoscSkreslonaDo20141108;
            set
            {
                if (value != _bir11OsFizycznaDzialalnoscSkreslonaDo20141108)
                {
                    _bir11OsFizycznaDzialalnoscSkreslonaDo20141108 = value;
                }
            }
        }

        #endregion

        #region private Guid _messageInspectorId...

        private Guid _messageInspectorId;

        /// <summary>
        ///     Identyfikator w tabeli MessageInspector
        /// </summary>
        [Key]
        [Column(Order = 2)]
        [JsonProperty(nameof(MessageInspectorId), Order = 2)]
        [Display(Name = "Identyfikator w tabeli MessageInspector",
            Prompt = "Wpisz lub wybierz identyfikator w tabeli MessageInspector",
            Description = "Identyfikator w tabeli MessageInspector")]
        public Guid MessageInspectorId
        {
            get => _messageInspectorId;
            set
            {
                if (value != _messageInspectorId)
                {
                    _messageInspectorId = value;
                }
            }
        }

        #endregion

        #region private MessageInspector _messageInspector...

        private MessageInspector _messageInspector;

        /// <summary>
        ///     Obiekt w tabeli MessageInspector
        /// </summary>
        [Column(Order = 2)]
        [JsonProperty(nameof(MessageInspector), Order = 2)]
        [Display(Name = "Obiekt w tabeli MessageInspector",
            Prompt = "Wpisz lub wybierz Obiekt w tabeli MessageInspector",
            Description = "Obiekt w tabeli MessageInspector")]
        public MessageInspector MessageInspector
        {
            get => _messageInspector;
            set
            {
                if (value != _messageInspector)
                {
                    _messageInspector = value;
                }
            }
        }

        #endregion
    }
}

#endregion
