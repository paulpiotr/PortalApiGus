#region using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using PortalApiGus.ApiRegon.Core.Models.DaneSzukajPodmioty;

#endregion

#region namespace

namespace PortalApiGus.ApiRegon.Core.ViewModels
{
    public sealed class DaneSzukajPodmiotyViewModel : INotifyPropertyChanged
    {
        #region public DaneSzukajPodmiotyViewModel...

        public DaneSzukajPodmiotyViewModel()
        {
        }

        #endregion

        #region public DaneSzukajPodmiotyViewModel...

        public DaneSzukajPodmiotyViewModel(DateTime? dateOfCreateFrom, DateTime? dateOfCreateTo, int total = 0,
            IEnumerable<DaneSzukajPodmioty> data = null)
        {
            DateOfCreateFrom = dateOfCreateFrom;
            DateOfCreateTo = dateOfCreateTo;
            Total = total;
            DaneSzukajPodmiotyEnumerable = data;
        }

        #endregion

        #region public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///     PropertyChangedEventHandler PropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)

        /// <summary>
        ///     protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        /// </summary>
        /// <param name="args"></param>
        private void OnPropertyChanged(PropertyChangedEventArgs args) => PropertyChanged?.Invoke(this, args);

        #endregion

        #region protected void OnPropertyChanged(string propertyName)

        /// <summary>
        ///     protected void OnPropertyChanged(string propertyName)
        /// </summary>
        /// <param name="propertyName"></param>
        private void OnPropertyChanged(string propertyName) =>
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));

        #endregion

        #region private DateTime _dateOfCreateFrom; public DateTime DateOfCreateFrom

        private DateTime? _dateOfCreateFrom = new(DateTime.Now.Year, DateTime.Now.Month, 1);

        //[JsonConverter(typeof(JsonDateConverter))]
        [JsonProperty(nameof(DateOfCreateFrom))]
        [Display(Name = "Data utworzenia od", Prompt = "Wpisz lub wybierz datę utworzenia od",
            Description = "Data utworzenia od")]
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime? DateOfCreateFrom
        {
            get => _dateOfCreateFrom;
            set
            {
                if (value != _dateOfCreateFrom)
                {
                    _dateOfCreateFrom = value;
                    OnPropertyChanged(nameof(DateOfCreateFrom));
                }
            }
        }

        #endregion

        #region private DateTime _dateOfCreateTo; public DateTime DateOfCreateTo

        private DateTime? _dateOfCreateTo = new(DateTime.Now.Year, DateTime.Now.Month,
            DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));

        //[JsonConverter(typeof(JsonDateConverter))]
        [JsonProperty(nameof(DateOfCreateTo))]
        [Display(Name = "Data utworzenia do", Prompt = "Wpisz lub wybierz datę utworzenia do",
            Description = "Data utworzenia do")]
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime? DateOfCreateTo
        {
            get => _dateOfCreateTo;
            set
            {
                if (value != _dateOfCreateTo)
                {
                    _dateOfCreateTo = value;
                    OnPropertyChanged(nameof(DateOfCreateTo));
                }
            }
        }

        #endregion

        #region private int? _total = 0; public int? Total

        private int? _total = 0;

        [JsonProperty(nameof(Total))]
        [Display(Name = "Ilość znalezionych rekordów", Prompt = "Wpisz ilość znalezionych rekordów",
            Description = "Ilość znalezionych rekordów")]
        public int? Total
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

        #region private IEnumerable<Models.FileImportFromIcasa>; public IEnumerable<Models.FileImportFromIcasa>

        private IEnumerable<DaneSzukajPodmioty> _daneSzukajPodmiotyEnumerable;

        [JsonProperty("Data")]
        [Display(Name = "Lista znalezionych rekordów", Prompt = "Ustaw listę znalezionych rekordów",
            Description = "Ilość znalezionych rekordów")]
        public IEnumerable<DaneSzukajPodmioty> DaneSzukajPodmiotyEnumerable
        {
            get => _daneSzukajPodmiotyEnumerable;
            private set
            {
                if (!Equals(value, _daneSzukajPodmiotyEnumerable))
                {
                    _daneSzukajPodmiotyEnumerable = value;
                    OnPropertyChanged(nameof(DaneSzukajPodmiotyEnumerable));
                }
            }
        }

        #endregion
    }
}

#endregion
