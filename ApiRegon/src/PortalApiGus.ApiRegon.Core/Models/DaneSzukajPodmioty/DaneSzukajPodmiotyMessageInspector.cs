#region using

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

#endregion

#region namespace

namespace PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty
{
    /// <summary>
    ///     Model danych PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty
    ///     DaneSzukajPodmiotyMessageInspector
    /// </summary>
    [Table(nameof(DaneSzukajPodmiotyMessageInspector), Schema = "pagard")]
    [JsonObject(nameof(DaneSzukajPodmiotyMessageInspector))]
    [Display(Name = "Inspektor wiadomości soap",
        Description = "Inspektor wiadomości soap dla encji DaneSzukajPodmioty")]
    [Index(nameof(DaneSzukajPodmiotyId))]
    [Index(nameof(MessageInspectorId))]
    public class DaneSzukajPodmiotyMessageInspector
    {
        #region public DaneSzukajPodmiotyMessageInspector...

        public DaneSzukajPodmiotyMessageInspector() { }

        #endregion 

        #region public DaneSzukajPodmiotyMessageInspector...

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="daneSzukajPodmioty">
        /// Parametr daneSzukajPodmioty jako DaneSzukajPodmioty
        /// </param>
        /// <param name="messageInspector">
        /// Parametr messageInspector jako MessageInspector
        /// </param>
        public DaneSzukajPodmiotyMessageInspector(DaneSzukajPodmioty daneSzukajPodmioty, MessageInspector messageInspector)
        {
            _daneSzukajPodmioty = daneSzukajPodmioty;
            _daneSzukajPodmiotyId = daneSzukajPodmioty.Id;
            _messageInspector = messageInspector;
            _messageInspectorId = messageInspector.Id;
        }

        #endregion

        #region _daneSzukajPodmiotyId...

        private Guid _daneSzukajPodmiotyId;

        /// <summary>
        ///     Identyfikator w tabeli DaneSzukajPodmioty
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [JsonProperty(nameof(DaneSzukajPodmiotyId), Order = 1)]
        [Display(Name = "Identyfikator w tabeli DaneSzukajPodmioty",
            Prompt = "Wpisz lub wybierz identyfikator w tabeli DaneSzukajPodmioty",
            Description = "Identyfikator w tabeli DaneSzukajPodmioty")]
        public Guid DaneSzukajPodmiotyId
        {
            get => _daneSzukajPodmiotyId;
            set
            {
                if (value != _daneSzukajPodmiotyId)
                {
                    _daneSzukajPodmiotyId = value;
                }
            }
        }

        #endregion

        #region private DaneSzukajPodmioty _daneSzukajPodmioty...

        private DaneSzukajPodmioty _daneSzukajPodmioty;

        /// <summary>
        ///     Obiekt w tabeli DaneSzukajPodmioty
        /// </summary>
        [Column(Order = 1)]
        [JsonProperty(nameof(DaneSzukajPodmioty), Order = 1)]
        [Display(Name = "Obiekt w tabeli DaneSzukajPodmioty",
            Prompt = "Wpisz lub wybierz Obiekt w tabeli DaneSzukajPodmioty",
            Description = "Obiekt w tabeli DaneSzukajPodmioty")]
        public DaneSzukajPodmioty DaneSzukajPodmioty
        {
            get => _daneSzukajPodmioty;
            set
            {
                if (value != _daneSzukajPodmioty)
                {
                    _daneSzukajPodmioty = value;
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
