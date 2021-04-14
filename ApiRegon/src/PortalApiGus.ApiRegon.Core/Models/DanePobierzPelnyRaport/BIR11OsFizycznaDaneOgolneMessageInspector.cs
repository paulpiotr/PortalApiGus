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
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsFizycznaDaneOgolne
    ///     BIR11OsFizycznaDaneOgolneMessageInspector
    /// </summary>
    [Table(nameof(BIR11OsFizycznaDaneOgolneMessageInspector), Schema = "pagard")]
    [JsonObject(nameof(BIR11OsFizycznaDaneOgolneMessageInspector))]
    [Display(Name = "Inspektor wiadomości soap",
        Description = "Inspektor wiadomości soap dla encji BIR11OsFizycznaDaneOgolne")]
    [Index(nameof(BIR11OsFizycznaDaneOgolneId))]
    [Index(nameof(MessageInspectorId))]
    public class BIR11OsFizycznaDaneOgolneMessageInspector
    {
        #region public BIR11OsFizycznaDaneOgolneMessageInspector...

        public BIR11OsFizycznaDaneOgolneMessageInspector()
        {
        }

        #endregion 

        #region public BIR11OsFizycznaDaneOgolneMessageInspector...

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="bir11OsFizycznaDaneOgolne">
        /// Parametr bir11OsFizycznaDaneOgolne jako BIR11OsFizycznaDaneOgolne
        /// </param>
        /// <param name="messageInspector">
        /// Parametr messageInspector jako MessageInspector
        /// </param>
        public BIR11OsFizycznaDaneOgolneMessageInspector(BIR11OsFizycznaDaneOgolne bir11OsFizycznaDaneOgolne, MessageInspector messageInspector)
        {
            _bir11OsFizycznaDaneOgolne = bir11OsFizycznaDaneOgolne;
            _bir11OsFizycznaDaneOgolneId = bir11OsFizycznaDaneOgolne.Id;
            _messageInspector = messageInspector;
            _messageInspectorId = messageInspector.Id;
        }

        #endregion

        #region _BIR11OsFizycznaDaneOgolneId...

        private Guid _bir11OsFizycznaDaneOgolneId;

        /// <summary>
        ///     Identyfikator w tabeli BIR11OsFizycznaDaneOgolne
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11OsFizycznaDaneOgolneId), Order = 1)]
        [Display(Name = "Identyfikator w tabeli BIR11OsFizycznaDaneOgolne",
            Prompt = "Wpisz lub wybierz identyfikator w tabeli BIR11OsFizycznaDaneOgolne",
            Description = "Identyfikator w tabeli BIR11OsFizycznaDaneOgolne")]
        public Guid BIR11OsFizycznaDaneOgolneId
        {
            get => _bir11OsFizycznaDaneOgolneId;
            set
            {
                if (value != _bir11OsFizycznaDaneOgolneId)
                {
                    _bir11OsFizycznaDaneOgolneId = value;
                }
            }
        }

        #endregion

        #region private BIR11OsFizycznaDaneOgolne _BIR11OsFizycznaDaneOgolne...

        private BIR11OsFizycznaDaneOgolne _bir11OsFizycznaDaneOgolne;

        /// <summary>
        ///     Obiekt w tabeli BIR11OsFizycznaDaneOgolne
        /// </summary>
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11OsFizycznaDaneOgolne), Order = 1)]
        [Display(Name = "Obiekt w tabeli BIR11OsFizycznaDaneOgolne",
            Prompt = "Wpisz lub wybierz Obiekt w tabeli BIR11OsFizycznaDaneOgolne",
            Description = "Obiekt w tabeli BIR11OsFizycznaDaneOgolne")]
        public BIR11OsFizycznaDaneOgolne BIR11OsFizycznaDaneOgolne
        {
            get => _bir11OsFizycznaDaneOgolne;
            set
            {
                if (value != _bir11OsFizycznaDaneOgolne)
                {
                    _bir11OsFizycznaDaneOgolne = value;
                }
            }
        }

        #endregion

        #region _messageInspectorId...

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
