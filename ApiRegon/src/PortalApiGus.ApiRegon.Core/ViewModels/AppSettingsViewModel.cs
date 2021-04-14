using System;
using System.Collections.Generic;
using System.Text;

namespace PortalApiGus.ApiRegon.Core.ViewModels
{
    public class AppSettingsViewModel
    {
        private Models.AppSettings _coreAppSettings;

        public Models.AppSettings CoreAppSettings
        {
            get => _coreAppSettings;
            set
            {
                if (value != _coreAppSettings)
                {
                    _coreAppSettings = value;
                }
            }
        }
    }
}
