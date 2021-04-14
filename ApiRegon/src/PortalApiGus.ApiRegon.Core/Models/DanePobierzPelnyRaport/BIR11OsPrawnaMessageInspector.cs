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
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsPrawna
    ///     BIR11OsPrawnaMessageInspector
    /// </summary>
    [Table(nameof(BIR11OsPrawnaMessageInspector), Schema = "pagard")]
    [JsonObject(nameof(BIR11OsPrawnaMessageInspector))]
    [Display(Name = "Inspektor wiadomości soap",
        Description = "Inspektor wiadomości soap dla encji BIR11OsPrawna")]
    [Index(nameof(BIR11OsPrawnaId))]
    [Index(nameof(MessageInspectorId))]
    public class BIR11OsPrawnaMessageInspector
    {
        #region public BIR11OsPrawnaMessageInspector...

        public BIR11OsPrawnaMessageInspector()
        {
        }

        #endregion 

        #region public BIR11OsPrawnaMessageInspector...

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="BIR11OsPrawna">
        /// Parametr BIR11OsPrawna jako BIR11OsPrawna
        /// </param>
        /// <param name="messageInspector">
        /// Parametr messageInspector jako MessageInspector
        /// </param>
        public BIR11OsPrawnaMessageInspector(BIR11OsPrawna BIR11OsPrawna, MessageInspector messageInspector)
        {
            _BIR11OsPrawna = BIR11OsPrawna;
            _BIR11OsPrawnaId = BIR11OsPrawna.Id;
            _messageInspector = messageInspector;
            _messageInspectorId = messageInspector.Id;
        }

        #endregion

        #region _BIR11OsPrawnaId...

        private Guid _BIR11OsPrawnaId;

        /// <summary>
        ///     Identyfikator w tabeli BIR11OsPrawna
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11OsPrawnaId), Order = 1)]
        [Display(Name = "Identyfikator w tabeli BIR11OsPrawna",
            Prompt = "Wpisz lub wybierz identyfikator w tabeli BIR11OsPrawna",
            Description = "Identyfikator w tabeli BIR11OsPrawna")]
        public Guid BIR11OsPrawnaId
        {
            get => _BIR11OsPrawnaId;
            set
            {
                if (value != _BIR11OsPrawnaId)
                {
                    _BIR11OsPrawnaId = value;
                }
            }
        }

        #endregion

        #region private BIR11OsPrawna _BIR11OsPrawna...

        private BIR11OsPrawna _BIR11OsPrawna;

        /// <summary>
        ///     Obiekt w tabeli BIR11OsPrawna
        /// </summary>
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11OsPrawna), Order = 1)]
        [Display(Name = "Obiekt w tabeli BIR11OsPrawna",
            Prompt = "Wpisz lub wybierz Obiekt w tabeli BIR11OsPrawna",
            Description = "Obiekt w tabeli BIR11OsPrawna")]
        public BIR11OsPrawna BIR11OsPrawna
        {
            get => _BIR11OsPrawna;
            set
            {
                if (value != _BIR11OsPrawna)
                {
                    _BIR11OsPrawna = value;
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
