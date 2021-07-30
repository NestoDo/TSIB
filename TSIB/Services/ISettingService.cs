using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSIB.Api.Models;

namespace TSIB.Services
{
    public interface ISettingService
    {
        Task<Setting> GetSetting();
    }
}
