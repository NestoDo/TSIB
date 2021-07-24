using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TSIB.Api.Models;

namespace TSIB.Services
{
    public class AttendanceTypeService : IAttendanceTypeService
    {
        private readonly HttpClient httpClient;

        public AttendanceTypeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<AttendanceType>> GetAttendanceType(string search)
        {
            return await httpClient.GetJsonAsync<AttendanceType[]>($"api/attendanceType/search?{search}");
        }
    }
}
