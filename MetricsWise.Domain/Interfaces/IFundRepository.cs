using MetricsWise.Domain.Entities;

namespace MetricsWise.Domain.Interfaces
{
    public interface IFundRepository
    {
        IEnumerable<Fund> GetAllFunds();
    }
}
