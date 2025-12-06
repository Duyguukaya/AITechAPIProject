using AITech.DataAccess.Context;
using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.Entity.Entities;

namespace AITech.DataAccess.Repositories.FAQRepositories
{
    public class FAQRepository : GenericRepository<FAQ>, IFAQRepository
    {
        public FAQRepository(AppDbContext context) : base(context)
        {
        }
    }
}
