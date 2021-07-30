using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TSIB.Api.Models;

namespace TSIB.Api.Repositories
{
    public class SettingRepository : ISettingRepository
    {
        private readonly AppDbContext _appDbContext;
        public SettingRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<Setting> GetSetting()
        {
            using (SqlConnection con = new SqlConnection(_appDbContext.Database.GetDbConnection().ConnectionString))
            {
                con.Open();
                var result = await con.QueryAsync<Setting>(
                    "GetSetting",
                    commandType: CommandType.StoredProcedure);

                return result.FirstOrDefault();
            }
        }
    }
}
