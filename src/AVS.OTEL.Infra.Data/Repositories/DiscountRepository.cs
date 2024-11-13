using AVS.OTEL.Domain.Entities;
using AVS.OTEL.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AVS.OTEL.Infra.Data.Repositories
{
    public class DiscountRepository
    {
        protected readonly ApplicationDbContext _context;

        public DiscountRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        #region Métodos Asincronos

        public async Task<bool> InsertAsync(Discount entity)
        {
            _context.Add(entity);
            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateAsync(Discount discount)
        {
            var entity = await _context.Set<Discount>()
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id.Equals(discount.Id));

            if (entity == null)
            {
                return await Task.FromResult(false);
            }
            entity.Name = discount.Name;
            entity.Description = discount.Description;
            entity.Percent = discount.Percent;
            entity.Status = discount.Status;

            _context.Update(entity);
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var entity = await _context.Set<Discount>()
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id.Equals(int.Parse(id)));

            if (entity == null)
            {
                return await Task.FromResult(false);
            }

            _context.Remove(entity);
            return await Task.FromResult(true);
        }

        public async Task<List<Discount>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _context.Set<Discount>()
                .AsNoTracking().ToListAsync(cancellationToken);
        }

        public async Task<Discount> GetAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.
                Set<Discount>().AsNoTracking().
                SingleOrDefaultAsync(x => x.Id.Equals(id), cancellationToken);
        }

        public Task<IEnumerable<Discount>> GetAllWithPaginationAsync(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Discount> GetAsync(string id)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Discount>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
