using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VelocityTracking.WebApi.Application.Interfaces;
using VelocityTracking.WebApi.Contracts.VelocityTrackingRecord;
using VelocityTracking.WebApi.Entities;
using VelocityTracking.WebApi.Models;

namespace VelocityTracking.WebApi.Controllers
{
    [Route("api/velocity_tracking_records")]
    [ApiController]
    public class VelocityTrackingController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IProjectRepository _projectRepository;
        private readonly ITasksRepository _taskRepository;
        private readonly IVelocityTrackingRecordRepository _velocityTrackingRecordRepository;
        public VelocityTrackingController(
            IEmployeeRepository employeeRepository,
            IProjectRepository projectRepository,
            ITasksRepository taskRepository,
            IVelocityTrackingRecordRepository velocityTrackingRecordRepository)
        {
            _employeeRepository = employeeRepository;
            _projectRepository = projectRepository;
            _taskRepository = taskRepository;
            _velocityTrackingRecordRepository = velocityTrackingRecordRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetVelocityTrackingRecords()
        {
            List<EmployeeRecord> employeeRecords = new List<EmployeeRecord>();
            var velocity_tracking_records = await _velocityTrackingRecordRepository.GetVelocityTrackingRecords();
            foreach (var employee in velocity_tracking_records)
            {
                var empoyee_record_item = new EmployeeRecord
                {
                    EmployeeName = employee.EmployeeName,
                    EstimatedHours = employee.EstimatedHours,
                    ActualHours = employee.ActualHours
                };

                employeeRecords.Add(empoyee_record_item);
            }

            var velocityTrackingRecords = new VelocityTrackingRecordResponseModel();
            {
                velocityTrackingRecords.ProjectName = velocity_tracking_records.First().ProjectName;
                velocityTrackingRecords.TaskTitle = velocity_tracking_records.First().TaskTitle;
                velocityTrackingRecords.TaskDescription = velocity_tracking_records.First().TaskDescription;
                velocityTrackingRecords.TaskTotalEstimate = velocity_tracking_records.First().TaskTotalEstimate;
                velocityTrackingRecords.Employees = employeeRecords;
            };

            return Ok(velocityTrackingRecords);
        }

        [HttpPost]
        public async Task<IActionResult> CreateVelocityTrackingRecord(VelocityTrackingRecordRequest velocityTracking)
        {
            List<EmployeeRecord> employees = new List<EmployeeRecord>();
            employees.AddRange(velocityTracking.Employees);

            bool queryDone = false;

            foreach(var item in employees)
            {
                var velocity_tracking_record = new VelocityTrackingRecord
                {
                    ProjectName = velocityTracking.ProjectName,
                    TaskTitle = velocityTracking.TaskTitle,
                    TaskDescription = velocityTracking.TaskDescription,
                    TaskTotalEstimate = velocityTracking.TaskTotalEstimate,
                    EmployeeName = item.EmployeeName,
                    EstimatedHours = item.EstimatedHours,
                    ActualHours = item.ActualHours,
                    Statuscode = 1000
                };

                await _velocityTrackingRecordRepository.CreateVelocityTrackingRecord(velocity_tracking_record);
            }

            queryDone = true;

            return Ok(queryDone);
        }

    }
}
