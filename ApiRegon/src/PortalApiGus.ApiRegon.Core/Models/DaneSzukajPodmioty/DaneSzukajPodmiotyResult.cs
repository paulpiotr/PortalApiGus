#region using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using NetAppCommon.Helpers.Xmls;
using Newtonsoft.Json;

#endregion

#nullable enable annotations

#region namespace

namespace PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty
{
    [Serializable]
    [XmlRoot("root")]
    [JsonObject(nameof(DaneSzukajPodmiotyResult))]
    [Display(Name = "Rezultat wyszukiwania podmiotów gospodarczych",
        Description = "Rezultat wyszukiwania podmiotów gospodarczych")]
    [NotMapped]
    public class DaneSzukajPodmiotyResult : INotifyPropertyChanged
    {
        #region public DaneSzukajPodmiotyResult...

        /// <summary>
        ///     Konstruktor
        ///     Constructor
        /// </summary>
        public DaneSzukajPodmiotyResult() { }

        #endregion

        #region public DaneSzukajPodmiotyResult...

        /// <summary>
        ///     Konstruktor
        ///     Constructor
        /// </summary>
        public DaneSzukajPodmiotyResult(ICollection<DaneSzukajPodmioty> daneSzukajPodmiotyCollection)
        {
            _data = (List<DaneSzukajPodmioty>) daneSzukajPodmiotyCollection;
            _total = _data.Count;
        }

        #endregion

        #region public DaneSzukajPodmiotyResult...

        /// <summary>
        ///     Konstruktor
        ///     Constructor
        /// </summary>
        /// <param name="parametryWyszukiwania">
        ///     Model danych parametry wyszukiwania jako DaneSzukajPodmiotyParametryWyszukiwania
        ///     Data model search parameters as DaneSzukajPodmiotyParametryWyszukiwania
        /// </param>
        /// <param name="xml">
        ///     Zawartość odpowiedzi z serwisu jako string xml
        ///     The content of the response from the site as an xml string
        /// </param>
        /// <param name="messageInspectorList">
        ///     Lista elementów inspektora wiadomości soap lub null
        ///     List of inspector items soap or null
        /// </param>
        public DaneSzukajPodmiotyResult(
            DaneSzukajPodmiotyParametryWyszukiwania parametryWyszukiwania,
            string xml,
            List<MessageInspector> messageInspectorList = null!)
        {
            if (!string.IsNullOrWhiteSpace(xml))
            {
                _data = XmlHelper.DeserializeXmlFromString<DaneSzukajPodmiotyResult>(xml)
                    .Data;
                _error = XmlHelper.DeserializeXmlFromString<DaneSzukajPodmiotyKomunikatyOBledach>(
                    xml);
                _messageInspector = messageInspectorList;

                foreach (DaneSzukajPodmioty daneSzukajPodmioty in _data)
                {
                    daneSzukajPodmioty.DaneSzukajPodmiotyParametryWyszukiwaniaId =
                        parametryWyszukiwania.Id;
                    daneSzukajPodmioty.DaneSzukajPodmiotyParametryWyszukiwania =
                        parametryWyszukiwania;
                    if (null != _error)
                    {
                        daneSzukajPodmioty.DaneSzukajPodmiotyKomunikatyOBledach = _error;
                        daneSzukajPodmioty.DaneSzukajPodmiotyKomunikatyOBledachId = _error.Id;
                    }

                    if (null != _messageInspector)
                    {
                        daneSzukajPodmioty.DaneSzukajPodmiotyMessageInspector =
                            new List<DaneSzukajPodmiotyMessageInspector>();
                        foreach (MessageInspector? messageInspector in
                            _messageInspector!)
                        {
                            daneSzukajPodmioty.DaneSzukajPodmiotyMessageInspector.Add(new DaneSzukajPodmiotyMessageInspector(daneSzukajPodmioty, messageInspector));
                        }
                    }
                }

                _total = _data.Count;
            }
        }

        #endregion

        #region private int _total...

        private int _total;

        [XmlIgnore]
        [JsonProperty(nameof(Total))]
        [Display(Name = "Ilość rekordów", Prompt = "Wpisz ilość rekordów",
            Description = "Ilość rekordów")]
        public int Total
        {
            get => _total;
            private set
            {
                if (value != _total)
                {
                    _total = value;
                    OnPropertyChanged(nameof(Total));
                }
            }
        }

        #endregion

        #region private List<DaneSzukajPodmioty> _data...

        private List<DaneSzukajPodmioty> _data;

        [XmlElement(ElementName = "dane",
            Type = typeof(DaneSzukajPodmioty), IsNullable = true, Order = 1)]
        [JsonProperty(nameof(Data))]
        [Display(Name = "Rezultat wyszukiwania podmiotów gospodarczych",
            Description = "Rezultat wyszukiwania podmiotów gospodarczych")]
        public List<DaneSzukajPodmioty> Data
        {
            get => _data;
            set
            {
                if (!Equals(value, _data))
                {
                    _data = value;
                    OnPropertyChanged(nameof(Data));
                }
            }
        }

        #endregion

        #region private DaneSzukajPodmiotyKomunikatyOBledach _error...

        private DaneSzukajPodmiotyKomunikatyOBledach _error;

        [XmlIgnore]
        //[JsonProperty(nameof(Error))]
        [JsonIgnore]
        [Display(Name = "Komunikaty o błędach",
            Description = "Komunikaty o błędach z usługi UslugaBIRzewnPublVer11Prod")]
        public DaneSzukajPodmiotyKomunikatyOBledach Error
        {
            get => _error;
            set
            {
                if (value != _error)
                {
                    _error = value;
                    OnPropertyChanged(nameof(Error));
                }
            }
        }

        #endregion

        #region private ICollection<DaneSzukajPodmiotyMessageInspector> _messageInspector...

        private ICollection<MessageInspector>? _messageInspector;

        [XmlIgnore]
        //[JsonProperty(nameof(MessageInspector))]
        [JsonIgnore]
        [Display(Name = "Inspektor wiadomości soap", Description = "Model danych inspektor wiadomości soap")]
        public ICollection<MessageInspector>? MessageInspector
        {
            get => _messageInspector;
            set
            {
                if (!Equals(value, _messageInspector))
                {
                    _messageInspector = value;
                    OnPropertyChanged(nameof(MessageInspector));
                }
            }
        }

        #endregion

        #region Implements INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        #region private virtual void OnPropertyChanged(PropertyChangedEventArgs args)

        /// <summary>
        ///     private virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        /// </summary>
        /// <param name="args"></param>
        public virtual void OnPropertyChanged(PropertyChangedEventArgs args) => PropertyChanged?.Invoke(this, args);

        #endregion

        #region public void OnPropertyChanged(string propertyName)

        /// <summary>
        ///     public void OnPropertyChanged(string propertyName)
        ///     public void OnPropertyChanged(string propertyName)
        /// </summary>
        /// <param name="propertyName">
        /// </param>
        public void OnPropertyChanged(string propertyName) =>
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));

        #endregion

        #endregion
    }
}

#endregion
