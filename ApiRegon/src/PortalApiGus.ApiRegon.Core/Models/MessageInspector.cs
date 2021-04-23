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
    }
}

#endregion
