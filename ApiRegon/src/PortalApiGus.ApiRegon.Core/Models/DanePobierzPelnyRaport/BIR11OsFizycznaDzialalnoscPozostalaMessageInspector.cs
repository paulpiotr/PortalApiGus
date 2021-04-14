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
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDzialalnoscPozostala
    ///     BIR11OsFizycznaDzialalnoscPozostalaMessageInspector
    /// </summary>
    [Table(nameof(BIR11OsFizycznaDzialalnoscPozostalaMessageInspector), Schema = "pagard")]
    [JsonObject(nameof(BIR11OsFizycznaDzialalnoscPozostalaMessageInspector))]
    [Display(Name = "Inspektor wiadomości soap",
        Description = "Inspektor wiadomości soap dla encji BIR11OsFizycznaDzialalnoscPozostala")]
    [Index(nameof(BIR11OsFizycznaDzialalnoscPozostalaId))]
    [Index(nameof(MessageInspectorId))]
    public class BIR11OsFizycznaDzialalnoscPozostalaMessageInspector
    {
        #region public BIR11OsFizycznaDzialalnoscPozostalaMessageInspector...

        public BIR11OsFizycznaDzialalnoscPozostalaMessageInspector()
        {
        }

        #endregion 

        #region public BIR11OsFizycznaDzialalnoscPozostalaMessageInspector...

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="bir11OsFizycznaDzialalnoscPozostala">
        /// Parametr BIR11OsFizycznaDzialalnoscPozostala jako BIR11OsFizycznaDzialalnoscPozostala
        /// </param>
        /// <param name="messageInspector">
        /// Parametr messageInspector jako MessageInspector
        /// </param>
        public BIR11OsFizycznaDzialalnoscPozostalaMessageInspector(BIR11OsFizycznaDzialalnoscPozostala bir11OsFizycznaDzialalnoscPozostala, MessageInspector messageInspector)
        {
            _bir11OsFizycznaDzialalnoscPozostala = bir11OsFizycznaDzialalnoscPozostala;
            _bir11OsFizycznaDzialalnoscPozostalaId = bir11OsFizycznaDzialalnoscPozostala.Id;
            _messageInspector = messageInspector;
            _messageInspectorId = messageInspector.Id;
        }

        #endregion

        #region _BIR11OsFizycznaDzialalnoscPozostalaId...

        private Guid _bir11OsFizycznaDzialalnoscPozostalaId;

        /// <summary>
        ///     Identyfikator w tabeli BIR11OsFizycznaDzialalnoscPozostala
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11OsFizycznaDzialalnoscPozostalaId), Order = 1)]
        [Display(Name = "Identyfikator w tabeli BIR11OsFizycznaDzialalnoscPozostala",
            Prompt = "Wpisz lub wybierz identyfikator w tabeli BIR11OsFizycznaDzialalnoscPozostala",
            Description = "Identyfikator w tabeli BIR11OsFizycznaDzialalnoscPozostala")]
        public Guid BIR11OsFizycznaDzialalnoscPozostalaId
        {
            get => _bir11OsFizycznaDzialalnoscPozostalaId;
            set
            {
                if (value != _bir11OsFizycznaDzialalnoscPozostalaId)
                {
                    _bir11OsFizycznaDzialalnoscPozostalaId = value;
                }
            }
        }

        #endregion

        #region private BIR11OsFizycznaDzialalnoscPozostala _BIR11OsFizycznaDzialalnoscPozostala...

        private BIR11OsFizycznaDzialalnoscPozostala _bir11OsFizycznaDzialalnoscPozostala;

        /// <summary>
        ///     Obiekt w tabeli BIR11OsFizycznaDzialalnoscPozostala
        /// </summary>
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11OsFizycznaDzialalnoscPozostala), Order = 1)]
        [Display(Name = "Obiekt w tabeli BIR11OsFizycznaDzialalnoscPozostala",
            Prompt = "Wpisz lub wybierz Obiekt w tabeli BIR11OsFizycznaDzialalnoscPozostala",
            Description = "Obiekt w tabeli BIR11OsFizycznaDzialalnoscPozostala")]
        public BIR11OsFizycznaDzialalnoscPozostala BIR11OsFizycznaDzialalnoscPozostala
        {
            get => _bir11OsFizycznaDzialalnoscPozostala;
            set
            {
                if (value != _bir11OsFizycznaDzialalnoscPozostala)
                {
                    _bir11OsFizycznaDzialalnoscPozostala = value;
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
