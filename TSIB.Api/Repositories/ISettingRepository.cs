using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSIB.Api.Models;

namespace TSIB.Api.Repositories
{
    public interface ISettingRepository
    {
        Task<Setting> GetSetting();
        Task<Setting> UpdateSetting(Setting setting);
    }
}
