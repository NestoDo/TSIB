using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSIB.Api.Models;
using TSIB.Services;

namespace TSIB.Pages
{
    public partial class Settings
    {
        [Inject]
        public ISettingService SettingService { get; set; }

        public Setting SettingsRecord { get; set; } = new Setting();

        protected override async Task OnInitializedAsync()
        {

            SettingsRecord = (await SettingService.GetSetting());
        }

        public void HandleValidSubmit()
        {

        }
    }
}
