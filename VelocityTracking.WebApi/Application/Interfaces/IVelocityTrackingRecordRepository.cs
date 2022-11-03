using VelocityTracking.WebApi.Entities;

namespace VelocityTracking.WebApi.Application.Interfaces
{
    public interface IVelocityTrackingRecordRepository
    {
        Task<IEnumerable<VelocityTrackingRecord>> GetVelocityTrackingRecords();
        Task<int> CreateVelocityTrackingRecord(VelocityTrackingRecord velocityTrackingRecord);
    }
}
