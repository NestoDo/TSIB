﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TSIB.Api.Models;
using TSIB.Services;

namespace TSIB.Pages
{
    public class AttendanceViewModel
    {
        public int EmployeeId { get; set; }

        public Dictionary<int, string> Attendance { get; set; }
    }

    public partial class Attendance
    {
        [Inject]
        public IAttendanceService AttendanceService { get; set; }
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public IEnumerable<TSIB.Api.Models.Employee> Employees { get; set; }
        public IEnumerable<TSIB.Api.Models.Employee> Attendances { get; set; }
        public IEnumerable<AttendanceViewModel> AttendancesViewModel { get; set; }

        public string Year { get; set; } = DateTime.Now.Year.ToString();
        public string Month { get; set; } = DateTime.Now.Month.ToString();

        public int Days { get; set; } = 0;

        protected override async Task OnInitializedAsync()
        {
            int year = Convert.ToInt32(Year);
            int month = Convert.ToInt32(Month);

            int days = DateTime.DaysInMonth(year, month);

            this.Days = days;

            //string search = search = $"IsActive=true";
            //Employees = (await EmployeeService.GetEmployees(search)).ToList();            

            string search = $"employeeId=24&year={year}&month={month}";
            Attendances = (await AttendanceService.GetAttendance(search)).ToList();

            //List<AttendanceViewModel> avml = new List<AttendanceViewModel>();
            //AttendanceViewModel avm = null;
            //foreach (var employee in Employees)
            //{
            //    avm = new AttendanceViewModel();
            //    avm.EmployeeId = employee.EmployeeId;
            //    avm.Attendance = new Dictionary<int, string>();


            //}
        }

        private void AttendanceGetData_Click()
        {
            int days = DateTime.DaysInMonth(Convert.ToInt32(Year), Convert.ToInt32(Month));

            this.Days = days;
        }

        private async void SaveAttenndace_Click(Employee employee, int year, int month, int day)
        {
            DateTime dateAttendance = new DateTime(year, month, day);

            //await AttendanceService.UpdateAttendance(employee, dateAttendance);
        }
    }
}
