using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TSIB.Api.Models;

namespace TSIB.Services
{
    public class AttendanceService : IAttendanceService
    {
        private readonly HttpClient httpClient;

        public AttendanceService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Employee>> GetAttendance(string search)
        {

            return await httpClient.GetJsonAsync<Employee[]>($"api/attendance/search?{search}");
        }

        public async Task<Attendance> UpdateAttendance(TSIB.Api.Models.Attendance attendance)
        {
            return await httpClient.PutJsonAsync<Attendance>($"api/attendance", attendance);
        }
    }
}
