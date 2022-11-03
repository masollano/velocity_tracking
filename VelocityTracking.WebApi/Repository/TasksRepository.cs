using VelocityTracking.WebApi.Data;
using VelocityTracking.WebApi.Application.Interfaces;

namespace VelocityTracking.WebApi.Repository
{
    public class TasksRepository : ITasksRepository
    {
        private readonly DapperContext _dapperContext;
        public TasksRepository(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }
    }
}
