using VelocityTracking.WebApi.Data;
using VelocityTracking.WebApi.Application.Interfaces;

namespace VelocityTracking.WebApi.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly DapperContext _dapperContext;
        public ProjectRepository(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }
    }
}
