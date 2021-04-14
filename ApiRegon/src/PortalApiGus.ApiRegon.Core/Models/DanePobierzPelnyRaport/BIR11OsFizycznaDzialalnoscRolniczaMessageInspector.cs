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
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDzialalnoscRolnicza
    ///     BIR11OsFizycznaDzialalnoscRolniczaMessageInspector
    /// </summary>
    [Table(nameof(BIR11OsFizycznaDzialalnoscRolniczaMessageInspector), Schema = "pagard")]
    [JsonObject(nameof(BIR11OsFizycznaDzialalnoscRolniczaMessageInspector))]
    [Display(Name = "Inspektor wiadomości soap",
        Description = "Inspektor wiadomości soap dla encji BIR11OsFizycznaDzialalnoscRolnicza")]
    [Index(nameof(BIR11OsFizycznaDzialalnoscRolniczaId))]
    [Index(nameof(MessageInspectorId))]
    public class BIR11OsFizycznaDzialalnoscRolniczaMessageInspector
    {
        #region public BIR11OsFizycznaDzialalnoscRolniczaMessageInspector...

        public BIR11OsFizycznaDzialalnoscRolniczaMessageInspector()
        {
        }

        #endregion 

        #region public BIR11OsFizycznaDzialalnoscRolniczaMessageInspector...

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="bir11OsFizycznaDzialalnoscRolnicza">
        /// Parametr BIR11OsFizycznaDzialalnoscRolnicza jako BIR11OsFizycznaDzialalnoscRolnicza
        /// </param>
        /// <param name="messageInspector">
        /// Parametr messageInspector jako MessageInspector
        /// </param>
        public BIR11OsFizycznaDzialalnoscRolniczaMessageInspector(BIR11OsFizycznaDzialalnoscRolnicza bir11OsFizycznaDzialalnoscRolnicza, MessageInspector messageInspector)
        {
            _bir11OsFizycznaDzialalnoscRolnicza = bir11OsFizycznaDzialalnoscRolnicza;
            _bir11OsFizycznaDzialalnoscRolniczaId = bir11OsFizycznaDzialalnoscRolnicza.Id;
            _messageInspector = messageInspector;
            _messageInspectorId = messageInspector.Id;
        }

        #endregion

        #region _BIR11OsFizycznaDzialalnoscRolniczaId...

        private Guid _bir11OsFizycznaDzialalnoscRolniczaId;

        /// <summary>
        ///     Identyfikator w tabeli BIR11OsFizycznaDzialalnoscRolnicza
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11OsFizycznaDzialalnoscRolniczaId), Order = 1)]
        [Display(Name = "Identyfikator w tabeli BIR11OsFizycznaDzialalnoscRolnicza",
            Prompt = "Wpisz lub wybierz identyfikator w tabeli BIR11OsFizycznaDzialalnoscRolnicza",
            Description = "Identyfikator w tabeli BIR11OsFizycznaDzialalnoscRolnicza")]
        public Guid BIR11OsFizycznaDzialalnoscRolniczaId
        {
            get => _bir11OsFizycznaDzialalnoscRolniczaId;
            set
            {
                if (value != _bir11OsFizycznaDzialalnoscRolniczaId)
                {
                    _bir11OsFizycznaDzialalnoscRolniczaId = value;
                }
            }
        }

        #endregion

        #region private BIR11OsFizycznaDzialalnoscRolnicza _BIR11OsFizycznaDzialalnoscRolnicza...

        private BIR11OsFizycznaDzialalnoscRolnicza _bir11OsFizycznaDzialalnoscRolnicza;

        /// <summary>
        ///     Obiekt w tabeli BIR11OsFizycznaDzialalnoscRolnicza
        /// </summary>
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11OsFizycznaDzialalnoscRolnicza), Order = 1)]
        [Display(Name = "Obiekt w tabeli BIR11OsFizycznaDzialalnoscRolnicza",
            Prompt = "Wpisz lub wybierz Obiekt w tabeli BIR11OsFizycznaDzialalnoscRolnicza",
            Description = "Obiekt w tabeli BIR11OsFizycznaDzialalnoscRolnicza")]
        public BIR11OsFizycznaDzialalnoscRolnicza BIR11OsFizycznaDzialalnoscRolnicza
        {
            get => _bir11OsFizycznaDzialalnoscRolnicza;
            set
            {
                if (value != _bir11OsFizycznaDzialalnoscRolnicza)
                {
                    _bir11OsFizycznaDzialalnoscRolnicza = value;
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
