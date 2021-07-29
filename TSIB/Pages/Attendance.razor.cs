using Microsoft.AspNetCore.Components;
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
        public string EmployeeName { get; set; }
        public int[] Attendance { get; set; }
    }

    public partial class Attendance
    {
        [Inject]
        public IAttendanceService AttendanceService { get; set; }
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Inject]
        public IAttendanceTypeService AttendanceTypeService { get; set; }

        public IEnumerable<TSIB.Api.Models.Employee> Employees { get; set; }
        public IEnumerable<TSIB.Api.Models.Employee> Attendances { get; set; }
        public IEnumerable<TSIB.Api.Models.AttendanceType> AttendanceTypes { get; set; }
        public IEnumerable<AttendanceViewModel> AttendancesViewModel { get; set; }

        public string Year { get; set; } = DateTime.Now.Year.ToString();
        public string Month { get; set; } = DateTime.Now.Month.ToString();
        public int Days { get; set; } = 0;

        protected override async Task OnInitializedAsync()
        {
            

            //string search = search = $"IsActive=true";
            //Employees = (await EmployeeService.GetEmployees(search)).ToList();

            //search = $"employeeId=24&year={year}&month={month}";
            //Attendances = (await AttendanceService.GetAttendance(search)).ToList();

            //search = string.Empty;
            //AttendanceTypes = (await AttendanceTypeService.GetAttendanceType(search)).ToList();

            //List <AttendanceViewModel> avml= new List<AttendanceViewModel>();
            //AttendanceViewModel avm = new AttendanceViewModel();
            //foreach (var attendance in Attendances)
            //{
            //    avm = new AttendanceViewModel();
            //    avm.EmployeeId = attendance.EmployeeId;
            //    avm.EmployeeName = $"{attendance.FirstName} {attendance.LastName}";

            //    int [] attend = new int[this.Days+1];
            //    for (int i = 1; i < attend.Length; i++)
            //    {
            //        attend[i] = 0;
            //    }

            //    if (attendance.Attendances.Count > 0)
            //    {
            //        foreach (var item in attendance.Attendances)
            //        {
            //            attend[item.Date.Day] = item.AttendanceType.AttendanceTypeId;
            //        }
            //    }

            //    avm.Attendance = attend;

            //    avml.Add(avm);
            //}

            //AttendancesViewModel = avml;       

            await this.AttendanceSearch();
        }

        private async Task AttendanceSearch_Click()
        {
            //int days = DateTime.DaysInMonth(Convert.ToInt32(Year), Convert.ToInt32(Month));

            //this.Days = days;

            await this.AttendanceSearch();
        }

        private async void SaveAttenndace_Click(AttendanceViewModel attendanceView, int year, int month, int day)
        {
            DateTime dateAttendance = new DateTime(year, month, day);

            TSIB.Api.Models.Attendance attendance = new TSIB.Api.Models.Attendance()
            {
                EmployeeId = attendanceView.EmployeeId,
                Date = dateAttendance,
                AttendanceTypeId = attendanceView.Attendance[day]
            };

            await AttendanceService.UpdateAttendance(attendance);
        }

        private async Task AttendanceSearch()
        {
            int year = Convert.ToInt32(Year);
            int month = Convert.ToInt32(Month);

            int days = DateTime.DaysInMonth(year, month);

            this.Days = days;

            string search = search = $"IsActive=true";
            Employees = (await EmployeeService.GetEmployees(search)).ToList();

            search = $"employeeId=24&year={year}&month={month}";
            Attendances = (await AttendanceService.GetAttendance(search)).ToList();

            search = string.Empty;
            AttendanceTypes = (await AttendanceTypeService.GetAttendanceType(search)).ToList();

            List<AttendanceViewModel> avml = new List<AttendanceViewModel>();
            AttendanceViewModel avm = new AttendanceViewModel();
            foreach (var attendance in Attendances)
            {
                avm = new AttendanceViewModel();
                avm.EmployeeId = attendance.EmployeeId;
                avm.EmployeeName = $"{attendance.FirstName} {attendance.LastName}";

                int[] attend = new int[this.Days + 1];
                for (int i = 1; i < attend.Length; i++)
                {
                    attend[i] = 0;
                }

                if (attendance.Attendances.Count > 0)
                {
                    foreach (var item in attendance.Attendances)
                    {
                        attend[item.Date.Day] = item.AttendanceType.AttendanceTypeId;
                    }
                }

                avm.Attendance = attend;

                avml.Add(avm);
            }

            AttendancesViewModel = avml;
        }
    }
}
