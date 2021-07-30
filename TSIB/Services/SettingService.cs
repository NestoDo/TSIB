using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TSIB.Api.Models;

namespace TSIB.Services
{
    public class SettingService : ISettingService
    {
        private readonly HttpClient httpClient;

        public SettingService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Setting> GetSetting()
        {
            return await httpClient.GetJsonAsync<Setting>($"api/setting/search?");
        }
    }
}
