using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
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
        public IJSRuntime JSRuntime { get; set; }

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

        public int EmployeeId { get; set; } = 0;
        public string Year { get; set; } = DateTime.Now.Year.ToString();
        public string Month { get; set; } = DateTime.Now.Month.ToString();
        public string MonthText { get; set; } = string.Empty;
        

        public int YearSearch { get; set; } = DateTime.Now.Year;
        public int MonthSearch { get; set; } = DateTime.Now.Month;
        public int Days { get; set; } = 0;

        protected override async Task OnInitializedAsync()
        {
            await this.AttendanceSearch();
        }

        private async Task AttendanceSearch_Click()
        {
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

        public string GetMonthName(int month)
        {
            return new CultureInfo(("Es-Es")).
                DateTimeFormat.GetMonthName
                (month);
        }

        private async Task AttendanceSearch()
        {
            YearSearch = Convert.ToInt32(Year);
            MonthSearch = Convert.ToInt32(Month);
            MonthText = GetMonthName(MonthSearch);

            int days = DateTime.DaysInMonth(YearSearch, MonthSearch);

            this.Days = days;

            string search = search = $"IsActive=true";            
            Employees = (await EmployeeService.GetEmployees(search)).ToList();

            search = $"employeeId={EmployeeId}&year={YearSearch}&month={MonthSearch}";
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

        public int YearhModal { get; set; } = 1900;
        public int MonthhModal { get; set; } = 1;
        public int DayhModal { get; set; } = 1;
        public string NamehModal { get; set; } = string.Empty;

        private async Task CommentModalDisplay_Click(AttendanceViewModel attendanceView, int year, int month, int day)
        {
            YearhModal = year;
            MonthhModal = month;
            DayhModal = day;
            NamehModal = attendanceView.EmployeeName;

            await JSRuntime.InvokeVoidAsync("showCommentModal", "JS function called from .NET");

        }
    }
}
