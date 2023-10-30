using MetricsWise.Domain.Entities;
using MetricsWise.Domain.Interfaces;
using MetricsWise.Infra.Data.Context;

namespace MetricsWise.Infra.Data.Repostories
{
    public class FundRepository : IFundRepository
    {
        private readonly ApplicationDbContext _context;

        public FundRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Fund> GetAllFunds()
        {
            return _context.Funds;
        }
    }
}
