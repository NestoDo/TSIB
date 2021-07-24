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

        public async Task<IEnumerable<Attendance>> GetAttendance(string search)
        {

            return await httpClient.GetJsonAsync<Attendance[]>($"api/attendance/search?{search}");
        }

        //public async Task<Attendance> UpdateAttendance(Attendance employee)
        //{
        //    return await httpClient.PutJsonAsync<Attendance>($"api/attendance", employee);
        //}
    }
}
