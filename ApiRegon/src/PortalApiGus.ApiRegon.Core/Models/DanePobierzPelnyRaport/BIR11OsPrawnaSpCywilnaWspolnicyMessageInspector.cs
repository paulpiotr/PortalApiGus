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
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.BIR11OsPrawnaSpCywilnaWspolnicy
    ///     BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector
    /// </summary>
    [Table(nameof(BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector), Schema = "pagard")]
    [JsonObject(nameof(BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector))]
    [Display(Name = "Inspektor wiadomości soap",
        Description = "Inspektor wiadomości soap dla encji BIR11OsPrawnaSpCywilnaWspolnicy")]
    [Index(nameof(BIR11OsPrawnaSpCywilnaWspolnicyId))]
    [Index(nameof(MessageInspectorId))]
    public class BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector
    {
        #region public BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector...

        public BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector()
        {
        }

        #endregion 

        #region public BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector...

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="bir11OsPrawnaSpCywilnaWspolnicy">
        /// Parametr BIR11OsPrawnaSpCywilnaWspolnicy jako BIR11OsPrawnaSpCywilnaWspolnicy
        /// </param>
        /// <param name="messageInspector">
        /// Parametr messageInspector jako MessageInspector
        /// </param>
        public BIR11OsPrawnaSpCywilnaWspolnicyMessageInspector(BIR11OsPrawnaSpCywilnaWspolnicy bir11OsPrawnaSpCywilnaWspolnicy, MessageInspector messageInspector)
        {
            _bir11OsPrawnaSpCywilnaWspolnicy = bir11OsPrawnaSpCywilnaWspolnicy;
            _bir11OsPrawnaSpCywilnaWspolnicyId = bir11OsPrawnaSpCywilnaWspolnicy.Id;
            _messageInspector = messageInspector;
            _messageInspectorId = messageInspector.Id;
        }

        #endregion

        #region _BIR11OsPrawnaSpCywilnaWspolnicyId...

        private Guid _bir11OsPrawnaSpCywilnaWspolnicyId;

        /// <summary>
        ///     Identyfikator w tabeli BIR11OsPrawnaSpCywilnaWspolnicy
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11OsPrawnaSpCywilnaWspolnicyId), Order = 1)]
        [Display(Name = "Identyfikator w tabeli BIR11OsPrawnaSpCywilnaWspolnicy",
            Prompt = "Wpisz lub wybierz identyfikator w tabeli BIR11OsPrawnaSpCywilnaWspolnicy",
            Description = "Identyfikator w tabeli BIR11OsPrawnaSpCywilnaWspolnicy")]
        public Guid BIR11OsPrawnaSpCywilnaWspolnicyId
        {
            get => _bir11OsPrawnaSpCywilnaWspolnicyId;
            set
            {
                if (value != _bir11OsPrawnaSpCywilnaWspolnicyId)
                {
                    _bir11OsPrawnaSpCywilnaWspolnicyId = value;
                }
            }
        }

        #endregion

        #region private BIR11OsPrawnaSpCywilnaWspolnicy _BIR11OsPrawnaSpCywilnaWspolnicy...

        private BIR11OsPrawnaSpCywilnaWspolnicy _bir11OsPrawnaSpCywilnaWspolnicy;

        /// <summary>
        ///     Obiekt w tabeli BIR11OsPrawnaSpCywilnaWspolnicy
        /// </summary>
        [Column(Order = 1)]
        [JsonProperty(nameof(BIR11OsPrawnaSpCywilnaWspolnicy), Order = 1)]
        [Display(Name = "Obiekt w tabeli BIR11OsPrawnaSpCywilnaWspolnicy",
            Prompt = "Wpisz lub wybierz Obiekt w tabeli BIR11OsPrawnaSpCywilnaWspolnicy",
            Description = "Obiekt w tabeli BIR11OsPrawnaSpCywilnaWspolnicy")]
        public BIR11OsPrawnaSpCywilnaWspolnicy BIR11OsPrawnaSpCywilnaWspolnicy
        {
            get => _bir11OsPrawnaSpCywilnaWspolnicy;
            set
            {
                if (value != _bir11OsPrawnaSpCywilnaWspolnicy)
                {
                    _bir11OsPrawnaSpCywilnaWspolnicy = value;
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
