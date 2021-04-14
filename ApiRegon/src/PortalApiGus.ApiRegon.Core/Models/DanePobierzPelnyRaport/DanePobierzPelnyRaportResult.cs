#region using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using Newtonsoft.Json;

#endregion

namespace PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport
{
    [Serializable]
    [XmlRoot("root")]
    [NotMapped]
    public class DanePobierzPelnyRaportResult<TModel> : INotifyPropertyChanged
    {
        #region private List<TModel> _dane...

        private List<TModel> _dane;

        [XmlElement(ElementName = "dane")]
        [JsonProperty(nameof(Dane))]
        public List<TModel> Dane
        {
            get => _dane;
            set
            {
                if (!Equals(value, _dane))
                {
                    _dane = value;
                    OnPropertyChanged(nameof(Dane));
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
